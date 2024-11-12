using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace prj_TicketReservation
{
    public partial class DepartureDate : Form
    {
        public static int _year, _month;
        public DateTime selectedDate;  // 선택된 날짜를 저장할 필드

        private Ticketing parentForm; // 부모 폼 참조

        public DepartureDate(Ticketing ticketing)
        {
            InitializeComponent();
            parentForm = ticketing;  // 부모 폼 저장
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // 캘린더 출력
        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            // 한국 시간대 설정
            TimeZoneInfo kstZone = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");
            DateTime kstTime = TimeZoneInfo.ConvertTime(DateTime.Now, kstZone);

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lbMonth.Text = year + "년 " + month + "월";
            DateTime startedMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = (int)startedMonth.DayOfWeek;  // 요일 값을 숫자로 변환

            for (int i = 0; i < week; i++)
            {
                ucDay uc = new ucDay("");
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= day; i++)
            {
                ucDay uc = new ucDay(i + "");
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        // 폼이 실행됐을 때
        private void DepartureDate_Load(object sender, EventArgs e)
        {
            // 한국 시간으로 날짜 표시
            TimeZoneInfo kstZone = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");
            DateTime kstTime = TimeZoneInfo.ConvertTime(DateTime.Now, kstZone);
            selectedDate = kstTime.Date; // 현재 날짜으로 초기화

            // 캘린더 표시
            showDays(kstTime.Month, kstTime.Year);
        }

        // 캘린더 다음 클릭
        private void lbNext_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }

        // 캘린더 이전 클릭
        private void lbPrev_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }

        // 하나의 날짜만 선택할 수 있도록 하는 메서드
        public void DeselectAllDays()
        {
            foreach (var control in flowLayoutPanel1.Controls.OfType<ucDay>())
            {
                control.DeselectDay();  // 각 ucDay에 DeselectDay 메서드 추가
            }
        }

        // 날짜가 선택되었을 때 호출되는 메서드
        public void SetSelectedDate(DateTime date)
        {
            selectedDate = date;
            //Console.WriteLine("Selected Date: " + selectedDate.ToString("yyyy-MM-dd"));
        }

        // 닫기 버튼 클릭했을 때
        private void btnClose_Click(object sender, EventArgs e)
        {
            string date = selectedDate.ToString("yyyy-MM-dd");

            // 선택된 날짜가 기본값이 아닌 경우에만 부모 폼에 전달
            if (!string.IsNullOrEmpty(date))
            {
                // 선택된 날짜를 부모 폼에 전달
                parentForm.ReceiveSelectedDate(date);
            }

            this.DialogResult = DialogResult.OK; // 폼을 닫기 위한 DialogResult 설정
            this.Close(); // 폼 닫기
        }
    }
}
