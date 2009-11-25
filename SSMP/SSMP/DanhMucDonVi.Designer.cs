namespace SSMP
{
    partial class FrmUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnit));
            this.tcQuanLyChucVu = new System.Windows.Forms.TabControl();
            this.tpQuanLyChucVu = new System.Windows.Forms.TabPage();
            this.panelUnit = new System.Windows.Forms.Panel();
            this.bindingNavigatorUnit = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLblTotal = new System.Windows.Forms.ToolStripLabel();
            this.gvUnit = new System.Windows.Forms.DataGridView();
            this.gbTimKiemQuanLy = new System.Windows.Forms.GroupBox();
            this.chkSearchAll = new System.Windows.Forms.CheckBox();
            this.chkSearchUnitDesc = new System.Windows.Forms.CheckBox();
            this.chkSearchUnitName = new System.Windows.Forms.CheckBox();
            this.chkSearchUnitID = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnInAnQuanLy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkDispAll = new System.Windows.Forms.CheckBox();
            this.chkDispUnitDesc = new System.Windows.Forms.CheckBox();
            this.chkDispUnitName = new System.Windows.Forms.CheckBox();
            this.chkDispUnitID = new System.Windows.Forms.CheckBox();
            this.lblHienThiQuanLy = new System.Windows.Forms.Label();
            this.lblDanhSachChucVuQuanLy = new System.Windows.Forms.Label();
            this.gbThongTinChucVu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUnitDesc = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.lblMaChucVu = new System.Windows.Forms.Label();
            this.btnReloadAll = new System.Windows.Forms.Button();
            this.tcQuanLyChucVu.SuspendLayout();
            this.tpQuanLyChucVu.SuspendLayout();
            this.panelUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUnit)).BeginInit();
            this.bindingNavigatorUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).BeginInit();
            this.gbTimKiemQuanLy.SuspendLayout();
            this.gbThongTinChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLyChucVu
            // 
            this.tcQuanLyChucVu.Controls.Add(this.tpQuanLyChucVu);
            this.tcQuanLyChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuanLyChucVu.Location = new System.Drawing.Point(0, 0);
            this.tcQuanLyChucVu.Name = "tcQuanLyChucVu";
            this.tcQuanLyChucVu.SelectedIndex = 0;
            this.tcQuanLyChucVu.Size = new System.Drawing.Size(826, 560);
            this.tcQuanLyChucVu.TabIndex = 0;
            // 
            // tpQuanLyChucVu
            // 
            this.tpQuanLyChucVu.Controls.Add(this.btnReloadAll);
            this.tpQuanLyChucVu.Controls.Add(this.panelUnit);
            this.tpQuanLyChucVu.Controls.Add(this.gbTimKiemQuanLy);
            this.tpQuanLyChucVu.Controls.Add(this.btnInAnQuanLy);
            this.tpQuanLyChucVu.Controls.Add(this.btnClose);
            this.tpQuanLyChucVu.Controls.Add(this.chkDispAll);
            this.tpQuanLyChucVu.Controls.Add(this.chkDispUnitDesc);
            this.tpQuanLyChucVu.Controls.Add(this.chkDispUnitName);
            this.tpQuanLyChucVu.Controls.Add(this.chkDispUnitID);
            this.tpQuanLyChucVu.Controls.Add(this.lblHienThiQuanLy);
            this.tpQuanLyChucVu.Controls.Add(this.lblDanhSachChucVuQuanLy);
            this.tpQuanLyChucVu.Controls.Add(this.gbThongTinChucVu);
            this.tpQuanLyChucVu.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLyChucVu.Name = "tpQuanLyChucVu";
            this.tpQuanLyChucVu.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyChucVu.Size = new System.Drawing.Size(818, 534);
            this.tpQuanLyChucVu.TabIndex = 0;
            this.tpQuanLyChucVu.Text = "Quản lý Đơn vị";
            this.tpQuanLyChucVu.UseVisualStyleBackColor = true;
            // 
            // panelUnit
            // 
            this.panelUnit.Controls.Add(this.bindingNavigatorUnit);
            this.panelUnit.Controls.Add(this.gvUnit);
            this.panelUnit.Location = new System.Drawing.Point(15, 253);
            this.panelUnit.Name = "panelUnit";
            this.panelUnit.Size = new System.Drawing.Size(787, 267);
            this.panelUnit.TabIndex = 27;
            // 
            // bindingNavigatorUnit
            // 
            this.bindingNavigatorUnit.AddNewItem = null;
            this.bindingNavigatorUnit.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorUnit.DeleteItem = null;
            this.bindingNavigatorUnit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorUnit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripBtnReload,
            this.toolStripSeparator1,
            this.toolStripBtnAdd,
            this.toolStripBtnEdit,
            this.toolStripBtnDelete,
            this.toolStripLblTotal});
            this.bindingNavigatorUnit.Location = new System.Drawing.Point(0, 242);
            this.bindingNavigatorUnit.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorUnit.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorUnit.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorUnit.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorUnit.Name = "bindingNavigatorUnit";
            this.bindingNavigatorUnit.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorUnit.Size = new System.Drawing.Size(787, 25);
            this.bindingNavigatorUnit.TabIndex = 15;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "of {0}";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "of {0}";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnReload
            // 
            this.toolStripBtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnReload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnReload.Image")));
            this.toolStripBtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnReload.Name = "toolStripBtnReload";
            this.toolStripBtnReload.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnReload.ToolTipText = "Tải lại";
            this.toolStripBtnReload.Click += new System.EventHandler(this.toolStripBtnReload_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnAdd
            // 
            this.toolStripBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAdd.Image")));
            this.toolStripBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAdd.Name = "toolStripBtnAdd";
            this.toolStripBtnAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnAdd.ToolTipText = "Thêm mới";
            this.toolStripBtnAdd.Click += new System.EventHandler(this.toolStripBtnAdd_Click);
            // 
            // toolStripBtnEdit
            // 
            this.toolStripBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEdit.Image")));
            this.toolStripBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEdit.Name = "toolStripBtnEdit";
            this.toolStripBtnEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnEdit.ToolTipText = "Sửa";
            this.toolStripBtnEdit.Click += new System.EventHandler(this.toolStripBtnEdit_Click);
            // 
            // toolStripBtnDelete
            // 
            this.toolStripBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDelete.Image")));
            this.toolStripBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDelete.Name = "toolStripBtnDelete";
            this.toolStripBtnDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnDelete.ToolTipText = "Xóa";
            this.toolStripBtnDelete.Click += new System.EventHandler(this.toolStripBtnDelete_Click);
            // 
            // toolStripLblTotal
            // 
            this.toolStripLblTotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLblTotal.Name = "toolStripLblTotal";
            this.toolStripLblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripLblTotal.Size = new System.Drawing.Size(87, 22);
            this.toolStripLblTotal.Text = "Tổng số dòng: ";
            // 
            // gvUnit
            // 
            this.gvUnit.AllowUserToAddRows = false;
            this.gvUnit.AllowUserToDeleteRows = false;
            this.gvUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvUnit.Location = new System.Drawing.Point(0, 0);
            this.gvUnit.MultiSelect = false;
            this.gvUnit.Name = "gvUnit";
            this.gvUnit.ReadOnly = true;
            this.gvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUnit.Size = new System.Drawing.Size(787, 282);
            this.gvUnit.TabIndex = 13;
            this.gvUnit.SelectionChanged += new System.EventHandler(this.gvUnit_SelectionChanged);
            // 
            // gbTimKiemQuanLy
            // 
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchAll);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUnitDesc);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUnitName);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUnitID);
            this.gbTimKiemQuanLy.Controls.Add(this.btnSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.txtSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.lblTimKiemQuanLy);
            this.gbTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbTimKiemQuanLy.Location = new System.Drawing.Point(363, 6);
            this.gbTimKiemQuanLy.Name = "gbTimKiemQuanLy";
            this.gbTimKiemQuanLy.Size = new System.Drawing.Size(439, 191);
            this.gbTimKiemQuanLy.TabIndex = 26;
            this.gbTimKiemQuanLy.TabStop = false;
            this.gbTimKiemQuanLy.Text = "TÌM KIẾM:";
            // 
            // chkSearchAll
            // 
            this.chkSearchAll.AutoSize = true;
            this.chkSearchAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchAll.Location = new System.Drawing.Point(79, 60);
            this.chkSearchAll.Name = "chkSearchAll";
            this.chkSearchAll.Size = new System.Drawing.Size(57, 17);
            this.chkSearchAll.TabIndex = 8;
            this.chkSearchAll.Text = "Tất cả";
            this.chkSearchAll.UseVisualStyleBackColor = true;
            this.chkSearchAll.CheckedChanged += new System.EventHandler(this.chkSearchAll_CheckedChanged);
            // 
            // chkSearchUnitDesc
            // 
            this.chkSearchUnitDesc.AutoSize = true;
            this.chkSearchUnitDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUnitDesc.Location = new System.Drawing.Point(310, 60);
            this.chkSearchUnitDesc.Name = "chkSearchUnitDesc";
            this.chkSearchUnitDesc.Size = new System.Drawing.Size(53, 17);
            this.chkSearchUnitDesc.TabIndex = 11;
            this.chkSearchUnitDesc.Text = "Mô tả";
            this.chkSearchUnitDesc.UseVisualStyleBackColor = true;
            // 
            // chkSearchUnitName
            // 
            this.chkSearchUnitName.AutoSize = true;
            this.chkSearchUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUnitName.Location = new System.Drawing.Point(228, 60);
            this.chkSearchUnitName.Name = "chkSearchUnitName";
            this.chkSearchUnitName.Size = new System.Drawing.Size(57, 17);
            this.chkSearchUnitName.TabIndex = 10;
            this.chkSearchUnitName.Text = "Đơn vị";
            this.chkSearchUnitName.UseVisualStyleBackColor = true;
            // 
            // chkSearchUnitID
            // 
            this.chkSearchUnitID.AutoSize = true;
            this.chkSearchUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUnitID.Location = new System.Drawing.Point(139, 60);
            this.chkSearchUnitID.Name = "chkSearchUnitID";
            this.chkSearchUnitID.Size = new System.Drawing.Size(74, 17);
            this.chkSearchUnitID.TabIndex = 9;
            this.chkSearchUnitID.Text = "Mã đơn vị";
            this.chkSearchUnitID.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Image = global::SSMP.Properties.Resources.page_find;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(337, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm &kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(79, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // lblTimKiemQuanLy
            // 
            this.lblTimKiemQuanLy.AutoSize = true;
            this.lblTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimKiemQuanLy.Location = new System.Drawing.Point(21, 29);
            this.lblTimKiemQuanLy.Name = "lblTimKiemQuanLy";
            this.lblTimKiemQuanLy.Size = new System.Drawing.Size(52, 13);
            this.lblTimKiemQuanLy.TabIndex = 0;
            this.lblTimKiemQuanLy.Text = "Tìm kiếm:";
            // 
            // btnInAnQuanLy
            // 
            this.btnInAnQuanLy.Image = global::SSMP.Properties.Resources.printer;
            this.btnInAnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInAnQuanLy.Location = new System.Drawing.Point(674, 224);
            this.btnInAnQuanLy.Name = "btnInAnQuanLy";
            this.btnInAnQuanLy.Size = new System.Drawing.Size(61, 23);
            this.btnInAnQuanLy.TabIndex = 16;
            this.btnInAnQuanLy.Text = "&In ấn";
            this.btnInAnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInAnQuanLy.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::SSMP.Properties.Resources.application_side_expand;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(741, 224);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Đ&óng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkDispAll
            // 
            this.chkDispAll.AutoSize = true;
            this.chkDispAll.Checked = true;
            this.chkDispAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispAll.Location = new System.Drawing.Point(64, 228);
            this.chkDispAll.Name = "chkDispAll";
            this.chkDispAll.Size = new System.Drawing.Size(57, 17);
            this.chkDispAll.TabIndex = 12;
            this.chkDispAll.Text = "Tất cả";
            this.chkDispAll.UseVisualStyleBackColor = true;
            this.chkDispAll.CheckedChanged += new System.EventHandler(this.chkDispAll_CheckedChanged);
            // 
            // chkDispUnitDesc
            // 
            this.chkDispUnitDesc.AutoSize = true;
            this.chkDispUnitDesc.Location = new System.Drawing.Point(288, 228);
            this.chkDispUnitDesc.Name = "chkDispUnitDesc";
            this.chkDispUnitDesc.Size = new System.Drawing.Size(53, 17);
            this.chkDispUnitDesc.TabIndex = 15;
            this.chkDispUnitDesc.Text = "Mô tả";
            this.chkDispUnitDesc.UseVisualStyleBackColor = true;
            this.chkDispUnitDesc.CheckedChanged += new System.EventHandler(this.chkDispUnitDesc_CheckedChanged);
            // 
            // chkDispUnitName
            // 
            this.chkDispUnitName.AutoSize = true;
            this.chkDispUnitName.Location = new System.Drawing.Point(216, 228);
            this.chkDispUnitName.Name = "chkDispUnitName";
            this.chkDispUnitName.Size = new System.Drawing.Size(57, 17);
            this.chkDispUnitName.TabIndex = 14;
            this.chkDispUnitName.Text = "Đơn vị";
            this.chkDispUnitName.UseVisualStyleBackColor = true;
            this.chkDispUnitName.CheckedChanged += new System.EventHandler(this.chkDispUnitName_CheckedChanged);
            // 
            // chkDispUnitID
            // 
            this.chkDispUnitID.AutoSize = true;
            this.chkDispUnitID.Checked = true;
            this.chkDispUnitID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispUnitID.Enabled = false;
            this.chkDispUnitID.Location = new System.Drawing.Point(127, 228);
            this.chkDispUnitID.Name = "chkDispUnitID";
            this.chkDispUnitID.Size = new System.Drawing.Size(74, 17);
            this.chkDispUnitID.TabIndex = 13;
            this.chkDispUnitID.Text = "Mã đơn vị";
            this.chkDispUnitID.UseVisualStyleBackColor = true;
            this.chkDispUnitID.CheckedChanged += new System.EventHandler(this.chkDispUnitID_CheckedChanged);
            // 
            // lblHienThiQuanLy
            // 
            this.lblHienThiQuanLy.AutoSize = true;
            this.lblHienThiQuanLy.Location = new System.Drawing.Point(12, 229);
            this.lblHienThiQuanLy.Name = "lblHienThiQuanLy";
            this.lblHienThiQuanLy.Size = new System.Drawing.Size(46, 13);
            this.lblHienThiQuanLy.TabIndex = 15;
            this.lblHienThiQuanLy.Text = "Hiển thị:";
            // 
            // lblDanhSachChucVuQuanLy
            // 
            this.lblDanhSachChucVuQuanLy.AutoSize = true;
            this.lblDanhSachChucVuQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachChucVuQuanLy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDanhSachChucVuQuanLy.Location = new System.Drawing.Point(12, 205);
            this.lblDanhSachChucVuQuanLy.Name = "lblDanhSachChucVuQuanLy";
            this.lblDanhSachChucVuQuanLy.Size = new System.Drawing.Size(130, 13);
            this.lblDanhSachChucVuQuanLy.TabIndex = 14;
            this.lblDanhSachChucVuQuanLy.Text = "DANH SÁCH ĐƠN VỊ:";
            // 
            // gbThongTinChucVu
            // 
            this.gbThongTinChucVu.Controls.Add(this.label1);
            this.gbThongTinChucVu.Controls.Add(this.btnReset);
            this.gbThongTinChucVu.Controls.Add(this.btnSave);
            this.gbThongTinChucVu.Controls.Add(this.txtUnitDesc);
            this.gbThongTinChucVu.Controls.Add(this.lblMoTa);
            this.gbThongTinChucVu.Controls.Add(this.txtUnitName);
            this.gbThongTinChucVu.Controls.Add(this.lblChucVu);
            this.gbThongTinChucVu.Controls.Add(this.txtUnitID);
            this.gbThongTinChucVu.Controls.Add(this.lblMaChucVu);
            this.gbThongTinChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThongTinChucVu.Location = new System.Drawing.Point(15, 6);
            this.gbThongTinChucVu.Name = "gbThongTinChucVu";
            this.gbThongTinChucVu.Size = new System.Drawing.Size(332, 191);
            this.gbThongTinChucVu.TabIndex = 0;
            this.gbThongTinChucVu.TabStop = false;
            this.gbThongTinChucVu.Text = "THÔNG TIN ĐƠN VỊ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(310, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "*";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Image = global::SSMP.Properties.Resources.cross;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(224, 158);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Xóa &trắng";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Image = global::SSMP.Properties.Resources.disk;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(138, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUnitDesc
            // 
            this.txtUnitDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUnitDesc.Location = new System.Drawing.Point(96, 84);
            this.txtUnitDesc.Multiline = true;
            this.txtUnitDesc.Name = "txtUnitDesc";
            this.txtUnitDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUnitDesc.Size = new System.Drawing.Size(208, 65);
            this.txtUnitDesc.TabIndex = 3;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTa.Location = new System.Drawing.Point(23, 87);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(37, 13);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUnitName.Location = new System.Drawing.Point(96, 55);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(208, 20);
            this.txtUnitName.TabIndex = 2;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChucVu.Location = new System.Drawing.Point(23, 58);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(41, 13);
            this.lblChucVu.TabIndex = 2;
            this.lblChucVu.Text = "Đơn vị:";
            // 
            // txtUnitID
            // 
            this.txtUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUnitID.Location = new System.Drawing.Point(96, 26);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(100, 20);
            this.txtUnitID.TabIndex = 1;
            // 
            // lblMaChucVu
            // 
            this.lblMaChucVu.AutoSize = true;
            this.lblMaChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaChucVu.Location = new System.Drawing.Point(23, 29);
            this.lblMaChucVu.Name = "lblMaChucVu";
            this.lblMaChucVu.Size = new System.Drawing.Size(58, 13);
            this.lblMaChucVu.TabIndex = 0;
            this.lblMaChucVu.Text = "Mã đơn vị:";
            // 
            // btnReloadAll
            // 
            this.btnReloadAll.Image = global::SSMP.Properties.Resources.arrow_refresh;
            this.btnReloadAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReloadAll.Location = new System.Drawing.Point(558, 224);
            this.btnReloadAll.Name = "btnReloadAll";
            this.btnReloadAll.Size = new System.Drawing.Size(100, 23);
            this.btnReloadAll.TabIndex = 40;
            this.btnReloadAll.Text = "Tải lại toàn bộ";
            this.btnReloadAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReloadAll.UseVisualStyleBackColor = true;
            this.btnReloadAll.Click += new System.EventHandler(this.btnReloadAll_Click);
            // 
            // FrmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.tcQuanLyChucVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnit";
            this.Text = "Quản Lý Đơn Vị";
            this.Load += new System.EventHandler(this.FrmUnit_Load);
            this.tcQuanLyChucVu.ResumeLayout(false);
            this.tpQuanLyChucVu.ResumeLayout(false);
            this.tpQuanLyChucVu.PerformLayout();
            this.panelUnit.ResumeLayout(false);
            this.panelUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUnit)).EndInit();
            this.bindingNavigatorUnit.ResumeLayout(false);
            this.bindingNavigatorUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).EndInit();
            this.gbTimKiemQuanLy.ResumeLayout(false);
            this.gbTimKiemQuanLy.PerformLayout();
            this.gbThongTinChucVu.ResumeLayout(false);
            this.gbThongTinChucVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLyChucVu;
        private System.Windows.Forms.TabPage tpQuanLyChucVu;
        private System.Windows.Forms.GroupBox gbThongTinChucVu;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.Label lblMaChucVu;
        private System.Windows.Forms.TextBox txtUnitDesc;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblDanhSachChucVuQuanLy;
        private System.Windows.Forms.Label lblHienThiQuanLy;
        private System.Windows.Forms.CheckBox chkDispUnitID;
        private System.Windows.Forms.CheckBox chkDispUnitName;
        private System.Windows.Forms.CheckBox chkDispAll;
        private System.Windows.Forms.CheckBox chkDispUnitDesc;
        private System.Windows.Forms.Button btnInAnQuanLy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbTimKiemQuanLy;
        private System.Windows.Forms.CheckBox chkSearchAll;
        private System.Windows.Forms.CheckBox chkSearchUnitDesc;
        private System.Windows.Forms.CheckBox chkSearchUnitName;
        private System.Windows.Forms.CheckBox chkSearchUnitID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTimKiemQuanLy;
        private System.Windows.Forms.Panel panelUnit;
        private System.Windows.Forms.DataGridView gvUnit;
        private System.Windows.Forms.BindingNavigator bindingNavigatorUnit;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnEdit;
        private System.Windows.Forms.ToolStripButton toolStripBtnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReloadAll;
    }
}