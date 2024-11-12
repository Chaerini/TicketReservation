using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_TicketReservation
{
    public partial class Arrivals : Form
    {
        // 부모 폼
        private Ticketing ticketing;
        public Arrivals()
        {
            InitializeComponent();
        }

        // Ticketing 폼을 전달
        public Arrivals(Ticketing ticketing)
        {
            InitializeComponent();
            this.ticketing = ticketing;
        }

        private void Arrivals_Load(object sender, EventArgs e)
        {
            btn_all.BackColor = Color.SteelBlue;
            btn_all.ForeColor = Color.White;
            this.ActiveControl = null;

            btn_arrPlace1.Text = "서울역";
            btn_arrPlace2.Text = "용산역";
            btn_arrPlace3.Text = "영등포역";
            btn_arrPlace4.Text = "부산역";
            btn_arrPlace5.Text = "수원역";
            btn_arrPlace6.Text = "평택역";
            btn_arrPlace7.Text = "대구역";
            btn_arrPlace8.Text = "여수EXPO역";
            btn_arrPlace9.Text = "조치원역";
            btn_arrPlace10.Text = "대전역";
            btn_arrPlace11.Text = "광주역";
            btn_arrPlace12.Text = "구미역";
            btn_arrPlace13.Text = "논산역";
            btn_arrPlace14.Text = "전주역";
            btn_arrPlace15.Text = "오산역";
        }

        // 선택한 초성에 해당하는 기차역 출력
        private void AllStations()
        {

        }

        // 버튼 속성 초기화
        private void BtnAttrInit()
        {
            btn_all.BackColor = SystemColors.ControlLight;
            btn_all.ForeColor = SystemColors.ControlText;
            btn_ga.BackColor = SystemColors.ControlLight;
            btn_ga.ForeColor = SystemColors.ControlText;
            btn_na.BackColor = SystemColors.ControlLight;
            btn_na.ForeColor = SystemColors.ControlText;
            btn_da.BackColor = SystemColors.ControlLight;
            btn_da.ForeColor = SystemColors.ControlText;
            btn_ra.BackColor = SystemColors.ControlLight;
            btn_ra.ForeColor = SystemColors.ControlText;
            btn_ma.BackColor = SystemColors.ControlLight;
            btn_ma.ForeColor = SystemColors.ControlText;
            btn_ba.BackColor = SystemColors.ControlLight;
            btn_ba.ForeColor = SystemColors.ControlText;
            btn_sa.BackColor = SystemColors.ControlLight;
            btn_sa.ForeColor = SystemColors.ControlText;
            btn_aa.BackColor = SystemColors.ControlLight;
            btn_aa.ForeColor = SystemColors.ControlText;
            btn_ja.BackColor = SystemColors.ControlLight;
            btn_ja.ForeColor = SystemColors.ControlText;
            btn_cha.BackColor = SystemColors.ControlLight;
            btn_cha.ForeColor = SystemColors.ControlText;
            btn_ca.BackColor = SystemColors.ControlLight;
            btn_ca.ForeColor = SystemColors.ControlText;
            btn_ta.BackColor = SystemColors.ControlLight;
            btn_ta.ForeColor = SystemColors.ControlText;
            btn_pa.BackColor = SystemColors.ControlLight;
            btn_pa.ForeColor = SystemColors.ControlText;
            btn_ha.BackColor = SystemColors.ControlLight;
            btn_ha.ForeColor = SystemColors.ControlText;

            btn_arrPlace1.Visible = true;
            btn_arrPlace2.Visible = true;
            btn_arrPlace3.Visible = true;
            btn_arrPlace4.Visible = true;
            btn_arrPlace5.Visible = true;
            btn_arrPlace6.Visible = true;
            btn_arrPlace7.Visible = true;
            btn_arrPlace8.Visible = true;
            btn_arrPlace9.Visible = true;
            btn_arrPlace10.Visible = true;
            btn_arrPlace11.Visible = true;
            btn_arrPlace12.Visible = true;
            btn_arrPlace13.Visible = true;
            btn_arrPlace14.Visible = true;
            btn_arrPlace15.Visible = true;
            btn_arrPlace15.Visible = true;
        }

        // 주요역 버튼 클릭했을 때
        private void btn_all_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_all.BackColor = Color.SteelBlue;
            btn_all.ForeColor = Color.White;

            btn_arrPlace1.Text = "서울역";
            btn_arrPlace2.Text = "용산역";
            btn_arrPlace3.Text = "영등포역";
            btn_arrPlace4.Text = "부산역";
            btn_arrPlace5.Text = "수원역";
            btn_arrPlace6.Text = "평택역";
            btn_arrPlace7.Text = "대구역";
            btn_arrPlace8.Text = "여수EXPO역";
            btn_arrPlace9.Text = "조치원역";
            btn_arrPlace10.Text = "대전역";
            btn_arrPlace11.Text = "광주역";
            btn_arrPlace12.Text = "구미역";
            btn_arrPlace13.Text = "논산역";
            btn_arrPlace14.Text = "전주역";
            btn_arrPlace15.Text = "오산역";
        }

        // ㄱ 버튼 클릭했을 때
        private void btn_ga_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_ga.BackColor = Color.SteelBlue;
            btn_ga.ForeColor = Color.White;

            btn_arrPlace1.Text = "강경역";
            btn_arrPlace2.Text = "경산역";
            btn_arrPlace3.Text = "계룡역";
            btn_arrPlace4.Text = "곡성역";
            btn_arrPlace5.Text = "광주역";
            btn_arrPlace6.Text = "광주송정역";
            btn_arrPlace7.Text = "광천역";
            btn_arrPlace8.Text = "구례구역";
            btn_arrPlace9.Text = "구미역";
            btn_arrPlace10.Text = "구포역";
            btn_arrPlace11.Text = "군산역";
            btn_arrPlace12.Text = "김제역";
            btn_arrPlace13.Text = "김천역";
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㄴ 버튼 클릭했을 때
        private void btn_na_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_na.BackColor = Color.SteelBlue;
            btn_na.ForeColor = Color.White;

            btn_arrPlace1.Text = "나주역";
            btn_arrPlace2.Text = "남성현역";
            btn_arrPlace3.Text = "남원역";
            btn_arrPlace4.Text = "논산역";
            btn_arrPlace5.Visible = false;
            btn_arrPlace6.Visible = false;
            btn_arrPlace7.Visible = false;
            btn_arrPlace8.Visible = false;
            btn_arrPlace9.Visible = false;
            btn_arrPlace10.Visible = false;
            btn_arrPlace11.Visible = false;
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㄷ 버튼 클릭했을 때
        private void btn_da_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_da.BackColor = Color.SteelBlue;
            btn_da.ForeColor = Color.White;

            btn_arrPlace1.Text = "대구역";
            btn_arrPlace2.Text = "대야역";
            btn_arrPlace3.Text = "대전역";
            btn_arrPlace4.Text = "대천역";
            btn_arrPlace5.Text = "도고온천역";
            btn_arrPlace6.Text = "동대구역";
            btn_arrPlace7.Visible = false;
            btn_arrPlace8.Visible = false;
            btn_arrPlace9.Visible = false;
            btn_arrPlace10.Visible = false;
            btn_arrPlace11.Visible = false;
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㄹ 버튼 클릭했을 때
        private void btn_ra_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_ra.BackColor = Color.SteelBlue;
            btn_ra.ForeColor = Color.White;

            btn_arrPlace1.Visible = false;
            btn_arrPlace2.Visible = false;
            btn_arrPlace3.Visible = false;
            btn_arrPlace4.Visible = false;
            btn_arrPlace5.Visible = false;
            btn_arrPlace6.Visible = false;
            btn_arrPlace7.Visible = false;
            btn_arrPlace8.Visible = false;
            btn_arrPlace9.Visible = false;
            btn_arrPlace10.Visible = false;
            btn_arrPlace11.Visible = false;
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㅁ 버튼 클릭했을 때
        private void btn_ma_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_ma.BackColor = Color.SteelBlue;
            btn_ma.ForeColor = Color.White;

            btn_arrPlace1.Text = "마산역";
            btn_arrPlace2.Text = "목포역";
            btn_arrPlace3.Text = "몽탄역";
            btn_arrPlace4.Text = "무안역";
            btn_arrPlace5.Text = "물금역";
            btn_arrPlace6.Text = "밀양역";
            btn_arrPlace7.Visible = false;
            btn_arrPlace8.Visible = false;
            btn_arrPlace9.Visible = false;
            btn_arrPlace10.Visible = false;
            btn_arrPlace11.Visible = false;
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㅂ 클릭했을 때
        private void btn_ba_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_ba.BackColor = Color.SteelBlue;
            btn_ba.ForeColor = Color.White;

            btn_arrPlace1.Text = "백양사역";
            btn_arrPlace2.Text = "부강역";
            btn_arrPlace3.Text = "부산역";
            btn_arrPlace4.Text = "부전역";
            btn_arrPlace5.Visible = false;
            btn_arrPlace6.Visible = false;
            btn_arrPlace7.Visible = false;
            btn_arrPlace8.Visible = false;
            btn_arrPlace9.Visible = false;
            btn_arrPlace10.Visible = false;
            btn_arrPlace11.Visible = false;
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㅅ 클릭했을 때
        private void btn_sa_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_sa.BackColor = Color.SteelBlue;
            btn_sa.ForeColor = Color.White;

            btn_arrPlace1.Text = "삼랑진역";
            btn_arrPlace2.Text = "삼례역";
            btn_arrPlace3.Text = "삽교역";
            btn_arrPlace4.Text = "서울역";
            btn_arrPlace5.Text = "상동역";
            btn_arrPlace6.Text = "서대전역";
            btn_arrPlace7.Text = "서정리역";
            btn_arrPlace8.Text = "서천역";
            btn_arrPlace9.Text = "성환역";
            btn_arrPlace10.Text = "수원역";
            btn_arrPlace11.Text = "순천역";
            btn_arrPlace12.Text = "신동역";
            btn_arrPlace13.Text = "신례원역";
            btn_arrPlace14.Text = "신탄진역";
            btn_arrPlace15.Text = "신해운대역";
        }

        // ㅇ 클릭했을 때
        private void btn_aa_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_aa.BackColor = Color.SteelBlue;
            btn_aa.ForeColor = Color.White;

            btn_arrPlace1.Text = "아산역";
            btn_arrPlace2.Text = "안양역";
            btn_arrPlace3.Text = "약목역";
            btn_arrPlace4.Text = "여수EXPO역";
            btn_arrPlace5.Text = "여천역";
            btn_arrPlace6.Text = "연산역";
            btn_arrPlace7.Text = "영동역";
            btn_arrPlace8.Text = "영등포역";
            btn_arrPlace9.Text = "예산역";
            btn_arrPlace10.Text = "오근장역";
            btn_arrPlace11.Text = "오산역";
            btn_arrPlace12.Text = "오송역";
            btn_arrPlace13.Text = "오수역";
            btn_arrPlace14.Text = "옥천역";
            btn_arrPlace15.Text = "온양온천역";
        }

        // ㅈ 클릭했을 때
        private void btn_ja_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_ja.BackColor = Color.SteelBlue;
            btn_ja.ForeColor = Color.White;

            btn_arrPlace1.Text = "장성역";
            btn_arrPlace2.Text = "장항역";
            btn_arrPlace3.Text = "전의역";
            btn_arrPlace4.Text = "전주역";
            btn_arrPlace5.Text = "정읍역";
            btn_arrPlace6.Text = "제천역";
            btn_arrPlace7.Text = "조치원역";
            btn_arrPlace8.Text = "주덕역";
            btn_arrPlace9.Text = "증평역";
            btn_arrPlace10.Text = "진영역";
            btn_arrPlace11.Text = "진주역";
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㅊ 클릭했을 때
        private void btn_cha_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_cha.BackColor = Color.SteelBlue;
            btn_cha.ForeColor = Color.White;

            btn_arrPlace1.Text = "창원역";
            btn_arrPlace2.Text = "창원중앙역";
            btn_arrPlace3.Text = "청도역";
            btn_arrPlace4.Text = "청소역";
            btn_arrPlace5.Text = "청주역";
            btn_arrPlace6.Text = "청주공항역";
            btn_arrPlace7.Text = "추풍령역";
            btn_arrPlace8.Text = "충주역";
            btn_arrPlace9.Visible = false;
            btn_arrPlace10.Visible = false;
            btn_arrPlace11.Visible = false;
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㅋ 클릭했을 때
        private void btn_ca_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_ca.BackColor = Color.SteelBlue;
            btn_ca.ForeColor = Color.White;

            btn_arrPlace1.Visible = false;
            btn_arrPlace2.Visible = false;
            btn_arrPlace3.Visible = false;
            btn_arrPlace4.Visible = false;
            btn_arrPlace5.Visible = false;
            btn_arrPlace6.Visible = false;
            btn_arrPlace7.Visible = false;
            btn_arrPlace8.Visible = false;
            btn_arrPlace9.Visible = false;
            btn_arrPlace10.Visible = false;
            btn_arrPlace11.Visible = false;
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㅌ 버튼 클릭했을 때
        private void btn_ta_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_ta.BackColor = Color.SteelBlue;
            btn_ta.ForeColor = Color.White;

            btn_arrPlace1.Visible = false;
            btn_arrPlace2.Visible = false;
            btn_arrPlace3.Visible = false;
            btn_arrPlace4.Visible = false;
            btn_arrPlace5.Visible = false;
            btn_arrPlace6.Visible = false;
            btn_arrPlace7.Visible = false;
            btn_arrPlace8.Visible = false;
            btn_arrPlace9.Visible = false;
            btn_arrPlace10.Visible = false;
            btn_arrPlace11.Visible = false;
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㅍ 클릭했을 때
        private void btn_pa_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_pa.BackColor = Color.SteelBlue;
            btn_pa.ForeColor = Color.White;

            btn_arrPlace1.Text = "판교(충남)역";
            btn_arrPlace2.Text = "평택역";
            btn_arrPlace3.Visible = false;
            btn_arrPlace4.Visible = false;
            btn_arrPlace5.Visible = false;
            btn_arrPlace6.Visible = false;
            btn_arrPlace7.Visible = false;
            btn_arrPlace8.Visible = false;
            btn_arrPlace9.Visible = false;
            btn_arrPlace10.Visible = false;
            btn_arrPlace11.Visible = false;
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // ㅎ 클릭했을 때
        private void btn_ha_Click(object sender, EventArgs e)
        {
            BtnAttrInit();
            btn_ha.BackColor = Color.SteelBlue;
            btn_ha.ForeColor = Color.White;

            btn_arrPlace1.Text = "함안역";
            btn_arrPlace2.Text = "함열역";
            btn_arrPlace3.Text = "함평역";
            btn_arrPlace4.Text = "홍성역";
            btn_arrPlace5.Text = "화명역";
            btn_arrPlace6.Text = "황간역";
            btn_arrPlace7.Visible = false;
            btn_arrPlace8.Visible = false;
            btn_arrPlace9.Visible = false;
            btn_arrPlace10.Visible = false;
            btn_arrPlace11.Visible = false;
            btn_arrPlace12.Visible = false;
            btn_arrPlace13.Visible = false;
            btn_arrPlace14.Visible = false;
            btn_arrPlace15.Visible = false;
        }

        // 해당하는 기차역 가져와서 Ticketing 폼으로 넘기기
        private void btn_arrPlace1_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace1.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace2_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace2.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace3_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace3.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace4_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace4.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace5_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace5.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace6_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace6.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace7_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace7.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace8_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace8.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace9_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace9.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace10_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace10.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace11_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace11.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace12_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace12.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace13_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace13.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace14_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace14.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_arrPlace15_Click(object sender, EventArgs e)
        {
            string arrPlace = btn_arrPlace15.Text;

            if (!string.IsNullOrEmpty(arrPlace))
            {
                ticketing.ReceiveSelectedArrPlace(arrPlace);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
