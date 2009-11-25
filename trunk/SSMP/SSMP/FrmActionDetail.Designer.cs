namespace SSMP
{
    partial class FrmActionDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActionDetail));
            this.tcQuanLyActionDetail = new System.Windows.Forms.TabControl();
            this.tpQuanLyActionDetail = new System.Windows.Forms.TabPage();
            this.panelActionDetail = new System.Windows.Forms.Panel();
            this.bindingNavigatorActionDetail = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gvActionDetail = new System.Windows.Forms.DataGridView();
            this.gbTimKiemQuanLy = new System.Windows.Forms.GroupBox();
            this.chkSearchAll = new System.Windows.Forms.CheckBox();
            this.chkSearchActionDetailDesc = new System.Windows.Forms.CheckBox();
            this.chkSearchActionDetailName = new System.Windows.Forms.CheckBox();
            this.chkSearchActionDetailID = new System.Windows.Forms.CheckBox();
            this.lblViDuTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimKiemQuanLy = new System.Windows.Forms.Label();
            this.btnInAnQuanLy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkDispAll = new System.Windows.Forms.CheckBox();
            this.chkDispActionDetailDesc = new System.Windows.Forms.CheckBox();
            this.chkDispActionDetailName = new System.Windows.Forms.CheckBox();
            this.chkDispActionDetailID = new System.Windows.Forms.CheckBox();
            this.lblHienThiQuanLy = new System.Windows.Forms.Label();
            this.lblDanhSachActionDetailQuanLy = new System.Windows.Forms.Label();
            this.gbThongTinActionDetail = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtActionDetailDesc = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtActionDetailName = new System.Windows.Forms.TextBox();
            this.lblActionDetail = new System.Windows.Forms.Label();
            this.txtActionDetailID = new System.Windows.Forms.TextBox();
            this.lblMaActionDetail = new System.Windows.Forms.Label();
            this.btnReloadAll = new System.Windows.Forms.Button();
            this.tcQuanLyActionDetail.SuspendLayout();
            this.tpQuanLyActionDetail.SuspendLayout();
            this.panelActionDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorActionDetail)).BeginInit();
            this.bindingNavigatorActionDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvActionDetail)).BeginInit();
            this.gbTimKiemQuanLy.SuspendLayout();
            this.gbThongTinActionDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLyActionDetail
            // 
            this.tcQuanLyActionDetail.Controls.Add(this.tpQuanLyActionDetail);
            this.tcQuanLyActionDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuanLyActionDetail.Location = new System.Drawing.Point(0, 0);
            this.tcQuanLyActionDetail.Name = "tcQuanLyActionDetail";
            this.tcQuanLyActionDetail.SelectedIndex = 0;
            this.tcQuanLyActionDetail.Size = new System.Drawing.Size(826, 560);
            this.tcQuanLyActionDetail.TabIndex = 0;
            // 
            // tpQuanLyActionDetail
            // 
            this.tpQuanLyActionDetail.Controls.Add(this.btnReloadAll);
            this.tpQuanLyActionDetail.Controls.Add(this.panelActionDetail);
            this.tpQuanLyActionDetail.Controls.Add(this.gbTimKiemQuanLy);
            this.tpQuanLyActionDetail.Controls.Add(this.btnInAnQuanLy);
            this.tpQuanLyActionDetail.Controls.Add(this.btnClose);
            this.tpQuanLyActionDetail.Controls.Add(this.chkDispAll);
            this.tpQuanLyActionDetail.Controls.Add(this.chkDispActionDetailDesc);
            this.tpQuanLyActionDetail.Controls.Add(this.chkDispActionDetailName);
            this.tpQuanLyActionDetail.Controls.Add(this.chkDispActionDetailID);
            this.tpQuanLyActionDetail.Controls.Add(this.lblHienThiQuanLy);
            this.tpQuanLyActionDetail.Controls.Add(this.lblDanhSachActionDetailQuanLy);
            this.tpQuanLyActionDetail.Controls.Add(this.gbThongTinActionDetail);
            this.tpQuanLyActionDetail.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLyActionDetail.Name = "tpQuanLyActionDetail";
            this.tpQuanLyActionDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyActionDetail.Size = new System.Drawing.Size(818, 534);
            this.tpQuanLyActionDetail.TabIndex = 0;
            this.tpQuanLyActionDetail.Text = "Quản lý Dấu vết";
            this.tpQuanLyActionDetail.UseVisualStyleBackColor = true;
            // 
            // panelActionDetail
            // 
            this.panelActionDetail.Controls.Add(this.bindingNavigatorActionDetail);
            this.panelActionDetail.Controls.Add(this.gvActionDetail);
            this.panelActionDetail.Location = new System.Drawing.Point(15, 253);
            this.panelActionDetail.Name = "panelActionDetail";
            this.panelActionDetail.Size = new System.Drawing.Size(787, 267);
            this.panelActionDetail.TabIndex = 27;
            // 
            // bindingNavigatorActionDetail
            // 
            this.bindingNavigatorActionDetail.AddNewItem = null;
            this.bindingNavigatorActionDetail.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorActionDetail.DeleteItem = null;
            this.bindingNavigatorActionDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorActionDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorActionDetail.Location = new System.Drawing.Point(0, 242);
            this.bindingNavigatorActionDetail.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorActionDetail.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorActionDetail.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorActionDetail.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorActionDetail.Name = "bindingNavigatorActionDetail";
            this.bindingNavigatorActionDetail.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorActionDetail.Size = new System.Drawing.Size(787, 25);
            this.bindingNavigatorActionDetail.TabIndex = 14;
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
            this.toolStripBtnAdd.Enabled = false;
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
            this.toolStripBtnEdit.Enabled = false;
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
            this.toolStripBtnDelete.Enabled = false;
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
            // gvActionDetail
            // 
            this.gvActionDetail.AllowUserToAddRows = false;
            this.gvActionDetail.AllowUserToDeleteRows = false;
            this.gvActionDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvActionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvActionDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvActionDetail.Location = new System.Drawing.Point(0, 0);
            this.gvActionDetail.MultiSelect = false;
            this.gvActionDetail.Name = "gvActionDetail";
            this.gvActionDetail.ReadOnly = true;
            this.gvActionDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvActionDetail.Size = new System.Drawing.Size(787, 267);
            this.gvActionDetail.TabIndex = 18;
            this.gvActionDetail.SelectionChanged += new System.EventHandler(this.gvActionDetail_SelectionChanged);
            // 
            // gbTimKiemQuanLy
            // 
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchAll);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchActionDetailDesc);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchActionDetailName);
            this.gbTimKiemQuanLy.Controls.Add(this.chkSearchActionDetailID);
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
            // chkSearchActionDetailDesc
            // 
            this.chkSearchActionDetailDesc.AutoSize = true;
            this.chkSearchActionDetailDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchActionDetailDesc.Location = new System.Drawing.Point(310, 80);
            this.chkSearchActionDetailDesc.Name = "chkSearchActionDetailDesc";
            this.chkSearchActionDetailDesc.Size = new System.Drawing.Size(53, 17);
            this.chkSearchActionDetailDesc.TabIndex = 11;
            this.chkSearchActionDetailDesc.Text = "Mô tả";
            this.chkSearchActionDetailDesc.UseVisualStyleBackColor = true;
            // 
            // chkSearchActionDetailName
            // 
            this.chkSearchActionDetailName.AutoSize = true;
            this.chkSearchActionDetailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchActionDetailName.Location = new System.Drawing.Point(228, 80);
            this.chkSearchActionDetailName.Name = "chkSearchActionDetailName";
            this.chkSearchActionDetailName.Size = new System.Drawing.Size(64, 17);
            this.chkSearchActionDetailName.TabIndex = 10;
            this.chkSearchActionDetailName.Text = "Dấu vết";
            this.chkSearchActionDetailName.UseVisualStyleBackColor = true;
            // 
            // chkSearchActionDetailID
            // 
            this.chkSearchActionDetailID.AutoSize = true;
            this.chkSearchActionDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkSearchActionDetailID.Location = new System.Drawing.Point(139, 80);
            this.chkSearchActionDetailID.Name = "chkSearchActionDetailID";
            this.chkSearchActionDetailID.Size = new System.Drawing.Size(80, 17);
            this.chkSearchActionDetailID.TabIndex = 9;
            this.chkSearchActionDetailID.Text = "Mã dấu vết";
            this.chkSearchActionDetailID.UseVisualStyleBackColor = true;
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
            // chkDispActionDetailDesc
            // 
            this.chkDispActionDetailDesc.AutoSize = true;
            this.chkDispActionDetailDesc.Location = new System.Drawing.Point(288, 228);
            this.chkDispActionDetailDesc.Name = "chkDispActionDetailDesc";
            this.chkDispActionDetailDesc.Size = new System.Drawing.Size(53, 17);
            this.chkDispActionDetailDesc.TabIndex = 15;
            this.chkDispActionDetailDesc.Text = "Mô tả";
            this.chkDispActionDetailDesc.UseVisualStyleBackColor = true;
            this.chkDispActionDetailDesc.CheckedChanged += new System.EventHandler(this.chkDispActionDetailDesc_CheckedChanged);
            // 
            // chkDispActionDetailName
            // 
            this.chkDispActionDetailName.AutoSize = true;
            this.chkDispActionDetailName.Location = new System.Drawing.Point(216, 228);
            this.chkDispActionDetailName.Name = "chkDispActionDetailName";
            this.chkDispActionDetailName.Size = new System.Drawing.Size(64, 17);
            this.chkDispActionDetailName.TabIndex = 14;
            this.chkDispActionDetailName.Text = "Dấu vết";
            this.chkDispActionDetailName.UseVisualStyleBackColor = true;
            this.chkDispActionDetailName.CheckedChanged += new System.EventHandler(this.chkDispActionDetailName_CheckedChanged);
            // 
            // chkDispActionDetailID
            // 
            this.chkDispActionDetailID.AutoSize = true;
            this.chkDispActionDetailID.Checked = true;
            this.chkDispActionDetailID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispActionDetailID.Enabled = false;
            this.chkDispActionDetailID.Location = new System.Drawing.Point(127, 228);
            this.chkDispActionDetailID.Name = "chkDispActionDetailID";
            this.chkDispActionDetailID.Size = new System.Drawing.Size(80, 17);
            this.chkDispActionDetailID.TabIndex = 13;
            this.chkDispActionDetailID.Text = "Mã dấu vết";
            this.chkDispActionDetailID.UseVisualStyleBackColor = true;
            this.chkDispActionDetailID.CheckedChanged += new System.EventHandler(this.chkDispActionDetailID_CheckedChanged);
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
            // lblDanhSachActionDetailQuanLy
            // 
            this.lblDanhSachActionDetailQuanLy.AutoSize = true;
            this.lblDanhSachActionDetailQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachActionDetailQuanLy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDanhSachActionDetailQuanLy.Location = new System.Drawing.Point(12, 205);
            this.lblDanhSachActionDetailQuanLy.Name = "lblDanhSachActionDetailQuanLy";
            this.lblDanhSachActionDetailQuanLy.Size = new System.Drawing.Size(141, 13);
            this.lblDanhSachActionDetailQuanLy.TabIndex = 14;
            this.lblDanhSachActionDetailQuanLy.Text = "DANH SÁCH DẤU VẾT:";
            // 
            // gbThongTinActionDetail
            // 
            this.gbThongTinActionDetail.Controls.Add(this.label1);
            this.gbThongTinActionDetail.Controls.Add(this.btnReset);
            this.gbThongTinActionDetail.Controls.Add(this.btnSave);
            this.gbThongTinActionDetail.Controls.Add(this.txtActionDetailDesc);
            this.gbThongTinActionDetail.Controls.Add(this.lblMoTa);
            this.gbThongTinActionDetail.Controls.Add(this.txtActionDetailName);
            this.gbThongTinActionDetail.Controls.Add(this.lblActionDetail);
            this.gbThongTinActionDetail.Controls.Add(this.txtActionDetailID);
            this.gbThongTinActionDetail.Controls.Add(this.lblMaActionDetail);
            this.gbThongTinActionDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThongTinActionDetail.Location = new System.Drawing.Point(15, 6);
            this.gbThongTinActionDetail.Name = "gbThongTinActionDetail";
            this.gbThongTinActionDetail.Size = new System.Drawing.Size(332, 191);
            this.gbThongTinActionDetail.TabIndex = 0;
            this.gbThongTinActionDetail.TabStop = false;
            this.gbThongTinActionDetail.Text = "THÔNG TIN DẤU VẾT:";
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
            // txtActionDetailDesc
            // 
            this.txtActionDetailDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtActionDetailDesc.Location = new System.Drawing.Point(96, 84);
            this.txtActionDetailDesc.Multiline = true;
            this.txtActionDetailDesc.Name = "txtActionDetailDesc";
            this.txtActionDetailDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActionDetailDesc.Size = new System.Drawing.Size(208, 65);
            this.txtActionDetailDesc.TabIndex = 3;
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
            // txtActionDetailName
            // 
            this.txtActionDetailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtActionDetailName.Location = new System.Drawing.Point(96, 55);
            this.txtActionDetailName.Name = "txtActionDetailName";
            this.txtActionDetailName.Size = new System.Drawing.Size(208, 20);
            this.txtActionDetailName.TabIndex = 2;
            // 
            // lblActionDetail
            // 
            this.lblActionDetail.AutoSize = true;
            this.lblActionDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblActionDetail.Location = new System.Drawing.Point(23, 58);
            this.lblActionDetail.Name = "lblActionDetail";
            this.lblActionDetail.Size = new System.Drawing.Size(48, 13);
            this.lblActionDetail.TabIndex = 2;
            this.lblActionDetail.Text = "Dấu vết:";
            // 
            // txtActionDetailID
            // 
            this.txtActionDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtActionDetailID.Location = new System.Drawing.Point(96, 26);
            this.txtActionDetailID.Name = "txtActionDetailID";
            this.txtActionDetailID.ReadOnly = true;
            this.txtActionDetailID.Size = new System.Drawing.Size(100, 20);
            this.txtActionDetailID.TabIndex = 1;
            // 
            // lblMaActionDetail
            // 
            this.lblMaActionDetail.AutoSize = true;
            this.lblMaActionDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaActionDetail.Location = new System.Drawing.Point(23, 29);
            this.lblMaActionDetail.Name = "lblMaActionDetail";
            this.lblMaActionDetail.Size = new System.Drawing.Size(64, 13);
            this.lblMaActionDetail.TabIndex = 0;
            this.lblMaActionDetail.Text = "Mã dấu vết:";
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
            // FrmActionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.tcQuanLyActionDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmActionDetail";
            this.Text = "Quản Lý Dấu vết";
            this.Load += new System.EventHandler(this.FrmActionDetail_Load);
            this.tcQuanLyActionDetail.ResumeLayout(false);
            this.tpQuanLyActionDetail.ResumeLayout(false);
            this.tpQuanLyActionDetail.PerformLayout();
            this.panelActionDetail.ResumeLayout(false);
            this.panelActionDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorActionDetail)).EndInit();
            this.bindingNavigatorActionDetail.ResumeLayout(false);
            this.bindingNavigatorActionDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvActionDetail)).EndInit();
            this.gbTimKiemQuanLy.ResumeLayout(false);
            this.gbTimKiemQuanLy.PerformLayout();
            this.gbThongTinActionDetail.ResumeLayout(false);
            this.gbThongTinActionDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLyActionDetail;
        private System.Windows.Forms.TabPage tpQuanLyActionDetail;
        private System.Windows.Forms.GroupBox gbThongTinActionDetail;
        private System.Windows.Forms.TextBox txtActionDetailName;
        private System.Windows.Forms.Label lblActionDetail;
        private System.Windows.Forms.TextBox txtActionDetailID;
        private System.Windows.Forms.Label lblMaActionDetail;
        private System.Windows.Forms.TextBox txtActionDetailDesc;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblDanhSachActionDetailQuanLy;
        private System.Windows.Forms.Label lblHienThiQuanLy;
        private System.Windows.Forms.CheckBox chkDispActionDetailID;
        private System.Windows.Forms.CheckBox chkDispActionDetailName;
        private System.Windows.Forms.CheckBox chkDispAll;
        private System.Windows.Forms.CheckBox chkDispActionDetailDesc;
        private System.Windows.Forms.Button btnInAnQuanLy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbTimKiemQuanLy;
        private System.Windows.Forms.CheckBox chkSearchAll;
        private System.Windows.Forms.CheckBox chkSearchActionDetailDesc;
        private System.Windows.Forms.CheckBox chkSearchActionDetailName;
        private System.Windows.Forms.CheckBox chkSearchActionDetailID;
        private System.Windows.Forms.Label lblViDuTimKiemQuanLy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTimKiemQuanLy;
        private System.Windows.Forms.Panel panelActionDetail;
        private System.Windows.Forms.BindingNavigator bindingNavigatorActionDetail;
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
        private System.Windows.Forms.DataGridView gvActionDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReloadAll;
    }
}