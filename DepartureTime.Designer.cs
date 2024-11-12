namespace prj_TicketReservation
{
    partial class DepartureTime
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
            lbMonth = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnClose = new System.Windows.Forms.Button();
            lb_Prev = new System.Windows.Forms.Label();
            lb_Next = new System.Windows.Forms.Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbMonth
            // 
            lbMonth.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbMonth.Location = new System.Drawing.Point(0, 28);
            lbMonth.Name = "lbMonth";
            lbMonth.Size = new System.Drawing.Size(798, 32);
            lbMonth.TabIndex = 43;
            lbMonth.Text = "출발시간을 선택해주세요 !";
            lbMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Location = new System.Drawing.Point(38, 95);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(714, 353);
            flowLayoutPanel1.TabIndex = 44;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 711F));
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(711, 0);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.SteelBlue;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(38, 445);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(714, 54);
            btnClose.TabIndex = 45;
            btnClose.Text = "닫기";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lb_Prev
            // 
            lb_Prev.AutoSize = true;
            lb_Prev.Location = new System.Drawing.Point(640, 71);
            lb_Prev.Name = "lb_Prev";
            lb_Prev.Size = new System.Drawing.Size(47, 15);
            lb_Prev.TabIndex = 46;
            lb_Prev.Text = "◀ 이전";
            // 
            // lb_Next
            // 
            lb_Next.AutoSize = true;
            lb_Next.Location = new System.Drawing.Point(705, 71);
            lb_Next.Name = "lb_Next";
            lb_Next.Size = new System.Drawing.Size(47, 15);
            lb_Next.TabIndex = 47;
            lb_Next.Text = "다음 ▶";
            lb_Next.Click += lb_Next_Click;
            // 
            // DepartureTime
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 511);
            Controls.Add(lb_Next);
            Controls.Add(lb_Prev);
            Controls.Add(btnClose);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lbMonth);
            Name = "DepartureTime";
            Text = "DepartureTime";
            Load += DepartureTime_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Prev;
        private System.Windows.Forms.Label lb_Next;
    }
}