namespace SSMP
{
    partial class FrmUserStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserStatus));
            this.tcQuanLyUserStatus = new System.Windows.Forms.TabControl();
            this.tpQuanLyUserStatus = new System.Windows.Forms.TabPage();
            this.panelUserStatus = new System.Windows.Forms.Panel();
            this.bindingNavigatorUserStatus = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gvUserStatus = new System.Windows.Forms.DataGridView();
            this.gbTimKiemQuanLy = new System.Windows.Forms.GroupBox();
            this.chkSearchAll = new System.Windows.Forms.CheckBox();
            this.chkSearchUserStatusDesc = new System.Windows.Forms.CheckBox();
            this.chkSearchUserStatusName = new System.Windows.Forms.CheckBox();
            this.chkSearchUserStatusID = new System.Windows.Forms.CheckBox();
            this.lblViDuTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnInAnQuanLy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkDispAll = new System.Windows.Forms.CheckBox();
            this.chkDispUserStatusDesc = new System.Windows.Forms.CheckBox();
            this.chkDispUserStatusName = new System.Windows.Forms.CheckBox();
            this.chkDispUserStatusID = new System.Windows.Forms.CheckBox();
            this.lblHienThiQuanLy = new System.Windows.Forms.Label();
            this.lblDanhSachUserStatusQuanLy = new System.Windows.Forms.Label();
            this.gbThongTinUserStatus = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUserStatusDesc = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtUserStatusName = new System.Windows.Forms.TextBox();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.txtUserStatusID = new System.Windows.Forms.TextBox();
            this.lblMaUserStatus = new System.Windows.Forms.Label();
            this.btnReloadAll = new System.Windows.Forms.Button();
            this.tcQuanLyUserStatus.SuspendLayout();
            this.tpQuanLyUserStatus.SuspendLayout();
            this.panelUserStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUserStatus)).BeginInit();
            this.bindingNavigatorUserStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserStatus)).BeginInit();
            this.gbTimKiemQuanLy.SuspendLayout();
            this.gbThongTinUserStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLyUserStatus
            // 
            this.tcQuanLyUserStatus.Controls.Add(this.tpQuanLyUserStatus);
            this.tcQuanLyUserStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuanLyUserStatus.Location = new System.Drawing.Point(0, 0);
            this.tcQuanLyUserStatus.Name = "tcQuanLyUserStatus";
            this.tcQuanLyUserStatus.SelectedIndex = 0;
            this.tcQuanLyUserStatus.Size = new System.Drawing.Size(826, 560);
            this.tcQuanLyUserStatus.TabIndex = 0;
            // 
            // tpQuanLyUserStatus
            // 
            this.tpQuanLyUserStatus.Controls.Add(this.btnReloadAll);
            this.tpQuanLyUserStatus.Controls.Add(this.panelUserStatus);
            this.tpQuanLyUserStatus.Controls.Add(this.gbTimKiemQuanLy);
            this.tpQuanLyUserStatus.Controls.Add(this.btnInAnQuanLy);
            this.tpQuanLyUserStatus.Controls.Add(this.btnClose);
            this.tpQuanLyUserStatus.Controls.Add(this.chkDispAll);
            this.tpQuanLyUserStatus.Controls.Add(this.chkDispUserStatusDesc);
            this.tpQuanLyUserStatus.Controls.Add(this.chkDispUserStatusName);
            this.tpQuanLyUserStatus.Controls.Add(this.chkDispUserStatusID);
            this.tpQuanLyUserStatus.Controls.Add(this.lblHienThiQuanLy);
            this.tpQuanLyUserStatus.Controls.Add(this.lblDanhSachUserStatusQuanLy);
            this.tpQuanLyUserStatus.Controls.Add(this.gbThongTinUserStatus);
            this.tpQuanLyUserStatus.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLyUserStatus.Name = "tpQuanLyUserStatus";
            this.tpQuanLyUserStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyUserStatus.Size = new System.Drawing.Size(818, 534);
            this.tpQuanLyUserStatus.TabIndex = 0;
            this.tpQuanLyUserStatus.Text = "Quản lý Trạng thái";
            this.tpQuanLyUserStatus.UseVisualStyleBackColor = true;
            // 
            // panelUserStatus
            // 
            this.panelUserStatus.Controls.Add(this.bindingNavigatorUserStatus);
            this.panelUserStatus.Controls.Add(this.gvUserStatus);
            this.panelUserStatus.Location = new System.Drawing.Point(15, 253);
            this.panelUserStatus.Name = "panelUserStatus";
            this.panelUserStatus.Size = new System.Drawing.Size(787, 267);
            this.panelUserStatus.TabIndex = 27;
            // 
            // bindingNavigatorUserStatus
            // 
            this.bindingNavigatorUserStatus.AddNewItem = null;
            this.bindingNavigatorUserStatus.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorUserStatus.DeleteItem = null;
            this.bindingNavigatorUserStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorUserStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorUserStatus.Location = new System.Drawing.Point(0, 242);
            this.bindingNavigatorUserStatus.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorUserStatus.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorUserStatus.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorUserStatus.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorUserStatus.Name = "bindingNavigatorUserStatus";
            this.bindingNavigatorUserStatus.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorUserStatus.Size = new System.Drawing.Size(787, 25);
            this.bindingNavigatorUserStatus.TabIndex = 14;
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
            // gvUserStatus
            // 
            this.gvUserStatus.AllowUserToAddRows = false;
            this.gvUserStatus.AllowUserToDeleteRows = false;
            this.gvUserStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUserStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvUserStatus.Location = new System.Drawing.Point(0, 0);
            this.gvUserStatus.MultiSelect = false;
            this.gvUserStatus.Name = "gvUserStatus";
            this.gvUserStatus.ReadOnly = true;
            this.gvUserStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUserStatus.Size = new System.Drawing.Size(787, 282);
            this.gvUserStatus.TabIndex = 18;
            this.gvUserStatus.SelectionChanged += new System.EventHandler(this.gvUserStatus_SelectionChanged);
            // 
            // gbTimKiemQuanLy
            // 
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchAll);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUserStatusDesc);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUserStatusName);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUserStatusID);
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
            // chkSearchUserStatusDesc
            // 
            this.chkSearchUserStatusDesc.AutoSize = true;
            this.chkSearchUserStatusDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUserStatusDesc.Location = new System.Drawing.Point(310, 80);
            this.chkSearchUserStatusDesc.Name = "chkSearchUserStatusDesc";
            this.chkSearchUserStatusDesc.Size = new System.Drawing.Size(53, 17);
            this.chkSearchUserStatusDesc.TabIndex = 11;
            this.chkSearchUserStatusDesc.Text = "Mô tả";
            this.chkSearchUserStatusDesc.UseVisualStyleBackColor = true;
            // 
            // chkSearchUserStatusName
            // 
            this.chkSearchUserStatusName.AutoSize = true;
            this.chkSearchUserStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUserStatusName.Location = new System.Drawing.Point(228, 80);
            this.chkSearchUserStatusName.Name = "chkSearchUserStatusName";
            this.chkSearchUserStatusName.Size = new System.Drawing.Size(74, 17);
            this.chkSearchUserStatusName.TabIndex = 10;
            this.chkSearchUserStatusName.Text = "Trạng thái";
            this.chkSearchUserStatusName.UseVisualStyleBackColor = true;
            // 
            // chkSearchUserStatusID
            // 
            this.chkSearchUserStatusID.AutoSize = true;
            this.chkSearchUserStatusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUserStatusID.Location = new System.Drawing.Point(139, 80);
            this.chkSearchUserStatusID.Name = "chkSearchUserStatusID";
            this.chkSearchUserStatusID.Size = new System.Drawing.Size(88, 17);
            this.chkSearchUserStatusID.TabIndex = 9;
            this.chkSearchUserStatusID.Text = "Mã trạng thái";
            this.chkSearchUserStatusID.UseVisualStyleBackColor = true;
            // 
            // lblViDuTimKiemQuanLy
            // 
            this.lblViDuTimKiemQuanLy.AutoSize = true;
            this.lblViDuTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblViDuTimKiemQuanLy.Location = new System.Drawing.Point(76, 55);
            this.lblViDuTimKiemQuanLy.Name = "lblViDuTimKiemQuanLy";
            this.lblViDuTimKiemQuanLy.Size = new System.Drawing.Size(158, 13);
            this.lblViDuTimKiemQuanLy.TabIndex = 3;
            this.lblViDuTimKiemQuanLy.Text = "(ví dụ: Hoạt động, Tạm khóa...)";
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
            // chkDispUserStatusDesc
            // 
            this.chkDispUserStatusDesc.AutoSize = true;
            this.chkDispUserStatusDesc.Location = new System.Drawing.Point(288, 228);
            this.chkDispUserStatusDesc.Name = "chkDispUserStatusDesc";
            this.chkDispUserStatusDesc.Size = new System.Drawing.Size(53, 17);
            this.chkDispUserStatusDesc.TabIndex = 15;
            this.chkDispUserStatusDesc.Text = "Mô tả";
            this.chkDispUserStatusDesc.UseVisualStyleBackColor = true;
            this.chkDispUserStatusDesc.CheckedChanged += new System.EventHandler(this.chkDispUserStatusDesc_CheckedChanged);
            // 
            // chkDispUserStatusName
            // 
            this.chkDispUserStatusName.AutoSize = true;
            this.chkDispUserStatusName.Location = new System.Drawing.Point(216, 228);
            this.chkDispUserStatusName.Name = "chkDispUserStatusName";
            this.chkDispUserStatusName.Size = new System.Drawing.Size(74, 17);
            this.chkDispUserStatusName.TabIndex = 14;
            this.chkDispUserStatusName.Text = "Trạng thái";
            this.chkDispUserStatusName.UseVisualStyleBackColor = true;
            this.chkDispUserStatusName.CheckedChanged += new System.EventHandler(this.chkDispUserStatusName_CheckedChanged);
            // 
            // chkDispUserStatusID
            // 
            this.chkDispUserStatusID.AutoSize = true;
            this.chkDispUserStatusID.Checked = true;
            this.chkDispUserStatusID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispUserStatusID.Enabled = false;
            this.chkDispUserStatusID.Location = new System.Drawing.Point(127, 228);
            this.chkDispUserStatusID.Name = "chkDispUserStatusID";
            this.chkDispUserStatusID.Size = new System.Drawing.Size(88, 17);
            this.chkDispUserStatusID.TabIndex = 13;
            this.chkDispUserStatusID.Text = "Mã trạng thái";
            this.chkDispUserStatusID.UseVisualStyleBackColor = true;
            this.chkDispUserStatusID.CheckedChanged += new System.EventHandler(this.chkDispUserStatusID_CheckedChanged);
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
            // lblDanhSachUserStatusQuanLy
            // 
            this.lblDanhSachUserStatusQuanLy.AutoSize = true;
            this.lblDanhSachUserStatusQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachUserStatusQuanLy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDanhSachUserStatusQuanLy.Location = new System.Drawing.Point(12, 205);
            this.lblDanhSachUserStatusQuanLy.Name = "lblDanhSachUserStatusQuanLy";
            this.lblDanhSachUserStatusQuanLy.Size = new System.Drawing.Size(163, 13);
            this.lblDanhSachUserStatusQuanLy.TabIndex = 14;
            this.lblDanhSachUserStatusQuanLy.Text = "DANH SÁCH TRẠNG THÁI:";
            // 
            // gbThongTinUserStatus
            // 
            this.gbThongTinUserStatus.Controls.Add(this.label1);
            this.gbThongTinUserStatus.Controls.Add(this.btnReset);
            this.gbThongTinUserStatus.Controls.Add(this.btnSave);
            this.gbThongTinUserStatus.Controls.Add(this.txtUserStatusDesc);
            this.gbThongTinUserStatus.Controls.Add(this.lblMoTa);
            this.gbThongTinUserStatus.Controls.Add(this.txtUserStatusName);
            this.gbThongTinUserStatus.Controls.Add(this.lblUserStatus);
            this.gbThongTinUserStatus.Controls.Add(this.txtUserStatusID);
            this.gbThongTinUserStatus.Controls.Add(this.lblMaUserStatus);
            this.gbThongTinUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThongTinUserStatus.Location = new System.Drawing.Point(15, 6);
            this.gbThongTinUserStatus.Name = "gbThongTinUserStatus";
            this.gbThongTinUserStatus.Size = new System.Drawing.Size(332, 191);
            this.gbThongTinUserStatus.TabIndex = 0;
            this.gbThongTinUserStatus.TabStop = false;
            this.gbThongTinUserStatus.Text = "THÔNG TIN TRẠNG THÁI:";
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
            // txtUserStatusDesc
            // 
            this.txtUserStatusDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserStatusDesc.Location = new System.Drawing.Point(96, 84);
            this.txtUserStatusDesc.Multiline = true;
            this.txtUserStatusDesc.Name = "txtUserStatusDesc";
            this.txtUserStatusDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserStatusDesc.Size = new System.Drawing.Size(208, 65);
            this.txtUserStatusDesc.TabIndex = 3;
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
            // txtUserStatusName
            // 
            this.txtUserStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserStatusName.Location = new System.Drawing.Point(96, 55);
            this.txtUserStatusName.Name = "txtUserStatusName";
            this.txtUserStatusName.Size = new System.Drawing.Size(208, 20);
            this.txtUserStatusName.TabIndex = 2;
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserStatus.Location = new System.Drawing.Point(23, 58);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(58, 13);
            this.lblUserStatus.TabIndex = 2;
            this.lblUserStatus.Text = "Trạng thái:";
            // 
            // txtUserStatusID
            // 
            this.txtUserStatusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserStatusID.Location = new System.Drawing.Point(96, 26);
            this.txtUserStatusID.Name = "txtUserStatusID";
            this.txtUserStatusID.ReadOnly = true;
            this.txtUserStatusID.Size = new System.Drawing.Size(100, 20);
            this.txtUserStatusID.TabIndex = 1;
            // 
            // lblMaUserStatus
            // 
            this.lblMaUserStatus.AutoSize = true;
            this.lblMaUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaUserStatus.Location = new System.Drawing.Point(23, 29);
            this.lblMaUserStatus.Name = "lblMaUserStatus";
            this.lblMaUserStatus.Size = new System.Drawing.Size(72, 13);
            this.lblMaUserStatus.TabIndex = 0;
            this.lblMaUserStatus.Text = "Mã trạng thái:";
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
            // FrmUserStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.tcQuanLyUserStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserStatus";
            this.Text = "Quản Lý Trạng Thái";
            this.Load += new System.EventHandler(this.FrmUserStatus_Load);
            this.tcQuanLyUserStatus.ResumeLayout(false);
            this.tpQuanLyUserStatus.ResumeLayout(false);
            this.tpQuanLyUserStatus.PerformLayout();
            this.panelUserStatus.ResumeLayout(false);
            this.panelUserStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUserStatus)).EndInit();
            this.bindingNavigatorUserStatus.ResumeLayout(false);
            this.bindingNavigatorUserStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserStatus)).EndInit();
            this.gbTimKiemQuanLy.ResumeLayout(false);
            this.gbTimKiemQuanLy.PerformLayout();
            this.gbThongTinUserStatus.ResumeLayout(false);
            this.gbThongTinUserStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLyUserStatus;
        private System.Windows.Forms.TabPage tpQuanLyUserStatus;
        private System.Windows.Forms.GroupBox gbThongTinUserStatus;
        private System.Windows.Forms.TextBox txtUserStatusName;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.TextBox txtUserStatusID;
        private System.Windows.Forms.Label lblMaUserStatus;
        private System.Windows.Forms.TextBox txtUserStatusDesc;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblDanhSachUserStatusQuanLy;
        private System.Windows.Forms.Label lblHienThiQuanLy;
        private System.Windows.Forms.CheckBox chkDispUserStatusID;
        private System.Windows.Forms.CheckBox chkDispUserStatusName;
        private System.Windows.Forms.CheckBox chkDispAll;
        private System.Windows.Forms.CheckBox chkDispUserStatusDesc;
        private System.Windows.Forms.Button btnInAnQuanLy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbTimKiemQuanLy;
        private System.Windows.Forms.CheckBox chkSearchAll;
        private System.Windows.Forms.CheckBox chkSearchUserStatusDesc;
        private System.Windows.Forms.CheckBox chkSearchUserStatusName;
        private System.Windows.Forms.CheckBox chkSearchUserStatusID;
        private System.Windows.Forms.Label lblViDuTimKiemQuanLy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTimKiemQuanLy;
        private System.Windows.Forms.Panel panelUserStatus;
        private System.Windows.Forms.BindingNavigator bindingNavigatorUserStatus;
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
        private System.Windows.Forms.DataGridView gvUserStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReloadAll;
    }
}