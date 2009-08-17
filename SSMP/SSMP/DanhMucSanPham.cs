using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SSMP.Data.Manager;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using log4net;

namespace SSMP
{
    public partial class frmDanhMucSanPham : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        HoTro ht;
        Int32 DongHienTai;

        //Manager object
        private ProductManager productManager;
        private ProductNameManager productNameManager = new ProductNameManager();
        private ProductStatusManager productStatusManager;
        private UnitManager unitManager;

        private CategoryManager categoryManager;
        private ManufacturerManager manufacturerManager;
        private CountryManager countryManager;
        private ProviderManager providerManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(frmDanhMucSanPham));
        private Product searchEntity;
        private ProductName searchEntityProductName;
        private SearchParam searchParam;
        private SearchParam searchParamProductName;
        private IList<Product> currentListProduct;
        private IList<ProductName> currentListProductName;
        private List<Int32> listPages;
        private List<Int32> listPagesProductName;
        private DataSet dataSetProduct;
        private DataSet dataSetProductName;
        private int MODE;
        private int updateProductId;


        public frmDanhMucSanPham()
        {
            InitializeComponent();


            //Create Manager which will use in form
            productManager = new ProductManager();
            productNameManager = new ProductNameManager();            
            productStatusManager = new ProductStatusManager();
            unitManager = new UnitManager();

            categoryManager = new CategoryManager();
            manufacturerManager = new ManufacturerManager();
            countryManager = new CountryManager();
            providerManager = new ProviderManager();

            //
            MODE = Constants.MODE.ADD;
        }

        private string DieuKienTimKiem()
        {
            string dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                dk = " where SanPham.MaSanPham like '%" + textBoxSearch.Text + "%' or SanPham.TenSanPham like N'%" + textBoxSearch.Text + "%' or LoaiSanPham.LoaiSanPham like N'%" + textBoxSearch.Text + "%' or DonVi.DonVi like N'%" + textBoxSearch.Text + "%' or QuocGia.QuocGia like N'%" + textBoxSearch.Text + "%' or NhaSanXuat.TenNhaSanXuat like N'%" + textBoxSearch.Text + "%' or NhaCungCap.NhaCungCap like N'%" + textBoxSearch.Text + "%' or SanPham.MoTa like N'%" + textBoxSearch.Text + "%'";
            else
            {
                if (chkMaSanPhamTimKiemQuanLy.Checked)
                    dk += " or SanPham.MaSanPham like '%" + textBoxSearch.Text+"%'";
                if (chkTenSanPhamTimKiemQuanLy.Checked)
                    dk += " or SanPham.TenSanPham like N'%" + textBoxSearch.Text+"%'";
                if (chkLoaiSanPhamTimKiemQuanLy.Checked)
                    dk += " or LoaiSanPham.LoaiSanPham like N'%" + textBoxSearch.Text+"%'";
                if (chkDonViTimKiemQuanLy.Checked)
                    dk += " or DonVi.DonVi like N'%" + textBoxSearch.Text + "%'";
                if (chkNguonGocTimKiemQuanLy.Checked)
                    dk += " or QuocGia.QuocGia like N'%"+ textBoxSearch.Text+"%'";
                if (chkNhaSanXuatTimKiemQuanLy.Checked)
                    dk += "or NhaSanXuat.TenNhaSanXuat like N'%" + textBoxSearch.Text + "%'";
                if (chkNhaCungCapTimKiemQuanLy.Checked)
                    dk += " or NhaCungCap.NhaCungCap like N'%" + textBoxSearch.Text + "%'";
                if (chkMoTaTimKiemQuanLy.Checked)
                    dk += " or SanPham.MoTa like N'%" + textBoxSearch.Text+"%'";

                if (dk.Trim().Length > 0)
                    dk = " where "+dk.Substring(4);
            }

            return dk;
        }


        private void frmDanhMucSanPham_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);

            try
            {
                //Create column of gridview                
                ContructGridViewColumn();
                
                //Get all product
                searchParam = new SearchParam();
                searchParam.Start = DEFAULT_START;
                searchParam.Limit = DEFAULT_LIMIT;
                searchParam.SortBy = DEFAULT_SORT_BY;
                searchParam.SortDir = DEFAULT_SORT_DIR;

                searchParamProductName = new SearchParam();
                searchParamProductName.Start = DEFAULT_START;
                searchParamProductName.Limit = DEFAULT_LIMIT;
                searchParamProductName.SortBy = DEFAULT_SORT_BY;
                searchParamProductName.SortDir = DEFAULT_SORT_DIR;

                searchEntity = new Product();
                searchEntityProductName = new ProductName();
                SearchResult<Product> searchResult = productManager.GetProductListByParam(searchEntity, searchParam);

                SearchResult<ProductName> searchResultProductName = productNameManager.GetProductNameListByParam(searchEntityProductName, searchParamProductName);
                currentListProduct = searchResult.SearchList;
                currentListProductName = searchResultProductName.SearchList;

                //Binding list product to gridview
                IList2DataTable(currentListProduct, dataSetProduct.Tables["Product"]);
                IList2DataTableProductName(currentListProductName, dataSetProductName.Tables["ProductName"]);

                listPages = new List<Int32>();
                listPagesProductName = new List<Int32>();
                BindingDataToBindingNagivator(searchResult.SearchSize, 0);
                BindingDataToBindingNagivatorProductName(searchResultProductName.SearchSize, 0);

                

                //Binding value for combobox
                comboBoxTenSanPham.DataSource = productNameManager.GetAll();
                comboBoxTenSanPham.DisplayMember = "ProdName";
                comboBoxTenSanPham.ValueMember = "ID";

                comboBoxLoaiSanPham.DataSource = categoryManager.GetAll();
                comboBoxLoaiSanPham.DisplayMember = "CategoryName";
                comboBoxLoaiSanPham.ValueMember = "ID";
                
                cboTenSanPham.DataSource = productNameManager.GetAll();
                cboTenSanPham.DisplayMember = "ProdName";
                cboTenSanPham.ValueMember = "ID";

                cboLoaiSanPham.DataSource = categoryManager.GetAll();
                cboLoaiSanPham.DisplayMember = "CategoryName";
                cboLoaiSanPham.ValueMember = "ID";

                cboNguonGoc.DataSource = countryManager.GetAll();
                cboNguonGoc.DisplayMember = "CountryName";
                cboNguonGoc.ValueMember = "ID";

                cboNhaSanXuat.DataSource = manufacturerManager.GetAll();
                cboNhaSanXuat.DisplayMember = "ManName";
                cboNhaSanXuat.ValueMember = "ID";

                cboDonVi.DataSource = unitManager.GetAll();
                cboDonVi.DisplayMember = "UnitName";
                cboDonVi.ValueMember = "ID";

                cboTrangThai.DataSource = productStatusManager.GetAll();
                cboTrangThai.DisplayMember = "StatusName";
                cboTrangThai.ValueMember = "ID";
                //Display all column in gridview
                DisplayAll();
            }
            catch (Exception ex)
            {
                logger.Debug(ex.Message);
                logger.Debug(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }

        }

        #region Binding Data

        private void BindingDataToBindingNagivator(int sizeOfList, int position)
        {
            int totalPage = 0;
            if (sizeOfList % DEFAULT_LIMIT > 0)
            {
                totalPage = (int)sizeOfList / DEFAULT_LIMIT + 1;
            }
            else
            {
                totalPage = (int)sizeOfList / DEFAULT_LIMIT;
            }

            logger.Debug("sizeOfList = " + sizeOfList);
            logger.Debug("totalPage = " + totalPage);
            listPages.Clear();

            for (int i = 0; i < totalPage; i++)
            {
                listPages.Add(i);
            }

            bindingNavigatorProduct.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorProduct.BindingSource.Position = position;
            bindingNavigatorProduct.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);
            toolStripLblTotal.Text = "Tổng số sản phẩm: " + sizeOfList;
        }

        private void BindingDataToBindingNagivatorProductName(int sizeOfList, int position)
        {
            int totalPage = 0;
            if (sizeOfList % DEFAULT_LIMIT > 0)
            {
                totalPage = (int)sizeOfList / DEFAULT_LIMIT + 1;
            }
            else
            {
                totalPage = (int)sizeOfList / DEFAULT_LIMIT;
            }

            logger.Debug("sizeOfList = " + sizeOfList);
            logger.Debug("totalPage = " + totalPage);
            listPagesProductName.Clear();

            for (int i = 0; i < totalPage; i++)
            {
                listPagesProductName.Add(i);
            }

            bindingNavigator1.BindingSource = new BindingSource(listPagesProductName, "");
            bindingNavigator1.BindingSource.Position = position;
            bindingNavigator1.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);
            toolStripLabeltotalProductName.Text = "Tổng số tên sản phẩm: " + sizeOfList;
        }

        private void BindingDataToForm(Product entity, SearchParam searchParam, int position)
        {
            SearchResult<Product> searchResult = productManager.GetProductListByParam(entity, searchParam);

            if (searchResult != null)
            {
                DataTable dataTableProduct = new DataTable("Product");
                dataTableProduct.Columns.Add("ProductId", typeof(Int64));
                dataTableProduct.Columns.Add("MfgDate", typeof(DateTime));
                dataTableProduct.Columns.Add("ExpDate", typeof(DateTime));
                dataTableProduct.Columns.Add("ProductNameId", typeof(int));
                dataTableProduct.Columns.Add("ProdName", typeof(string));
                dataTableProduct.Columns.Add("PurchasePrice", typeof(string));
                dataTableProduct.Columns.Add("SalePrice", typeof(string));
                dataTableProduct.Columns.Add("Discount", typeof(string));
                dataTableProduct.Columns.Add("StatusId", typeof(int));
                dataTableProduct.Columns.Add("Status", typeof(string));
                dataTableProduct.Columns.Add("BillPurchaseId", typeof(int));
                dataTableProduct.Columns.Add("BillSaleId", typeof(int));
                dataTableProduct.Columns.Add("UnitId", typeof(int));
                dataTableProduct.Columns.Add("Unit", typeof(string));

                foreach (Product objProduct in searchResult.SearchList)
                {
                    DataRow rowTemp = dataTableProduct.NewRow();
                    rowTemp["ProductId"] = objProduct.ID;
                    rowTemp["MfgDate"] = objProduct.MfgDate;
                    rowTemp["ExpDate"] = objProduct.ExpDate;
                    rowTemp["ProductNameId"] = objProduct.ProductNameIdLookup.ID;
                    rowTemp["ProdName"] = objProduct.ProductNameIdLookup.ProdName;
                    rowTemp["PurchasePrice"] = objProduct.PurchasePrice;
                    rowTemp["SalePrice"] = objProduct.SalePrice;
                    rowTemp["Discount"] = objProduct.Discount;
                    rowTemp["StatusId"] = objProduct.ProductStatusIdLookup.ID;
                    rowTemp["Status"] = objProduct.ProductStatusIdLookup.StatusName;
                    rowTemp["BillPurchaseId"] = objProduct.BillPurchaseId;
                    if (objProduct.BillSaleId != null) rowTemp["BillSaleId"] = objProduct.BillSaleId;
                    rowTemp["UnitId"] = objProduct.UnitIdLookup.ID;
                    rowTemp["Unit"] = objProduct.UnitIdLookup.UnitName;
                    dataTableProduct.Rows.Add(rowTemp);
                }

                dataSetProduct = new DataSet();
                dataSetProduct.Tables.Add(dataTableProduct);
                gvSanPhamDanhMuc.DataSource = dataSetProduct;


                gvSanPhamDanhMuc.DataSource = dataSetProduct;
                gvSanPhamDanhMuc.DataMember = "Product";
                gvSanPhamDanhMuc.Columns["ProductId"].HeaderText = "Mã sản phẩm";
                gvSanPhamDanhMuc.Columns["MfgDate"].HeaderText = "Ngày sản xuất";
                gvSanPhamDanhMuc.Columns["ExpDate"].HeaderText = "Ngày hết hạn";
                gvSanPhamDanhMuc.Columns["ProductNameId"].Visible = false;
                gvSanPhamDanhMuc.Columns["ProdName"].HeaderText = "Tên sản phẩm";
                gvSanPhamDanhMuc.Columns["PurchasePrice"].HeaderText = "Giá mua";
                gvSanPhamDanhMuc.Columns["SalePrice"].HeaderText = "Giá bán";
                gvSanPhamDanhMuc.Columns["Discount"].HeaderText = "Giảm giá";
                gvSanPhamDanhMuc.Columns["StatusId"].Visible = false;
                gvSanPhamDanhMuc.Columns["Status"].HeaderText = "Trạng thái";
                gvSanPhamDanhMuc.Columns["BillPurchaseId"].HeaderText = "Mã mua";
                gvSanPhamDanhMuc.Columns["BillSaleId"].HeaderText = "Mã bán";
                gvSanPhamDanhMuc.Columns["UnitId"].Visible = false;
                gvSanPhamDanhMuc.Columns["Unit"].HeaderText = "Đơn vị";

                //
                currentListProduct = searchResult.SearchList;

                //
                logger.Debug("searchList size = " + searchResult.SearchList.Count);

                List<Int32> listPages = new List<Int32>();
                int totalPage = 0;

                if (searchResult.SearchSize % DEFAULT_LIMIT > 0)
                {
                    totalPage = (int)searchResult.SearchSize / DEFAULT_LIMIT + 1;
                }
                else
                {
                    totalPage = (int)searchResult.SearchSize / DEFAULT_LIMIT;
                }

                logger.Debug("searchSize = " + searchResult.SearchSize);
                logger.Debug("totalPage = " + totalPage);

                for (int i = 0; i < totalPage; i++)
                {
                    listPages.Add(i);
                }

                bindingNavigatorProduct.BindingSource = new BindingSource(listPages, "");
                bindingNavigatorProduct.BindingSource.Position = position;
                bindingNavigatorProduct.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

                //Set total of number product in bindingNavigator
                toolStripLblTotal.Text = "Tổng số sản phẩm: " + searchResult.SearchSize;
            }
        }


        private void ContructGridViewColumn()
        {
            //Create DataTable of Product
            DataTable dataTableProduct = new DataTable("Product");
            dataTableProduct.Columns.Add("ProductId", typeof(Int64));
            dataTableProduct.Columns.Add("MfgDate", typeof(DateTime));
            dataTableProduct.Columns.Add("ExpDate", typeof(DateTime));
            dataTableProduct.Columns.Add("ProductNameId", typeof(int));
            dataTableProduct.Columns.Add("ProdName", typeof(string));
            dataTableProduct.Columns.Add("PurchasePrice", typeof(string));
            dataTableProduct.Columns.Add("SalePrice", typeof(string));
            dataTableProduct.Columns.Add("Discount", typeof(string));
            dataTableProduct.Columns.Add("StatusId", typeof(int));
            dataTableProduct.Columns.Add("Status", typeof(string));
            dataTableProduct.Columns.Add("BillPurchaseId", typeof(int));
            dataTableProduct.Columns.Add("BillSaleId", typeof(int));
            dataTableProduct.Columns.Add("UnitId", typeof(int));
            dataTableProduct.Columns.Add("Unit", typeof(string));

            //Create DataSet of Product
            dataSetProduct = new DataSet();
            dataSetProduct.Tables.Add(dataTableProduct);

            //Config detail of column in grid view            
            gvSanPhamDanhMuc.DataSource = dataSetProduct;
            gvSanPhamDanhMuc.DataMember = "Product";
            gvSanPhamDanhMuc.Columns["ProductId"].HeaderText = "Mã sản phẩm";
            gvSanPhamDanhMuc.Columns["MfgDate"].HeaderText = "Ngày sản xuất";
            gvSanPhamDanhMuc.Columns["ExpDate"].HeaderText = "Ngày hết hạn";
            gvSanPhamDanhMuc.Columns["ProductNameId"].Visible = false;
            gvSanPhamDanhMuc.Columns["ProdName"].HeaderText = "Tên sản phẩm";
            gvSanPhamDanhMuc.Columns["PurchasePrice"].HeaderText = "Giá mua";
            gvSanPhamDanhMuc.Columns["SalePrice"].HeaderText = "Giá bán";
            gvSanPhamDanhMuc.Columns["Discount"].HeaderText = "Giảm giá";
            gvSanPhamDanhMuc.Columns["StatusId"].Visible = false;
            gvSanPhamDanhMuc.Columns["Status"].HeaderText = "Trạng thái";
            gvSanPhamDanhMuc.Columns["BillPurchaseId"].HeaderText = "Mã mua";
            gvSanPhamDanhMuc.Columns["BillSaleId"].HeaderText = "Mã bán";
            gvSanPhamDanhMuc.Columns["UnitId"].Visible = false;
            gvSanPhamDanhMuc.Columns["Unit"].HeaderText = "Đơn vị";

            // ============================================================


            //Create DataTable of ProductName
            DataTable dataTableProductName = new DataTable("ProductName");
            dataTableProductName.Columns.Add("ProductNameId", typeof(Int32));
            dataTableProductName.Columns.Add("ProdName", typeof(string));
            dataTableProductName.Columns.Add("CategoryId", typeof(int));
            dataTableProductName.Columns.Add("CategoryName", typeof(string));
            dataTableProductName.Columns.Add("ManId", typeof(int));
            dataTableProductName.Columns.Add("ManName", typeof(string));
            dataTableProductName.Columns.Add("ProdDesc", typeof(string));
            
            //Create DataSet of ProductName
            dataSetProductName = new DataSet();
            dataSetProductName.Tables.Add(dataTableProductName);

            //Config detail of column in grid view            
            gvSanPham.DataSource = dataSetProductName;
            gvSanPham.DataMember = "ProductName";
            gvSanPham.Columns["ProductNameId"].HeaderText = "Mã tên sản phẩm";
            gvSanPham.Columns["ProdName"].HeaderText = "Tên sản phẩm";
            gvSanPham.Columns["CategoryId"].Visible = false;
            gvSanPham.Columns["CategoryName"].HeaderText = "Loại sản phẩm";
            gvSanPham.Columns["ManId"].Visible = false;
            gvSanPham.Columns["ManName"].HeaderText = "Nhà sản xuất";
            gvSanPham.Columns["ProdDesc"].HeaderText = "Mô tả";

            
        }

        private void IList2DataTable(IList<Product> listProduct, DataTable dataTableProduct)
        {
            if (listProduct != null)
            {
                foreach (Product objProduct in listProduct)
                {
                    DataRow rowTemp = dataTableProduct.NewRow();
                    rowTemp["ProductId"] = objProduct.ID;                    
                    rowTemp["MfgDate"] = objProduct.MfgDate;
                    rowTemp["ExpDate"] = objProduct.ExpDate;
                    rowTemp["ProductNameId"] = objProduct.ProductNameIdLookup.ID;
                    rowTemp["ProdName"] = objProduct.ProductNameIdLookup.ProdName;
                    rowTemp["PurchasePrice"] = objProduct.PurchasePrice;
                    rowTemp["SalePrice"] = objProduct.SalePrice;
                    rowTemp["Discount"] = objProduct.Discount;
                    rowTemp["StatusId"] = objProduct.ProductStatusIdLookup.ID;
                    rowTemp["Status"] = objProduct.ProductStatusIdLookup.StatusName;
                    rowTemp["BillPurchaseId"] = objProduct.BillPurchaseId;
                    if (objProduct.BillSaleId != null) rowTemp["BillSaleId"] = objProduct.BillSaleId;
                    rowTemp["UnitId"] = objProduct.UnitIdLookup.ID;
                    rowTemp["Unit"] = objProduct.UnitIdLookup.UnitName;
                    dataTableProduct.Rows.Add(rowTemp);
                }
            }
        }

        private void IList2DataTableProductName(IList<ProductName> listProductName, DataTable dataTableProductName)
        {
            if (listProductName != null)
            {
                foreach (ProductName objProduct in listProductName)
                {
                    DataRow rowTemp = dataTableProductName.NewRow();
                    rowTemp["ProductNameId"] = objProduct.ID;
                    rowTemp["ProdName"] = objProduct.ProdName ;
                    rowTemp["CategoryId"] = objProduct.CategoryIdLookup.ID;
                    rowTemp["CategoryName"] = objProduct.CategoryIdLookup.CategoryName;
                    rowTemp["ManId"] = objProduct.ManIdLookup.ID;
                    rowTemp["ManName"] = objProduct.ManIdLookup.ManName;
                    rowTemp["ProdDesc"] = objProduct.ProdDesc;
                    dataTableProductName.Rows.Add(rowTemp);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = textBoxSearch.Text.Trim(); ;
            searchEntity = new Product();
            /*
            if (chkSearchProductId.Checked == true)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new Product(Int32.Parse(strSearch));
                }
                else
                {
                    searchEntity = new Product(-1);
                }
            }
            else
            {
                searchEntity = new Product();
            }

            if (chkSearchEmail.Checked == true)
            {
                searchEntity.Email = strSearch;
            }

            if (chkSearchFullname.Checked == true)
            {
                searchEntity.FullName = strSearch;
            }

            if (chkSearchProductname.Checked == true)
            {
                searchEntity.Productname = strSearch;
            }
            */
            BindingDataToForm(searchEntity, searchParam, 0);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProduct.BindingSource.Position);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProduct.BindingSource.Position);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProduct.BindingSource.Position);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProduct.BindingSource.Position);
        }

        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProduct.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProduct.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorProduct.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            this.BindingDataToForm(searchEntity, searchParam, position);
        }

        public void RefreshGridViewProducts()
        {
            Product entity = new Product();

            SearchParam searchParam = new SearchParam();
            searchParam.Start = DEFAULT_START;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            this.BindingDataToForm(entity, searchParam, 0);

            bindingNavigatorProduct.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);
        }

        #endregion

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {/*
            try
            {
                Product userEntity;

                if (MODE == Constants.MODE.ADD)
                {
                    userEntity = new Product();
                }
                else if (MODE == Constants.MODE.UPDATE)
                {
                    int idxInList = -1;

                    foreach (Product objProduct in currentListProduct)
                    {
                        if (objProduct.ID == updateProductId)
                        {
                            idxInList = currentListProduct.IndexOf(objProduct);
                        }
                    }

                    userEntity = currentListProduct[idxInList];
                }
                else
                {
                    userEntity = new Product();
                }

                string strFullname = txtFullname.Text.Trim();
                string strProductname = txtProductname.Text.Trim();
                string strPassword = txtPassword.Text.Trim();
                string strPasswordConfirm = txtPasswordConfirm.Text.Trim();
                int valueTitle = (int)cbbProductTitle.SelectedValue;
                int valueRole = (int)cbbProductRole.SelectedValue;
                byte valueSex = rdMale.Checked == true ? (byte)1 : (byte)0;
                DateTime dateDOB = dateTimeDOB.Value;
                string strIdCardNo = txtIdCardNo.Text.Trim();
                string strTelNo = txtTelNo.Text.Trim();
                string strEmail = txtEmail.Text.Trim();
                string strAddress = txtAddress.Text.Trim();

                if (strPassword != strPasswordConfirm)
                {
                    MessageBox.Show("Mật khẩu không trùng nhau. Vui lòng nhập lại", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    userEntity.FullName = strFullname;
                    userEntity.Productname = strProductname;
                    userEntity.Password = new HoTro().DoiSangMaMD5(strPassword);
                    userEntity.ProductTitleId = valueTitle;
                    userEntity.ProductRoleId = valueRole;
                    userEntity.ProductStatusId = DBConstants.Product.ACTIVE;
                    userEntity.Sex = valueSex;
                    userEntity.Birthday = dateDOB;
                    userEntity.IdCardNo = strIdCardNo;
                    userEntity.TelNo = strTelNo;
                    userEntity.Email = strEmail;
                    userEntity.Address = strAddress;

                    //Do save new entity
                    productManager.SaveOrUpdate(userEntity);

                    //Show message success
                    if (MODE == Constants.MODE.ADD)
                    {
                        MessageBox.Show("Tạo mới người dùng [" + userEntity.ID + " ] thành công", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (MODE == Constants.MODE.UPDATE)
                    {
                        MessageBox.Show("Cập nhật người dùng [" + userEntity.ID + " ] thành công", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MODE = Constants.MODE.ADD;
                        btnAddUpdate.Text = "Thêm";
                        this.ResetForm();
                    }

                    //Refresh grid view after insert successfully
                    this.RefreshGridViewProducts();
                }
            }
            catch (Exception ex)
            {
                logger.Debug(ex.Message);
                logger.Debug(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
          */
        }

        private void toolStripBtnUpdate_Click(object sender, EventArgs e)
        {
            if (gvSanPhamDanhMuc.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvSanPhamDanhMuc.SelectedCells[0].RowIndex;

                BindingProductToForm(selectedRowIndex);

                //btnAddUpdate.Text = "Update";
                MODE = Constants.MODE.UPDATE;
                updateProductId = (int)gvSanPhamDanhMuc.Rows[selectedRowIndex].Cells["ProductId"].Value;
            }

        }

        private void toolStripBtnDelete_Click(object sender, EventArgs e)
        {
            if (gvSanPhamDanhMuc.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvSanPhamDanhMuc.SelectedCells[0].RowIndex;
                int deleteProductId = (int)gvSanPhamDanhMuc.Rows[selectedRowIndex].Cells["ProductId"].Value;
                string deleteProductname = (string)gvSanPhamDanhMuc.Rows[selectedRowIndex].Cells["Productname"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng [" + deleteProductname + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idxInList = -1;

                    foreach (Product objProduct in currentListProduct)
                    {
                        if (objProduct.ID == deleteProductId)
                        {
                            idxInList = currentListProduct.IndexOf(objProduct);
                        }
                    }

                    productManager.Delete(currentListProduct[idxInList]);

                    //Refresh grid view after delete successfully
                    this.RefreshGridViewProducts();
                }
            }
        }

        private void chkDispAll_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (chkDispAll.Checked == true)
            {
                DisplayAll();
            }
            else
            {
                chkDispAddress.Checked = false;
                chkDispDOB.Checked = false;
                chkDispEmail.Checked = false;
                chkDispFullname.Checked = false;
                chkDispIdCardNo.Checked = false;
                chkDispSex.Checked = false;
                chkDispTelNo.Checked = false;
                chkDispProductname.Checked = false;
                chkDispProductRole.Checked = false;
                chkDispProductStatus.Checked = false;
                chkDispProductTitle.Checked = false;
            }
            */
        }

        private void chkDispFullname_CheckedChanged(object sender, EventArgs e)
        {
            // DisplayColumn(gvSanPhamDanhMuc, chkDispFullname, "Fullname");
        }

        private void chkDispProductname_CheckedChanged(object sender, EventArgs e)
        {
            //DisplayColumn(gvSanPhamDanhMuc, chkDispProductname, "Productname");
        }

        private void chkDispProductTitle_CheckedChanged(object sender, EventArgs e)
        {
            //DisplayColumn(gvSanPhamDanhMuc, chkDispProductTitle, "ProductTitle");
        }

        private void chkDispProductStatus_CheckedChanged(object sender, EventArgs e)
        {
            //DisplayColumn(gvSanPhamDanhMuc, chkDispProductStatus, "ProductStatus");
        }

        private void chkDispProductRole_CheckedChanged(object sender, EventArgs e)
        {
            //DisplayColumn(gvSanPhamDanhMuc, chkDispProductRole, "ProductRole");
        }

        private void chkDispSex_CheckedChanged(object sender, EventArgs e)
        {
            //DisplayColumn(gvSanPhamDanhMuc, chkDispSex, "Sex");
        }

        private void chkDispDOB_CheckedChanged(object sender, EventArgs e)
        {
            //DisplayColumn(gvSanPhamDanhMuc, chkDispDOB, "Birthday");
        }

        private void chkDispIdCardNo_CheckedChanged(object sender, EventArgs e)
        {
            // DisplayColumn(gvSanPhamDanhMuc, chkDispIdCardNo, "IdCardNo");
        }

        private void chkDispTelNo_CheckedChanged(object sender, EventArgs e)
        {
           // DisplayColumn(gvSanPhamDanhMuc, chkDispTelNo, "TelNo");
        }

        private void chkDispEmail_CheckedChanged(object sender, EventArgs e)
        {
            //DisplayColumn(gvSanPhamDanhMuc, chkDispEmail, "Email");
        }

        private void chkDispAddress_CheckedChanged(object sender, EventArgs e)
        {
            //DisplayColumn(gvSanPhamDanhMuc, chkDispAddress, "Address");
        }

        private void DisplayColumn(DataGridView gridView, CheckBox chk, string columnName)
        {
            if (chk.Checked)
            {
                gridView.Columns[columnName].Visible = true;
            }
            else
            {
                gridView.Columns[columnName].Visible = false;
            }
        }

        private void DisplayAll()
        {
            chkLoaiSp.Checked = true;
            //chkMasp.Checked = true;
            chkMota.Checked = true;
            chkTatCaHienThiQuanLySanPham.Checked = true;
            //chkDispIdCardNo.Checked = true;
        }

        private void BindingProductToForm(int rowIndex)
        {

            textBoxMaSanPham.Text = (Int64)gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductId"].Value + "";
            //textBoxMota.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductId"].Value + "";

            if (!gvSanPhamDanhMuc.Rows[rowIndex].Cells["SalePrice"].Value.ToString().Equals(""))
                textBoxGiaBan.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["SalePrice"].Value + "";
            else textBoxGiaBan.Text = "";
            if (!gvSanPhamDanhMuc.Rows[rowIndex].Cells["Discount"].Value.ToString().Equals(""))
                textBoxGiamGia.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["Discount"].Value + "";
            else textBoxGiamGia.Text = "";
            textBoxGiaMua.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["PurchasePrice"].Value + "";
            Object productNameId = gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductNameId"].Value ; 
            cboTenSanPham.SelectedValue = productNameId;
            cboTrangThai.SelectedValue = gvSanPhamDanhMuc.Rows[rowIndex].Cells["StatusId"].Value;
            cboDonVi.SelectedValue = gvSanPhamDanhMuc.Rows[rowIndex].Cells["UnitId"].Value;
            //cboLoaiSanPham.SelectedValue = gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductRoleId"].Value;
            //cboNguonGoc.SelectedValue = gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductRoleId"].Value;
            //cboNhaSanXuat.SelectedValue = gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductRoleId"].Value;

            dateTimePickerSx.Value = (DateTime)gvSanPhamDanhMuc.Rows[rowIndex].Cells["MfgDate"].Value;
            dateTimePickerHetHan.Value = (DateTime)gvSanPhamDanhMuc.Rows[rowIndex].Cells["ExpDate"].Value;

            ProductName prdName = productNameManager.GetById((int)productNameId, true);
            cboLoaiSanPham.SelectedValue = prdName.CategoryIdLookup.ID;
            int manId = prdName.ManIdLookup.ID;
            cboNhaSanXuat.SelectedValue = manId;

            Manufacturer manu = manufacturerManager.GetById(manId, false);
            cboNguonGoc.SelectedValue = manu.CountryIdLookup.ID;

            /*
            rowTemp["ProductId"] = objProduct.ID;
            rowTemp["MfgDate"] = objProduct.MfgDate;
            rowTemp["ExpDate"] = objProduct.ExpDate;
            rowTemp["ProductNameId"] = objProduct.ProductNameIdLookup.ID;
            rowTemp["ProdName"] = objProduct.ProductNameIdLookup.ProdName;
            rowTemp["PurchasePrice"] = objProduct.PurchasePrice;
            rowTemp["SalePrice"] = objProduct.SalePrice;
            rowTemp["Discount"] = objProduct.Discount;
            rowTemp["StatusId"] = objProduct.ProductStatusIdLookup.ID;
            rowTemp["Status"] = objProduct.ProductStatusIdLookup.StatusName;
            rowTemp["BillPurchaseId"] = objProduct.BillPurchaseId;
            if (objProduct.BillSaleId != null) rowTemp["BillSaleId"] = objProduct.BillSaleId;
            rowTemp["UnitId"] = objProduct.UnitIdLookup.ID;
            rowTemp["Unit"] = objProduct.UnitIdLookup.UnitName;
            dataTableProduct.Rows.Add(rowTemp);
            */
            /*
             gvSanPhamDanhMuc.Rows[selectedRowIndex].Cells["ProductId"].Value;

            txtAddress.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["Address"].Value;
            dateTimeDOB.Value = (DateTime)gvSanPhamDanhMuc.Rows[rowIndex].Cells["Birthday"].Value;
            txtEmail.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["Email"].Value;
            txtFullname.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["Fullname"].Value;
            txtIdCardNo.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["IdCardNo"].Value;
            txtTelNo.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["TelNo"].Value;
            txtProductId.Text = (int)gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductId"].Value + "";
            txtProductname.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["Productname"].Value;
            cbbProductRole.SelectedValue = gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductRoleId"].Value;
            cbbProductStatus.SelectedValue = gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductStatusId"].Value;
            cbbProductTitle.SelectedValue = gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductTitleId"].Value;
            rdMale.Checked = (byte)gvSanPhamDanhMuc.Rows[rowIndex].Cells["Sex"].Value == 1 ? true : false;
            rdFemale.Checked = (byte)gvSanPhamDanhMuc.Rows[rowIndex].Cells["Sex"].Value == 0 ? true : false;
            */

        }

        private void ResetForm()
        {
            /*
            txtAddress.ResetText();
            dateTimeDOB.ResetText();
            txtEmail.ResetText();
            txtFullname.ResetText();
            txtIdCardNo.ResetText();
            txtTelNo.ResetText();
            txtProductId.ResetText();
            txtProductname.ResetText();
            cbbProductRole.ResetText();
            cbbProductStatus.ResetText();
            cbbProductTitle.ResetText();
            rdMale.ResetText();
            rdFemale.ResetText();
             */
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (chkSearchAll.Checked == true)
            {
                DisplaySearchAll();
            }
            else
            {

                chkSearchEmail.Checked = false;
                chkSearchFullname.Checked = false;
                //chkSearchIdCardNo.Checked = false;
                //chkSearchTelNo.Checked = false;
                //chkSearchDOB.Checked = false;
                chkSearchProductId.Checked = false;
                chkSearchProductname.Checked = false;
                //chkSearchProductRole.Checked = false;
                //chkSearchProductStatus.Checked = false;
                //chkSearchProductTitle.Checked = false;
            } */
        }

        private void DisplaySearchAll()
        {
            //chkSearchDOB.Checked = true;
            //chkSearchEmail.Checked = true;
            //chkSearchFullname.Checked = true;
            //chkSearchIdCardNo.Checked = true;
            //chkSearchTelNo.Checked = true;
            //chkSearchProductId.Checked = true;
            //chkSearchProductname.Checked = true;
            //chkSearchProductRole.Checked = true;
            //chkSearchProductStatus.Checked = true;
            //chkSearchProductTitle.Checked = true;
        }

        private bool KiemTraDuLieu()
        {
           
            //kiem tra loai san pham duoc lua chon
            if (cboLoaiSanPham.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa lựa chọn loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiSanPham.Focus();
                return false;
            }

            //kiem tra don vi duoc lua chon
            if (cboDonVi.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa lựa chọn đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDonVi.Focus();
                return false;
            }

            //kiem tra nguon goc duoc lua chon
            if (cboNguonGoc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa lựa chọn nguồn gốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNguonGoc.Focus();
                return false;
            }

            //kiem tra nha san xuat
            if (cboNhaSanXuat.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa lựa chọn nhà sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhaSanXuat.Focus();
                return false;
            }

            return true;
        }

        private void btnDongQuanLy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXoaQuanLy_Click(object sender, EventArgs e)
        {
            //if (txtMaSanPham.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa lựa chọn sản phẩm để cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //int MaSanPham = Int32.Parse(txtMaSanPham.Text);

            //string CauLenh = "";

            ////cap nhat du lieu trong bang SanPham
            //CauLenh = "delete SanPham where MaSanPham=" + MaSanPham;
            //ht.CapNhatDuLieu(CauLenh);

            //CauLenh = CauLenh = "select SanPham.MaSanPham, SanPham.TenSanPham, LoaiSanPham.MaLoaiSanPham, DonVi.MaDonVi, QuocGia.MaQuocGia, NhaSanXuat.MaNhaSanXuat, NhaCungCap.MaNhaCungCap, SanPham.MoTa from SanPham, LoaiSanPham, DonVi, QuocGia, NhaSanXuat, NhaCungCap, ChiTietSanPham where (SanPham.MaLoaiSanPham=LoaiSanPham.MaLoaiSanPham) and (SanPham.MaSanPham=ChiTietSanPham.MaSanPham) and (QuocGia.MaQuocGia=ChiTietSanPham.MaQuocGia)and (DonVi.MaDonVi=ChiTietSanPham.MaDonVi) and (NhaSanXuat.MaNhaSanXuat=ChiTietSanPham.MaNhaSanXuat) and (NhaCungCap.MaNhaCungCap=ChiTietSanPham.MaNhaCungCap)";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTimKiemQuanLy_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa đánh vào từ tìm kiếm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBoxSearch.Focus();
                return;
            }

            if (DieuKienTimKiem().Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn điều kiện tìm kiếm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBoxSearch.Focus();
                textBoxSearch.SelectAll();
                return;
            }

            string CauLenh = "";
            CauLenh = CauLenh = "select SanPham.MaSanPham, SanPham.TenSanPham, LoaiSanPham.MaLoaiSanPham, DonVi.MaDonVi, QuocGia.MaQuocGia, NhaSanXuat.MaNhaSanXuat, NhaCungCap.MaNhaCungCap, SanPham.MoTa from SanPham, LoaiSanPham, DonVi, QuocGia, NhaSanXuat, NhaCungCap, ChiTietSanPham where (SanPham.MaLoaiSanPham=LoaiSanPham.MaLoaiSanPham) and (SanPham.MaSanPham=ChiTietSanPham.MaSanPham) and (QuocGia.MaQuocGia=ChiTietSanPham.MaQuocGia)and (DonVi.MaDonVi=ChiTietSanPham.MaDonVi) and (NhaSanXuat.MaNhaSanXuat=ChiTietSanPham.MaNhaSanXuat) and (NhaCungCap.MaNhaCungCap=ChiTietSanPham.MaNhaCungCap)";
            ht.HienThiVaoDataGridView(gvSanPhamDanhMuc, CauLenh);
        }

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            //if (!KiemTraDuLieu()) return;

            //string CauLenh = "";

            ////cap nhat du lieu trong bang SanPham
            //CauLenh = "insert SanPham(TenSanPham,MaLoaiSanPham,MoTa) values(N'" + txtTenSanPham.Text + "'," + cboLoaiSanPham.SelectedValue.ToString() + ",N'" + txtMoTa.Text + "')";
            //ht.CapNhatDuLieu(CauLenh);

            //Int32 MaSanPham = 0;
            //MaSanPham = ht.LayGiaTriTruongKhoaVuaChen("SanPham", "MaSanPham");

            //Int32 MaDonVi=0, MaQuocGia=0, MaNhaSanXuat=0;
            //MaDonVi = (Int32)cboDonVi.SelectedValue;
            //MaQuocGia = (Int32)cboNguonGoc.SelectedValue;
            //MaNhaSanXuat = (Int32)cboNhaSanXuat.SelectedValue;

            //CauLenh = "insert ChiTietSanPham(MaSanPham,MaDonVi,MaQuocGia,MaNhaSanXuat) values(" + MaSanPham + "," + MaDonVi + "," + MaQuocGia + "," + MaNhaSanXuat + ")";
            //ht.CapNhatDuLieu(CauLenh);

            //CauLenh = "select SanPham.MaSanPham as [Mã sản phẩm], SanPham.TenSanPham as [Tên sản phẩm], LoaiSanPham.LoaiSanPham as [Loại sản phẩm], DonVi.DonVi as [Đơn vị], QuocGia.QuocGia as [Quốc gia], NhaSanXuat.TenNhaSanXuat [Nhà sản xuất], SanPham.MoTa as [Mô tả] from SanPham, LoaiSanPham, DonVi, QuocGia, NhaSanXuat, ChiTietSanPham where (SanPham.MaLoaiSanPham=LoaiSanPham.MaLoaiSanPham) and (SanPham.MaSanPham=ChiTietSanPham.MaSanPham) and (QuocGia.MaQuocGia=ChiTietSanPham.MaQuocGia)and (DonVi.MaDonVi=ChiTietSanPham.MaDonVi) and (NhaSanXuat.MaNhaSanXuat=ChiTietSanPham.MaNhaSanXuat)";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void dgvQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //textBoxMaSanPham.Text = gvSanPhamDanhMuc.Rows[e.RowIndex].Cells[0].Value.ToString();
            //textBoxMota.Text = gvSanPhamDanhMuc.Rows[e.RowIndex].Cells[6].Value.ToString();

            if (gvSanPhamDanhMuc.SelectedCells.Count > 0)
            {
                btnThemQuanLy.TextAlign = ContentAlignment.MiddleRight;
                btnThemQuanLy.Text = "&Cập Nhật";
                btnThemQuanLy.ImageIndex = 2;
                int selectedRowIndex = gvSanPhamDanhMuc.SelectedCells[0].RowIndex;
                BindingProductToForm(selectedRowIndex);
            }

            ////txtTenSanPham.Text = gvSanPhamDanhMuc.Rows[e.RowIndex].Cells[1].Value.ToString();
            //cboLoaiSanPham.SelectedIndex = cboLoaiSanPham.FindStringExact(gvSanPhamDanhMuc.Rows[e.RowIndex].Cells[2].Value.ToString());
            //cboDonVi.SelectedIndex = cboDonVi.FindStringExact(gvSanPhamDanhMuc.Rows[e.RowIndex].Cells[3].Value.ToString());
            //cboNguonGoc.SelectedIndex = cboNguonGoc.FindStringExact(gvSanPhamDanhMuc.Rows[e.RowIndex].Cells[4].Value.ToString());
            //cboNhaSanXuat.SelectedIndex = cboNhaSanXuat.FindStringExact(gvSanPhamDanhMuc.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void btnCapNhatQuanLy_Click(object sender, EventArgs e)
        {
            //if (txtMaSanPham.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa lựa chọn sản phẩm để cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //int MaSanPham = Int32.Parse(txtMaSanPham.Text);

            //if (!KiemTraDuLieu()) return;

            //string CauLenh = "";

            ////cap nhat du lieu trong bang SanPham
            //CauLenh = "update SanPham set TenSanPham=N'" + txtTenSanPham.Text + "', MaLoaiSanPham=" + cboLoaiSanPham.SelectedValue.ToString() + ", MoTa=N'" + txtMoTa.Text + "' where MaSanPham="+MaSanPham;
            //ht.CapNhatDuLieu(CauLenh);

            //string DonVi, NguonGoc, NhaSanXuat;
            //DonVi = dgvQuanLy.Rows[DongHienTai].Cells[3].Value.ToString();
            //NguonGoc = dgvQuanLy.Rows[DongHienTai].Cells[4].Value.ToString();
            //NhaSanXuat = dgvQuanLy.Rows[DongHienTai].Cells[5].Value.ToString();

            //CauLenh = "update ChiTietSanPham set MaSanPham=" + MaSanPham + ", MaDonVi=" + cboDonVi.SelectedValue + ",MaQuocGia=" + cboNguonGoc.SelectedValue + ",MaNhaSanXuat=" + cboNhaSanXuat.SelectedValue + " where (MaSanPham="+MaSanPham+") and (MaDonVi="+ht.LayVeKhoa("DonVi","MaDonVi","DonVi",DonVi)+") and (MaQuocGia="+ht.LayVeKhoa("QuocGia","MaQuocGia","QuocGia",NguonGoc)+") and (MaNhaSanXuat="+ht.LayVeKhoa("NhaSanXuat","MaNhaSanXuat","TenNhaSanXuat",NhaSanXuat)+")";
            //ht.CapNhatDuLieu(CauLenh);

            //CauLenh = "select SanPham.MaSanPham as [Mã sản phẩm], SanPham.TenSanPham as [Tên sản phẩm], LoaiSanPham.LoaiSanPham as [Loại sản phẩm], DonVi.DonVi as [Đơn vị], QuocGia.QuocGia as [Quốc gia], NhaSanXuat.TenNhaSanXuat [Nhà sản xuất], SanPham.MoTa as [Mô tả] from SanPham, LoaiSanPham, DonVi, QuocGia, NhaSanXuat, ChiTietSanPham where (SanPham.MaLoaiSanPham=LoaiSanPham.MaLoaiSanPham) and (SanPham.MaSanPham=ChiTietSanPham.MaSanPham) and (QuocGia.MaQuocGia=ChiTietSanPham.MaQuocGia)and (DonVi.MaDonVi=ChiTietSanPham.MaDonVi) and (NhaSanXuat.MaNhaSanXuat=ChiTietSanPham.MaNhaSanXuat)";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaTrangQuanLy_Click(object sender, EventArgs e)
        {
            btnThemQuanLy.TextAlign = ContentAlignment.MiddleRight;
            btnThemQuanLy.Text = "&Thêm mới";
            btnThemQuanLy.ImageIndex = 1;
            
            textBoxMaSanPham.Text = "";
            textBoxMota.Text = "";
            textBoxGiaBan.Text = "";
            textBoxGiamGia.Text = "";
            textBoxGiaMua.Text = "";
            textBoxMota.Text = "";
            
            cboTenSanPham.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            cboDonVi.SelectedIndex = -1;
            cboLoaiSanPham.SelectedIndex = -1;
            cboNguonGoc.SelectedIndex = -1;
            cboNhaSanXuat.SelectedIndex = -1;

            
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select SanPham.MaSanPham as [Mã sản phẩm], SanPham.TenSanPham as [Tên sản phẩm], LoaiSanPham.LoaiSanPham as [Loại sản phẩm], DonVi.DonVi as [Đơn vị], QuocGia.QuocGia as [Quốc gia], NhaSanXuat.TenNhaSanXuat [Nhà sản xuất], SanPham.MoTa as [Mô tả] from SanPham, LoaiSanPham, DonVi, QuocGia, NhaSanXuat, ChiTietSanPham where (SanPham.MaLoaiSanPham=LoaiSanPham.MaLoaiSanPham) and (SanPham.MaSanPham=ChiTietSanPham.MaSanPham) and (QuocGia.MaQuocGia=ChiTietSanPham.MaQuocGia)and (DonVi.MaDonVi=ChiTietSanPham.MaDonVi) and (NhaSanXuat.MaNhaSanXuat=ChiTietSanPham.MaNhaSanXuat)";
            ht.HienThiVaoDataGridView(gvSanPhamDanhMuc, CauLenh);
        }

        private void btnDongQuanLy_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThemQuanLySanPham_Click(object sender, EventArgs e)
        {
            


        }

        private void btnCapNhatQuanLySanPham_Click(object sender, EventArgs e)
        {
            ht = new HoTro();
            //SqlCommand command = new SqlCommand("update Product set CategoryId = @CategoryId, Giaban= @Giaban,Mota = @Mota where ProductId=@ProductId");
      
            int maTenSP = ht.LayVeKhoa("ProductName", "ProductNameId", "ProductName", comboBoxTenSanPham.Text) ;
            //command.Parameters.Add("@ProductId", maSP);
            //command.Parameters.Add("@Mota", txtMoTa.Text);
            //command.Parameters.Add("@Giaban", float.Parse(txtGiaban.Text));
            //command.Parameters.Add("@CategoryId", ht.LayVeKhoa("Category", "CategoryId", "CategoryName", cboLoaiSanPhamQuanLySanPham.Text));
            //ht.CapNhatDuLieu(command);

            SqlCommand command = new SqlCommand("update Product set salePrice= @Giaban where ProdNameId=@ProductNameId");
            command.Parameters.Add("@ProductNameId", maTenSP);
            command.Parameters.Add("@Giaban", txtGiaban.Text);
            ht.CapNhatDuLieu(command);
            MessageBox.Show("updated");
        }

        private void tpQuanLySanPham_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}