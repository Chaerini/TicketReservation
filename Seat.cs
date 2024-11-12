using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace prj_TicketReservation
{
    public partial class Seat : Form
    {
        // 가져온 데이터 저장
        string trainType, arrPlace, depTime, arrTime, price;

        public Seat()
        {
            InitializeComponent();
        }

        // Departuretime 에서 데이터 받아옴
        public Seat(string trainType, string arrPlace, string depTime, string arrTime, string price)
        {
            InitializeComponent();

            this.trainType = trainType;
            this.arrPlace = arrPlace;
            this.depTime = depTime;
            this.arrTime = arrTime;
            this.price = price;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        // 폼이 실행됐을 때
        private void Seat_Load(object sender, EventArgs e)
        {
            lb_adultPrice.Text = price + " 원";
            lb_childrenPrice.Text = (int.Parse(price) * 0.5).ToString() + " 원";
            lb_oldPrice.Text = (int.Parse(price) * 0.3).ToString() + " 원";
            lb_totalPrice.Text = price;

            // 폼 로드 시 체크박스들을 리스트에 추가
            seatCheckBoxes.AddRange(new List<CheckBox>
            {
                ckb_Seat1, ckb_Seat2, ckb_Seat3, ckb_Seat4, ckb_Seat5, ckb_Seat6,
                ckb_Seat7, ckb_Seat8, ckb_Seat9, ckb_Seat10, ckb_Seat11, ckb_Seat12,
                ckb_Seat13, ckb_Seat14, ckb_Seat15, ckb_Seat16, ckb_Seat17, ckb_Seat18,
                ckb_Seat19, ckb_Seat20, ckb_Seat21, ckb_Seat22, ckb_Seat23, ckb_Seat24,
                ckb_Seat25, ckb_Seat26, ckb_Seat27, ckb_Seat28, ckb_Seat29, ckb_Seat30,
                ckb_Seat31, ckb_Seat32, ckb_Seat33, ckb_Seat34, ckb_Seat35, ckb_Seat36,
                ckb_Seat37, ckb_Seat38, ckb_Seat39, ckb_Seat40, ckb_Seat41, ckb_Seat42,
                ckb_Seat43, ckb_Seat44, ckb_Seat45, ckb_Seat46, ckb_Seat47, ckb_Seat48,
                ckb_Seat49, ckb_Seat50, ckb_Seat51, ckb_Seat52, ckb_Seat53, ckb_Seat54,
                ckb_Seat55, ckb_Seat56
            });
        }

        // 어른 + 버튼 눌렀을 때
        private void btn_adultUp_Click(object sender, EventArgs e)
        {
            lb_adult.Text = (int.Parse(lb_adult.Text) + 1).ToString();
            lb_totalCount.Text = (int.Parse(lb_totalCount.Text) + 1).ToString();
            lb_totalPrice.Text = (int.Parse(lb_totalPrice.Text) + int.Parse(price)).ToString();
        }

        // 어른 - 버튼 눌렀을 때
        private void btn_adultDown_Click(object sender, EventArgs e)
        {
            if (!(int.Parse(lb_adult.Text) <= 0))
            {
                lb_adult.Text = (int.Parse(lb_adult.Text) - 1).ToString();
                lb_totalCount.Text = (int.Parse(lb_totalCount.Text) - 1).ToString();
                lb_totalPrice.Text = (int.Parse(lb_totalPrice.Text) - int.Parse(price)).ToString();
            }
        }

        // 경로 + 버튼 눌렀을 때
        private void btn_oldUp_Click(object sender, EventArgs e)
        {
            lb_old.Text = (int.Parse(lb_old.Text) + 1).ToString();
            lb_totalCount.Text = (int.Parse(lb_totalCount.Text) + 1).ToString();
            lb_totalPrice.Text = (int.Parse(lb_totalPrice.Text) + (int.Parse(price) * 0.3)).ToString();
        }

        // 경로 - 버튼 눌렀을 때
        private void btn_oldDown_Click(object sender, EventArgs e)
        {
            if (!(int.Parse(lb_old.Text) <= 0))
            {
                lb_old.Text = (int.Parse(lb_old.Text) - 1).ToString();
                lb_totalCount.Text = (int.Parse(lb_totalCount.Text) - 1).ToString();
                lb_totalPrice.Text = (int.Parse(lb_totalPrice.Text) - (int.Parse(price) * 0.3)).ToString();
            }
        }

        // 어린이 + 버튼 눌렀을 때
        private void btn_childrenUp_Click(object sender, EventArgs e)
        {
            lb_children.Text = (int.Parse(lb_children.Text) + 1).ToString();
            lb_totalCount.Text = (int.Parse(lb_totalCount.Text) + 1).ToString();
            lb_totalPrice.Text = (int.Parse(lb_totalPrice.Text) + (int.Parse(price) * 0.5)).ToString();
        }

        private void btn_childrenDown_Click(object sender, EventArgs e)
        {
            if (!(int.Parse(lb_children.Text) <= 0))
            {
                lb_children.Text = (int.Parse(lb_children.Text) - 1).ToString();
                lb_totalCount.Text = (int.Parse(lb_totalCount.Text) - 1).ToString();
                lb_totalPrice.Text = (int.Parse(lb_totalPrice.Text) - (int.Parse(price) * 0.5)).ToString();
            }
        }

        // 56개의 체크박스를 리스트로 관리
        private List<CheckBox> seatCheckBoxes = new List<CheckBox>();

        int selectedSeatsCount = 0;
        // 좌석을 선택했을 때
        private void ckb_Seat1_CheckedChanged(object sender, EventArgs e)
        {
            // 선택된 좌석의 개수 계산
            selectedSeatsCount = seatCheckBoxes.Count(cb => cb.Checked);

            // 이벤트가 발생한 객체를 Checkbox 타입으로 변환
            CheckBox ckb_Seat = sender as CheckBox;

            // 선택된 좌석이 총 좌석 수를 초과하지 않도록 방지
            if (selectedSeatsCount > int.Parse(lb_totalCount.Text))
            {
                MessageBox.Show("선택된 좌석이 예약한 좌석 수를 초과합니다.");
                if (ckb_Seat != null)
                {
                    ckb_Seat.Checked = false; // 선택을 취소
                }
                return;
            }

            if (ckb_Seat.Checked == true)
            {
                ckb_Seat.FlatAppearance.BorderSize = 1;
                ckb_Seat.FlatAppearance.BorderColor = Color.BlueViolet;
            }
            else
            {
                ckb_Seat.FlatAppearance.BorderSize = 0;
                ckb_Seat.FlatAppearance.BorderColor = Color.White;
            }
        }

        private void ckb_Seat3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_Seat4_CheckedChanged(object sender, EventArgs e)
        {

        }

        // 다음 클릭했을 때
        private void btn_check_Click(object sender, EventArgs e)
        {
            if(selectedSeatsCount < int.Parse(lb_totalCount.Text))
            {
                MessageBox.Show("좌석을 선택해주세요.");
                return;
            }

            Confirmation confirmationForm = new Confirmation(trainType, depTime, arrPlace, arrTime, lb_totalCount.Text, seatCheckBoxes, lb_totalPrice.Text);

            this.Hide();
            confirmationForm.ShowDialog();

            this.DialogResult = DialogResult.OK; // 폼을 닫기 위한 DialogResult 설정
            this.Close(); // 폼 닫기
        }
    }
}
