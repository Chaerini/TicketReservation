using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_TicketReservation
{
    public partial class ucDay : UserControl
    {
        string _day, date, weekday;
        public ucDay(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = _day;
            checkBox1.Hide();
            date = DepartureDate._month + "/" + _day + "/" + DepartureDate._year;
        }

        // 일요일 표시
        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                if(day.DayOfWeek == DayOfWeek.Sunday)
                {
                    label1.ForeColor = Color.FromArgb(255, 0, 0);
                } else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }
            } catch(Exception ex)
            {
                // 에러 처리 로깅 (필요 시)
                Console.WriteLine("Error in sundays: " + ex.Message);
            }
        }

        // 폼 실행했을 때
        private void ucDayrs_Load(object sender, EventArgs e)
        {
            sundays();
        }

        // 날짜 클릭했을 때
        private void panel1_Click(object sender, EventArgs e)
        {
            // 다른 날짜 선택 해제
            DepartureDate form = (DepartureDate)this.FindForm(); // 폼 참조
            form.DeselectAllDays();  // 모든 날짜 선택 해제

            // 현재 날짜 선택 상태로 설정
            checkBox1.Checked = true;
            this.BackColor = Color.FromArgb(255, 150, 79);  // 선택된 배경 색

            // 선택된 날짜를 DepartureDate에 저장
            DateTime selectedDate = DateTime.ParseExact(date, "MM/d/yyyy", null);
            form.SetSelectedDate(selectedDate);  // 선택된 날짜 전달
        }

        // 다른 날짜의 선택 해제
        public void DeselectDay()
        {
            checkBox1.Checked = false;
            this.BackColor = Color.FromArgb(244, 244, 244);  // 기본 배경 색으로 변경
        }
    }
}
