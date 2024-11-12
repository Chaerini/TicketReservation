using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prj_TicketReservation
{
    public partial class DepartureTime : Form
    {
        // API URL
        const string targetURL = "http://apis.data.go.kr/1613000/TrainInfoService/getStrtpntAlocFndTrainInfo";

        //마이 페이지에서 자신의 인증키 입력.
        const string serviceKey = "oJqcUrwlk4TQccbzi4UY6XpbsD0GYLlEy4z4qNaBNUHAojJB2uPUZbgAYBDigq82%2FxTo3zCOL4c2LEdfFk2cXw%3D%3D";

        // 페이지 번호
        int pageNo = 1;

        // 기차 정보 개수
        int infoSize = 0;

        // 부모 폼 참조
        private Ticketing ticketingform;

        // 가져온 데이터
        private string arrPlace, date;
        private int type;

        public DepartureTime()
        {
            InitializeComponent();
        }

        public DepartureTime(string arrPlace, string date, int type)
        {
            InitializeComponent();
            this.arrPlace = arrPlace;
            this.date = date;
            this.type = type;
        }

        // 기차역ID 딕셔너리
        Dictionary<string, string> StationIDList = new Dictionary<string, string>() {
            {"강경역", "NAT030607" },
            {"경산역", "NAT013395" },
            {"계룡역", "NAT030254" },
            {"곡성역", "NAT041072" },
            {"광주역", "NAT883012" },
            {"광주송정역", "NAT031857" },
            {"광천역", "NAT080749" },
            {"구례구역", "NAT041285" },
            {"구미역", "NAT012775" },
            {"구포역", "NAT014281" },
            {"군산역", "NAT081388" },
            {"김제역", "NAT031056" },
            {"김천역", "NAT012546" },
            {"나주역", "NAT031998" },
            {"남성현역", "NAT013542" },
            {"남원역", "NAT040868" },
            {"논산역", "NAT030508" },
            {"대구역", "NAT013239" },
            {"대야역", "NAT320131" },
            {"대전역", "NAT011668" },
            {"대천역", "NAT080952" },
            {"도고온천역", "NAT080309" },
            {"동대구역", "NAT013271" },
            {"마산역", "NAT880345" },
            {"목포역", "NAT032563" },
            {"몽탄역", "NAT032313" },
            {"무안역", "NAT032273" },
            {"물금역", "NAT014150" },
            {"밀양역", "NAT013841" },
            {"백양사역", "NAT031486" },
            {"부강역", "NAT011403" },
            {"부산역", "NAT014445" },
            {"부전역", "NAT750046" },
            {"삼랑진역", "NAT013967" },
            {"삼례역", "NAT040133" },
            {"삽교역", "NAT080492" },
            {"서울역", "NAT010000" },
            {"상동역", "NAT013747" },
            {"서대전역", "NAT030057" },
            {"서정리역", "NAT010670" },
            {"서천역", "NAT081343" },
            {"성환역", "NAT010848" },
            {"수원역", "NAT010415" },
            {"순천역", "NAT041595" },
            {"신동역", "NAT013067" },
            {"신례원역", "NAT080353" },
            {"신탄진역", "NAT011524" },
            {"신태인역", "NAT031179" },
            {"신해운대역", "NAT750189" },
            {"심천역", "NAT012016" },
            {"아산역", "NAT080045" },
            {"안양역", "NAT010239" },
            {"약목역", "NAT012903" },
            {"여수EXPO역", "NAT041993" },
            {"여천역", "NAT041866" },
            {"연산역", "NAT030396" },
            {"영동역", "NAT012124" },
            {"영등포역", "NAT010091" },
            {"예산역", "NAT080402" },
            {"오근장역", "NAT050215" },
            {"오산역", "NAT010570" },
            {"오송역", "NAT050044" },
            {"오수역", "NAT040667" },
            {"옥천역", "NAT011833" },
            {"온양온천역", "NAT080147" },
            {"왜관역", "NAT012968" },
            {"용산역", "NAT010032" },
            {"웅천역", "NAT081099" },
            {"원동역", "NAT014058" },
            {"음성역", "NAT050596" },
            {"이원역", "NAT011916" },
            {"익산역", "NAT030879" },
            {"일로역", "NAT032422" },
            {"임실역", "NAT040536" },
            {"장성역", "NAT031638" },
            {"장항역", "NAT081318" },
            {"전의역", "NAT011154" },
            {"전주역", "NAT040257" },
            {"정읍역", "NAT031314" },
            {"제천역", "NAT021549" },
            {"조치원역", "NAT011298" },
            {"주덕역", "NAT050719" },
            {"증평역", "NAT050366" },
            {"진영역", "NAT880177" },
            {"진주역", "NAT881014" },
            {"창원역", "NAT880310" },
            {"창원중앙역", "NAT880281" },
            {"청도역", "NAT013629" },
            {"청소역", "NAT080827" },
            {"청주역", "NAT050114" },
            {"청주공항역", "NAT050244" },
            {"추풍령역", "NAT012355" },
            {"충주역", "NAT050827" },
            {"판교(충남)역", "NAT081240" },
            {"평택역", "NAT010754" },
            {"함안역", "NAT880520" },
            {"함열역", "NAT030718" },
            {"함평역", "NAT032212" },
            {"홍성역", "NAT080622" },
            {"화명역", "NAT014244" },
            {"황간역", "NAT012270" }
        };

        // openAPI 사용해서 실시간 기차 시간표 가져오기
        public static string getResults(int pageNo, string arrPlaceId, string date)
        {
            // 결과를 저장할 변수
            string result = string.Empty;

            try
            {
                WebClient client = new WebClient();
                string url = string.Format(@"{0}?serviceKey={1}&pageNo={2}&depPlaceId={3}&arrPlaceId={4}&depPlandTime={5}", targetURL, serviceKey, pageNo, "NAT010971", arrPlaceId, date.Replace("-", ""));
                Console.WriteLine(arrPlaceId);

                using (Stream data = client.OpenRead(url))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        string s = reader.ReadToEnd();
                        result = s;

                        reader.Close();
                        data.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Console.WriteLine(result);
            return result;
        }

        // 가져온 기차 시간표 파싱
        private void ParseXmlAndFillTable(string result)
        {
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.AutoSize = true;  // 전체적으로 자동 크기 조정


            // XML 데이터
            string xmlData = result;

            // XML 파싱
            XDocument xmlDoc = XDocument.Parse(xmlData);

            // 필요한 정보 추출
            var items = from item in xmlDoc.Descendants("item")
                        select new
                        {
                            AdultCharge = item.Element("adultcharge")?.Value, // 운임
                            ArrPlaceName = item.Element("arrplacename")?.Value, // 도착지
                            ArrPlanTime = item.Element("arrplandtime")?.Value, // 도착시간
                            DepPlaceName = item.Element("depplacename")?.Value, // 출발지
                            DepPlanTime = item.Element("depplandtime")?.Value, // 출발시간
                            TrainNo = item.Element("trainno")?.Value, // 열차번호
                            TrainType = item.Element("traingradename")?.Value // 열차종류
                        };

            // 표 제목 설정
            tableLayoutPanel1.Controls.Add(new Label()
            {
                Text = "구분",
                Font = new Font("맑은 고딕", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,  // 텍스트를 가운데 정렬
            },
            0, 0);
            tableLayoutPanel1.Controls.Add(new Label()
            {
                Text = "열차번호",
                Font = new Font("맑은 고딕", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label()
            {
                Text = "도착지",
                Font = new Font("맑은 고딕", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label()
            {
                Text = "출발시간",
                Font = new Font("맑은 고딕", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label()
            {
                Text = "도착시간",
                Font = new Font("맑은 고딕", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            }, 4, 0);
            tableLayoutPanel1.Controls.Add(new Label()
            {
                Text = "운임",
                Font = new Font("맑은 고딕", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            }, 5, 0);
            tableLayoutPanel1.Controls.Add(new Label()
            {
                Text = "선택",
                Font = new Font("맑은 고딕", 12, FontStyle.Bold),
                Padding = new Padding(12, 0, 0, 0)
            }, 6, 0);

            // 각 아이템을 TableLayoutPanel에 추가
            int row = 1; // 0번째는 헤더이므로 1부터 시작

            foreach (var item in items)
            {
                if (item.AdultCharge == "0")
                {
                    continue;
                }
                // 고속 열차를 선택했다면
                if (type == 1)
                {
                    // 고속 열차가 아니라면
                    if (!(item.TrainType.Contains("KTX") || item.TrainType.Contains("ITX") || item.TrainType.Contains("SRT")))
                    {
                        continue;
                    }
                }
                Console.WriteLine(date);

                tableLayoutPanel1.RowCount += 1;

                // 열차종류
                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = item.TrainType,
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 0, row);
                // 열차번호
                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = item.TrainNo,
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 1, row);
                // 도착지
                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = item.ArrPlaceName,
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 2, row);
                // 출발시간
                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = ConvertTime(item.DepPlanTime),
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 3, row);
                // 도착시간
                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = ConvertTime(item.ArrPlanTime),
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 4, row);
                // 요금
                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = item.AdultCharge,
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 5, row);
                // 선택 버튼
                Button selectButton = new Button()
                {
                    Text = "선택",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = 70,
                    Tag = new { Row = row, Item = item } // Tag에 현재 행 번호와 데이터를 저장
                };
                selectButton.Click += SelectButton_Click; // 버튼 클릭 이벤트 핸들러 추가

                tableLayoutPanel1.Controls.Add(selectButton, 6, row);

                row++;
                infoSize++;
            }
        }

        // 선택 버튼 클릭했을 때
        private void SelectButton_Click(object sender, EventArgs e)
        {
            // sender는 버튼이므로 Button으로 캐스팅
            if (sender is Button clickedButton && clickedButton.Tag != null)
            {
                // Tag에서 행 번호와 해당 행의 아이템 정보 가져오기
                var tagData = (dynamic)clickedButton.Tag;
                int selectedRow = tagData.Row; // 행 번호
                var selectedItem = tagData.Item;

                // 여기에서 필요한 데이터 저장
                string selectedTrainType = selectedItem.TrainType;
                string selectedArrPlace = selectedItem.ArrPlaceName;
                string selectedDepTime = ConvertTime(selectedItem.DepPlanTime);
                string selectedArrTime = ConvertTime(selectedItem.ArrPlanTime);
                string selectedAdultCharge = selectedItem.AdultCharge;

                Seat SeatForm = new Seat(selectedTrainType, selectedArrPlace, selectedDepTime, selectedArrTime, selectedAdultCharge);

                this.Hide();
                SeatForm.ShowDialog();

                this.DialogResult = DialogResult.OK; // 폼 닫기
                this.Close(); // 폼을 닫는다
            }
        }

        // 시간 형식 변환
        private string ConvertTime(string time)
        {
            if (string.IsNullOrEmpty(time))
            {
                MessageBox.Show("시간을 받을 수 없습니다.");
                return "";
            }
            else
            {
                // HHMI 추출 (6번째부터 4자리 추출)
                string hhmi = time.Substring(8, 4);

                // HH와 MI 분리
                string hour = hhmi.Substring(0, 2); // HH
                string minute = hhmi.Substring(2, 2); // MI

                // 변환
                return $"{hour}시 {minute}분";
            }
        }

        // 폼이 실행되었을 때
        private void DepartureTime_Load(object sender, EventArgs e)
        {
            string result = getResults(1, StationIDList[arrPlace], date);
            ParseXmlAndFillTable(result);
        }

        // 이전 버튼을 클릭했을 때
        private void lb_Prev_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();

            // 페이지 계산
            int PageNum = infoSize / 10;
            pageNo -= 1;
            if (pageNo <= 0)
            {
                pageNo = PageNum;
            }
            string result = getResults(pageNo, StationIDList[arrPlace], date);
            ParseXmlAndFillTable(result);
        }

        // 다음 버튼을 클릭했을 때
        private void lb_Next_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();

            // 페이지 계산
            int PageNum = infoSize / 10;

            pageNo += 1;
            if (pageNo > PageNum)
            {
                pageNo = 1;
            }
            string result = getResults(pageNo, StationIDList[arrPlace], date);
            ParseXmlAndFillTable(result);
        }


        // 닫기 클릭했을 때
        private void btnClose_Click(object sender, EventArgs e)
        {
            Ticketing ticketingForm = new Ticketing();

            this.Hide();
            ticketingForm.ShowDialog();

            this.DialogResult = DialogResult.OK; // 폼 닫기
            this.Close(); // 폼을 닫는다
        }
    }
}
