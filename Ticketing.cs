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
    public partial class Ticketing : Form
    {
        // 출발 날짜
        string Date = "";
        static int cnt = 0;

        // 도착지
        string arrPlace = string.Empty;

        // 열차 종류 버튼 상태
        bool high_train = false;
        bool all_train = false;

        // 열차 종류
        int train_type = 0;

        public Ticketing()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // 출발일 선택 버튼을 눌렀을 때
        private void btn_departureDate_Click(object sender, EventArgs e)
        {
            DepartureDate show_departureDate = new DepartureDate(this);
            show_departureDate.ShowDialog();

        }

        // 폼이 실행됐을 때
        private void Ticketing_Load(object sender, EventArgs e)
        {
            if (cnt == 0)
            {
                // 한국 시간으로 날짜 표시
                TimeZoneInfo kstZone = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");
                DateTime kstTime = TimeZoneInfo.ConvertTime(DateTime.Now, kstZone);
                Date = kstTime.Date.ToString("yyyy-MM-dd"); // 현재 날짜으로 초기화
                cnt += 1;
            }

            lb_Date.Text = Date;

            btn_All.BackColor = Color.SteelBlue;
            btn_All.ForeColor = Color.White;
        }

        // 선택된 날짜를 받는 메서드
        public void ReceiveSelectedDate(string selectedDate)
        {
            Date = selectedDate;
            lb_Date.Text = selectedDate;
            Console.WriteLine(Date);

            // 선택된 날짜를 사용
            //MessageBox.Show("선택된 날짜: " + selectedDate);
        }

        // 조회하기 클릭했을 때
        private void btn_check_Click(object sender, EventArgs e)
        {
            DepartureTime departureTime = new DepartureTime(arrPlace, Date, train_type);

            this.Hide();
            departureTime.ShowDialog(); // 폼 보여주기

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // 도착지 폼에서 데이터 받기
        public void ReceiveSelectedArrPlace(string selectedArrPlace)
        {
            arrPlace = selectedArrPlace;
            lb_End.Text = arrPlace;
            Console.WriteLine(arrPlace);
        }

        // 도착지 폼 클릭했을 때
        private void btn_arrivals_Click(object sender, EventArgs e)
        {
            Arrivals show_arrivals = new Arrivals(this);
            show_arrivals.ShowDialog();
        }

        // 고속 열차 버튼 선택했을 때
        private void button5_Click(object sender, EventArgs e)
        {
            Btninit();
            btn_High.BackColor = Color.SteelBlue;
            btn_High.ForeColor = Color.White;

            if (all_train)
            {
                all_train = false;
            }

            high_train = true;
            train_type = 1;
        }

        // 전체 열차 버튼 선택했을 때
        private void btn_All_Click(object sender, EventArgs e)
        {
            Btninit();
            btn_All.BackColor = Color.SteelBlue;
            btn_All.ForeColor = Color.White;

            if (high_train)
            {
                high_train = false;
            }

            all_train = true;
            train_type = 0;
        }

        // 버튼 색 초기화
        private void Btninit()
        {
            btn_All.BackColor = SystemColors.ControlLight;
            btn_All.ForeColor = SystemColors.ControlText;
            btn_High.BackColor = SystemColors.ControlLight;
            btn_High.ForeColor = SystemColors.ControlText;
        }
    }
}
