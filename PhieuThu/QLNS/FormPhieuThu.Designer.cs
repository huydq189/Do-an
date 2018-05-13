namespace QLNS
{
    partial class FormPhieuThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.txtNgayPT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSotiennoKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSotienthuPT = new System.Windows.Forms.TextBox();
            this.txtNgayThuPT = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvPT = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẬP PHIẾU THU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbNV);
            this.panel1.Controls.Add(this.txtNgayPT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 101);
            this.panel1.TabIndex = 1;
            // 
            // cbbNV
            // 
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(93, 13);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(191, 21);
            this.cbbNV.TabIndex = 0;
            this.cbbNV.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNgayPT
            // 
            this.txtNgayPT.Enabled = false;
            this.txtNgayPT.Location = new System.Drawing.Point(93, 65);
            this.txtNgayPT.Name = "txtNgayPT";
            this.txtNgayPT.Size = new System.Drawing.Size(191, 20);
            this.txtNgayPT.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhân viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSotiennoKH);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(319, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 85);
            this.panel2.TabIndex = 2;
            // 
            // txtSotiennoKH
            // 
            this.txtSotiennoKH.Location = new System.Drawing.Point(338, 52);
            this.txtSotiennoKH.Name = "txtSotiennoKH";
            this.txtSotiennoKH.Size = new System.Drawing.Size(100, 20);
            this.txtSotiennoKH.TabIndex = 7;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(338, 16);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 20);
            this.txtTenKH.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xuất";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(243, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Số tiền nợ";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(16, 45);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(140, 20);
            this.txtMaKH.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(243, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nhập mã khách hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtSotienthuPT);
            this.panel3.Controls.Add(this.txtNgayThuPT);
            this.panel3.Controls.Add(this.txtMaPT);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 203);
            this.panel3.TabIndex = 3;
            // 
            // txtSotienthuPT
            // 
            this.txtSotienthuPT.Location = new System.Drawing.Point(122, 124);
            this.txtSotienthuPT.Name = "txtSotienthuPT";
            this.txtSotienthuPT.Size = new System.Drawing.Size(162, 20);
            this.txtSotienthuPT.TabIndex = 6;
            // 
            // txtNgayThuPT
            // 
            this.txtNgayThuPT.Location = new System.Drawing.Point(122, 73);
            this.txtNgayThuPT.Name = "txtNgayThuPT";
            this.txtNgayThuPT.Size = new System.Drawing.Size(162, 20);
            this.txtNgayThuPT.TabIndex = 5;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Enabled = false;
            this.txtMaPT.Location = new System.Drawing.Point(122, 22);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(162, 20);
            this.txtMaPT.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Xuất phiếu thu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nhập lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số tiền thu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày thu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã phiếu thu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dtgvPT);
            this.panel4.Location = new System.Drawing.Point(316, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(474, 208);
            this.panel4.TabIndex = 4;
            // 
            // dtgvPT
            // 
            this.dtgvPT.AllowUserToAddRows = false;
            this.dtgvPT.AllowUserToDeleteRows = false;
            this.dtgvPT.AllowUserToResizeColumns = false;
            this.dtgvPT.AllowUserToResizeRows = false;
            this.dtgvPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPT.Location = new System.Drawing.Point(0, 0);
            this.dtgvPT.Name = "dtgvPT";
            this.dtgvPT.ReadOnly = true;
            this.dtgvPT.RowHeadersVisible = false;
            this.dtgvPT.Size = new System.Drawing.Size(472, 206);
            this.dtgvPT.TabIndex = 0;
            this.dtgvPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPT_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thông tin nợ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chi tiết phiếu thu";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(497, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "Phiếu thu mới";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(360, 392);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 44);
            this.button5.TabIndex = 9;
            this.button5.Text = "In phiếu thu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(712, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 44);
            this.button6.TabIndex = 10;
            this.button6.Text = "Trở về";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 440);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu thu";
            this.Load += new System.EventHandler(this.FormPhieuThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtSotiennoKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.TextBox txtNgayPT;
        private System.Windows.Forms.TextBox txtSotienthuPT;
        private System.Windows.Forms.TextBox txtNgayThuPT;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.DataGridView dtgvPT;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}