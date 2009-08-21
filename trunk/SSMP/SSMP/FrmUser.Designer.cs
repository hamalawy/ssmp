namespace SSMP
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.tcUserManagement = new System.Windows.Forms.TabControl();
            this.tpUserManagement = new System.Windows.Forms.TabPage();
            this.chkDispAddress = new System.Windows.Forms.CheckBox();
            this.chkDispSex = new System.Windows.Forms.CheckBox();
            this.chkDispEmail = new System.Windows.Forms.CheckBox();
            this.chkSearchEmail = new System.Windows.Forms.CheckBox();
            this.chkDispIdCardNo = new System.Windows.Forms.CheckBox();
            this.chkDispTelNo = new System.Windows.Forms.CheckBox();
            this.chkDispDOB = new System.Windows.Forms.CheckBox();
            this.panelGridUser = new System.Windows.Forms.Panel();
            this.bindingNavigatorUser = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLblPage = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLblTotal = new System.Windows.Forms.ToolStripLabel();
            this.gvUser = new System.Windows.Forms.DataGridView();
            this.chkSearchFullname = new System.Windows.Forms.CheckBox();
            this.chkDispFullname = new System.Windows.Forms.CheckBox();
            this.lblSearchEx = new System.Windows.Forms.Label();
            this.imglQuanLyNguoiDung = new System.Windows.Forms.ImageList(this.components);
            this.chkDispUserTitle = new System.Windows.Forms.CheckBox();
            this.chkDispUserRole = new System.Windows.Forms.CheckBox();
            this.chkDispUserStatus = new System.Windows.Forms.CheckBox();
            this.chkDispUsername = new System.Windows.Forms.CheckBox();
            this.chkDispUserId = new System.Windows.Forms.CheckBox();
            this.chkDispAll = new System.Windows.Forms.CheckBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblUserList = new System.Windows.Forms.Label();
            this.chkSearchAll = new System.Windows.Forms.CheckBox();
            this.chkSearchUsername = new System.Windows.Forms.CheckBox();
            this.chkSearchUserId = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.cbbUserRole = new System.Windows.Forms.ComboBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtIdCardNo = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIdCardNo = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbbUserTitle = new System.Windows.Forms.ComboBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.cbbUserStatus = new System.Windows.Forms.ComboBox();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnReloadAll = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.tcUserManagement.SuspendLayout();
            this.tpUserManagement.SuspendLayout();
            this.panelGridUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUser)).BeginInit();
            this.bindingNavigatorUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUserManagement
            // 
            this.tcUserManagement.Controls.Add(this.tpUserManagement);
            this.tcUserManagement.Location = new System.Drawing.Point(7, 7);
            this.tcUserManagement.Name = "tcUserManagement";
            this.tcUserManagement.SelectedIndex = 0;
            this.tcUserManagement.Size = new System.Drawing.Size(1041, 546);
            this.tcUserManagement.TabIndex = 0;
            // 
            // tpUserManagement
            // 
            this.tpUserManagement.Controls.Add(this.chkDispAddress);
            this.tpUserManagement.Controls.Add(this.chkDispSex);
            this.tpUserManagement.Controls.Add(this.chkDispEmail);
            this.tpUserManagement.Controls.Add(this.chkSearchEmail);
            this.tpUserManagement.Controls.Add(this.chkDispIdCardNo);
            this.tpUserManagement.Controls.Add(this.chkDispTelNo);
            this.tpUserManagement.Controls.Add(this.chkDispDOB);
            this.tpUserManagement.Controls.Add(this.panelGridUser);
            this.tpUserManagement.Controls.Add(this.chkSearchFullname);
            this.tpUserManagement.Controls.Add(this.chkDispFullname);
            this.tpUserManagement.Controls.Add(this.lblSearchEx);
            this.tpUserManagement.Controls.Add(this.btnReloadAll);
            this.tpUserManagement.Controls.Add(this.btnPrint);
            this.tpUserManagement.Controls.Add(this.chkDispUserTitle);
            this.tpUserManagement.Controls.Add(this.chkDispUserRole);
            this.tpUserManagement.Controls.Add(this.chkDispUserStatus);
            this.tpUserManagement.Controls.Add(this.chkDispUsername);
            this.tpUserManagement.Controls.Add(this.chkDispUserId);
            this.tpUserManagement.Controls.Add(this.chkDispAll);
            this.tpUserManagement.Controls.Add(this.lblDisplay);
            this.tpUserManagement.Controls.Add(this.lblUserList);
            this.tpUserManagement.Controls.Add(this.chkSearchAll);
            this.tpUserManagement.Controls.Add(this.chkSearchUsername);
            this.tpUserManagement.Controls.Add(this.chkSearchUserId);
            this.tpUserManagement.Controls.Add(this.btnSearch);
            this.tpUserManagement.Controls.Add(this.txtSearch);
            this.tpUserManagement.Controls.Add(this.btnClose);
            this.tpUserManagement.Controls.Add(this.lblSearch);
            this.tpUserManagement.Controls.Add(this.gbUserInfo);
            this.tpUserManagement.Location = new System.Drawing.Point(4, 22);
            this.tpUserManagement.Name = "tpUserManagement";
            this.tpUserManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserManagement.Size = new System.Drawing.Size(1033, 520);
            this.tpUserManagement.TabIndex = 0;
            this.tpUserManagement.Text = "Quản lý Người dùng";
            this.tpUserManagement.UseVisualStyleBackColor = true;
            // 
            // chkDispAddress
            // 
            this.chkDispAddress.AutoSize = true;
            this.chkDispAddress.Location = new System.Drawing.Point(584, 172);
            this.chkDispAddress.Name = "chkDispAddress";
            this.chkDispAddress.Size = new System.Drawing.Size(59, 17);
            this.chkDispAddress.TabIndex = 54;
            this.chkDispAddress.Text = "Địa chỉ";
            this.chkDispAddress.UseVisualStyleBackColor = true;
            this.chkDispAddress.CheckedChanged += new System.EventHandler(this.chkDispAddress_CheckedChanged);
            // 
            // chkDispSex
            // 
            this.chkDispSex.AutoSize = true;
            this.chkDispSex.Location = new System.Drawing.Point(584, 148);
            this.chkDispSex.Name = "chkDispSex";
            this.chkDispSex.Size = new System.Drawing.Size(66, 17);
            this.chkDispSex.TabIndex = 53;
            this.chkDispSex.Text = "Giới tính";
            this.chkDispSex.UseVisualStyleBackColor = true;
            this.chkDispSex.CheckedChanged += new System.EventHandler(this.chkDispSex_CheckedChanged);
            // 
            // chkDispEmail
            // 
            this.chkDispEmail.AutoSize = true;
            this.chkDispEmail.Location = new System.Drawing.Point(474, 172);
            this.chkDispEmail.Name = "chkDispEmail";
            this.chkDispEmail.Size = new System.Drawing.Size(51, 17);
            this.chkDispEmail.TabIndex = 1;
            this.chkDispEmail.Text = "Email";
            this.chkDispEmail.UseVisualStyleBackColor = true;
            this.chkDispEmail.CheckedChanged += new System.EventHandler(this.chkDispEmail_CheckedChanged);
            // 
            // chkSearchEmail
            // 
            this.chkSearchEmail.AutoSize = true;
            this.chkSearchEmail.Location = new System.Drawing.Point(777, 59);
            this.chkSearchEmail.Name = "chkSearchEmail";
            this.chkSearchEmail.Size = new System.Drawing.Size(51, 17);
            this.chkSearchEmail.TabIndex = 1;
            this.chkSearchEmail.Text = "Email";
            this.chkSearchEmail.UseVisualStyleBackColor = true;
            // 
            // chkDispIdCardNo
            // 
            this.chkDispIdCardNo.AutoSize = true;
            this.chkDispIdCardNo.Location = new System.Drawing.Point(777, 148);
            this.chkDispIdCardNo.Name = "chkDispIdCardNo";
            this.chkDispIdCardNo.Size = new System.Drawing.Size(111, 17);
            this.chkDispIdCardNo.TabIndex = 1;
            this.chkDispIdCardNo.Text = "Số CMT/Passport";
            this.chkDispIdCardNo.UseVisualStyleBackColor = true;
            this.chkDispIdCardNo.CheckedChanged += new System.EventHandler(this.chkDispIdCardNo_CheckedChanged);
            // 
            // chkDispTelNo
            // 
            this.chkDispTelNo.AutoSize = true;
            this.chkDispTelNo.Location = new System.Drawing.Point(397, 172);
            this.chkDispTelNo.Name = "chkDispTelNo";
            this.chkDispTelNo.Size = new System.Drawing.Size(74, 17);
            this.chkDispTelNo.TabIndex = 1;
            this.chkDispTelNo.Text = "Điện thoại";
            this.chkDispTelNo.UseVisualStyleBackColor = true;
            this.chkDispTelNo.CheckedChanged += new System.EventHandler(this.chkDispTelNo_CheckedChanged);
            // 
            // chkDispDOB
            // 
            this.chkDispDOB.AutoSize = true;
            this.chkDispDOB.Location = new System.Drawing.Point(663, 148);
            this.chkDispDOB.Name = "chkDispDOB";
            this.chkDispDOB.Size = new System.Drawing.Size(73, 17);
            this.chkDispDOB.TabIndex = 1;
            this.chkDispDOB.Text = "Ngày sinh";
            this.chkDispDOB.UseVisualStyleBackColor = true;
            this.chkDispDOB.CheckedChanged += new System.EventHandler(this.chkDispDOB_CheckedChanged);
            // 
            // panelGridUser
            // 
            this.panelGridUser.Controls.Add(this.bindingNavigatorUser);
            this.panelGridUser.Controls.Add(this.gvUser);
            this.panelGridUser.Location = new System.Drawing.Point(332, 216);
            this.panelGridUser.Name = "panelGridUser";
            this.panelGridUser.Size = new System.Drawing.Size(691, 284);
            this.panelGridUser.TabIndex = 52;
            // 
            // bindingNavigatorUser
            // 
            this.bindingNavigatorUser.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorUser.CanOverflow = false;
            this.bindingNavigatorUser.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorUser.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigatorUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.toolStripLblPage,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripBtnReload,
            this.toolStripSeparator1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripBtnUpdate,
            this.toolStripBtnDelete,
            this.toolStripLblTotal});
            this.bindingNavigatorUser.Location = new System.Drawing.Point(0, 259);
            this.bindingNavigatorUser.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorUser.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorUser.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorUser.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorUser.Name = "bindingNavigatorUser";
            this.bindingNavigatorUser.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigatorUser.Size = new System.Drawing.Size(691, 25);
            this.bindingNavigatorUser.TabIndex = 51;
            this.bindingNavigatorUser.Text = "bindingNavigatorUser";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLblPage
            // 
            this.toolStripLblPage.Name = "toolStripLblPage";
            this.toolStripLblPage.Size = new System.Drawing.Size(33, 22);
            this.toolStripLblPage.Text = "Page";
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
            this.toolStripLblTotal.Size = new System.Drawing.Size(118, 22);
            this.toolStripLblTotal.Text = "Tổng sồ người dùng:";
            // 
            // gvUser
            // 
            this.gvUser.AllowUserToAddRows = false;
            this.gvUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvUser.Location = new System.Drawing.Point(0, 0);
            this.gvUser.MultiSelect = false;
            this.gvUser.Name = "gvUser";
            this.gvUser.ReadOnly = true;
            this.gvUser.Size = new System.Drawing.Size(691, 256);
            this.gvUser.TabIndex = 23;
            // 
            // chkSearchFullname
            // 
            this.chkSearchFullname.AutoSize = true;
            this.chkSearchFullname.Location = new System.Drawing.Point(584, 59);
            this.chkSearchFullname.Name = "chkSearchFullname";
            this.chkSearchFullname.Size = new System.Drawing.Size(73, 17);
            this.chkSearchFullname.TabIndex = 50;
            this.chkSearchFullname.Text = "Họ và tên";
            this.chkSearchFullname.UseVisualStyleBackColor = true;
            // 
            // chkDispFullname
            // 
            this.chkDispFullname.AutoSize = true;
            this.chkDispFullname.Location = new System.Drawing.Point(584, 124);
            this.chkDispFullname.Name = "chkDispFullname";
            this.chkDispFullname.Size = new System.Drawing.Size(73, 17);
            this.chkDispFullname.TabIndex = 49;
            this.chkDispFullname.Text = "Họ và tên";
            this.chkDispFullname.UseVisualStyleBackColor = true;
            this.chkDispFullname.CheckedChanged += new System.EventHandler(this.chkDispFullname_CheckedChanged);
            // 
            // lblSearchEx
            // 
            this.lblSearchEx.AutoSize = true;
            this.lblSearchEx.Location = new System.Drawing.Point(728, 32);
            this.lblSearchEx.Name = "lblSearchEx";
            this.lblSearchEx.Size = new System.Drawing.Size(100, 13);
            this.lblSearchEx.TabIndex = 48;
            this.lblSearchEx.Text = "(ví dụ: levantuan...)";
            // 
            // imglQuanLyNguoiDung
            // 
            this.imglQuanLyNguoiDung.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglQuanLyNguoiDung.ImageStream")));
            this.imglQuanLyNguoiDung.TransparentColor = System.Drawing.Color.Transparent;
            this.imglQuanLyNguoiDung.Images.SetKeyName(0, "undo.png");
            this.imglQuanLyNguoiDung.Images.SetKeyName(1, "add.png");
            this.imglQuanLyNguoiDung.Images.SetKeyName(2, "check.png");
            this.imglQuanLyNguoiDung.Images.SetKeyName(3, "delete.png");
            this.imglQuanLyNguoiDung.Images.SetKeyName(4, "exit.png");
            this.imglQuanLyNguoiDung.Images.SetKeyName(5, "printer3.png");
            this.imglQuanLyNguoiDung.Images.SetKeyName(6, "recycle_preferences.png");
            this.imglQuanLyNguoiDung.Images.SetKeyName(7, "refresh.png");
            this.imglQuanLyNguoiDung.Images.SetKeyName(8, "undo.png");
            this.imglQuanLyNguoiDung.Images.SetKeyName(9, "find.png");
            // 
            // chkDispUserTitle
            // 
            this.chkDispUserTitle.AutoSize = true;
            this.chkDispUserTitle.Location = new System.Drawing.Point(777, 124);
            this.chkDispUserTitle.Name = "chkDispUserTitle";
            this.chkDispUserTitle.Size = new System.Drawing.Size(66, 17);
            this.chkDispUserTitle.TabIndex = 43;
            this.chkDispUserTitle.Text = "Chức vụ";
            this.chkDispUserTitle.UseVisualStyleBackColor = true;
            this.chkDispUserTitle.CheckedChanged += new System.EventHandler(this.chkDispUserTitle_CheckedChanged);
            // 
            // chkDispUserRole
            // 
            this.chkDispUserRole.AutoSize = true;
            this.chkDispUserRole.Location = new System.Drawing.Point(474, 147);
            this.chkDispUserRole.Name = "chkDispUserRole";
            this.chkDispUserRole.Size = new System.Drawing.Size(110, 17);
            this.chkDispUserRole.TabIndex = 41;
            this.chkDispUserRole.Text = "Nhóm người dùng";
            this.chkDispUserRole.UseVisualStyleBackColor = true;
            this.chkDispUserRole.CheckedChanged += new System.EventHandler(this.chkDispUserRole_CheckedChanged);
            // 
            // chkDispUserStatus
            // 
            this.chkDispUserStatus.AutoSize = true;
            this.chkDispUserStatus.Location = new System.Drawing.Point(397, 147);
            this.chkDispUserStatus.Name = "chkDispUserStatus";
            this.chkDispUserStatus.Size = new System.Drawing.Size(74, 17);
            this.chkDispUserStatus.TabIndex = 40;
            this.chkDispUserStatus.Text = "Trạng thái";
            this.chkDispUserStatus.UseVisualStyleBackColor = true;
            this.chkDispUserStatus.CheckedChanged += new System.EventHandler(this.chkDispUserStatus_CheckedChanged);
            // 
            // chkDispUsername
            // 
            this.chkDispUsername.AutoSize = true;
            this.chkDispUsername.Location = new System.Drawing.Point(663, 124);
            this.chkDispUsername.Name = "chkDispUsername";
            this.chkDispUsername.Size = new System.Drawing.Size(100, 17);
            this.chkDispUsername.TabIndex = 39;
            this.chkDispUsername.Text = "Tên đăng nhập";
            this.chkDispUsername.UseVisualStyleBackColor = true;
            this.chkDispUsername.CheckedChanged += new System.EventHandler(this.chkDispUsername_CheckedChanged);
            // 
            // chkDispUserId
            // 
            this.chkDispUserId.AutoSize = true;
            this.chkDispUserId.Checked = true;
            this.chkDispUserId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispUserId.Enabled = false;
            this.chkDispUserId.Location = new System.Drawing.Point(474, 124);
            this.chkDispUserId.Name = "chkDispUserId";
            this.chkDispUserId.Size = new System.Drawing.Size(97, 17);
            this.chkDispUserId.TabIndex = 38;
            this.chkDispUserId.Text = "Mã người dùng";
            this.chkDispUserId.UseVisualStyleBackColor = true;
            // 
            // chkDispAll
            // 
            this.chkDispAll.AutoSize = true;
            this.chkDispAll.Checked = true;
            this.chkDispAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispAll.Location = new System.Drawing.Point(397, 124);
            this.chkDispAll.Name = "chkDispAll";
            this.chkDispAll.Size = new System.Drawing.Size(57, 17);
            this.chkDispAll.TabIndex = 37;
            this.chkDispAll.Text = "Tất cả";
            this.chkDispAll.UseVisualStyleBackColor = true;
            this.chkDispAll.CheckedChanged += new System.EventHandler(this.chkDispAll_CheckedChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(339, 125);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(46, 13);
            this.lblDisplay.TabIndex = 36;
            this.lblDisplay.Text = "Hiển thị:";
            // 
            // lblUserList
            // 
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserList.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUserList.Location = new System.Drawing.Point(338, 99);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(167, 13);
            this.lblUserList.TabIndex = 33;
            this.lblUserList.Text = "DANH SÁCH NGƯỜI DÙNG:";
            // 
            // chkSearchAll
            // 
            this.chkSearchAll.AutoSize = true;
            this.chkSearchAll.Location = new System.Drawing.Point(397, 60);
            this.chkSearchAll.Name = "chkSearchAll";
            this.chkSearchAll.Size = new System.Drawing.Size(57, 17);
            this.chkSearchAll.TabIndex = 32;
            this.chkSearchAll.Text = "Tất cả";
            this.chkSearchAll.UseVisualStyleBackColor = true;
            this.chkSearchAll.CheckedChanged += new System.EventHandler(this.chkSearchAll_CheckedChanged);
            // 
            // chkSearchUsername
            // 
            this.chkSearchUsername.AutoSize = true;
            this.chkSearchUsername.Location = new System.Drawing.Point(663, 59);
            this.chkSearchUsername.Name = "chkSearchUsername";
            this.chkSearchUsername.Size = new System.Drawing.Size(100, 17);
            this.chkSearchUsername.TabIndex = 28;
            this.chkSearchUsername.Text = "Tên đăng nhập";
            this.chkSearchUsername.UseVisualStyleBackColor = true;
            // 
            // chkSearchUserId
            // 
            this.chkSearchUserId.AutoSize = true;
            this.chkSearchUserId.Location = new System.Drawing.Point(474, 59);
            this.chkSearchUserId.Name = "chkSearchUserId";
            this.chkSearchUserId.Size = new System.Drawing.Size(97, 17);
            this.chkSearchUserId.TabIndex = 27;
            this.chkSearchUserId.Text = "Mã người dùng";
            this.chkSearchUserId.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(638, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Tìm &kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(397, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 20);
            this.txtSearch.TabIndex = 25;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(339, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 13);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.dateTimeDOB);
            this.gbUserInfo.Controls.Add(this.cbbUserRole);
            this.gbUserInfo.Controls.Add(this.rdFemale);
            this.gbUserInfo.Controls.Add(this.rdMale);
            this.gbUserInfo.Controls.Add(this.txtAddress);
            this.gbUserInfo.Controls.Add(this.txtEmail);
            this.gbUserInfo.Controls.Add(this.txtTelNo);
            this.gbUserInfo.Controls.Add(this.txtIdCardNo);
            this.gbUserInfo.Controls.Add(this.lblTelNo);
            this.gbUserInfo.Controls.Add(this.lblAddress);
            this.gbUserInfo.Controls.Add(this.lblEmail);
            this.gbUserInfo.Controls.Add(this.lblIdCardNo);
            this.gbUserInfo.Controls.Add(this.lblDOB);
            this.gbUserInfo.Controls.Add(this.lblSex);
            this.gbUserInfo.Controls.Add(this.btnClear);
            this.gbUserInfo.Controls.Add(this.cbbUserTitle);
            this.gbUserInfo.Controls.Add(this.txtFullname);
            this.gbUserInfo.Controls.Add(this.lblUserTitle);
            this.gbUserInfo.Controls.Add(this.lblFullname);
            this.gbUserInfo.Controls.Add(this.lblUserRole);
            this.gbUserInfo.Controls.Add(this.cbbUserStatus);
            this.gbUserInfo.Controls.Add(this.lblUserStatus);
            this.gbUserInfo.Controls.Add(this.txtPasswordConfirm);
            this.gbUserInfo.Controls.Add(this.lblPasswordConfirm);
            this.gbUserInfo.Controls.Add(this.txtPassword);
            this.gbUserInfo.Controls.Add(this.lblPassword);
            this.gbUserInfo.Controls.Add(this.txtUsername);
            this.gbUserInfo.Controls.Add(this.lblUsername);
            this.gbUserInfo.Controls.Add(this.txtUserId);
            this.gbUserInfo.Controls.Add(this.lblUserId);
            this.gbUserInfo.Controls.Add(this.btnAddUpdate);
            this.gbUserInfo.Location = new System.Drawing.Point(15, 6);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(306, 494);
            this.gbUserInfo.TabIndex = 17;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "THÔNG TIN NGƯỜI DÙNG:";
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.CustomFormat = "dd/MM/yyyy";
            this.dateTimeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDOB.Location = new System.Drawing.Point(119, 260);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(172, 20);
            this.dateTimeDOB.TabIndex = 1;
            // 
            // cbbUserRole
            // 
            this.cbbUserRole.FormattingEnabled = true;
            this.cbbUserRole.Location = new System.Drawing.Point(118, 210);
            this.cbbUserRole.Name = "cbbUserRole";
            this.cbbUserRole.Size = new System.Drawing.Size(172, 21);
            this.cbbUserRole.TabIndex = 24;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(197, 237);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(39, 17);
            this.rdFemale.TabIndex = 22;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(119, 237);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(47, 17);
            this.rdMale.TabIndex = 22;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(119, 373);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 54);
            this.txtAddress.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 345);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(118, 317);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(172, 20);
            this.txtTelNo.TabIndex = 21;
            // 
            // txtIdCardNo
            // 
            this.txtIdCardNo.Location = new System.Drawing.Point(119, 289);
            this.txtIdCardNo.Name = "txtIdCardNo";
            this.txtIdCardNo.Size = new System.Drawing.Size(171, 20);
            this.txtIdCardNo.TabIndex = 21;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(16, 319);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(55, 13);
            this.lblTelNo.TabIndex = 20;
            this.lblTelNo.Text = "Điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 376);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(43, 13);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 347);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // lblIdCardNo
            // 
            this.lblIdCardNo.AutoSize = true;
            this.lblIdCardNo.Location = new System.Drawing.Point(16, 290);
            this.lblIdCardNo.Name = "lblIdCardNo";
            this.lblIdCardNo.Size = new System.Drawing.Size(92, 13);
            this.lblIdCardNo.TabIndex = 20;
            this.lblIdCardNo.Text = "Số CMT/Passport";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(16, 264);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(54, 13);
            this.lblDOB.TabIndex = 20;
            this.lblDOB.Text = "Ngày sinh";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(16, 239);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(47, 13);
            this.lblSex.TabIndex = 19;
            this.lblSex.Text = "Giới tính";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::SSMP.Properties.Resources.cross;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(210, 433);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Xóa trắng";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbbUserTitle
            // 
            this.cbbUserTitle.FormattingEnabled = true;
            this.cbbUserTitle.Location = new System.Drawing.Point(119, 156);
            this.cbbUserTitle.Name = "cbbUserTitle";
            this.cbbUserTitle.Size = new System.Drawing.Size(171, 21);
            this.cbbUserTitle.TabIndex = 17;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(118, 51);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(172, 20);
            this.txtFullname.TabIndex = 15;
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Location = new System.Drawing.Point(16, 159);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(50, 13);
            this.lblUserTitle.TabIndex = 16;
            this.lblUserTitle.Text = "Chức vụ:";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(16, 54);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(57, 13);
            this.lblFullname.TabIndex = 14;
            this.lblFullname.Text = "Họ và tên:";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(16, 213);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(94, 13);
            this.lblUserRole.TabIndex = 12;
            this.lblUserRole.Text = "Nhóm người dùng:";
            // 
            // cbbUserStatus
            // 
            this.cbbUserStatus.FormattingEnabled = true;
            this.cbbUserStatus.Items.AddRange(new object[] {
            "Khóa",
            "Không Khóa"});
            this.cbbUserStatus.Location = new System.Drawing.Point(119, 183);
            this.cbbUserStatus.Name = "cbbUserStatus";
            this.cbbUserStatus.Size = new System.Drawing.Size(81, 21);
            this.cbbUserStatus.TabIndex = 11;
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Location = new System.Drawing.Point(16, 186);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(58, 13);
            this.lblUserStatus.TabIndex = 10;
            this.lblUserStatus.Text = "Trạng thái:";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(119, 130);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(171, 20);
            this.txtPasswordConfirm.TabIndex = 7;
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(16, 133);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(102, 13);
            this.lblPasswordConfirm.TabIndex = 6;
            this.lblPasswordConfirm.Text = "Mật khẩu xác nhận:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(171, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 107);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 78);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(172, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 81);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Tên đăng nhập:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(118, 25);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(81, 20);
            this.txtUserId.TabIndex = 1;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(16, 28);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(81, 13);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "Mã người dùng:";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
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
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // toolStripBtnReload
            // 
            this.toolStripBtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnReload.Image = global::SSMP.Properties.Resources.arrow_refresh;
            this.toolStripBtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnReload.Name = "toolStripBtnReload";
            this.toolStripBtnReload.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnReload.Text = "Tải lại";
            this.toolStripBtnReload.Click += new System.EventHandler(this.toolStripBtnReload_Click);
            // 
            // toolStripBtnUpdate
            // 
            this.toolStripBtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnUpdate.Image = global::SSMP.Properties.Resources.page_edit;
            this.toolStripBtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUpdate.Name = "toolStripBtnUpdate";
            this.toolStripBtnUpdate.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnUpdate.Text = "Cập nhật";
            this.toolStripBtnUpdate.Click += new System.EventHandler(this.toolStripBtnUpdate_Click);
            // 
            // toolStripBtnDelete
            // 
            this.toolStripBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDelete.Image = global::SSMP.Properties.Resources.delete;
            this.toolStripBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDelete.Name = "toolStripBtnDelete";
            this.toolStripBtnDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnDelete.Text = "Xóa";
            this.toolStripBtnDelete.Click += new System.EventHandler(this.toolStripBtnDelete_Click);
            // 
            // btnReloadAll
            // 
            this.btnReloadAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReloadAll.ImageIndex = 6;
            this.btnReloadAll.ImageList = this.imglQuanLyNguoiDung;
            this.btnReloadAll.Location = new System.Drawing.Point(792, 177);
            this.btnReloadAll.Name = "btnReloadAll";
            this.btnReloadAll.Size = new System.Drawing.Size(100, 23);
            this.btnReloadAll.TabIndex = 47;
            this.btnReloadAll.Text = "Tải lại toàn bộ";
            this.btnReloadAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReloadAll.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.ImageIndex = 5;
            this.btnPrint.ImageList = this.imglQuanLyNguoiDung;
            this.btnPrint.Location = new System.Drawing.Point(898, 177);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(58, 23);
            this.btnPrint.TabIndex = 45;
            this.btnPrint.Text = "&In ấn";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 4;
            this.btnClose.ImageList = this.imglQuanLyNguoiDung;
            this.btnClose.Location = new System.Drawing.Point(962, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Đ&óng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Image = global::SSMP.Properties.Resources.add;
            this.btnAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUpdate.Location = new System.Drawing.Point(119, 433);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnAddUpdate.TabIndex = 18;
            this.btnAddUpdate.Text = "T&hêm";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 562);
            this.Controls.Add(this.tcUserManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUser";
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.tcUserManagement.ResumeLayout(false);
            this.tpUserManagement.ResumeLayout(false);
            this.tpUserManagement.PerformLayout();
            this.panelGridUser.ResumeLayout(false);
            this.panelGridUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorUser)).EndInit();
            this.bindingNavigatorUser.ResumeLayout(false);
            this.bindingNavigatorUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUserManagement;
        private System.Windows.Forms.TabPage tpUserManagement;
        private System.Windows.Forms.Label lblUserList;
        private System.Windows.Forms.CheckBox chkSearchAll;
        private System.Windows.Forms.CheckBox chkSearchUsername;
        private System.Windows.Forms.CheckBox chkSearchUserId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ImageList imglQuanLyNguoiDung;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView gvUser;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.ComboBox cbbUserTitle;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.ComboBox cbbUserStatus;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.CheckBox chkDispUserTitle;
        private System.Windows.Forms.CheckBox chkDispUserRole;
        private System.Windows.Forms.CheckBox chkDispUserStatus;
        private System.Windows.Forms.CheckBox chkDispUsername;
        private System.Windows.Forms.CheckBox chkDispUserId;
        private System.Windows.Forms.CheckBox chkDispAll;
        private System.Windows.Forms.Button btnReloadAll;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblSearchEx;
        private System.Windows.Forms.CheckBox chkDispFullname;
        private System.Windows.Forms.CheckBox chkSearchFullname;
        private System.Windows.Forms.BindingNavigator bindingNavigatorUser;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLblPage;
        private System.Windows.Forms.Panel panelGridUser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripButton toolStripBtnUpdate;
        private System.Windows.Forms.ToolStripButton toolStripBtnDelete;
        private System.Windows.Forms.ToolStripButton toolStripBtnReload;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIdCardNo;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotal;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtIdCardNo;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.CheckBox chkSearchEmail;
        private System.Windows.Forms.CheckBox chkDispEmail;
        private System.Windows.Forms.CheckBox chkDispIdCardNo;
        private System.Windows.Forms.CheckBox chkDispDOB;
        private System.Windows.Forms.CheckBox chkDispTelNo;
        private System.Windows.Forms.CheckBox chkDispAddress;
        private System.Windows.Forms.CheckBox chkDispSex;
        private System.Windows.Forms.ComboBox cbbUserRole;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;

    }
}