namespace SSMP
{
    partial class FormSuaHoaDonBan
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
            this.buttonHuy = new System.Windows.Forms.Button();
            this.textBoxNguoiLapPhieu = new System.Windows.Forms.TextBox();
            this.textBoxNgayTao = new System.Windows.Forms.TextBox();
            this.textBoxMaPhieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.comboBoxKh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(344, 202);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 23;
            this.buttonHuy.Text = "Hủy bỏ";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // textBoxNguoiLapPhieu
            // 
            this.textBoxNguoiLapPhieu.Location = new System.Drawing.Point(184, 135);
            this.textBoxNguoiLapPhieu.Name = "textBoxNguoiLapPhieu";
            this.textBoxNguoiLapPhieu.ReadOnly = true;
            this.textBoxNguoiLapPhieu.Size = new System.Drawing.Size(235, 20);
            this.textBoxNguoiLapPhieu.TabIndex = 20;
            // 
            // textBoxNgayTao
            // 
            this.textBoxNgayTao.Location = new System.Drawing.Point(184, 69);
            this.textBoxNgayTao.Name = "textBoxNgayTao";
            this.textBoxNgayTao.ReadOnly = true;
            this.textBoxNgayTao.Size = new System.Drawing.Size(235, 20);
            this.textBoxNgayTao.TabIndex = 18;
            // 
            // textBoxMaPhieu
            // 
            this.textBoxMaPhieu.Location = new System.Drawing.Point(184, 38);
            this.textBoxMaPhieu.Name = "textBoxMaPhieu";
            this.textBoxMaPhieu.ReadOnly = true;
            this.textBoxMaPhieu.Size = new System.Drawing.Size(235, 20);
            this.textBoxMaPhieu.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Người lập phiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày tạo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã phiếu:";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Image = global::SSMP.Properties.Resources.accept;
            this.buttonLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLuu.Location = new System.Drawing.Point(253, 202);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 23);
            this.buttonLuu.TabIndex = 22;
            this.buttonLuu.Text = "Lưu Lại";
            this.buttonLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // comboBoxKh
            // 
            this.comboBoxKh.FormattingEnabled = true;
            this.comboBoxKh.Location = new System.Drawing.Point(184, 100);
            this.comboBoxKh.Name = "comboBoxKh";
            this.comboBoxKh.Size = new System.Drawing.Size(235, 21);
            this.comboBoxKh.TabIndex = 24;
            // 
            // FormSuaHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 264);
            this.Controls.Add(this.comboBoxKh);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.textBoxNguoiLapPhieu);
            this.Controls.Add(this.textBoxNgayTao);
            this.Controls.Add(this.textBoxMaPhieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaHoaDonBan";
            this.Text = "Sửa hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.FormSuaHoaDonBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox textBoxNguoiLapPhieu;
        private System.Windows.Forms.TextBox textBoxNgayTao;
        private System.Windows.Forms.TextBox textBoxMaPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKh;
    }
}