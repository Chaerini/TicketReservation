namespace prj_TicketReservation
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btn_reservation = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_reservation
            // 
            btn_reservation.BackColor = System.Drawing.Color.Transparent;
            btn_reservation.FlatAppearance.BorderSize = 0;
            btn_reservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_reservation.Font = new System.Drawing.Font("휴먼둥근헤드라인", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_reservation.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btn_reservation.Location = new System.Drawing.Point(-8, -28);
            btn_reservation.Name = "btn_reservation";
            btn_reservation.Size = new System.Drawing.Size(814, 546);
            btn_reservation.TabIndex = 0;
            btn_reservation.Text = "승차권 예매 시스템";
            btn_reservation.UseVisualStyleBackColor = false;
            btn_reservation.Click += btn_reservation_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 511);
            Controls.Add(btn_reservation);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_reservation;
    }
}