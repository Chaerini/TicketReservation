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
    public partial class Confirmation : Form
    {
        // 가져온 데이터 저장
        string trainType, depTime, arrPlace, arrTime, _lb_totalCount, _lb_totalPrice;

        private List<CheckBox> seatCheckBoxes = new List<CheckBox>();

        public Confirmation()
        {
            InitializeComponent();
        }

        public Confirmation(string trainType, string depTime, string arrPlace, string arrTime, string lb_totalCount, List<CheckBox> seatCheckBoxes, string lb_totalPrice)
        {
            InitializeComponent();
            this.trainType = trainType;
            this.depTime = depTime;
            this.arrPlace = arrPlace;
            this.arrTime = arrTime;
            this._lb_totalCount = lb_totalCount;
            this.seatCheckBoxes = seatCheckBoxes;
            this._lb_totalPrice = lb_totalPrice;
        }


        // 처음으로 버튼 눌렀을 때
        private void button1_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();

            this.Hide();
            mainForm.ShowDialog();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // 폼이 실행됐을 때
        private void Confirmation_Load(object sender, EventArgs e)
        {
            //List<CheckBox> selectedSeats = SelectedSeat();
            Console.WriteLine(trainType + depTime + arrPlace + arrTime + _lb_totalCount + _lb_totalPrice);
            string str = "";

            // 텍스트 넘침을 방지
            int cnt = 0;

            lb_type.Text = trainType;
            lb_depTime.Text = depTime;
            lb_arrPlace.Text = arrPlace + "역";
            lb_arrTime.Text = arrTime;
            lb_totalCount.Text = _lb_totalCount;

            foreach (CheckBox checkBox in seatCheckBoxes)
            {
                // 인덱스 가져오기
                if (checkBox.Checked == true)
                {
                    int index = seatCheckBoxes.IndexOf(checkBox);
                    str += (index + 1).ToString() + " ";
                    cnt++;
                }

                if (cnt >= 3) break;
            }

            if (cnt >= 3)
            {
                lb_seat.Text = str + "..";
            }
            else
            {
                lb_seat.Text = str;
            }

            lb_totalPrice.Text = _lb_totalPrice + "원";
        }

        // 선택 된 좌석 번호 가져오기
        private List<CheckBox> SelectedSeat()
        {
            // 체크된 좌석만 필터링
            var selectedSeats = seatCheckBoxes.Where(cb => cb.Checked).ToList();

            // 체크된 좌석 번호 출력
            foreach (var seat in selectedSeats)
            {
                // 각 체크박스의 이름을 통해 좌석 번호를 가져온다고 가정
                Console.WriteLine(seat.Name);
            }
            return selectedSeats;
        }


        // 카드 결제 버튼 클릭했을 때
        private void btn_card_Click(object sender, EventArgs e)
        {
            Payment paymentForm = new Payment();

            this.Hide();
            paymentForm.ShowDialog();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
