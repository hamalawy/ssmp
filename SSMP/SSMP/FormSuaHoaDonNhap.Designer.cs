namespace SSMP
{
    partial class FormSuaHoaDonNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaPhieu = new System.Windows.Forms.TextBox();
            this.textBoxNgayTao = new System.Windows.Forms.TextBox();
            this.textBoxNhanVienGH = new System.Windows.Forms.TextBox();
            this.textBoxNguoiLapPhieu = new System.Windows.Forms.TextBox();
            this.comboBoxNhaCungCap = new System.Windows.Forms.ComboBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày tạo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên giao hàng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà cung cấp:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Người lập phiếu:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxMaPhieu
            // 
            this.textBoxMaPhieu.Location = new System.Drawing.Point(175, 38);
            this.textBoxMaPhieu.Name = "textBoxMaPhieu";
            this.textBoxMaPhieu.ReadOnly = true;
            this.textBoxMaPhieu.Size = new System.Drawing.Size(235, 20);
            this.textBoxMaPhieu.TabIndex = 5;
            this.textBoxMaPhieu.TextChanged += new System.EventHandler(this.textBoxMaPhieu_TextChanged);
            // 
            // textBoxNgayTao
            // 
            this.textBoxNgayTao.Location = new System.Drawing.Point(175, 69);
            this.textBoxNgayTao.Name = "textBoxNgayTao";
            this.textBoxNgayTao.ReadOnly = true;
            this.textBoxNgayTao.Size = new System.Drawing.Size(235, 20);
            this.textBoxNgayTao.TabIndex = 6;
            this.textBoxNgayTao.TextChanged += new System.EventHandler(this.textBoxNgayTao_TextChanged);
            // 
            // textBoxNhanVienGH
            // 
            this.textBoxNhanVienGH.Location = new System.Drawing.Point(175, 100);
            this.textBoxNhanVienGH.Name = "textBoxNhanVienGH";
            this.textBoxNhanVienGH.Size = new System.Drawing.Size(235, 20);
            this.textBoxNhanVienGH.TabIndex = 7;
            this.textBoxNhanVienGH.TextChanged += new System.EventHandler(this.textBoxNhanVienGH_TextChanged);
            // 
            // textBoxNguoiLapPhieu
            // 
            this.textBoxNguoiLapPhieu.Location = new System.Drawing.Point(175, 159);
            this.textBoxNguoiLapPhieu.Name = "textBoxNguoiLapPhieu";
            this.textBoxNguoiLapPhieu.ReadOnly = true;
            this.textBoxNguoiLapPhieu.Size = new System.Drawing.Size(235, 20);
            this.textBoxNguoiLapPhieu.TabIndex = 8;
            this.textBoxNguoiLapPhieu.TextChanged += new System.EventHandler(this.textBoxNguoiLapPhieu_TextChanged);
            // 
            // comboBoxNhaCungCap
            // 
            this.comboBoxNhaCungCap.FormattingEnabled = true;
            this.comboBoxNhaCungCap.Location = new System.Drawing.Point(175, 128);
            this.comboBoxNhaCungCap.Name = "comboBoxNhaCungCap";
            this.comboBoxNhaCungCap.Size = new System.Drawing.Size(235, 21);
            this.comboBoxNhaCungCap.TabIndex = 9;
            this.comboBoxNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.comboBoxNhaCungCap_SelectedIndexChanged);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(335, 202);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 11;
            this.buttonHuy.Text = "Hủy bỏ";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Image = global::SSMP.Properties.Resources.accept;
            this.buttonLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLuu.Location = new System.Drawing.Point(244, 202);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 23);
            this.buttonLuu.TabIndex = 10;
            this.buttonLuu.Text = "Lưu Lại";
            this.buttonLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // FormSuaHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 264);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.comboBoxNhaCungCap);
            this.Controls.Add(this.textBoxNguoiLapPhieu);
            this.Controls.Add(this.textBoxNhanVienGH);
            this.Controls.Add(this.textBoxNgayTao);
            this.Controls.Add(this.textBoxMaPhieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaHoaDonNhap";
            this.Text = "Sửa Hóa Đơn Nhập Hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaPhieu;
        private System.Windows.Forms.TextBox textBoxNgayTao;
        private System.Windows.Forms.TextBox textBoxNhanVienGH;
        private System.Windows.Forms.TextBox textBoxNguoiLapPhieu;
        private System.Windows.Forms.ComboBox comboBoxNhaCungCap;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonHuy;
    }
}