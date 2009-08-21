namespace SSMP
{
    partial class FrmUserRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserRole));
            this.tabControlUserRole = new System.Windows.Forms.TabControl();
            this.tabPageUserRole = new System.Windows.Forms.TabPage();
            this.panelUserRole = new System.Windows.Forms.Panel();
            this.bindingNavigatorUserRole = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLblTotal = new System.Windows.Forms.ToolStripLabel();
            this.gvUserRole = new System.Windows.Forms.DataGridView();
            this.chkDispUserRoleDesc = new System.Windows.Forms.CheckBox();
            this.chkDispUserRoleName = new System.Windows.Forms.CheckBox();
            this.chkDispUserRoleID = new System.Windows.Forms.CheckBox();
            this.chkDispAll = new System.Windows.Forms.CheckBox();
            this.lblHienThiQuanLy = new System.Windows.Forms.Label();
            this.lblDanhSachNhomNguoiDungQuanLy = new System.Windows.Forms.Label();
            this.gbTimKiemQuanLy = new System.Windows.Forms.GroupBox();
            this.chkSearchAll = new System.Windows.Forms.CheckBox();
            this.chkSearchUserRoleDesc = new System.Windows.Forms.CheckBox();
            this.chkSearchUserRoleName = new System.Windows.Forms.CheckBox();
            this.chkSearchUserRoleID = new System.Windows.Forms.CheckBox();
            this.lblViDuTimKiemQuanLy = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimKiemQuanLy = new System.Windows.Forms.Label();
            this.gbThongTinNhomNguoiDung = new System.Windows.Forms.GroupBox();
            this.txtUserRoleDesc = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtUserRoleName = new System.Windows.Forms.TextBox();
            this.lblTenNhomNguoiDung = new System.Windows.Forms.Label();
            this.txtUserRoleID = new System.Windows.Forms.TextBox();
            this.lblMaNhomNguoiDung = new System.Windows.Forms.Label();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnInAnQuanLy = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.imglQuanLyNhomNguoiDung = new System.Windows.Forms.ImageList(this.components);
            this.tabControlUserRole.SuspendLayout();
            this.tabPageUserRole.SuspendLayout();
            this.panelUserRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUserRole)).BeginInit();
            this.bindingNavigatorUserRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserRole)).BeginInit();
            this.gbTimKiemQuanLy.SuspendLayout();
            this.gbThongTinNhomNguoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUserRole
            // 
            this.tabControlUserRole.Controls.Add(this.tabPageUserRole);
            this.tabControlUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUserRole.Location = new System.Drawing.Point(0, 0);
            this.tabControlUserRole.Name = "tabControlUserRole";
            this.tabControlUserRole.SelectedIndex = 0;
            this.tabControlUserRole.Size = new System.Drawing.Size(894, 598);
            this.tabControlUserRole.TabIndex = 0;
            // 
            // tabPageUserRole
            // 
            this.tabPageUserRole.Controls.Add(this.panelUserRole);
            this.tabPageUserRole.Controls.Add(this.btnInAnQuanLy);
            this.tabPageUserRole.Controls.Add(this.chkDispUserRoleDesc);
            this.tabPageUserRole.Controls.Add(this.chkDispUserRoleName);
            this.tabPageUserRole.Controls.Add(this.chkDispUserRoleID);
            this.tabPageUserRole.Controls.Add(this.chkDispAll);
            this.tabPageUserRole.Controls.Add(this.lblHienThiQuanLy);
            this.tabPageUserRole.Controls.Add(this.lblDanhSachNhomNguoiDungQuanLy);
            this.tabPageUserRole.Controls.Add(this.gbTimKiemQuanLy);
            this.tabPageUserRole.Controls.Add(this.btnClose);
            this.tabPageUserRole.Controls.Add(this.gbThongTinNhomNguoiDung);
            this.tabPageUserRole.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserRole.Name = "tabPageUserRole";
            this.tabPageUserRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserRole.Size = new System.Drawing.Size(886, 572);
            this.tabPageUserRole.TabIndex = 0;
            this.tabPageUserRole.Text = "Quản lý";
            this.tabPageUserRole.UseVisualStyleBackColor = true;
            // 
            // panelUserRole
            // 
            this.panelUserRole.Controls.Add(this.bindingNavigatorUserRole);
            this.panelUserRole.Controls.Add(this.gvUserRole);
            this.panelUserRole.Location = new System.Drawing.Point(15, 293);
            this.panelUserRole.Name = "panelUserRole";
            this.panelUserRole.Size = new System.Drawing.Size(858, 267);
            this.panelUserRole.TabIndex = 26;
            // 
            // bindingNavigatorUserRole
            // 
            this.bindingNavigatorUserRole.AddNewItem = null;
            this.bindingNavigatorUserRole.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorUserRole.DeleteItem = null;
            this.bindingNavigatorUserRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorUserRole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorUserRole.Location = new System.Drawing.Point(0, 242);
            this.bindingNavigatorUserRole.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorUserRole.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorUserRole.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorUserRole.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorUserRole.Name = "bindingNavigatorUserRole";
            this.bindingNavigatorUserRole.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorUserRole.Size = new System.Drawing.Size(858, 25);
            this.bindingNavigatorUserRole.TabIndex = 14;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLblTotal
            // 
            this.toolStripLblTotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLblTotal.Name = "toolStripLblTotal";
            this.toolStripLblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripLblTotal.Size = new System.Drawing.Size(79, 22);
            this.toolStripLblTotal.Text = "Tổng số dòng: ";
            // 
            // gvUserRole
            // 
            this.gvUserRole.AllowUserToAddRows = false;
            this.gvUserRole.AllowUserToDeleteRows = false;
            this.gvUserRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUserRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvUserRole.Location = new System.Drawing.Point(0, 0);
            this.gvUserRole.MultiSelect = false;
            this.gvUserRole.Name = "gvUserRole";
            this.gvUserRole.ReadOnly = true;
            this.gvUserRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUserRole.Size = new System.Drawing.Size(858, 282);
            this.gvUserRole.TabIndex = 13;
            this.gvUserRole.SelectionChanged += new System.EventHandler(this.gvUserRole_SelectionChanged);
            // 
            // chkDispUserRoleDesc
            // 
            this.chkDispUserRoleDesc.AutoSize = true;
            this.chkDispUserRoleDesc.Location = new System.Drawing.Point(390, 259);
            this.chkDispUserRoleDesc.Name = "chkDispUserRoleDesc";
            this.chkDispUserRoleDesc.Size = new System.Drawing.Size(53, 17);
            this.chkDispUserRoleDesc.TabIndex = 20;
            this.chkDispUserRoleDesc.Text = "Mô tả";
            this.chkDispUserRoleDesc.UseVisualStyleBackColor = true;
            this.chkDispUserRoleDesc.CheckedChanged += new System.EventHandler(this.chkDispUserDesc_CheckedChanged);
            // 
            // chkDispUserRoleName
            // 
            this.chkDispUserRoleName.AutoSize = true;
            this.chkDispUserRoleName.Location = new System.Drawing.Point(274, 259);
            this.chkDispUserRoleName.Name = "chkDispUserRoleName";
            this.chkDispUserRoleName.Size = new System.Drawing.Size(110, 17);
            this.chkDispUserRoleName.TabIndex = 19;
            this.chkDispUserRoleName.Text = "Nhóm người dùng";
            this.chkDispUserRoleName.UseVisualStyleBackColor = true;
            this.chkDispUserRoleName.CheckedChanged += new System.EventHandler(this.chkDispUserRoleName_CheckedChanged);
            // 
            // chkDispUserRoleID
            // 
            this.chkDispUserRoleID.AutoSize = true;
            this.chkDispUserRoleID.Checked = true;
            this.chkDispUserRoleID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispUserRoleID.Enabled = false;
            this.chkDispUserRoleID.Location = new System.Drawing.Point(142, 259);
            this.chkDispUserRoleID.Name = "chkDispUserRoleID";
            this.chkDispUserRoleID.Size = new System.Drawing.Size(126, 17);
            this.chkDispUserRoleID.TabIndex = 18;
            this.chkDispUserRoleID.Text = "Mã nhóm người dùng";
            this.chkDispUserRoleID.UseVisualStyleBackColor = true;
            this.chkDispUserRoleID.CheckedChanged += new System.EventHandler(this.chkDispUserRoleID_CheckedChanged);
            // 
            // chkDispAll
            // 
            this.chkDispAll.AutoSize = true;
            this.chkDispAll.Checked = true;
            this.chkDispAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispAll.Location = new System.Drawing.Point(79, 259);
            this.chkDispAll.Name = "chkDispAll";
            this.chkDispAll.Size = new System.Drawing.Size(57, 17);
            this.chkDispAll.TabIndex = 17;
            this.chkDispAll.Text = "Tất cả";
            this.chkDispAll.UseVisualStyleBackColor = true;
            this.chkDispAll.CheckedChanged += new System.EventHandler(this.chkDispAll_CheckedChanged);
            // 
            // lblHienThiQuanLy
            // 
            this.lblHienThiQuanLy.AutoSize = true;
            this.lblHienThiQuanLy.Location = new System.Drawing.Point(12, 260);
            this.lblHienThiQuanLy.Name = "lblHienThiQuanLy";
            this.lblHienThiQuanLy.Size = new System.Drawing.Size(46, 13);
            this.lblHienThiQuanLy.TabIndex = 16;
            this.lblHienThiQuanLy.Text = "Hiển thị:";
            // 
            // lblDanhSachNhomNguoiDungQuanLy
            // 
            this.lblDanhSachNhomNguoiDungQuanLy.AutoSize = true;
            this.lblDanhSachNhomNguoiDungQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachNhomNguoiDungQuanLy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDanhSachNhomNguoiDungQuanLy.Location = new System.Drawing.Point(12, 229);
            this.lblDanhSachNhomNguoiDungQuanLy.Name = "lblDanhSachNhomNguoiDungQuanLy";
            this.lblDanhSachNhomNguoiDungQuanLy.Size = new System.Drawing.Size(212, 13);
            this.lblDanhSachNhomNguoiDungQuanLy.TabIndex = 15;
            this.lblDanhSachNhomNguoiDungQuanLy.Text = "DANH SÁCH NHÓM NGƯỜI DÙNG :";
            // 
            // gbTimKiemQuanLy
            // 
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchAll);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUserRoleDesc);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUserRoleName);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchUserRoleID);
            this.gbTimKiemQuanLy.Controls.Add(this.lblViDuTimKiemQuanLy);
            this.gbTimKiemQuanLy.Controls.Add(this.btnSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.txtSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.lblTimKiemQuanLy);
            this.gbTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbTimKiemQuanLy.Location = new System.Drawing.Point(418, 6);
            this.gbTimKiemQuanLy.Name = "gbTimKiemQuanLy";
            this.gbTimKiemQuanLy.Size = new System.Drawing.Size(457, 203);
            this.gbTimKiemQuanLy.TabIndex = 14;
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
            this.chkSearchAll.TabIndex = 7;
            this.chkSearchAll.Text = "Tất cả";
            this.chkSearchAll.UseVisualStyleBackColor = true;
            this.chkSearchAll.CheckedChanged += new System.EventHandler(this.chkSearchAll_CheckedChanged);
            // 
            // chkSearchUserRoleDesc
            // 
            this.chkSearchUserRoleDesc.AutoSize = true;
            this.chkSearchUserRoleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUserRoleDesc.Location = new System.Drawing.Point(388, 80);
            this.chkSearchUserRoleDesc.Name = "chkSearchUserRoleDesc";
            this.chkSearchUserRoleDesc.Size = new System.Drawing.Size(53, 17);
            this.chkSearchUserRoleDesc.TabIndex = 6;
            this.chkSearchUserRoleDesc.Text = "Mô tả";
            this.chkSearchUserRoleDesc.UseVisualStyleBackColor = true;
            // 
            // chkSearchUserRoleName
            // 
            this.chkSearchUserRoleName.AutoSize = true;
            this.chkSearchUserRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUserRoleName.Location = new System.Drawing.Point(272, 80);
            this.chkSearchUserRoleName.Name = "chkSearchUserRoleName";
            this.chkSearchUserRoleName.Size = new System.Drawing.Size(110, 17);
            this.chkSearchUserRoleName.TabIndex = 5;
            this.chkSearchUserRoleName.Text = "Nhóm người dùng";
            this.chkSearchUserRoleName.UseVisualStyleBackColor = true;
            // 
            // chkSearchUserRoleID
            // 
            this.chkSearchUserRoleID.AutoSize = true;
            this.chkSearchUserRoleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchUserRoleID.Location = new System.Drawing.Point(139, 80);
            this.chkSearchUserRoleID.Name = "chkSearchUserRoleID";
            this.chkSearchUserRoleID.Size = new System.Drawing.Size(126, 17);
            this.chkSearchUserRoleID.TabIndex = 4;
            this.chkSearchUserRoleID.Text = "Mã nhóm người dùng";
            this.chkSearchUserRoleID.UseVisualStyleBackColor = true;
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
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(79, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 20);
            this.txtSearch.TabIndex = 1;
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
            // gbThongTinNhomNguoiDung
            // 
            this.gbThongTinNhomNguoiDung.Controls.Add(this.txtUserRoleDesc);
            this.gbThongTinNhomNguoiDung.Controls.Add(this.lblMoTa);
            this.gbThongTinNhomNguoiDung.Controls.Add(this.txtUserRoleName);
            this.gbThongTinNhomNguoiDung.Controls.Add(this.btnReset);
            this.gbThongTinNhomNguoiDung.Controls.Add(this.lblTenNhomNguoiDung);
            this.gbThongTinNhomNguoiDung.Controls.Add(this.btnSave);
            this.gbThongTinNhomNguoiDung.Controls.Add(this.txtUserRoleID);
            this.gbThongTinNhomNguoiDung.Controls.Add(this.lblMaNhomNguoiDung);
            this.gbThongTinNhomNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThongTinNhomNguoiDung.Location = new System.Drawing.Point(15, 6);
            this.gbThongTinNhomNguoiDung.Name = "gbThongTinNhomNguoiDung";
            this.gbThongTinNhomNguoiDung.Size = new System.Drawing.Size(397, 203);
            this.gbThongTinNhomNguoiDung.TabIndex = 7;
            this.gbThongTinNhomNguoiDung.TabStop = false;
            this.gbThongTinNhomNguoiDung.Text = "THÔNG TIN NHÓM NGƯỜI DÙNG:";
            // 
            // txtUserRoleDesc
            // 
            this.txtUserRoleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserRoleDesc.Location = new System.Drawing.Point(131, 78);
            this.txtUserRoleDesc.Multiline = true;
            this.txtUserRoleDesc.Name = "txtUserRoleDesc";
            this.txtUserRoleDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserRoleDesc.Size = new System.Drawing.Size(220, 75);
            this.txtUserRoleDesc.TabIndex = 5;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTa.Location = new System.Drawing.Point(15, 81);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(37, 13);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtUserRoleName
            // 
            this.txtUserRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserRoleName.Location = new System.Drawing.Point(131, 52);
            this.txtUserRoleName.Name = "txtUserRoleName";
            this.txtUserRoleName.Size = new System.Drawing.Size(220, 20);
            this.txtUserRoleName.TabIndex = 3;
            // 
            // lblTenNhomNguoiDung
            // 
            this.lblTenNhomNguoiDung.AutoSize = true;
            this.lblTenNhomNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNhomNguoiDung.Location = new System.Drawing.Point(15, 55);
            this.lblTenNhomNguoiDung.Name = "lblTenNhomNguoiDung";
            this.lblTenNhomNguoiDung.Size = new System.Drawing.Size(114, 13);
            this.lblTenNhomNguoiDung.TabIndex = 2;
            this.lblTenNhomNguoiDung.Text = "Tên nhóm người dùng:";
            // 
            // txtUserRoleID
            // 
            this.txtUserRoleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserRoleID.Location = new System.Drawing.Point(131, 26);
            this.txtUserRoleID.Name = "txtUserRoleID";
            this.txtUserRoleID.ReadOnly = true;
            this.txtUserRoleID.Size = new System.Drawing.Size(116, 20);
            this.txtUserRoleID.TabIndex = 1;
            // 
            // lblMaNhomNguoiDung
            // 
            this.lblMaNhomNguoiDung.AutoSize = true;
            this.lblMaNhomNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNhomNguoiDung.Location = new System.Drawing.Point(15, 29);
            this.lblMaNhomNguoiDung.Name = "lblMaNhomNguoiDung";
            this.lblMaNhomNguoiDung.Size = new System.Drawing.Size(110, 13);
            this.lblMaNhomNguoiDung.TabIndex = 0;
            this.lblMaNhomNguoiDung.Text = "Mã nhóm người dùng:";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "of {0}";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "of {0}";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
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
            // btnInAnQuanLy
            // 
            this.btnInAnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInAnQuanLy.ImageIndex = 6;
            this.btnInAnQuanLy.ImageList = this.imglQuanLyNhomNguoiDung;
            this.btnInAnQuanLy.Location = new System.Drawing.Point(737, 249);
            this.btnInAnQuanLy.Name = "btnInAnQuanLy";
            this.btnInAnQuanLy.Size = new System.Drawing.Size(64, 23);
            this.btnInAnQuanLy.TabIndex = 21;
            this.btnInAnQuanLy.Text = "&In ấn";
            this.btnInAnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInAnQuanLy.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageIndex = 5;
            this.btnSearch.ImageList = this.imglQuanLyNhomNguoiDung;
            this.btnSearch.Location = new System.Drawing.Point(337, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm &kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 4;
            this.btnClose.ImageList = this.imglQuanLyNhomNguoiDung;
            this.btnClose.Location = new System.Drawing.Point(808, 249);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Đ&óng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(271, 168);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 23);
            this.btnReset.TabIndex = 11;
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
            this.btnSave.Location = new System.Drawing.Point(185, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imglQuanLyNhomNguoiDung
            // 
            this.imglQuanLyNhomNguoiDung.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglQuanLyNhomNguoiDung.ImageStream")));
            this.imglQuanLyNhomNguoiDung.TransparentColor = System.Drawing.Color.Transparent;
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(0, "");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(1, "");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(2, "");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(3, "");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(4, "");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(5, "");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(6, "");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(7, "");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(8, "");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(9, "world_edit.png");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(10, "add.png");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(11, "arrow_refresh.png");
            this.imglQuanLyNhomNguoiDung.Images.SetKeyName(12, "delete.png");
            // 
            // FrmUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 598);
            this.Controls.Add(this.tabControlUserRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserRole";
            this.Text = "Quản Lý Nhóm Người Dùng";
            this.Load += new System.EventHandler(this.FrmUserRole_Load);
            this.tabControlUserRole.ResumeLayout(false);
            this.tabPageUserRole.ResumeLayout(false);
            this.tabPageUserRole.PerformLayout();
            this.panelUserRole.ResumeLayout(false);
            this.panelUserRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUserRole)).EndInit();
            this.bindingNavigatorUserRole.ResumeLayout(false);
            this.bindingNavigatorUserRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserRole)).EndInit();
            this.gbTimKiemQuanLy.ResumeLayout(false);
            this.gbTimKiemQuanLy.PerformLayout();
            this.gbThongTinNhomNguoiDung.ResumeLayout(false);
            this.gbThongTinNhomNguoiDung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUserRole;
        private System.Windows.Forms.TabPage tabPageUserRole;
        private System.Windows.Forms.DataGridView gvUserRole;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbThongTinNhomNguoiDung;
        private System.Windows.Forms.TextBox txtUserRoleDesc;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtUserRoleName;
        private System.Windows.Forms.Label lblTenNhomNguoiDung;
        private System.Windows.Forms.TextBox txtUserRoleID;
        private System.Windows.Forms.Label lblMaNhomNguoiDung;
        private System.Windows.Forms.GroupBox gbTimKiemQuanLy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTimKiemQuanLy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkSearchUserRoleID;
        private System.Windows.Forms.Label lblViDuTimKiemQuanLy;
        private System.Windows.Forms.CheckBox chkSearchUserRoleDesc;
        private System.Windows.Forms.CheckBox chkSearchUserRoleName;
        private System.Windows.Forms.Label lblDanhSachNhomNguoiDungQuanLy;
        private System.Windows.Forms.Label lblHienThiQuanLy;
        private System.Windows.Forms.CheckBox chkDispUserRoleDesc;
        private System.Windows.Forms.CheckBox chkDispUserRoleName;
        private System.Windows.Forms.CheckBox chkDispUserRoleID;
        private System.Windows.Forms.CheckBox chkDispAll;
        private System.Windows.Forms.CheckBox chkSearchAll;
        private System.Windows.Forms.Button btnInAnQuanLy;
        private System.Windows.Forms.Panel panelUserRole;
        private System.Windows.Forms.BindingNavigator bindingNavigatorUserRole;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnEdit;
        private System.Windows.Forms.ToolStripButton toolStripBtnDelete;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotal;
        private System.Windows.Forms.ToolStripButton toolStripBtnReload;
        private System.Windows.Forms.ImageList imglQuanLyNhomNguoiDung;
    }
}