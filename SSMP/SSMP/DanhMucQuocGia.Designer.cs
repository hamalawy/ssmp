namespace SSMP
{
    partial class frmDanhMucQuocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucQuocGia));
            this.imglDanhMucQuocGia = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpQuanLy = new System.Windows.Forms.TabPage();
            this.btnReload = new System.Windows.Forms.Button();
            this.chkMaQuocGiaHienThiQuanLy = new System.Windows.Forms.CheckBox();
            this.chkQuocGiaHienThiQuanLy = new System.Windows.Forms.CheckBox();
            this.lblHienThiQuanLy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinThongKeQuanLy = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTongSoQuanLy = new System.Windows.Forms.Label();
            this.gbTimKiemQuanLy = new System.Windows.Forms.GroupBox();
            this.lblViDuTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimKiemQuanLy = new System.Windows.Forms.Label();
            this.gvCountry = new System.Windows.Forms.DataGridView();
            this.gbThongTinQuocGia = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCountryId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMaQuocGia = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.lblTenQuocGia = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpQuanLy.SuspendLayout();
            this.gbThongTinThongKeQuanLy.SuspendLayout();
            this.gbTimKiemQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCountry)).BeginInit();
            this.gbThongTinQuocGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // imglDanhMucQuocGia
            // 
            this.imglDanhMucQuocGia.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglDanhMucQuocGia.ImageStream")));
            this.imglDanhMucQuocGia.TransparentColor = System.Drawing.Color.Transparent;
            this.imglDanhMucQuocGia.Images.SetKeyName(0, "exit.png");
            this.imglDanhMucQuocGia.Images.SetKeyName(1, "add.png");
            this.imglDanhMucQuocGia.Images.SetKeyName(2, "check.png");
            this.imglDanhMucQuocGia.Images.SetKeyName(3, "delete.png");
            this.imglDanhMucQuocGia.Images.SetKeyName(4, "undo.png");
            this.imglDanhMucQuocGia.Images.SetKeyName(5, "recycle.png");
            this.imglDanhMucQuocGia.Images.SetKeyName(6, "refresh.png");
            this.imglDanhMucQuocGia.Images.SetKeyName(7, "find.png");
            this.imglDanhMucQuocGia.Images.SetKeyName(8, "printer3.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpQuanLy);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tpQuanLy
            // 
            this.tpQuanLy.Controls.Add(this.btnReload);
            this.tpQuanLy.Controls.Add(this.chkMaQuocGiaHienThiQuanLy);
            this.tpQuanLy.Controls.Add(this.chkQuocGiaHienThiQuanLy);
            this.tpQuanLy.Controls.Add(this.lblHienThiQuanLy);
            this.tpQuanLy.Controls.Add(this.label1);
            this.tpQuanLy.Controls.Add(this.gbThongTinThongKeQuanLy);
            this.tpQuanLy.Controls.Add(this.gbTimKiemQuanLy);
            this.tpQuanLy.Controls.Add(this.gvCountry);
            this.tpQuanLy.Controls.Add(this.gbThongTinQuocGia);
            this.tpQuanLy.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLy.Name = "tpQuanLy";
            this.tpQuanLy.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLy.Size = new System.Drawing.Size(818, 550);
            this.tpQuanLy.TabIndex = 0;
            this.tpQuanLy.Text = "Quản lý";
            this.tpQuanLy.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.ImageIndex = 6;
            this.btnReload.ImageList = this.imglDanhMucQuocGia;
            this.btnReload.Location = new System.Drawing.Point(751, 37);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(61, 23);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Tải &lại";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // chkMaQuocGiaHienThiQuanLy
            // 
            this.chkMaQuocGiaHienThiQuanLy.AutoSize = true;
            this.chkMaQuocGiaHienThiQuanLy.Checked = true;
            this.chkMaQuocGiaHienThiQuanLy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaQuocGiaHienThiQuanLy.Enabled = false;
            this.chkMaQuocGiaHienThiQuanLy.Location = new System.Drawing.Point(513, 45);
            this.chkMaQuocGiaHienThiQuanLy.Name = "chkMaQuocGiaHienThiQuanLy";
            this.chkMaQuocGiaHienThiQuanLy.Size = new System.Drawing.Size(85, 17);
            this.chkMaQuocGiaHienThiQuanLy.TabIndex = 10;
            this.chkMaQuocGiaHienThiQuanLy.Text = "Mã quốc gia";
            this.chkMaQuocGiaHienThiQuanLy.UseVisualStyleBackColor = true;
            // 
            // chkQuocGiaHienThiQuanLy
            // 
            this.chkQuocGiaHienThiQuanLy.AutoSize = true;
            this.chkQuocGiaHienThiQuanLy.Location = new System.Drawing.Point(614, 45);
            this.chkQuocGiaHienThiQuanLy.Name = "chkQuocGiaHienThiQuanLy";
            this.chkQuocGiaHienThiQuanLy.Size = new System.Drawing.Size(69, 17);
            this.chkQuocGiaHienThiQuanLy.TabIndex = 11;
            this.chkQuocGiaHienThiQuanLy.Text = "Quốc gia";
            this.chkQuocGiaHienThiQuanLy.UseVisualStyleBackColor = true;
            // 
            // lblHienThiQuanLy
            // 
            this.lblHienThiQuanLy.AutoSize = true;
            this.lblHienThiQuanLy.Location = new System.Drawing.Point(449, 46);
            this.lblHienThiQuanLy.Name = "lblHienThiQuanLy";
            this.lblHienThiQuanLy.Size = new System.Drawing.Size(46, 13);
            this.lblHienThiQuanLy.TabIndex = 20;
            this.lblHienThiQuanLy.Text = "Hiển thị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(449, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "DANH SÁCH CÁC QUỐC GIA:";
            // 
            // gbThongTinThongKeQuanLy
            // 
            this.gbThongTinThongKeQuanLy.Controls.Add(this.txtTotal);
            this.gbThongTinThongKeQuanLy.Controls.Add(this.lblTongSoQuanLy);
            this.gbThongTinThongKeQuanLy.Location = new System.Drawing.Point(6, 288);
            this.gbThongTinThongKeQuanLy.Name = "gbThongTinThongKeQuanLy";
            this.gbThongTinThongKeQuanLy.Size = new System.Drawing.Size(424, 62);
            this.gbThongTinThongKeQuanLy.TabIndex = 18;
            this.gbThongTinThongKeQuanLy.TabStop = false;
            this.gbThongTinThongKeQuanLy.Text = "Thông tin thống kê:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(75, 24);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // lblTongSoQuanLy
            // 
            this.lblTongSoQuanLy.AutoSize = true;
            this.lblTongSoQuanLy.Location = new System.Drawing.Point(17, 27);
            this.lblTongSoQuanLy.Name = "lblTongSoQuanLy";
            this.lblTongSoQuanLy.Size = new System.Drawing.Size(49, 13);
            this.lblTongSoQuanLy.TabIndex = 0;
            this.lblTongSoQuanLy.Text = "Tổng số:";
            // 
            // gbTimKiemQuanLy
            // 
            this.gbTimKiemQuanLy.Controls.Add(this.lblViDuTimKiemQuanLy);
            this.gbTimKiemQuanLy.Controls.Add(this.btnSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.txtSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.lblTimKiemQuanLy);
            this.gbTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbTimKiemQuanLy.Location = new System.Drawing.Point(6, 16);
            this.gbTimKiemQuanLy.Name = "gbTimKiemQuanLy";
            this.gbTimKiemQuanLy.Size = new System.Drawing.Size(424, 95);
            this.gbTimKiemQuanLy.TabIndex = 17;
            this.gbTimKiemQuanLy.TabStop = false;
            this.gbTimKiemQuanLy.Text = "TÌM KIẾM";
            // 
            // lblViDuTimKiemQuanLy
            // 
            this.lblViDuTimKiemQuanLy.AutoSize = true;
            this.lblViDuTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblViDuTimKiemQuanLy.Location = new System.Drawing.Point(72, 50);
            this.lblViDuTimKiemQuanLy.Name = "lblViDuTimKiemQuanLy";
            this.lblViDuTimKiemQuanLy.Size = new System.Drawing.Size(161, 13);
            this.lblViDuTimKiemQuanLy.TabIndex = 4;
            this.lblViDuTimKiemQuanLy.Text = "(ví dụ: Trung Quốc, Nhật Bản...)";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageIndex = 7;
            this.btnSearch.ImageList = this.imglDanhMucQuocGia;
            this.btnSearch.Location = new System.Drawing.Point(312, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm &kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(75, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblTimKiemQuanLy
            // 
            this.lblTimKiemQuanLy.AutoSize = true;
            this.lblTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimKiemQuanLy.Location = new System.Drawing.Point(17, 30);
            this.lblTimKiemQuanLy.Name = "lblTimKiemQuanLy";
            this.lblTimKiemQuanLy.Size = new System.Drawing.Size(52, 13);
            this.lblTimKiemQuanLy.TabIndex = 0;
            this.lblTimKiemQuanLy.Text = "Tìm kiếm:";
            // 
            // gvCountry
            // 
            this.gvCountry.AllowUserToAddRows = false;
            this.gvCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCountry.Location = new System.Drawing.Point(452, 66);
            this.gvCountry.MultiSelect = false;
            this.gvCountry.Name = "gvCountry";
            this.gvCountry.ReadOnly = true;
            this.gvCountry.Size = new System.Drawing.Size(360, 465);
            this.gvCountry.TabIndex = 13;
            this.gvCountry.SelectionChanged += new System.EventHandler(this.gvCountry_SelectionChanged);
            // 
            // gbThongTinQuocGia
            // 
            this.gbThongTinQuocGia.Controls.Add(this.btnReset);
            this.gbThongTinQuocGia.Controls.Add(this.btnDelete);
            this.gbThongTinQuocGia.Controls.Add(this.btnUpdate);
            this.gbThongTinQuocGia.Controls.Add(this.txtCountryId);
            this.gbThongTinQuocGia.Controls.Add(this.btnAdd);
            this.gbThongTinQuocGia.Controls.Add(this.lblMaQuocGia);
            this.gbThongTinQuocGia.Controls.Add(this.txtCountryName);
            this.gbThongTinQuocGia.Controls.Add(this.lblTenQuocGia);
            this.gbThongTinQuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThongTinQuocGia.Location = new System.Drawing.Point(6, 128);
            this.gbThongTinQuocGia.Name = "gbThongTinQuocGia";
            this.gbThongTinQuocGia.Size = new System.Drawing.Size(424, 144);
            this.gbThongTinQuocGia.TabIndex = 14;
            this.gbThongTinQuocGia.TabStop = false;
            this.gbThongTinQuocGia.Text = "THÔNG TIN QUỐC GIA";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.ImageIndex = 4;
            this.btnReset.ImageList = this.imglDanhMucQuocGia;
            this.btnReset.Location = new System.Drawing.Point(250, 101);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Xóa &trắng";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.ImageList = this.imglDanhMucQuocGia;
            this.btnDelete.Location = new System.Drawing.Point(189, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageIndex = 2;
            this.btnUpdate.ImageList = this.imglDanhMucQuocGia;
            this.btnUpdate.Location = new System.Drawing.Point(97, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCountryId
            // 
            this.txtCountryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCountryId.Location = new System.Drawing.Point(97, 27);
            this.txtCountryId.Name = "txtCountryId";
            this.txtCountryId.ReadOnly = true;
            this.txtCountryId.Size = new System.Drawing.Size(78, 20);
            this.txtCountryId.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 1;
            this.btnAdd.ImageList = this.imglDanhMucQuocGia;
            this.btnAdd.Location = new System.Drawing.Point(20, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "T&hêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMaQuocGia
            // 
            this.lblMaQuocGia.AutoSize = true;
            this.lblMaQuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaQuocGia.Location = new System.Drawing.Point(18, 30);
            this.lblMaQuocGia.Name = "lblMaQuocGia";
            this.lblMaQuocGia.Size = new System.Drawing.Size(69, 13);
            this.lblMaQuocGia.TabIndex = 2;
            this.lblMaQuocGia.Text = "Mã quốc gia:";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCountryName.Location = new System.Drawing.Point(97, 53);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(178, 20);
            this.txtCountryName.TabIndex = 4;
            // 
            // lblTenQuocGia
            // 
            this.lblTenQuocGia.AutoSize = true;
            this.lblTenQuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenQuocGia.Location = new System.Drawing.Point(18, 56);
            this.lblTenQuocGia.Name = "lblTenQuocGia";
            this.lblTenQuocGia.Size = new System.Drawing.Size(73, 13);
            this.lblTenQuocGia.TabIndex = 0;
            this.lblTenQuocGia.Text = "Tên quốc gia:";
            // 
            // frmDanhMucQuocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 590);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDanhMucQuocGia";
            this.Text = "Danh Mục Quốc Gia";
            this.Load += new System.EventHandler(this.frmDanhMucQuocGia_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpQuanLy.ResumeLayout(false);
            this.tpQuanLy.PerformLayout();
            this.gbThongTinThongKeQuanLy.ResumeLayout(false);
            this.gbThongTinThongKeQuanLy.PerformLayout();
            this.gbTimKiemQuanLy.ResumeLayout(false);
            this.gbTimKiemQuanLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCountry)).EndInit();
            this.gbThongTinQuocGia.ResumeLayout(false);
            this.gbThongTinQuocGia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imglDanhMucQuocGia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpQuanLy;
        private System.Windows.Forms.CheckBox chkMaQuocGiaHienThiQuanLy;
        private System.Windows.Forms.CheckBox chkQuocGiaHienThiQuanLy;
        private System.Windows.Forms.Label lblHienThiQuanLy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTinThongKeQuanLy;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTongSoQuanLy;
        private System.Windows.Forms.GroupBox gbTimKiemQuanLy;
        private System.Windows.Forms.Label lblViDuTimKiemQuanLy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTimKiemQuanLy;
        private System.Windows.Forms.DataGridView gvCountry;
        private System.Windows.Forms.GroupBox gbThongTinQuocGia;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCountryId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMaQuocGia;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label lblTenQuocGia;
        private System.Windows.Forms.Button btnReload;
    }
}