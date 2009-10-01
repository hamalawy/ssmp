namespace SSMP
{
    partial class FrmProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProvider));
            this.tcQuanLyProvider = new System.Windows.Forms.TabControl();
            this.tpQuanLyProvider = new System.Windows.Forms.TabPage();
            this.panelProvider = new System.Windows.Forms.Panel();
            this.bindingNavigatorProvider = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gvProvider = new System.Windows.Forms.DataGridView();
            this.gbTimKiemQuanLy = new System.Windows.Forms.GroupBox();
            this.chkSearchAll = new System.Windows.Forms.CheckBox();
            this.chkSearchProviderName = new System.Windows.Forms.CheckBox();
            this.chkSearchProviderID = new System.Windows.Forms.CheckBox();
            this.lblViDuTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnInAnQuanLy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkDispAll = new System.Windows.Forms.CheckBox();
            this.chkDispProviderName = new System.Windows.Forms.CheckBox();
            this.chkDispProviderID = new System.Windows.Forms.CheckBox();
            this.lblHienThiQuanLy = new System.Windows.Forms.Label();
            this.lblDanhSachProviderQuanLy = new System.Windows.Forms.Label();
            this.gbThongTinProvider = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.lblProvider = new System.Windows.Forms.Label();
            this.txtProviderID = new System.Windows.Forms.TextBox();
            this.lblMaProvider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFaxNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.tcQuanLyProvider.SuspendLayout();
            this.tpQuanLyProvider.SuspendLayout();
            this.panelProvider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorProvider)).BeginInit();
            this.bindingNavigatorProvider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProvider)).BeginInit();
            this.gbTimKiemQuanLy.SuspendLayout();
            this.gbThongTinProvider.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLyProvider
            // 
            this.tcQuanLyProvider.Controls.Add(this.tpQuanLyProvider);
            this.tcQuanLyProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuanLyProvider.Location = new System.Drawing.Point(0, 0);
            this.tcQuanLyProvider.Name = "tcQuanLyProvider";
            this.tcQuanLyProvider.SelectedIndex = 0;
            this.tcQuanLyProvider.Size = new System.Drawing.Size(1068, 509);
            this.tcQuanLyProvider.TabIndex = 0;
            // 
            // tpQuanLyProvider
            // 
            this.tpQuanLyProvider.Controls.Add(this.panelProvider);
            this.tpQuanLyProvider.Controls.Add(this.gbTimKiemQuanLy);
            this.tpQuanLyProvider.Controls.Add(this.btnInAnQuanLy);
            this.tpQuanLyProvider.Controls.Add(this.btnClose);
            this.tpQuanLyProvider.Controls.Add(this.chkDispAll);
            this.tpQuanLyProvider.Controls.Add(this.chkDispProviderName);
            this.tpQuanLyProvider.Controls.Add(this.chkDispProviderID);
            this.tpQuanLyProvider.Controls.Add(this.lblHienThiQuanLy);
            this.tpQuanLyProvider.Controls.Add(this.lblDanhSachProviderQuanLy);
            this.tpQuanLyProvider.Controls.Add(this.gbThongTinProvider);
            this.tpQuanLyProvider.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLyProvider.Name = "tpQuanLyProvider";
            this.tpQuanLyProvider.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyProvider.Size = new System.Drawing.Size(1060, 483);
            this.tpQuanLyProvider.TabIndex = 0;
            this.tpQuanLyProvider.Text = "Quản lý Nhà cung cấp";
            this.tpQuanLyProvider.UseVisualStyleBackColor = true;
            // 
            // panelProvider
            // 
            this.panelProvider.Controls.Add(this.bindingNavigatorProvider);
            this.panelProvider.Controls.Add(this.gvProvider);
            this.panelProvider.Location = new System.Drawing.Point(363, 187);
            this.panelProvider.Name = "panelProvider";
            this.panelProvider.Size = new System.Drawing.Size(680, 280);
            this.panelProvider.TabIndex = 27;
            // 
            // bindingNavigatorProvider
            // 
            this.bindingNavigatorProvider.AddNewItem = null;
            this.bindingNavigatorProvider.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorProvider.DeleteItem = null;
            this.bindingNavigatorProvider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorProvider.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorProvider.Location = new System.Drawing.Point(0, 255);
            this.bindingNavigatorProvider.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorProvider.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorProvider.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorProvider.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorProvider.Name = "bindingNavigatorProvider";
            this.bindingNavigatorProvider.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorProvider.Size = new System.Drawing.Size(680, 25);
            this.bindingNavigatorProvider.TabIndex = 14;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            this.bindingNavigatorMoveFirstItem.Text = "Move First";
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
            this.toolStripLblTotal.Size = new System.Drawing.Size(79, 22);
            this.toolStripLblTotal.Text = "Tổng số dòng: ";
            // 
            // gvProvider
            // 
            this.gvProvider.AllowUserToAddRows = false;
            this.gvProvider.AllowUserToDeleteRows = false;
            this.gvProvider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvProvider.Location = new System.Drawing.Point(0, 0);
            this.gvProvider.MultiSelect = false;
            this.gvProvider.Name = "gvProvider";
            this.gvProvider.ReadOnly = true;
            this.gvProvider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProvider.Size = new System.Drawing.Size(680, 262);
            this.gvProvider.TabIndex = 13;
            this.gvProvider.SelectionChanged += new System.EventHandler(this.gvProvider_SelectionChanged);
            // 
            // gbTimKiemQuanLy
            // 
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchAll);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchProviderName);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchProviderID);
            this.gbTimKiemQuanLy.Controls.Add(this.lblViDuTimKiemQuanLy);
            this.gbTimKiemQuanLy.Controls.Add(this.btnSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.txtSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.lblTimKiemQuanLy);
            this.gbTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbTimKiemQuanLy.Location = new System.Drawing.Point(363, 6);
            this.gbTimKiemQuanLy.Name = "gbTimKiemQuanLy";
            this.gbTimKiemQuanLy.Size = new System.Drawing.Size(680, 116);
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
            this.chkSearchAll.TabIndex = 7;
            this.chkSearchAll.Text = "Tất cả";
            this.chkSearchAll.UseVisualStyleBackColor = true;
            this.chkSearchAll.CheckedChanged += new System.EventHandler(this.chkSearchAll_CheckedChanged);
            // 
            // chkSearchProviderName
            // 
            this.chkSearchProviderName.AutoSize = true;
            this.chkSearchProviderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchProviderName.Location = new System.Drawing.Point(250, 80);
            this.chkSearchProviderName.Name = "chkSearchProviderName";
            this.chkSearchProviderName.Size = new System.Drawing.Size(109, 17);
            this.chkSearchProviderName.TabIndex = 5;
            this.chkSearchProviderName.Text = "Tên nhà cung cấp";
            this.chkSearchProviderName.UseVisualStyleBackColor = true;
            // 
            // chkSearchProviderID
            // 
            this.chkSearchProviderID.AutoSize = true;
            this.chkSearchProviderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchProviderID.Location = new System.Drawing.Point(139, 80);
            this.chkSearchProviderID.Name = "chkSearchProviderID";
            this.chkSearchProviderID.Size = new System.Drawing.Size(105, 17);
            this.chkSearchProviderID.TabIndex = 4;
            this.chkSearchProviderID.Text = "Mã nhà cung cấp";
            this.chkSearchProviderID.UseVisualStyleBackColor = true;
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
            this.btnSearch.Location = new System.Drawing.Point(365, 24);
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
            this.txtSearch.Location = new System.Drawing.Point(79, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 20);
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
            // btnInAnQuanLy
            // 
            this.btnInAnQuanLy.Image = global::SSMP.Properties.Resources.printer;
            this.btnInAnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInAnQuanLy.Location = new System.Drawing.Point(908, 156);
            this.btnInAnQuanLy.Name = "btnInAnQuanLy";
            this.btnInAnQuanLy.Size = new System.Drawing.Size(61, 23);
            this.btnInAnQuanLy.TabIndex = 25;
            this.btnInAnQuanLy.Text = "&In ấn";
            this.btnInAnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInAnQuanLy.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::SSMP.Properties.Resources.application_side_expand;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(982, 156);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 23);
            this.btnClose.TabIndex = 24;
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
            this.chkDispAll.Location = new System.Drawing.Point(412, 160);
            this.chkDispAll.Name = "chkDispAll";
            this.chkDispAll.Size = new System.Drawing.Size(57, 17);
            this.chkDispAll.TabIndex = 19;
            this.chkDispAll.Text = "Tất cả";
            this.chkDispAll.UseVisualStyleBackColor = true;
            this.chkDispAll.CheckedChanged += new System.EventHandler(this.chkDispAll_CheckedChanged);
            // 
            // chkDispProviderName
            // 
            this.chkDispProviderName.AutoSize = true;
            this.chkDispProviderName.Location = new System.Drawing.Point(586, 160);
            this.chkDispProviderName.Name = "chkDispProviderName";
            this.chkDispProviderName.Size = new System.Drawing.Size(89, 17);
            this.chkDispProviderName.TabIndex = 17;
            this.chkDispProviderName.Text = "Nhà cung cấp";
            this.chkDispProviderName.UseVisualStyleBackColor = true;
            this.chkDispProviderName.CheckedChanged += new System.EventHandler(this.chkDispProviderName_CheckedChanged);
            // 
            // chkDispProviderID
            // 
            this.chkDispProviderID.AutoSize = true;
            this.chkDispProviderID.Checked = true;
            this.chkDispProviderID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispProviderID.Enabled = false;
            this.chkDispProviderID.Location = new System.Drawing.Point(475, 160);
            this.chkDispProviderID.Name = "chkDispProviderID";
            this.chkDispProviderID.Size = new System.Drawing.Size(105, 17);
            this.chkDispProviderID.TabIndex = 16;
            this.chkDispProviderID.Text = "Mã nhà cung cấp";
            this.chkDispProviderID.UseVisualStyleBackColor = true;
            this.chkDispProviderID.CheckedChanged += new System.EventHandler(this.chkDispProviderID_CheckedChanged);
            // 
            // lblHienThiQuanLy
            // 
            this.lblHienThiQuanLy.AutoSize = true;
            this.lblHienThiQuanLy.Location = new System.Drawing.Point(360, 161);
            this.lblHienThiQuanLy.Name = "lblHienThiQuanLy";
            this.lblHienThiQuanLy.Size = new System.Drawing.Size(46, 13);
            this.lblHienThiQuanLy.TabIndex = 15;
            this.lblHienThiQuanLy.Text = "Hiển thị:";
            // 
            // lblDanhSachProviderQuanLy
            // 
            this.lblDanhSachProviderQuanLy.AutoSize = true;
            this.lblDanhSachProviderQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachProviderQuanLy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDanhSachProviderQuanLy.Location = new System.Drawing.Point(360, 137);
            this.lblDanhSachProviderQuanLy.Name = "lblDanhSachProviderQuanLy";
            this.lblDanhSachProviderQuanLy.Size = new System.Drawing.Size(179, 13);
            this.lblDanhSachProviderQuanLy.TabIndex = 14;
            this.lblDanhSachProviderQuanLy.Text = "DANH SÁCH NHÀ SẢN XUẤT:";
            // 
            // gbThongTinProvider
            // 
            this.gbThongTinProvider.Controls.Add(this.cbbCountry);
            this.gbThongTinProvider.Controls.Add(this.btnReset);
            this.gbThongTinProvider.Controls.Add(this.btnSave);
            this.gbThongTinProvider.Controls.Add(this.label5);
            this.gbThongTinProvider.Controls.Add(this.label4);
            this.gbThongTinProvider.Controls.Add(this.txtWebsite);
            this.gbThongTinProvider.Controls.Add(this.txtEmail);
            this.gbThongTinProvider.Controls.Add(this.label3);
            this.gbThongTinProvider.Controls.Add(this.txtFaxNo);
            this.gbThongTinProvider.Controls.Add(this.label2);
            this.gbThongTinProvider.Controls.Add(this.txtTelNo);
            this.gbThongTinProvider.Controls.Add(this.label1);
            this.gbThongTinProvider.Controls.Add(this.txtAddress);
            this.gbThongTinProvider.Controls.Add(this.lblMoTa);
            this.gbThongTinProvider.Controls.Add(this.txtProviderName);
            this.gbThongTinProvider.Controls.Add(this.lblProvider);
            this.gbThongTinProvider.Controls.Add(this.txtProviderID);
            this.gbThongTinProvider.Controls.Add(this.lblMaProvider);
            this.gbThongTinProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThongTinProvider.Location = new System.Drawing.Point(15, 6);
            this.gbThongTinProvider.Name = "gbThongTinProvider";
            this.gbThongTinProvider.Size = new System.Drawing.Size(333, 461);
            this.gbThongTinProvider.TabIndex = 0;
            this.gbThongTinProvider.TabStop = false;
            this.gbThongTinProvider.Text = "THÔNG TIN NHÀ SẢN XUẤT:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(237, 261);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 23);
            this.btnReset.TabIndex = 27;
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
            this.btnSave.Location = new System.Drawing.Point(151, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAddress.Location = new System.Drawing.Point(109, 84);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(208, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTa.Location = new System.Drawing.Point(10, 87);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(43, 13);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Địa chỉ:";
            // 
            // txtProviderName
            // 
            this.txtProviderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtProviderName.Location = new System.Drawing.Point(109, 55);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(208, 20);
            this.txtProviderName.TabIndex = 3;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProvider.Location = new System.Drawing.Point(10, 58);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(93, 13);
            this.lblProvider.TabIndex = 2;
            this.lblProvider.Text = "Tên nhà cung cấp:";
            // 
            // txtProviderID
            // 
            this.txtProviderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtProviderID.Location = new System.Drawing.Point(109, 26);
            this.txtProviderID.Name = "txtProviderID";
            this.txtProviderID.ReadOnly = true;
            this.txtProviderID.Size = new System.Drawing.Size(100, 20);
            this.txtProviderID.TabIndex = 1;
            // 
            // lblMaProvider
            // 
            this.lblMaProvider.AutoSize = true;
            this.lblMaProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaProvider.Location = new System.Drawing.Point(10, 29);
            this.lblMaProvider.Name = "lblMaProvider";
            this.lblMaProvider.Size = new System.Drawing.Size(89, 13);
            this.lblMaProvider.TabIndex = 0;
            this.lblMaProvider.Text = "Mã nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(10, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Điện thoại:";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTelNo.Location = new System.Drawing.Point(109, 113);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelNo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(10, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fax:";
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFaxNo.Location = new System.Drawing.Point(109, 142);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFaxNo.Size = new System.Drawing.Size(100, 20);
            this.txtFaxNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(10, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(109, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmail.Size = new System.Drawing.Size(208, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(10, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Website:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(10, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quốc gia:";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtWebsite.Location = new System.Drawing.Point(109, 200);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWebsite.Size = new System.Drawing.Size(208, 20);
            this.txtWebsite.TabIndex = 5;
            // 
            // cbbCountry
            // 
            this.cbbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Location = new System.Drawing.Point(109, 229);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(208, 21);
            this.cbbCountry.TabIndex = 28;
            // 
            // FrmProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 509);
            this.Controls.Add(this.tcQuanLyProvider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProvider";
            this.Text = "Quản Lý Nhà cung cấp";
            this.Load += new System.EventHandler(this.FrmProvider_Load);
            this.tcQuanLyProvider.ResumeLayout(false);
            this.tpQuanLyProvider.ResumeLayout(false);
            this.tpQuanLyProvider.PerformLayout();
            this.panelProvider.ResumeLayout(false);
            this.panelProvider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorProvider)).EndInit();
            this.bindingNavigatorProvider.ResumeLayout(false);
            this.bindingNavigatorProvider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProvider)).EndInit();
            this.gbTimKiemQuanLy.ResumeLayout(false);
            this.gbTimKiemQuanLy.PerformLayout();
            this.gbThongTinProvider.ResumeLayout(false);
            this.gbThongTinProvider.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLyProvider;
        private System.Windows.Forms.TabPage tpQuanLyProvider;
        private System.Windows.Forms.GroupBox gbThongTinProvider;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.TextBox txtProviderID;
        private System.Windows.Forms.Label lblMaProvider;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblDanhSachProviderQuanLy;
        private System.Windows.Forms.Label lblHienThiQuanLy;
        private System.Windows.Forms.CheckBox chkDispProviderID;
        private System.Windows.Forms.CheckBox chkDispProviderName;
        private System.Windows.Forms.CheckBox chkDispAll;
        private System.Windows.Forms.Button btnInAnQuanLy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbTimKiemQuanLy;
        private System.Windows.Forms.CheckBox chkSearchAll;
        private System.Windows.Forms.CheckBox chkSearchProviderName;
        private System.Windows.Forms.CheckBox chkSearchProviderID;
        private System.Windows.Forms.Label lblViDuTimKiemQuanLy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTimKiemQuanLy;
        private System.Windows.Forms.Panel panelProvider;
        private System.Windows.Forms.BindingNavigator bindingNavigatorProvider;
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
        private System.Windows.Forms.DataGridView gvProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFaxNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.ComboBox cbbCountry;
    }
}