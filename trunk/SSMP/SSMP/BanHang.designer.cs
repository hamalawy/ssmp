namespace SSMP
{
    partial class BanHang
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNgayThang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewDS = new System.Windows.Forms.DataGridView();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenKhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaCacTruong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnDuaVaoPhieuXuat = new System.Windows.Forms.Button();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.checkBoxKh = new System.Windows.Forms.CheckBox();
            this.checkBoxTen = new System.Windows.Forms.CheckBox();
            this.checkBoxDonVi = new System.Windows.Forms.CheckBox();
            this.checkBoxGiaBan = new System.Windows.Forms.CheckBox();
            this.checkBoxGiamGia = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxId);
            this.tabPage1.Controls.Add(this.checkBoxKh);
            this.tabPage1.Controls.Add(this.checkBoxTen);
            this.tabPage1.Controls.Add(this.checkBoxDonVi);
            this.tabPage1.Controls.Add(this.checkBoxGiaBan);
            this.tabPage1.Controls.Add(this.checkBoxGiamGia);
            this.tabPage1.Controls.Add(this.txtNgayThang);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dataGridViewDS);
            this.tabPage1.Controls.Add(this.btnXoaCacTruong);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnCapNhat);
            this.tabPage1.Controls.Add(this.btnDuaVaoPhieuXuat);
            this.tabPage1.Controls.Add(this.txtKhachHang);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lập phiếu bán hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNgayThang
            // 
            this.txtNgayThang.Location = new System.Drawing.Point(441, 36);
            this.txtNgayThang.Name = "txtNgayThang";
            this.txtNgayThang.Size = new System.Drawing.Size(163, 20);
            this.txtNgayThang.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 16);
            this.label5.TabIndex = 141;
            this.label5.Text = "Danh sách hàng hóa :(trong phiếu xuất)";
            // 
            // dataGridViewDS
            // 
            this.dataGridViewDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.cltenKhachhang,
            this.clTenSp,
            this.clDonVi,
            this.clGiaBan,
            this.clGiamGia});
            this.dataGridViewDS.Location = new System.Drawing.Point(34, 176);
            this.dataGridViewDS.Name = "dataGridViewDS";
            this.dataGridViewDS.Size = new System.Drawing.Size(839, 299);
            this.dataGridViewDS.TabIndex = 140;
            // 
            // idProduct
            // 
            this.idProduct.HeaderText = "Id sản phẩm";
            this.idProduct.Name = "idProduct";
            // 
            // cltenKhachhang
            // 
            this.cltenKhachhang.HeaderText = "Khách hàng";
            this.cltenKhachhang.Name = "cltenKhachhang";
            // 
            // clTenSp
            // 
            this.clTenSp.HeaderText = "Tên sản phẩm";
            this.clTenSp.Name = "clTenSp";
            this.clTenSp.ReadOnly = true;
            // 
            // clDonVi
            // 
            this.clDonVi.HeaderText = "Đơn vị";
            this.clDonVi.Name = "clDonVi";
            this.clDonVi.ReadOnly = true;
            // 
            // clGiaBan
            // 
            this.clGiaBan.HeaderText = "Giá bán";
            this.clGiaBan.Name = "clGiaBan";
            this.clGiaBan.ReadOnly = true;
            // 
            // clGiamGia
            // 
            this.clGiamGia.HeaderText = "Giảm giá";
            this.clGiamGia.Name = "clGiamGia";
            this.clGiamGia.ReadOnly = true;
            // 
            // btnXoaCacTruong
            // 
            this.btnXoaCacTruong.Location = new System.Drawing.Point(714, 73);
            this.btnXoaCacTruong.Name = "btnXoaCacTruong";
            this.btnXoaCacTruong.Size = new System.Drawing.Size(88, 23);
            this.btnXoaCacTruong.TabIndex = 139;
            this.btnXoaCacTruong.Text = "Xóa các &trường";
            this.btnXoaCacTruong.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(644, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 23);
            this.btnXoa.TabIndex = 138;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(556, 73);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 137;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDuaVaoPhieuXuat
            // 
            this.btnDuaVaoPhieuXuat.Location = new System.Drawing.Point(414, 73);
            this.btnDuaVaoPhieuXuat.Name = "btnDuaVaoPhieuXuat";
            this.btnDuaVaoPhieuXuat.Size = new System.Drawing.Size(119, 23);
            this.btnDuaVaoPhieuXuat.TabIndex = 136;
            this.btnDuaVaoPhieuXuat.Text = "Đưa vào &Phiếu xuất";
            this.btnDuaVaoPhieuXuat.UseVisualStyleBackColor = true;
            this.btnDuaVaoPhieuXuat.Click += new System.EventHandler(this.btnDuaVaoPhieuXuat_Click);
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(144, 103);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(200, 20);
            this.txtKhachHang.TabIndex = 135;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 134;
            this.label13.Text = "Id khách hàng :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(143, 76);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(201, 20);
            this.txtId.TabIndex = 6;
            this.txtId.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id sản phẩm :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(714, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày tháng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Người viết:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU XUẤT KHO";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý phiếu bán hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(880, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Báo cáo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Checked = true;
            this.checkBoxId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxId.Location = new System.Drawing.Point(501, 124);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(84, 17);
            this.checkBoxId.TabIndex = 1;
            this.checkBoxId.Text = "Id sản phẩm";
            this.checkBoxId.UseVisualStyleBackColor = true;
            this.checkBoxId.CheckedChanged += new System.EventHandler(this.checkBoxId_CheckedChanged);
            // 
            // checkBoxKh
            // 
            this.checkBoxKh.AutoSize = true;
            this.checkBoxKh.Checked = true;
            this.checkBoxKh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKh.Location = new System.Drawing.Point(501, 147);
            this.checkBoxKh.Name = "checkBoxKh";
            this.checkBoxKh.Size = new System.Drawing.Size(84, 17);
            this.checkBoxKh.TabIndex = 2;
            this.checkBoxKh.Text = "Khách hàng";
            this.checkBoxKh.UseVisualStyleBackColor = true;
            this.checkBoxKh.CheckedChanged += new System.EventHandler(this.checkBoxKh_CheckedChanged);
            // 
            // checkBoxTen
            // 
            this.checkBoxTen.AutoSize = true;
            this.checkBoxTen.Checked = true;
            this.checkBoxTen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTen.Location = new System.Drawing.Point(607, 124);
            this.checkBoxTen.Name = "checkBoxTen";
            this.checkBoxTen.Size = new System.Drawing.Size(94, 17);
            this.checkBoxTen.TabIndex = 3;
            this.checkBoxTen.Text = "Tên sản phẩm";
            this.checkBoxTen.UseVisualStyleBackColor = true;
            this.checkBoxTen.CheckedChanged += new System.EventHandler(this.checkBoxTen_CheckedChanged);
            // 
            // checkBoxDonVi
            // 
            this.checkBoxDonVi.AutoSize = true;
            this.checkBoxDonVi.Checked = true;
            this.checkBoxDonVi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDonVi.Location = new System.Drawing.Point(607, 147);
            this.checkBoxDonVi.Name = "checkBoxDonVi";
            this.checkBoxDonVi.Size = new System.Drawing.Size(57, 17);
            this.checkBoxDonVi.TabIndex = 4;
            this.checkBoxDonVi.Text = "Đơn vị";
            this.checkBoxDonVi.UseVisualStyleBackColor = true;
            this.checkBoxDonVi.CheckedChanged += new System.EventHandler(this.checkBoxDonVi_CheckedChanged);
            // 
            // checkBoxGiaBan
            // 
            this.checkBoxGiaBan.AutoSize = true;
            this.checkBoxGiaBan.Checked = true;
            this.checkBoxGiaBan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGiaBan.Location = new System.Drawing.Point(714, 124);
            this.checkBoxGiaBan.Name = "checkBoxGiaBan";
            this.checkBoxGiaBan.Size = new System.Drawing.Size(63, 17);
            this.checkBoxGiaBan.TabIndex = 5;
            this.checkBoxGiaBan.Text = "Giá bán";
            this.checkBoxGiaBan.UseVisualStyleBackColor = true;
            this.checkBoxGiaBan.CheckedChanged += new System.EventHandler(this.checkBoxGiaBan_CheckedChanged);
            // 
            // checkBoxGiamGia
            // 
            this.checkBoxGiamGia.AutoSize = true;
            this.checkBoxGiamGia.Checked = true;
            this.checkBoxGiamGia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGiamGia.Location = new System.Drawing.Point(714, 147);
            this.checkBoxGiamGia.Name = "checkBoxGiamGia";
            this.checkBoxGiamGia.Size = new System.Drawing.Size(67, 17);
            this.checkBoxGiamGia.TabIndex = 6;
            this.checkBoxGiamGia.Text = "Giảm giá";
            this.checkBoxGiamGia.UseVisualStyleBackColor = true;
            this.checkBoxGiamGia.CheckedChanged += new System.EventHandler(this.checkBoxGiamGia_CheckedChanged);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "BanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnXoaCacTruong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnDuaVaoPhieuXuat;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewDS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenKhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiamGia;
        private System.Windows.Forms.TextBox txtNgayThang;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.CheckBox checkBoxKh;
        private System.Windows.Forms.CheckBox checkBoxTen;
        private System.Windows.Forms.CheckBox checkBoxDonVi;
        private System.Windows.Forms.CheckBox checkBoxGiaBan;
        private System.Windows.Forms.CheckBox checkBoxGiamGia;
    }
}