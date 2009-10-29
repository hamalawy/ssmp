namespace SSMP
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.gbDoiMatKhau = new System.Windows.Forms.GroupBox();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.imglDoiMatKhau = new System.Windows.Forms.ImageList(this.components);
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtXacNhanLaiMatKhau = new System.Windows.Forms.TextBox();
            this.lblXacNhanMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.picDoiMatKhau = new System.Windows.Forms.PictureBox();
            this.gbDoiMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoiMatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDoiMatKhau
            // 
            this.gbDoiMatKhau.Controls.Add(this.btnXoaTrang);
            this.gbDoiMatKhau.Controls.Add(this.btnDoiMatKhau);
            this.gbDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.gbDoiMatKhau.Controls.Add(this.lblMatKhauMoi);
            this.gbDoiMatKhau.Controls.Add(this.txtXacNhanLaiMatKhau);
            this.gbDoiMatKhau.Controls.Add(this.lblXacNhanMatKhauMoi);
            this.gbDoiMatKhau.Controls.Add(this.txtMatKhauCu);
            this.gbDoiMatKhau.Controls.Add(this.lblMatKhauCu);
            this.gbDoiMatKhau.Controls.Add(this.picDoiMatKhau);
            this.gbDoiMatKhau.Location = new System.Drawing.Point(12, 6);
            this.gbDoiMatKhau.Name = "gbDoiMatKhau";
            this.gbDoiMatKhau.Size = new System.Drawing.Size(447, 248);
            this.gbDoiMatKhau.TabIndex = 0;
            this.gbDoiMatKhau.TabStop = false;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTrang.ImageIndex = 0;
            this.btnXoaTrang.ImageList = this.imglDoiMatKhau;
            this.btnXoaTrang.Location = new System.Drawing.Point(289, 161);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTrang.TabIndex = 5;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // imglDoiMatKhau
            // 
            this.imglDoiMatKhau.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglDoiMatKhau.ImageStream")));
            this.imglDoiMatKhau.TransparentColor = System.Drawing.Color.Transparent;
            this.imglDoiMatKhau.Images.SetKeyName(0, "undo.png");
            this.imglDoiMatKhau.Images.SetKeyName(1, "user1_preferences.png");
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.ImageIndex = 1;
            this.btnDoiMatKhau.ImageList = this.imglDoiMatKhau;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(164, 161);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(97, 23);
            this.btnDoiMatKhau.TabIndex = 4;
            this.btnDoiMatKhau.Text = "Đổi &mật khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(255, 86);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(168, 20);
            this.txtMatKhauMoi.TabIndex = 2;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(127, 89);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(74, 13);
            this.lblMatKhauMoi.TabIndex = 5;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // txtXacNhanLaiMatKhau
            // 
            this.txtXacNhanLaiMatKhau.Location = new System.Drawing.Point(255, 112);
            this.txtXacNhanLaiMatKhau.Name = "txtXacNhanLaiMatKhau";
            this.txtXacNhanLaiMatKhau.PasswordChar = '*';
            this.txtXacNhanLaiMatKhau.Size = new System.Drawing.Size(168, 20);
            this.txtXacNhanLaiMatKhau.TabIndex = 3;
            // 
            // lblXacNhanMatKhauMoi
            // 
            this.lblXacNhanMatKhauMoi.AutoSize = true;
            this.lblXacNhanMatKhauMoi.Location = new System.Drawing.Point(127, 115);
            this.lblXacNhanMatKhauMoi.Name = "lblXacNhanMatKhauMoi";
            this.lblXacNhanMatKhauMoi.Size = new System.Drawing.Size(122, 13);
            this.lblXacNhanMatKhauMoi.TabIndex = 3;
            this.lblXacNhanMatKhauMoi.Text = "Xác nhận mật khẩu mới:";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(255, 60);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(168, 20);
            this.txtMatKhauCu.TabIndex = 1;
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Location = new System.Drawing.Point(127, 63);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(70, 13);
            this.lblMatKhauCu.TabIndex = 1;
            this.lblMatKhauCu.Text = "Mật khẩu cũ:";
            // 
            // picDoiMatKhau
            // 
            this.picDoiMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDoiMatKhau.Image = global::SSMP.Properties.Resources.user1_preferences;
            this.picDoiMatKhau.Location = new System.Drawing.Point(27, 72);
            this.picDoiMatKhau.Name = "picDoiMatKhau";
            this.picDoiMatKhau.Size = new System.Drawing.Size(56, 48);
            this.picDoiMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoiMatKhau.TabIndex = 0;
            this.picDoiMatKhau.TabStop = false;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 266);
            this.Controls.Add(this.gbDoiMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.gbDoiMatKhau.ResumeLayout(false);
            this.gbDoiMatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoiMatKhau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDoiMatKhau;
        private System.Windows.Forms.PictureBox picDoiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.TextBox txtXacNhanLaiMatKhau;
        private System.Windows.Forms.Label lblXacNhanMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.ImageList imglDoiMatKhau;
    }
}