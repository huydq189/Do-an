namespace QLNS
{
    partial class DoiMK
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
            this.txbMKCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMKMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbXacNhan = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbMKCu
            // 
            this.txbMKCu.Location = new System.Drawing.Point(184, 48);
            this.txbMKCu.Name = "txbMKCu";
            this.txbMKCu.Size = new System.Drawing.Size(144, 20);
            this.txbMKCu.TabIndex = 1;
            this.txbMKCu.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txbMaNV
            // 
            this.txbMaNV.Enabled = false;
            this.txbMaNV.Location = new System.Drawing.Point(184, 18);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(55, 20);
            this.txbMaNV.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu mới";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbMKMoi
            // 
            this.txbMKMoi.Location = new System.Drawing.Point(184, 87);
            this.txbMKMoi.Name = "txbMKMoi";
            this.txbMKMoi.Size = new System.Drawing.Size(144, 20);
            this.txbMKMoi.TabIndex = 2;
            this.txbMKMoi.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Xác nhận lại mật khẩu mới";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbXacNhan
            // 
            this.txbXacNhan.Location = new System.Drawing.Point(184, 123);
            this.txbXacNhan.Name = "txbXacNhan";
            this.txbXacNhan.Size = new System.Drawing.Size(144, 20);
            this.txbXacNhan.TabIndex = 3;
            this.txbXacNhan.UseSystemPasswordChar = true;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(275, 158);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(103, 41);
            this.btnDoiMK.TabIndex = 4;
            this.btnDoiMK.Text = "Thay đổi";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // DoiMK
            // 
            this.AcceptButton = this.btnDoiMK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 211);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.txbXacNhan);
            this.Controls.Add(this.txbMKMoi);
            this.Controls.Add(this.txbMKCu);
            this.Name = "DoiMK";
            this.Text = "DoiMK";
            this.Load += new System.EventHandler(this.DoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMKCu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMKMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbXacNhan;
        //private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Button btnDoiMK;
    }
}