namespace SSMP
{
    partial class FrmConfig
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.gbCauHinh = new System.Windows.Forms.GroupBox();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.imglCauHinh = new System.Windows.Forms.ImageList(this.components);
            this.btnCauHinh = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtCoSoDuLieu = new System.Windows.Forms.TextBox();
            this.lblCoSoDuLieu = new System.Windows.Forms.Label();
            this.txtTenMayChu = new System.Windows.Forms.TextBox();
            this.lblTenMayChu = new System.Windows.Forms.Label();
            this.picCauHinh = new System.Windows.Forms.PictureBox();
            this.gbCauHinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCauHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCauHinh
            // 
            this.gbCauHinh.Controls.Add(this.btnXoaTrang);
            this.gbCauHinh.Controls.Add(this.btnCauHinh);
            this.gbCauHinh.Controls.Add(this.txtMatKhau);
            this.gbCauHinh.Controls.Add(this.lblMatKhau);
            this.gbCauHinh.Controls.Add(this.txtTenDangNhap);
            this.gbCauHinh.Controls.Add(this.lblTenDangNhap);
            this.gbCauHinh.Controls.Add(this.txtCoSoDuLieu);
            this.gbCauHinh.Controls.Add(this.lblCoSoDuLieu);
            this.gbCauHinh.Controls.Add(this.txtTenMayChu);
            this.gbCauHinh.Controls.Add(this.lblTenMayChu);
            this.gbCauHinh.Controls.Add(this.picCauHinh);
            this.gbCauHinh.Location = new System.Drawing.Point(12, 2);
            this.gbCauHinh.Name = "gbCauHinh";
            this.gbCauHinh.Size = new System.Drawing.Size(424, 235);
            this.gbCauHinh.TabIndex = 0;
            this.gbCauHinh.TabStop = false;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXoaTrang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTrang.ImageIndex = 1;
            this.btnXoaTrang.ImageList = this.imglCauHinh;
            this.btnXoaTrang.Location = new System.Drawing.Point(324, 160);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(80, 23);
            this.btnXoaTrang.TabIndex = 6;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // imglCauHinh
            // 
            this.imglCauHinh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglCauHinh.ImageStream")));
            this.imglCauHinh.TransparentColor = System.Drawing.Color.Transparent;
            this.imglCauHinh.Images.SetKeyName(0, "wrench.png");
            this.imglCauHinh.Images.SetKeyName(1, "undo.png");
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCauHinh.ImageIndex = 0;
            this.btnCauHinh.ImageList = this.imglCauHinh;
            this.btnCauHinh.Location = new System.Drawing.Point(242, 160);
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.Size = new System.Drawing.Size(75, 23);
            this.btnCauHinh.TabIndex = 5;
            this.btnCauHinh.Text = "&Cấu hình";
            this.btnCauHinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCauHinh.UseVisualStyleBackColor = true;
            this.btnCauHinh.Click += new System.EventHandler(this.btnCauHinh_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(242, 114);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(162, 20);
            this.txtMatKhau.TabIndex = 4;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(154, 117);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(55, 13);
            this.lblMatKhau.TabIndex = 7;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(242, 88);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(162, 20);
            this.txtTenDangNhap.TabIndex = 3;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(154, 91);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(84, 13);
            this.lblTenDangNhap.TabIndex = 5;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtCoSoDuLieu
            // 
            this.txtCoSoDuLieu.Location = new System.Drawing.Point(242, 62);
            this.txtCoSoDuLieu.Name = "txtCoSoDuLieu";
            this.txtCoSoDuLieu.Size = new System.Drawing.Size(162, 20);
            this.txtCoSoDuLieu.TabIndex = 2;
            // 
            // lblCoSoDuLieu
            // 
            this.lblCoSoDuLieu.AutoSize = true;
            this.lblCoSoDuLieu.Location = new System.Drawing.Point(154, 65);
            this.lblCoSoDuLieu.Name = "lblCoSoDuLieu";
            this.lblCoSoDuLieu.Size = new System.Drawing.Size(71, 13);
            this.lblCoSoDuLieu.TabIndex = 3;
            this.lblCoSoDuLieu.Text = "Cơ sở dữ liệu:";
            // 
            // txtTenMayChu
            // 
            this.txtTenMayChu.Location = new System.Drawing.Point(242, 36);
            this.txtTenMayChu.Name = "txtTenMayChu";
            this.txtTenMayChu.Size = new System.Drawing.Size(162, 20);
            this.txtTenMayChu.TabIndex = 1;
            // 
            // lblTenMayChu
            // 
            this.lblTenMayChu.AutoSize = true;
            this.lblTenMayChu.Location = new System.Drawing.Point(154, 39);
            this.lblTenMayChu.Name = "lblTenMayChu";
            this.lblTenMayChu.Size = new System.Drawing.Size(72, 13);
            this.lblTenMayChu.TabIndex = 1;
            this.lblTenMayChu.Text = "Tên máy chủ:";
            // 
            // picCauHinh
            // 
            this.picCauHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCauHinh.Image = global::SSMP.Properties.Resources.workstation2;
            this.picCauHinh.Location = new System.Drawing.Point(30, 52);
            this.picCauHinh.Name = "picCauHinh";
            this.picCauHinh.Size = new System.Drawing.Size(64, 67);
            this.picCauHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCauHinh.TabIndex = 0;
            this.picCauHinh.TabStop = false;
            // 
            // FrmConfig
            // 
            this.AcceptButton = this.btnCauHinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnXoaTrang;
            this.ClientSize = new System.Drawing.Size(450, 249);
            this.Controls.Add(this.gbCauHinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.Text = "Cấu Hình";
            this.Load += new System.EventHandler(this.frmCauHinh_Load);
            this.gbCauHinh.ResumeLayout(false);
            this.gbCauHinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCauHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCauHinh;
        private System.Windows.Forms.PictureBox picCauHinh;
        private System.Windows.Forms.TextBox txtTenMayChu;
        private System.Windows.Forms.Label lblTenMayChu;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtCoSoDuLieu;
        private System.Windows.Forms.Label lblCoSoDuLieu;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnCauHinh;
        private System.Windows.Forms.ImageList imglCauHinh;
    }
}