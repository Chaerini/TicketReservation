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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        // 폼이 실행됐을 때
        private void Payment_Load(object sender, EventArgs e)
        {
            // 타이머 생성
            Timer timer = new Timer();
            timer.Interval = 5000; // 2초 (2000밀리초)
            timer.Tick += Timer_Tick; // 타이머가 끝났을 때 실행할 메서드 연결
            timer.Start(); // 타이머 시작
        }

        // 타이머 실행
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender; // 현재 타이머 가져오기
            timer.Stop(); // 타이머 중지 (한 번만 실행되도록)

            MessageBox.Show("결제가 완료되었습니다. 표를 출력합니다.");

            Complete completeForm = new Complete();

            this.Hide();
            completeForm.ShowDialog();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
