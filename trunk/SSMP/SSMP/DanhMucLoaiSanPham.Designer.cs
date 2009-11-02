namespace SSMP
{
    partial class FrmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            this.tcQuanLyCategory = new System.Windows.Forms.TabControl();
            this.tpQuanLyCategory = new System.Windows.Forms.TabPage();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.bindingNavigatorCategory = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gvCategory = new System.Windows.Forms.DataGridView();
            this.gbTimKiemQuanLy = new System.Windows.Forms.GroupBox();
            this.chkSearchAll = new System.Windows.Forms.CheckBox();
            this.chkSearchCategoryDesc = new System.Windows.Forms.CheckBox();
            this.chkSearchCategoryName = new System.Windows.Forms.CheckBox();
            this.chkSearchCategoryID = new System.Windows.Forms.CheckBox();
            this.lblViDuTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnInAnQuanLy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkDispAll = new System.Windows.Forms.CheckBox();
            this.chkDispCategoryDesc = new System.Windows.Forms.CheckBox();
            this.chkDispCategoryName = new System.Windows.Forms.CheckBox();
            this.chkDispCategoryID = new System.Windows.Forms.CheckBox();
            this.lblHienThiQuanLy = new System.Windows.Forms.Label();
            this.lblDanhSachCategoryQuanLy = new System.Windows.Forms.Label();
            this.gbThongTinCategory = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCategoryDesc = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblMaCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcQuanLyCategory.SuspendLayout();
            this.tpQuanLyCategory.SuspendLayout();
            this.panelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCategory)).BeginInit();
            this.bindingNavigatorCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            this.gbTimKiemQuanLy.SuspendLayout();
            this.gbThongTinCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLyCategory
            // 
            this.tcQuanLyCategory.Controls.Add(this.tpQuanLyCategory);
            this.tcQuanLyCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuanLyCategory.Location = new System.Drawing.Point(0, 0);
            this.tcQuanLyCategory.Name = "tcQuanLyCategory";
            this.tcQuanLyCategory.SelectedIndex = 0;
            this.tcQuanLyCategory.Size = new System.Drawing.Size(826, 560);
            this.tcQuanLyCategory.TabIndex = 0;
            // 
            // tpQuanLyCategory
            // 
            this.tpQuanLyCategory.Controls.Add(this.panelCategory);
            this.tpQuanLyCategory.Controls.Add(this.gbTimKiemQuanLy);
            this.tpQuanLyCategory.Controls.Add(this.btnInAnQuanLy);
            this.tpQuanLyCategory.Controls.Add(this.btnClose);
            this.tpQuanLyCategory.Controls.Add(this.chkDispAll);
            this.tpQuanLyCategory.Controls.Add(this.chkDispCategoryDesc);
            this.tpQuanLyCategory.Controls.Add(this.chkDispCategoryName);
            this.tpQuanLyCategory.Controls.Add(this.chkDispCategoryID);
            this.tpQuanLyCategory.Controls.Add(this.lblHienThiQuanLy);
            this.tpQuanLyCategory.Controls.Add(this.lblDanhSachCategoryQuanLy);
            this.tpQuanLyCategory.Controls.Add(this.gbThongTinCategory);
            this.tpQuanLyCategory.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLyCategory.Name = "tpQuanLyCategory";
            this.tpQuanLyCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyCategory.Size = new System.Drawing.Size(818, 534);
            this.tpQuanLyCategory.TabIndex = 0;
            this.tpQuanLyCategory.Text = "Quản lý Loại sản phẩm";
            this.tpQuanLyCategory.UseVisualStyleBackColor = true;
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.bindingNavigatorCategory);
            this.panelCategory.Controls.Add(this.gvCategory);
            this.panelCategory.Location = new System.Drawing.Point(15, 253);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(787, 267);
            this.panelCategory.TabIndex = 27;
            // 
            // bindingNavigatorCategory
            // 
            this.bindingNavigatorCategory.AddNewItem = null;
            this.bindingNavigatorCategory.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorCategory.DeleteItem = null;
            this.bindingNavigatorCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorCategory.Location = new System.Drawing.Point(0, 242);
            this.bindingNavigatorCategory.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorCategory.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorCategory.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorCategory.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorCategory.Name = "bindingNavigatorCategory";
            this.bindingNavigatorCategory.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorCategory.Size = new System.Drawing.Size(787, 25);
            this.bindingNavigatorCategory.TabIndex = 28;
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
            // gvCategory
            // 
            this.gvCategory.AllowUserToAddRows = false;
            this.gvCategory.AllowUserToDeleteRows = false;
            this.gvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvCategory.Location = new System.Drawing.Point(0, 0);
            this.gvCategory.MultiSelect = false;
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.ReadOnly = true;
            this.gvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCategory.Size = new System.Drawing.Size(787, 282);
            this.gvCategory.TabIndex = 18;
            this.gvCategory.SelectionChanged += new System.EventHandler(this.gvCategory_SelectionChanged);
            // 
            // gbTimKiemQuanLy
            // 
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchAll);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchCategoryDesc);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchCategoryName);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchCategoryID);
            this.gbTimKiemQuanLy.Controls.Add(this.lblViDuTimKiemQuanLy);
            this.gbTimKiemQuanLy.Controls.Add(this.btnSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.txtSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.lblTimKiemQuanLy);
            this.gbTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbTimKiemQuanLy.Location = new System.Drawing.Point(384, 6);
            this.gbTimKiemQuanLy.Name = "gbTimKiemQuanLy";
            this.gbTimKiemQuanLy.Size = new System.Drawing.Size(418, 191);
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
            // chkSearchCategoryDesc
            // 
            this.chkSearchCategoryDesc.AutoSize = true;
            this.chkSearchCategoryDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchCategoryDesc.Location = new System.Drawing.Point(356, 80);
            this.chkSearchCategoryDesc.Name = "chkSearchCategoryDesc";
            this.chkSearchCategoryDesc.Size = new System.Drawing.Size(53, 17);
            this.chkSearchCategoryDesc.TabIndex = 11;
            this.chkSearchCategoryDesc.Text = "Mô tả";
            this.chkSearchCategoryDesc.UseVisualStyleBackColor = true;
            // 
            // chkSearchCategoryName
            // 
            this.chkSearchCategoryName.AutoSize = true;
            this.chkSearchCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchCategoryName.Location = new System.Drawing.Point(254, 80);
            this.chkSearchCategoryName.Name = "chkSearchCategoryName";
            this.chkSearchCategoryName.Size = new System.Drawing.Size(95, 17);
            this.chkSearchCategoryName.TabIndex = 10;
            this.chkSearchCategoryName.Text = "Loại sản phẩm";
            this.chkSearchCategoryName.UseVisualStyleBackColor = true;
            // 
            // chkSearchCategoryID
            // 
            this.chkSearchCategoryID.AutoSize = true;
            this.chkSearchCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchCategoryID.Location = new System.Drawing.Point(139, 80);
            this.chkSearchCategoryID.Name = "chkSearchCategoryID";
            this.chkSearchCategoryID.Size = new System.Drawing.Size(109, 17);
            this.chkSearchCategoryID.TabIndex = 9;
            this.chkSearchCategoryID.Text = "Mã loại sản phẩm";
            this.chkSearchCategoryID.UseVisualStyleBackColor = true;
            // 
            // lblViDuTimKiemQuanLy
            // 
            this.lblViDuTimKiemQuanLy.AutoSize = true;
            this.lblViDuTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblViDuTimKiemQuanLy.Location = new System.Drawing.Point(76, 55);
            this.lblViDuTimKiemQuanLy.Name = "lblViDuTimKiemQuanLy";
            this.lblViDuTimKiemQuanLy.Size = new System.Drawing.Size(135, 13);
            this.lblViDuTimKiemQuanLy.TabIndex = 3;
            this.lblViDuTimKiemQuanLy.Text = "(ví dụ: (Ví dụ: sữa, rượu... )";
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
            // chkDispCategoryDesc
            // 
            this.chkDispCategoryDesc.AutoSize = true;
            this.chkDispCategoryDesc.Location = new System.Drawing.Point(339, 228);
            this.chkDispCategoryDesc.Name = "chkDispCategoryDesc";
            this.chkDispCategoryDesc.Size = new System.Drawing.Size(53, 17);
            this.chkDispCategoryDesc.TabIndex = 15;
            this.chkDispCategoryDesc.Text = "Mô tả";
            this.chkDispCategoryDesc.UseVisualStyleBackColor = true;
            this.chkDispCategoryDesc.CheckedChanged += new System.EventHandler(this.chkDispCategoryDesc_CheckedChanged);
            // 
            // chkDispCategoryName
            // 
            this.chkDispCategoryName.AutoSize = true;
            this.chkDispCategoryName.Location = new System.Drawing.Point(242, 228);
            this.chkDispCategoryName.Name = "chkDispCategoryName";
            this.chkDispCategoryName.Size = new System.Drawing.Size(95, 17);
            this.chkDispCategoryName.TabIndex = 14;
            this.chkDispCategoryName.Text = "Loại sản phẩm";
            this.chkDispCategoryName.UseVisualStyleBackColor = true;
            this.chkDispCategoryName.CheckedChanged += new System.EventHandler(this.chkDispCategoryName_CheckedChanged);
            // 
            // chkDispCategoryID
            // 
            this.chkDispCategoryID.AutoSize = true;
            this.chkDispCategoryID.Checked = true;
            this.chkDispCategoryID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispCategoryID.Enabled = false;
            this.chkDispCategoryID.Location = new System.Drawing.Point(127, 228);
            this.chkDispCategoryID.Name = "chkDispCategoryID";
            this.chkDispCategoryID.Size = new System.Drawing.Size(109, 17);
            this.chkDispCategoryID.TabIndex = 13;
            this.chkDispCategoryID.Text = "Mã loại sản phẩm";
            this.chkDispCategoryID.UseVisualStyleBackColor = true;
            this.chkDispCategoryID.CheckedChanged += new System.EventHandler(this.chkDispCategoryID_CheckedChanged);
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
            // lblDanhSachCategoryQuanLy
            // 
            this.lblDanhSachCategoryQuanLy.AutoSize = true;
            this.lblDanhSachCategoryQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachCategoryQuanLy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDanhSachCategoryQuanLy.Location = new System.Drawing.Point(12, 205);
            this.lblDanhSachCategoryQuanLy.Name = "lblDanhSachCategoryQuanLy";
            this.lblDanhSachCategoryQuanLy.Size = new System.Drawing.Size(183, 13);
            this.lblDanhSachCategoryQuanLy.TabIndex = 14;
            this.lblDanhSachCategoryQuanLy.Text = "DANH SÁCH LOẠI SẢN PHẨM:";
            // 
            // gbThongTinCategory
            // 
            this.gbThongTinCategory.Controls.Add(this.label1);
            this.gbThongTinCategory.Controls.Add(this.btnReset);
            this.gbThongTinCategory.Controls.Add(this.btnSave);
            this.gbThongTinCategory.Controls.Add(this.txtCategoryDesc);
            this.gbThongTinCategory.Controls.Add(this.lblMoTa);
            this.gbThongTinCategory.Controls.Add(this.txtCategoryName);
            this.gbThongTinCategory.Controls.Add(this.lblCategory);
            this.gbThongTinCategory.Controls.Add(this.txtCategoryID);
            this.gbThongTinCategory.Controls.Add(this.lblMaCategory);
            this.gbThongTinCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThongTinCategory.Location = new System.Drawing.Point(15, 6);
            this.gbThongTinCategory.Name = "gbThongTinCategory";
            this.gbThongTinCategory.Size = new System.Drawing.Size(363, 191);
            this.gbThongTinCategory.TabIndex = 0;
            this.gbThongTinCategory.TabStop = false;
            this.gbThongTinCategory.Text = "THÔNG TIN LOẠI SẢN PHẨM:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Image = global::SSMP.Properties.Resources.cross;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(252, 158);
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
            this.btnSave.Location = new System.Drawing.Point(166, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCategoryDesc.Location = new System.Drawing.Point(124, 84);
            this.txtCategoryDesc.Multiline = true;
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCategoryDesc.Size = new System.Drawing.Size(208, 65);
            this.txtCategoryDesc.TabIndex = 3;
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
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCategoryName.Location = new System.Drawing.Point(124, 55);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(208, 20);
            this.txtCategoryName.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCategory.Location = new System.Drawing.Point(23, 58);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Loại sản phẩm:";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCategoryID.Location = new System.Drawing.Point(125, 26);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryID.TabIndex = 1;
            // 
            // lblMaCategory
            // 
            this.lblMaCategory.AutoSize = true;
            this.lblMaCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaCategory.Location = new System.Drawing.Point(23, 29);
            this.lblMaCategory.Name = "lblMaCategory";
            this.lblMaCategory.Size = new System.Drawing.Size(93, 13);
            this.lblMaCategory.TabIndex = 0;
            this.lblMaCategory.Text = "Mã loại sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(338, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "*";
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.tcQuanLyCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategory";
            this.Text = "Quản Lý Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.tcQuanLyCategory.ResumeLayout(false);
            this.tpQuanLyCategory.ResumeLayout(false);
            this.tpQuanLyCategory.PerformLayout();
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCategory)).EndInit();
            this.bindingNavigatorCategory.ResumeLayout(false);
            this.bindingNavigatorCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            this.gbTimKiemQuanLy.ResumeLayout(false);
            this.gbTimKiemQuanLy.PerformLayout();
            this.gbThongTinCategory.ResumeLayout(false);
            this.gbThongTinCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLyCategory;
        private System.Windows.Forms.TabPage tpQuanLyCategory;
        private System.Windows.Forms.GroupBox gbThongTinCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblMaCategory;
        private System.Windows.Forms.TextBox txtCategoryDesc;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblDanhSachCategoryQuanLy;
        private System.Windows.Forms.Label lblHienThiQuanLy;
        private System.Windows.Forms.CheckBox chkDispCategoryID;
        private System.Windows.Forms.CheckBox chkDispCategoryName;
        private System.Windows.Forms.CheckBox chkDispAll;
        private System.Windows.Forms.CheckBox chkDispCategoryDesc;
        private System.Windows.Forms.Button btnInAnQuanLy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbTimKiemQuanLy;
        private System.Windows.Forms.CheckBox chkSearchAll;
        private System.Windows.Forms.CheckBox chkSearchCategoryDesc;
        private System.Windows.Forms.CheckBox chkSearchCategoryName;
        private System.Windows.Forms.CheckBox chkSearchCategoryID;
        private System.Windows.Forms.Label lblViDuTimKiemQuanLy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTimKiemQuanLy;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.DataGridView gvCategory;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCategory;
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
    }
}