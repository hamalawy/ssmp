namespace SSMP
{
    partial class FrmUserTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserTitle));
            this.tcQuanLyChucVu = new System.Windows.Forms.TabControl();
            this.tpQuanLyChucVu = new System.Windows.Forms.TabPage();
            this.panelUserTitle = new System.Windows.Forms.Panel();
            this.bindingNavigatorUserTitle = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gvUserTitle = new System.Windows.Forms.DataGridView();
            this.gbTimKiemQuanLy = new System.Windows.Forms.GroupBox();
            this.chkSearchAll = new System.Windows.Forms.CheckBox();
            this.chkSearchUserTitleDesc = new System.Windows.Forms.CheckBox();
            this.chkSearchUserTitleName = new System.Windows.Forms.CheckBox();
            this.chkSearchUserTitleID = new System.Windows.Forms.CheckBox();
            this.lblViDuTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnInAnQuanLy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkDispAll = new System.Windows.Forms.CheckBox();
            this.chkDispUserTitleDesc = new System.Windows.Forms.CheckBox();
            this.chkDispUserTitleName = new System.Windows.Forms.CheckBox();
            this.chkDispUserTitleID = new System.Windows.Forms.CheckBox();
            this.lblHienThiQuanLy = new System.Windows.Forms.Label();
            this.lblDanhSachChucVuQuanLy = new System.Windows.Forms.Label();
            this.gbThongTinChucVu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUserTitleDesc = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtUserTitleName = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtUserTitleID = new System.Windows.Forms.TextBox();
            this.lblMaChucVu = new System.Windows.Forms.Label();
            this.btnReloadAll = new System.Windows.Forms.Button();
            this.tcQuanLyChucVu.SuspendLayout();
            this.tpQuanLyChucVu.SuspendLayout();
            this.panelUserTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUserTitle)).BeginInit();
            this.bindingNavigatorUserTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserTitle)).BeginInit();
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
            this.tpQuanLyChucVu.Controls.Add(this.panelUserTitle);
            this.tpQuanLyChucVu.Controls.Add(this.gbTimKiemQuanLy);
            this.tpQuanLyChucVu.Controls.Add(this.btnInAnQuanLy);
            this.tpQuanLyChucVu.Controls.Add(this.btnClose);
            this.tpQuanLyChucVu.Controls.Add(this.chkDispAll);
            this.tpQuanLyChucVu.Controls.Add(this.chkDispUserTitleDesc);
            this.tpQuanLyChucVu.Controls.Add(this.chkDispUserTitleName);
            this.tpQuanLyChucVu.Controls.Add(this.chkDispUserTitleID);
            this.tpQuanLyChucVu.Controls.Add(this.lblHienThiQuanLy);
            this.tpQuanLyChucVu.Controls.Add(this.lblDanhSachChucVuQuanLy);
            this.tpQuanLyChucVu.Controls.Add(this.gbThongTinChucVu);
            this.tpQuanLyChucVu.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLyChucVu.Name = "tpQuanLyChucVu";
            this.tpQuanLyChucVu.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyChucVu.Size = new System.Drawing.Size(818, 534);
            this.tpQuanLyChucVu.TabIndex = 0;
            this.tpQuanLyChucVu.Text = "Quản lý Chức vụ";
            this.tpQuanLyChucVu.UseVisualStyleBackColor = true;
            // 
            // panelUserTitle
            // 
            this.panelUserTitle.Controls.Add(this.bindingNavigatorUserTitle);
            this.panelUserTitle.Controls.Add(this.gvUserTitle);
            this.panelUserTitle.Location = new System.Drawing.Point(15, 253);
            this.panelUserTitle.Name = "panelUserTitle";
            this.panelUserTitle.Size = new System.Drawing.Size(787, 267);
            this.panelUserTitle.TabIndex = 27;
            // 
            // bindingNavigatorUserTitle
            // 
            this.bindingNavigatorUserTitle.AddNewItem = null;
            this.bindingNavigatorUserTitle.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorUserTitle.DeleteItem = null;
            this.bindingNavigatorUserTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorUserTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorUserTitle.Location = new System.Drawing.Point(0, 242);
            this.bindingNavigatorUserTitle.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorUserTitle.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorUserTitle.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorUserTitle.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorUserTitle.Name = "bindingNavigatorUserTitle";
            this.bindingNavigatorUserTitle.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorUserTitle.Size = new System.Drawing.Size(787, 25);
            this.bindingNavigatorUserTitle.TabIndex = 14;
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
            // gvUserTitle
            // 
            this.gvUserTitle.AllowUserToAddRows = false;
            this.gvUserTitle.AllowUserToDeleteRows = false;
            this.gvUserTitle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUserTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvUserTitle.Location = new System.Drawing.Point(0, 0);
            this.gvUserTitle.MultiSelect = false;
            this.gvUserTitle.Name = "gvUserTitle";
            this.gvUserTitle.ReadOnly = true;
            this.gvUserTitle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUserTitle.Size = new System.Drawing.Size(787, 282);
            this.gvUserTitle.TabIndex = 13;
            this.gvUserTitle.SelectionChanged += new System.EventHandler(this.gvUserTitle_SelectionChanged);
            // 
            // gbTimKiemQuanLy
            // 
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchAll);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUserTitleDesc);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUserTitleName);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUserTitleID);
            this.gbTimKiemQuanLy.Controls.Add(this.lblViDuTimKiemQuanLy);
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
            this.chkSearchAll.Location = new System.Drawing.Point(79, 80);
            this.chkSearchAll.Name = "chkSearchAll";
            this.chkSearchAll.Size = new System.Drawing.Size(57, 17);
            this.chkSearchAll.TabIndex = 8;
            this.chkSearchAll.Text = "Tất cả";
            this.chkSearchAll.UseVisualStyleBackColor = true;
            this.chkSearchAll.CheckedChanged += new System.EventHandler(this.chkSearchAll_CheckedChanged);
            // 
            // chkSearchUserTitleDesc
            // 
            this.chkSearchUserTitleDesc.AutoSize = true;
            this.chkSearchUserTitleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUserTitleDesc.Location = new System.Drawing.Point(310, 80);
            this.chkSearchUserTitleDesc.Name = "chkSearchUserTitleDesc";
            this.chkSearchUserTitleDesc.Size = new System.Drawing.Size(53, 17);
            this.chkSearchUserTitleDesc.TabIndex = 11;
            this.chkSearchUserTitleDesc.Text = "Mô tả";
            this.chkSearchUserTitleDesc.UseVisualStyleBackColor = true;
            // 
            // chkSearchUserTitleName
            // 
            this.chkSearchUserTitleName.AutoSize = true;
            this.chkSearchUserTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUserTitleName.Location = new System.Drawing.Point(228, 80);
            this.chkSearchUserTitleName.Name = "chkSearchUserTitleName";
            this.chkSearchUserTitleName.Size = new System.Drawing.Size(66, 17);
            this.chkSearchUserTitleName.TabIndex = 10;
            this.chkSearchUserTitleName.Text = "Chức vụ";
            this.chkSearchUserTitleName.UseVisualStyleBackColor = true;
            // 
            // chkSearchUserTitleID
            // 
            this.chkSearchUserTitleID.AutoSize = true;
            this.chkSearchUserTitleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUserTitleID.Location = new System.Drawing.Point(139, 80);
            this.chkSearchUserTitleID.Name = "chkSearchUserTitleID";
            this.chkSearchUserTitleID.Size = new System.Drawing.Size(83, 17);
            this.chkSearchUserTitleID.TabIndex = 9;
            this.chkSearchUserTitleID.Text = "Mã chức vụ";
            this.chkSearchUserTitleID.UseVisualStyleBackColor = true;
            // 
            // lblViDuTimKiemQuanLy
            // 
            this.lblViDuTimKiemQuanLy.AutoSize = true;
            this.lblViDuTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblViDuTimKiemQuanLy.Location = new System.Drawing.Point(76, 55);
            this.lblViDuTimKiemQuanLy.Name = "lblViDuTimKiemQuanLy";
            this.lblViDuTimKiemQuanLy.Size = new System.Drawing.Size(140, 13);
            this.lblViDuTimKiemQuanLy.TabIndex = 3;
            this.lblViDuTimKiemQuanLy.Text = "(ví dụ: kế toán, bán hàng...)";
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
            // chkDispUserTitleDesc
            // 
            this.chkDispUserTitleDesc.AutoSize = true;
            this.chkDispUserTitleDesc.Location = new System.Drawing.Point(288, 228);
            this.chkDispUserTitleDesc.Name = "chkDispUserTitleDesc";
            this.chkDispUserTitleDesc.Size = new System.Drawing.Size(53, 17);
            this.chkDispUserTitleDesc.TabIndex = 15;
            this.chkDispUserTitleDesc.Text = "Mô tả";
            this.chkDispUserTitleDesc.UseVisualStyleBackColor = true;
            this.chkDispUserTitleDesc.CheckedChanged += new System.EventHandler(this.chkDispUserTitleDesc_CheckedChanged);
            // 
            // chkDispUserTitleName
            // 
            this.chkDispUserTitleName.AutoSize = true;
            this.chkDispUserTitleName.Location = new System.Drawing.Point(216, 228);
            this.chkDispUserTitleName.Name = "chkDispUserTitleName";
            this.chkDispUserTitleName.Size = new System.Drawing.Size(66, 17);
            this.chkDispUserTitleName.TabIndex = 14;
            this.chkDispUserTitleName.Text = "Chức vụ";
            this.chkDispUserTitleName.UseVisualStyleBackColor = true;
            this.chkDispUserTitleName.CheckedChanged += new System.EventHandler(this.chkDispUserTitleName_CheckedChanged);
            // 
            // chkDispUserTitleID
            // 
            this.chkDispUserTitleID.AutoSize = true;
            this.chkDispUserTitleID.Checked = true;
            this.chkDispUserTitleID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispUserTitleID.Enabled = false;
            this.chkDispUserTitleID.Location = new System.Drawing.Point(127, 228);
            this.chkDispUserTitleID.Name = "chkDispUserTitleID";
            this.chkDispUserTitleID.Size = new System.Drawing.Size(83, 17);
            this.chkDispUserTitleID.TabIndex = 13;
            this.chkDispUserTitleID.Text = "Mã chức vụ";
            this.chkDispUserTitleID.UseVisualStyleBackColor = true;
            this.chkDispUserTitleID.CheckedChanged += new System.EventHandler(this.chkDispUserTitleID_CheckedChanged);
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
            this.lblDanhSachChucVuQuanLy.Size = new System.Drawing.Size(142, 13);
            this.lblDanhSachChucVuQuanLy.TabIndex = 14;
            this.lblDanhSachChucVuQuanLy.Text = "DANH SÁCH CHỨC VỤ:";
            // 
            // gbThongTinChucVu
            // 
            this.gbThongTinChucVu.Controls.Add(this.label1);
            this.gbThongTinChucVu.Controls.Add(this.btnReset);
            this.gbThongTinChucVu.Controls.Add(this.btnSave);
            this.gbThongTinChucVu.Controls.Add(this.txtUserTitleDesc);
            this.gbThongTinChucVu.Controls.Add(this.lblMoTa);
            this.gbThongTinChucVu.Controls.Add(this.txtUserTitleName);
            this.gbThongTinChucVu.Controls.Add(this.lblChucVu);
            this.gbThongTinChucVu.Controls.Add(this.txtUserTitleID);
            this.gbThongTinChucVu.Controls.Add(this.lblMaChucVu);
            this.gbThongTinChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThongTinChucVu.Location = new System.Drawing.Point(15, 6);
            this.gbThongTinChucVu.Name = "gbThongTinChucVu";
            this.gbThongTinChucVu.Size = new System.Drawing.Size(332, 191);
            this.gbThongTinChucVu.TabIndex = 0;
            this.gbThongTinChucVu.TabStop = false;
            this.gbThongTinChucVu.Text = "THÔNG TIN CHỨC VỤ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(310, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "*";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
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
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(138, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUserTitleDesc
            // 
            this.txtUserTitleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserTitleDesc.Location = new System.Drawing.Point(96, 84);
            this.txtUserTitleDesc.Multiline = true;
            this.txtUserTitleDesc.Name = "txtUserTitleDesc";
            this.txtUserTitleDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserTitleDesc.Size = new System.Drawing.Size(208, 65);
            this.txtUserTitleDesc.TabIndex = 3;
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
            // txtUserTitleName
            // 
            this.txtUserTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserTitleName.Location = new System.Drawing.Point(96, 55);
            this.txtUserTitleName.Name = "txtUserTitleName";
            this.txtUserTitleName.Size = new System.Drawing.Size(208, 20);
            this.txtUserTitleName.TabIndex = 2;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChucVu.Location = new System.Drawing.Point(23, 58);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(50, 13);
            this.lblChucVu.TabIndex = 2;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // txtUserTitleID
            // 
            this.txtUserTitleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserTitleID.Location = new System.Drawing.Point(96, 26);
            this.txtUserTitleID.Name = "txtUserTitleID";
            this.txtUserTitleID.ReadOnly = true;
            this.txtUserTitleID.Size = new System.Drawing.Size(100, 20);
            this.txtUserTitleID.TabIndex = 1;
            // 
            // lblMaChucVu
            // 
            this.lblMaChucVu.AutoSize = true;
            this.lblMaChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaChucVu.Location = new System.Drawing.Point(23, 29);
            this.lblMaChucVu.Name = "lblMaChucVu";
            this.lblMaChucVu.Size = new System.Drawing.Size(67, 13);
            this.lblMaChucVu.TabIndex = 0;
            this.lblMaChucVu.Text = "Mã chức vụ:";
            // 
            // btnReloadAll
            // 
            this.btnReloadAll.Image = global::SSMP.Properties.Resources.arrow_refresh;
            this.btnReloadAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReloadAll.Location = new System.Drawing.Point(568, 224);
            this.btnReloadAll.Name = "btnReloadAll";
            this.btnReloadAll.Size = new System.Drawing.Size(100, 23);
            this.btnReloadAll.TabIndex = 40;
            this.btnReloadAll.Text = "Tải lại toàn bộ";
            this.btnReloadAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReloadAll.UseVisualStyleBackColor = true;
            this.btnReloadAll.Click += new System.EventHandler(this.btnReloadAll_Click);
            // 
            // FrmUserTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.tcQuanLyChucVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserTitle";
            this.Text = "Quản Lý Chức Vụ";
            this.Load += new System.EventHandler(this.FrmUserTitle_Load);
            this.tcQuanLyChucVu.ResumeLayout(false);
            this.tpQuanLyChucVu.ResumeLayout(false);
            this.tpQuanLyChucVu.PerformLayout();
            this.panelUserTitle.ResumeLayout(false);
            this.panelUserTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUserTitle)).EndInit();
            this.bindingNavigatorUserTitle.ResumeLayout(false);
            this.bindingNavigatorUserTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserTitle)).EndInit();
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
        private System.Windows.Forms.TextBox txtUserTitleName;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtUserTitleID;
        private System.Windows.Forms.Label lblMaChucVu;
        private System.Windows.Forms.TextBox txtUserTitleDesc;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblDanhSachChucVuQuanLy;
        private System.Windows.Forms.Label lblHienThiQuanLy;
        private System.Windows.Forms.CheckBox chkDispUserTitleID;
        private System.Windows.Forms.CheckBox chkDispUserTitleName;
        private System.Windows.Forms.CheckBox chkDispAll;
        private System.Windows.Forms.CheckBox chkDispUserTitleDesc;
        private System.Windows.Forms.Button btnInAnQuanLy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbTimKiemQuanLy;
        private System.Windows.Forms.CheckBox chkSearchAll;
        private System.Windows.Forms.CheckBox chkSearchUserTitleDesc;
        private System.Windows.Forms.CheckBox chkSearchUserTitleName;
        private System.Windows.Forms.CheckBox chkSearchUserTitleID;
        private System.Windows.Forms.Label lblViDuTimKiemQuanLy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTimKiemQuanLy;
        private System.Windows.Forms.Panel panelUserTitle;
        private System.Windows.Forms.BindingNavigator bindingNavigatorUserTitle;
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
        private System.Windows.Forms.DataGridView gvUserTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReloadAll;
    }
}