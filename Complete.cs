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
    public partial class Complete : Form
    {
        public Complete()
        {
            InitializeComponent();
        }

        private void Complete_Load(object sender, EventArgs e)
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

            Main mainForm = new Main();

            this.Hide();
            mainForm.ShowDialog();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
