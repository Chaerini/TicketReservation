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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // 예매 클릭
        private void btn_reservation_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Ticketing showTicketing = new Ticketing();

            this.Hide();
            showTicketing.ShowDialog();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
