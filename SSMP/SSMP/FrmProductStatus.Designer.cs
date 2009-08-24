namespace SSMP
{
    partial class FrmProductStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductStatus));
            this.tcQuanLyProductStatus = new System.Windows.Forms.TabControl();
            this.tpQuanLyProductStatus = new System.Windows.Forms.TabPage();
            this.panelProductStatus = new System.Windows.Forms.Panel();
            this.bindingNavigatorProductStatus = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gvProductStatus = new System.Windows.Forms.DataGridView();
            this.gbTimKiemQuanLy = new System.Windows.Forms.GroupBox();
            this.chkSearchAll = new System.Windows.Forms.CheckBox();
            this.chkSearchProductStatusDesc = new System.Windows.Forms.CheckBox();
            this.chkSearchProductStatusName = new System.Windows.Forms.CheckBox();
            this.chkSearchProductStatusID = new System.Windows.Forms.CheckBox();
            this.lblViDuTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnInAnQuanLy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkDispAll = new System.Windows.Forms.CheckBox();
            this.chkDispProductStatusDesc = new System.Windows.Forms.CheckBox();
            this.chkDispProductStatusName = new System.Windows.Forms.CheckBox();
            this.chkDispProductStatusID = new System.Windows.Forms.CheckBox();
            this.lblHienThiQuanLy = new System.Windows.Forms.Label();
            this.lblDanhSachProductStatusQuanLy = new System.Windows.Forms.Label();
            this.gbThongTinProductStatus = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProductStatusDesc = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtProductStatusName = new System.Windows.Forms.TextBox();
            this.lblProductStatus = new System.Windows.Forms.Label();
            this.txtProductStatusID = new System.Windows.Forms.TextBox();
            this.lblMaProductStatus = new System.Windows.Forms.Label();
            this.tcQuanLyProductStatus.SuspendLayout();
            this.tpQuanLyProductStatus.SuspendLayout();
            this.panelProductStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorProductStatus)).BeginInit();
            this.bindingNavigatorProductStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductStatus)).BeginInit();
            this.gbTimKiemQuanLy.SuspendLayout();
            this.gbThongTinProductStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLyProductStatus
            // 
            this.tcQuanLyProductStatus.Controls.Add(this.tpQuanLyProductStatus);
            this.tcQuanLyProductStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuanLyProductStatus.Location = new System.Drawing.Point(0, 0);
            this.tcQuanLyProductStatus.Name = "tcQuanLyProductStatus";
            this.tcQuanLyProductStatus.SelectedIndex = 0;
            this.tcQuanLyProductStatus.Size = new System.Drawing.Size(826, 560);
            this.tcQuanLyProductStatus.TabIndex = 0;
            // 
            // tpQuanLyProductStatus
            // 
            this.tpQuanLyProductStatus.Controls.Add(this.panelProductStatus);
            this.tpQuanLyProductStatus.Controls.Add(this.gbTimKiemQuanLy);
            this.tpQuanLyProductStatus.Controls.Add(this.btnInAnQuanLy);
            this.tpQuanLyProductStatus.Controls.Add(this.btnClose);
            this.tpQuanLyProductStatus.Controls.Add(this.chkDispAll);
            this.tpQuanLyProductStatus.Controls.Add(this.chkDispProductStatusDesc);
            this.tpQuanLyProductStatus.Controls.Add(this.chkDispProductStatusName);
            this.tpQuanLyProductStatus.Controls.Add(this.chkDispProductStatusID);
            this.tpQuanLyProductStatus.Controls.Add(this.lblHienThiQuanLy);
            this.tpQuanLyProductStatus.Controls.Add(this.lblDanhSachProductStatusQuanLy);
            this.tpQuanLyProductStatus.Controls.Add(this.gbThongTinProductStatus);
            this.tpQuanLyProductStatus.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLyProductStatus.Name = "tpQuanLyProductStatus";
            this.tpQuanLyProductStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyProductStatus.Size = new System.Drawing.Size(818, 534);
            this.tpQuanLyProductStatus.TabIndex = 0;
            this.tpQuanLyProductStatus.Text = "Quản lý trạng thái sản phẩm";
            this.tpQuanLyProductStatus.UseVisualStyleBackColor = true;
            // 
            // panelProductStatus
            // 
            this.panelProductStatus.Controls.Add(this.bindingNavigatorProductStatus);
            this.panelProductStatus.Controls.Add(this.gvProductStatus);
            this.panelProductStatus.Location = new System.Drawing.Point(15, 253);
            this.panelProductStatus.Name = "panelProductStatus";
            this.panelProductStatus.Size = new System.Drawing.Size(787, 267);
            this.panelProductStatus.TabIndex = 27;
            // 
            // bindingNavigatorProductStatus
            // 
            this.bindingNavigatorProductStatus.AddNewItem = null;
            this.bindingNavigatorProductStatus.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorProductStatus.DeleteItem = null;
            this.bindingNavigatorProductStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorProductStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorProductStatus.Location = new System.Drawing.Point(0, 242);
            this.bindingNavigatorProductStatus.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorProductStatus.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorProductStatus.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorProductStatus.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorProductStatus.Name = "bindingNavigatorProductStatus";
            this.bindingNavigatorProductStatus.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorProductStatus.Size = new System.Drawing.Size(787, 25);
            this.bindingNavigatorProductStatus.TabIndex = 14;
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
            this.toolStripLblTotal.Size = new System.Drawing.Size(79, 22);
            this.toolStripLblTotal.Text = "Tổng số dòng: ";
            // 
            // gvProductStatus
            // 
            this.gvProductStatus.AllowUserToAddRows = false;
            this.gvProductStatus.AllowUserToDeleteRows = false;
            this.gvProductStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProductStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvProductStatus.Location = new System.Drawing.Point(0, 0);
            this.gvProductStatus.MultiSelect = false;
            this.gvProductStatus.Name = "gvProductStatus";
            this.gvProductStatus.ReadOnly = true;
            this.gvProductStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProductStatus.Size = new System.Drawing.Size(787, 282);
            this.gvProductStatus.TabIndex = 13;
            this.gvProductStatus.SelectionChanged += new System.EventHandler(this.gvProductStatus_SelectionChanged);
            // 
            // gbTimKiemQuanLy
            // 
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchAll);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchProductStatusDesc);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchProductStatusName);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchProductStatusID);
            this.gbTimKiemQuanLy.Controls.Add(this.lblViDuTimKiemQuanLy);
            this.gbTimKiemQuanLy.Controls.Add(this.btnSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.txtSearch);
            this.gbTimKiemQuanLy.Controls.Add(this.lblTimKiemQuanLy);
            this.gbTimKiemQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbTimKiemQuanLy.Location = new System.Drawing.Point(383, 6);
            this.gbTimKiemQuanLy.Name = "gbTimKiemQuanLy";
            this.gbTimKiemQuanLy.Size = new System.Drawing.Size(419, 191);
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
            // chkSearchProductStatusDesc
            // 
            this.chkSearchProductStatusDesc.AutoSize = true;
            this.chkSearchProductStatusDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchProductStatusDesc.Location = new System.Drawing.Point(355, 80);
            this.chkSearchProductStatusDesc.Name = "chkSearchProductStatusDesc";
            this.chkSearchProductStatusDesc.Size = new System.Drawing.Size(53, 17);
            this.chkSearchProductStatusDesc.TabIndex = 6;
            this.chkSearchProductStatusDesc.Text = "Mô tả";
            this.chkSearchProductStatusDesc.UseVisualStyleBackColor = true;
            // 
            // chkSearchProductStatusName
            // 
            this.chkSearchProductStatusName.AutoSize = true;
            this.chkSearchProductStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchProductStatusName.Location = new System.Drawing.Point(228, 80);
            this.chkSearchProductStatusName.Name = "chkSearchProductStatusName";
            this.chkSearchProductStatusName.Size = new System.Drawing.Size(123, 17);
            this.chkSearchProductStatusName.TabIndex = 5;
            this.chkSearchProductStatusName.Text = "Trạng thái sản phẩm";
            this.chkSearchProductStatusName.UseVisualStyleBackColor = true;
            // 
            // chkSearchProductStatusID
            // 
            this.chkSearchProductStatusID.AutoSize = true;
            this.chkSearchProductStatusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchProductStatusID.Location = new System.Drawing.Point(139, 80);
            this.chkSearchProductStatusID.Name = "chkSearchProductStatusID";
            this.chkSearchProductStatusID.Size = new System.Drawing.Size(88, 17);
            this.chkSearchProductStatusID.TabIndex = 4;
            this.chkSearchProductStatusID.Text = "Mã trạng thái";
            this.chkSearchProductStatusID.UseVisualStyleBackColor = true;
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
            // btnInAnQuanLy
            // 
            this.btnInAnQuanLy.Image = global::SSMP.Properties.Resources.printer;
            this.btnInAnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInAnQuanLy.Location = new System.Drawing.Point(674, 224);
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
            this.btnClose.Location = new System.Drawing.Point(741, 224);
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
            this.chkDispAll.Location = new System.Drawing.Point(64, 228);
            this.chkDispAll.Name = "chkDispAll";
            this.chkDispAll.Size = new System.Drawing.Size(57, 17);
            this.chkDispAll.TabIndex = 19;
            this.chkDispAll.Text = "Tất cả";
            this.chkDispAll.UseVisualStyleBackColor = true;
            this.chkDispAll.CheckedChanged += new System.EventHandler(this.chkDispAll_CheckedChanged);
            // 
            // chkDispProductStatusDesc
            // 
            this.chkDispProductStatusDesc.AutoSize = true;
            this.chkDispProductStatusDesc.Location = new System.Drawing.Point(342, 228);
            this.chkDispProductStatusDesc.Name = "chkDispProductStatusDesc";
            this.chkDispProductStatusDesc.Size = new System.Drawing.Size(53, 17);
            this.chkDispProductStatusDesc.TabIndex = 18;
            this.chkDispProductStatusDesc.Text = "Mô tả";
            this.chkDispProductStatusDesc.UseVisualStyleBackColor = true;
            this.chkDispProductStatusDesc.CheckedChanged += new System.EventHandler(this.chkDispProductStatusDesc_CheckedChanged);
            // 
            // chkDispProductStatusName
            // 
            this.chkDispProductStatusName.AutoSize = true;
            this.chkDispProductStatusName.Location = new System.Drawing.Point(216, 228);
            this.chkDispProductStatusName.Name = "chkDispProductStatusName";
            this.chkDispProductStatusName.Size = new System.Drawing.Size(123, 17);
            this.chkDispProductStatusName.TabIndex = 17;
            this.chkDispProductStatusName.Text = "Trạng thái sản phẩm";
            this.chkDispProductStatusName.UseVisualStyleBackColor = true;
            this.chkDispProductStatusName.CheckedChanged += new System.EventHandler(this.chkDispProductStatusName_CheckedChanged);
            // 
            // chkDispProductStatusID
            // 
            this.chkDispProductStatusID.AutoSize = true;
            this.chkDispProductStatusID.Checked = true;
            this.chkDispProductStatusID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispProductStatusID.Enabled = false;
            this.chkDispProductStatusID.Location = new System.Drawing.Point(127, 228);
            this.chkDispProductStatusID.Name = "chkDispProductStatusID";
            this.chkDispProductStatusID.Size = new System.Drawing.Size(88, 17);
            this.chkDispProductStatusID.TabIndex = 16;
            this.chkDispProductStatusID.Text = "Mã trạng thái";
            this.chkDispProductStatusID.UseVisualStyleBackColor = true;
            this.chkDispProductStatusID.CheckedChanged += new System.EventHandler(this.chkDispProductStatusID_CheckedChanged);
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
            // lblDanhSachProductStatusQuanLy
            // 
            this.lblDanhSachProductStatusQuanLy.AutoSize = true;
            this.lblDanhSachProductStatusQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachProductStatusQuanLy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDanhSachProductStatusQuanLy.Location = new System.Drawing.Point(12, 205);
            this.lblDanhSachProductStatusQuanLy.Name = "lblDanhSachProductStatusQuanLy";
            this.lblDanhSachProductStatusQuanLy.Size = new System.Drawing.Size(231, 13);
            this.lblDanhSachProductStatusQuanLy.TabIndex = 14;
            this.lblDanhSachProductStatusQuanLy.Text = "DANH SÁCH TRẠNG THÁI SẢN PHẨM:";
            // 
            // gbThongTinProductStatus
            // 
            this.gbThongTinProductStatus.Controls.Add(this.btnReset);
            this.gbThongTinProductStatus.Controls.Add(this.btnSave);
            this.gbThongTinProductStatus.Controls.Add(this.txtProductStatusDesc);
            this.gbThongTinProductStatus.Controls.Add(this.lblMoTa);
            this.gbThongTinProductStatus.Controls.Add(this.txtProductStatusName);
            this.gbThongTinProductStatus.Controls.Add(this.lblProductStatus);
            this.gbThongTinProductStatus.Controls.Add(this.txtProductStatusID);
            this.gbThongTinProductStatus.Controls.Add(this.lblMaProductStatus);
            this.gbThongTinProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThongTinProductStatus.Location = new System.Drawing.Point(15, 6);
            this.gbThongTinProductStatus.Name = "gbThongTinProductStatus";
            this.gbThongTinProductStatus.Size = new System.Drawing.Size(362, 191);
            this.gbThongTinProductStatus.TabIndex = 0;
            this.gbThongTinProductStatus.TabStop = false;
            this.gbThongTinProductStatus.Text = "THÔNG TIN TRẠNG THÁI SẢN PHẨM:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(265, 158);
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
            this.btnSave.Location = new System.Drawing.Point(179, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProductStatusDesc
            // 
            this.txtProductStatusDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtProductStatusDesc.Location = new System.Drawing.Point(137, 84);
            this.txtProductStatusDesc.Multiline = true;
            this.txtProductStatusDesc.Name = "txtProductStatusDesc";
            this.txtProductStatusDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProductStatusDesc.Size = new System.Drawing.Size(208, 65);
            this.txtProductStatusDesc.TabIndex = 5;
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
            // txtProductStatusName
            // 
            this.txtProductStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtProductStatusName.Location = new System.Drawing.Point(137, 55);
            this.txtProductStatusName.Name = "txtProductStatusName";
            this.txtProductStatusName.Size = new System.Drawing.Size(208, 20);
            this.txtProductStatusName.TabIndex = 3;
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.AutoSize = true;
            this.lblProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductStatus.Location = new System.Drawing.Point(23, 58);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(107, 13);
            this.lblProductStatus.TabIndex = 2;
            this.lblProductStatus.Text = "Trạng thái sản phẩm:";
            // 
            // txtProductStatusID
            // 
            this.txtProductStatusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtProductStatusID.Location = new System.Drawing.Point(137, 26);
            this.txtProductStatusID.Name = "txtProductStatusID";
            this.txtProductStatusID.ReadOnly = true;
            this.txtProductStatusID.Size = new System.Drawing.Size(100, 20);
            this.txtProductStatusID.TabIndex = 1;
            // 
            // lblMaProductStatus
            // 
            this.lblMaProductStatus.AutoSize = true;
            this.lblMaProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaProductStatus.Location = new System.Drawing.Point(23, 29);
            this.lblMaProductStatus.Name = "lblMaProductStatus";
            this.lblMaProductStatus.Size = new System.Drawing.Size(72, 13);
            this.lblMaProductStatus.TabIndex = 0;
            this.lblMaProductStatus.Text = "Mã trạng thái:";
            // 
            // FrmProductStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.tcQuanLyProductStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductStatus";
            this.Text = "Quản Lý Trạng Thái Sản Phẩm";
            this.Load += new System.EventHandler(this.FrmProductStatus_Load);
            this.tcQuanLyProductStatus.ResumeLayout(false);
            this.tpQuanLyProductStatus.ResumeLayout(false);
            this.tpQuanLyProductStatus.PerformLayout();
            this.panelProductStatus.ResumeLayout(false);
            this.panelProductStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorProductStatus)).EndInit();
            this.bindingNavigatorProductStatus.ResumeLayout(false);
            this.bindingNavigatorProductStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductStatus)).EndInit();
            this.gbTimKiemQuanLy.ResumeLayout(false);
            this.gbTimKiemQuanLy.PerformLayout();
            this.gbThongTinProductStatus.ResumeLayout(false);
            this.gbThongTinProductStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLyProductStatus;
        private System.Windows.Forms.TabPage tpQuanLyProductStatus;
        private System.Windows.Forms.GroupBox gbThongTinProductStatus;
        private System.Windows.Forms.TextBox txtProductStatusName;
        private System.Windows.Forms.Label lblProductStatus;
        private System.Windows.Forms.TextBox txtProductStatusID;
        private System.Windows.Forms.Label lblMaProductStatus;
        private System.Windows.Forms.TextBox txtProductStatusDesc;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblDanhSachProductStatusQuanLy;
        private System.Windows.Forms.Label lblHienThiQuanLy;
        private System.Windows.Forms.CheckBox chkDispProductStatusID;
        private System.Windows.Forms.CheckBox chkDispProductStatusName;
        private System.Windows.Forms.CheckBox chkDispAll;
        private System.Windows.Forms.CheckBox chkDispProductStatusDesc;
        private System.Windows.Forms.Button btnInAnQuanLy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbTimKiemQuanLy;
        private System.Windows.Forms.CheckBox chkSearchAll;
        private System.Windows.Forms.CheckBox chkSearchProductStatusDesc;
        private System.Windows.Forms.CheckBox chkSearchProductStatusName;
        private System.Windows.Forms.CheckBox chkSearchProductStatusID;
        private System.Windows.Forms.Label lblViDuTimKiemQuanLy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTimKiemQuanLy;
        private System.Windows.Forms.Panel panelProductStatus;
        private System.Windows.Forms.BindingNavigator bindingNavigatorProductStatus;
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
        private System.Windows.Forms.DataGridView gvProductStatus;
    }
}