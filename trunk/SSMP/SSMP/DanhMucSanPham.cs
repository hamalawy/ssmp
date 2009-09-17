﻿using System;
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
        private Int64 updateProductId;
        private Int64 updateProductNameId;

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
                //comboBoxTenSanPham.DataSource = productNameManager.GetAll();
                //comboBoxTenSanPham.DisplayMember = "ProdName";
                //comboBoxTenSanPham.ValueMember = "ID";

                comboBoxLoaiSanPham.DataSource = categoryManager.GetAll();
                comboBoxLoaiSanPham.DisplayMember = "CategoryName";
                comboBoxLoaiSanPham.ValueMember = "ID";

                comboBoxNhasx.DataSource = manufacturerManager.GetAll();
                comboBoxNhasx.DisplayMember = "ManName";
                comboBoxNhasx.ValueMember = "ID";

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

                //int khoa = Int32.Parse(cboTenSanPham.SelectedValue.ToString());
                //ProductName productName = productNameManager.GetById(khoa, true);
                //cboLoaiSanPham.SelectedValue = productName.CategoryIdLookup.ID;
                //cboNhaSanXuat.SelectedValue = productName.ManIdLookup.ID;
                //Manufacturer man = manufacturerManager.GetById(productName.ManIdLookup.ID, true);
                //cboNguonGoc.SelectedValue = man.CountryIdLookup.ID;

                //xoaTrang();

                //Display all column in gridview
                DisplayAll();

                //BindingProductToForm(0);
                //updateProductId = (Int64)gvSanPhamDanhMuc.Rows[0].Cells["ProductId"].Value;

                //BindingProductNameToForm(0);
                //updateProductNameId = (Int32)gvTenSanPham.Rows[0].Cells["ProductNameId"].Value;
            }
            catch (Exception ex)
            {
                logger.Debug(ex.Message);
                logger.Debug(ex.StackTrace);
                MessageBox.Show(ex.StackTrace);
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

            bindingNavigatorProductName.BindingSource = new BindingSource(listPagesProductName, "");
            bindingNavigatorProductName.BindingSource.Position = position;
            bindingNavigatorProductName.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChangedProductName);
            //toolStripLabeltotalProductName.Text = "Tổng số tên sản phẩm: " + sizeOfList;
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
                dataTableProduct.Columns.Add("Description", typeof(string));

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
                    rowTemp["Description"] = objProduct.Description;
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
                gvSanPhamDanhMuc.Columns["Description"].HeaderText = "Mô tả";

                currentListProduct = searchResult.SearchList;
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
                toolStripLblTotal.Text = "Tổng số sản phẩm: " + searchResult.SearchSize;
            }
        }

        private void BindingDataToFormProductName(ProductName entity, SearchParam searchParam, int position)
        {
            SearchResult<ProductName> searchResult = productNameManager.GetProductNameListByParam(entity, searchParam);
            if (searchResult != null)
            {
                DataTable dataTableProductName = new DataTable("ProductName");
                dataTableProductName.Columns.Add("ProductNameId", typeof(Int32));
                dataTableProductName.Columns.Add("ProdName", typeof(string));
                dataTableProductName.Columns.Add("CategoryId", typeof(int));
                dataTableProductName.Columns.Add("CategoryName", typeof(string));
                dataTableProductName.Columns.Add("ManId", typeof(int));
                dataTableProductName.Columns.Add("ManName", typeof(string));
                foreach (ProductName objProduct in searchResult.SearchList)
                {
                    DataRow rowTemp = dataTableProductName.NewRow();
                    rowTemp["ProductNameId"] = objProduct.ID;
                    rowTemp["ProdName"] = objProduct.ProdName;
                    rowTemp["CategoryId"] = objProduct.CategoryIdLookup.ID;
                    rowTemp["CategoryName"] = objProduct.CategoryIdLookup.CategoryName;
                    rowTemp["ManId"] = objProduct.ManIdLookup.ID;
                    rowTemp["ManName"] = objProduct.ManIdLookup.ManName;
                    dataTableProductName.Rows.Add(rowTemp);
                }
                dataSetProductName = new DataSet();
                dataSetProductName.Tables.Add(dataTableProductName);
                gvTenSanPham.DataSource = dataSetProductName;
                gvTenSanPham.DataSource = dataSetProductName;
                gvTenSanPham.DataMember = "ProductName";
                gvTenSanPham.Columns["ProductNameId"].HeaderText = "Mã tên sản phẩm";
                gvTenSanPham.Columns["ProdName"].HeaderText = "Tên sản phẩm";
                gvTenSanPham.Columns["CategoryId"].Visible = false;
                gvTenSanPham.Columns["CategoryName"].HeaderText = "Loại sản phẩm";
                gvTenSanPham.Columns["ManId"].Visible = false;
                gvTenSanPham.Columns["ManName"].HeaderText = "Nhà sản xuất";
                currentListProductName = searchResult.SearchList;
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
                bindingNavigatorProductName.BindingSource = new BindingSource(listPages, "");
                bindingNavigatorProductName.BindingSource.Position = position;
                bindingNavigatorProductName.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChangedProductName);
                toolStripLblTotal.Text = "Tổng số tên sản phẩm: " + searchResult.SearchSize;
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
            dataTableProduct.Columns.Add("Description", typeof(string));

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
            gvSanPhamDanhMuc.Columns["Description"].HeaderText = "Mô tả";

            // ============================================================


            //Create DataTable of ProductName
            DataTable dataTableProductName = new DataTable("ProductName");
            dataTableProductName.Columns.Add("ProductNameId", typeof(Int32));
            dataTableProductName.Columns.Add("ProdName", typeof(string));
            dataTableProductName.Columns.Add("CategoryId", typeof(int));
            dataTableProductName.Columns.Add("CategoryName", typeof(string));
            dataTableProductName.Columns.Add("ManId", typeof(int));
            dataTableProductName.Columns.Add("ManName", typeof(string));

            //Create DataSet of ProductName
            dataSetProductName = new DataSet();
            dataSetProductName.Tables.Add(dataTableProductName);

            //Config detail of column in grid view            
            gvTenSanPham.DataSource = dataSetProductName;
            gvTenSanPham.DataMember = "ProductName";
            gvTenSanPham.Columns["ProductNameId"].HeaderText = "Mã tên sản phẩm";
            gvTenSanPham.Columns["ProdName"].HeaderText = "Tên sản phẩm";
            gvTenSanPham.Columns["CategoryId"].Visible = false;
            gvTenSanPham.Columns["CategoryName"].HeaderText = "Loại sản phẩm";
            gvTenSanPham.Columns["ManId"].Visible = false;
            gvTenSanPham.Columns["ManName"].HeaderText = "Nhà sản xuất";    
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
                    rowTemp["Description"] = objProduct.Description;
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

        //
        private void toolStripBtnProductNameFirstItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + bindingNavigatorProductName.BindingSource.Position);
            //MoveItemProductName(bindingNavigatorProductName.BindingSource.Position);
        }

        private void toolStripBtnProductNamePreviousItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + bindingNavigatorProductName.BindingSource.Position);
            MoveItemProductName(bindingNavigatorProductName.BindingSource.Position);
        }

        private void toolStripBtnProductNameNextItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + bindingNavigatorProductName.BindingSource.Position);
            MoveItemProductName(bindingNavigatorProductName.BindingSource.Position);
        }

        private void toolStripBtnProductNameLastItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + bindingNavigatorProductName.BindingSource.Position);
            MoveItemProductName(bindingNavigatorProductName.BindingSource.Position);
        }
        //

        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProduct.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProduct.BindingSource.Position);
        }

        private void BindingSource_PositionChangedProductName(object sender, EventArgs e)
        {
            MoveItemProductName(bindingNavigatorProductName.BindingSource.Position);
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

        private void MoveItemProductName(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorProductName.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;
            this.BindingDataToFormProductName(searchEntityProductName, searchParam, position);
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
        public void RefreshGridViewProductNames()
        {
            ProductName entity = new ProductName();
            SearchParam searchParam = new SearchParam();
            searchParam.Start = DEFAULT_START;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;
            this.BindingDataToFormProductName(entity, searchParam, 0);
            bindingNavigatorProductName.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);
        }

        #endregion

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {/*
            try
            {
                Product productEntity;

                if (MODE == Constants.MODE.ADD)
                {
                    productEntity = new Product();
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

                    productEntity = currentListProduct[idxInList];
                }
                else
                {
                    productEntity = new Product();
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
                    productEntity.FullName = strFullname;
                    productEntity.Productname = strProductname;
                    productEntity.Password = new HoTro().DoiSangMaMD5(strPassword);
                    productEntity.ProductTitleId = valueTitle;
                    productEntity.ProductRoleId = valueRole;
                    productEntity.ProductStatusId = DBConstants.Product.ACTIVE;
                    productEntity.Sex = valueSex;
                    productEntity.Birthday = dateDOB;
                    productEntity.IdCardNo = strIdCardNo;
                    productEntity.TelNo = strTelNo;
                    productEntity.Email = strEmail;
                    productEntity.Address = strAddress;

                    //Do save new entity
                    productManager.SaveOrUpdate(productEntity);

                    //Show message success
                    if (MODE == Constants.MODE.ADD)
                    {
                        MessageBox.Show("Tạo mới người dùng [" + productEntity.ID + " ] thành công", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (MODE == Constants.MODE.UPDATE)
                    {
                        MessageBox.Show("Cập nhật người dùng [" + productEntity.ID + " ] thành công", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            checkBoxHTGiaban.Checked = true;
            checkBoxHTGiamGia.Checked = true;
            checkBoxHTGiaMua.Checked = true;
            checkBoxHTMaBan.Checked = true;
            checkBoxHTMamua.Checked = true;
            checkBoxHTNgayHethan.Checked = true;
            checkBoxHTNgaySx.Checked = true;
            checkBoxHTStatus.Checked = true;
            checkBoxHTMota.Checked = true;
            checkBoxHTTenSp.Checked = true;
            checkBoxHTDonVi.Checked = true;
        }

        private void DisplayAllTenSp()
        {
            chkLoaiSp.Checked = true;
            chkNhaSx.Checked = true;
            chkTenSp.Checked = true;
        }

        private void BindingProductNameToForm(int rowIndex)
        {
            try
            {
                txtId.Text = (Int32)gvTenSanPham.Rows[rowIndex].Cells["ProductNameId"].Value + "";
                txtTenSp.Text = (string)gvTenSanPham.Rows[rowIndex].Cells["ProdName"].Value + "";
                ProductName prdName = productNameManager.GetById(Int32.Parse(txtId.Text), true);
                comboBoxLoaiSanPham.SelectedValue = prdName.CategoryIdLookup.ID;
                comboBoxNhasx.SelectedValue = prdName.ManIdLookup.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void BindingProductToForm(int rowIndex)
        {
            try
            {
                textBoxMaSanPham.Text = (Int64)gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductId"].Value + "";
                if (!gvSanPhamDanhMuc.Rows[rowIndex].Cells["SalePrice"].Value.ToString().Equals(""))
                    textBoxGiaBan.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["SalePrice"].Value + "";
                else textBoxGiaBan.Text = "";
                if (!gvSanPhamDanhMuc.Rows[rowIndex].Cells["Discount"].Value.ToString().Equals(""))
                    textBoxGiamGia.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["Discount"].Value + "";
                else textBoxGiamGia.Text = "";
                textBoxGiaMua.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["PurchasePrice"].Value + "";
                Object productNameId = gvSanPhamDanhMuc.Rows[rowIndex].Cells["ProductNameId"].Value;
                cboTenSanPham.SelectedValue = productNameId;
                cboTrangThai.SelectedValue = gvSanPhamDanhMuc.Rows[rowIndex].Cells["StatusId"].Value;
                cboDonVi.SelectedValue = gvSanPhamDanhMuc.Rows[rowIndex].Cells["UnitId"].Value;
                dateTimePickerSx.Value = (DateTime)gvSanPhamDanhMuc.Rows[rowIndex].Cells["MfgDate"].Value;
                dateTimePickerHetHan.Value = (DateTime)gvSanPhamDanhMuc.Rows[rowIndex].Cells["ExpDate"].Value;
                if (!gvSanPhamDanhMuc.Rows[rowIndex].Cells["Description"].Value.ToString().Equals(""))
                    textBoxMota.Text = (string)gvSanPhamDanhMuc.Rows[rowIndex].Cells["Description"].Value + "";
                else textBoxMota.Text = "";
                ProductName prdName = productNameManager.GetById((int)productNameId, true);
                cboLoaiSanPham.SelectedValue = prdName.CategoryIdLookup.ID;
                int manId = prdName.ManIdLookup.ID;
                cboNhaSanXuat.SelectedValue = manId;

                Manufacturer manu = manufacturerManager.GetById(manId, false);
                cboNguonGoc.SelectedValue = manu.CountryIdLookup.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
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
            try
            {
                int idxInList = -1;
                foreach (Product objProduct in currentListProduct)
                {
                    if (objProduct.ID == updateProductId)
                    {
                        idxInList = currentListProduct.IndexOf(objProduct);
                    }
                }
                Product productEntity = currentListProduct[idxInList];
                int IdName = (int) cboTenSanPham.SelectedValue ;
                DateTime ngaySX = dateTimePickerSx.Value;
                DateTime ngayHH = dateTimePickerHetHan.Value;
                String giaMua = textBoxGiaMua.Text;
                String giaBan = textBoxGiaBan.Text;
                int giamGia = 0;
                int donViId = (int) cboDonVi.SelectedValue;
                int trangThaiId = (int)cboTrangThai.SelectedValue;
                try
                {
                    Int64.Parse(giaMua);
                    Int64.Parse(giaBan);
                    giamGia = Int32.Parse(textBoxGiamGia.Text);
                }
                catch (Exception ex) {
                    MessageBox.Show("Giá nhập không đúng. Vui lòng nhập lại", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                productEntity.ProductNameId = IdName;
                productEntity.MfgDate = ngaySX;
                productEntity.ExpDate = ngayHH;
                productEntity.PurchasePrice = giaMua;
                productEntity.SalePrice = giaBan;
                productEntity.Discount = giamGia;
                productEntity.UnitId = donViId;
                productEntity.StatusId = trangThaiId;

                //Do save new entity
                productManager.SaveOrUpdate(productEntity);
                //Show message success

                MessageBox.Show("Cập nhật sản phẩm [" + productEntity.ID + " ] thành công", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ResetForm();                

                //Refresh grid view after insert successfully
                this.RefreshGridViewProducts();
                
            }
            catch (Exception ex)
            {
                logger.Debug(ex.Message);
                logger.Debug(ex.StackTrace);
                MessageBox.Show(ex.StackTrace);
            }

            
        }

        private void dgvQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvSanPhamDanhMuc.SelectedCells.Count > 0)
            {
                try
                {
                    int selectedRowIndex = gvSanPhamDanhMuc.SelectedCells[0].RowIndex;
                    BindingProductToForm(selectedRowIndex);
                    updateProductId = (Int64)gvSanPhamDanhMuc.Rows[selectedRowIndex].Cells["ProductId"].Value;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.StackTrace);
                }
                
            }
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
            xoaTrang();
        }

        private void xoaTrang() {
            textBoxMaSanPham.Text = "";
            textBoxMota.Text = "";
            textBoxGiaBan.Text = "";
            textBoxGiamGia.Text = "";
            textBoxGiaMua.Text = "";
            textBoxMota.Text = "";

            cboTenSanPham.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            cboDonVi.SelectedIndex = 0;
            updateProductId = 0;
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            searchEntity = new Product();
            SearchResult<Product> searchResult = productManager.GetProductListByParam(searchEntity, searchParam);
            currentListProduct = searchResult.SearchList;

            //Binding list product to gridview
            dataSetProduct.Clear();
            IList2DataTable(currentListProduct, dataSetProduct.Tables["Product"]);

            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void btnDongQuanLy_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThemQuanLySanPham_Click(object sender, EventArgs e)
        {
            try
            {
                ProductName productNameEntity;

                if (MODE == Constants.MODE.ADD)
                {
                    productNameEntity = new ProductName();
                }
                else if (MODE == Constants.MODE.UPDATE)
                {
                    int idxInList = -1;

                    foreach (ProductName objProductName in currentListProductName)
                    {
                        if (objProductName.ID == updateProductNameId)
                        {
                            idxInList = currentListProductName.IndexOf(objProductName);
                        }
                    }
                    productNameEntity = currentListProductName[idxInList];
                }
                else
                {
                    productNameEntity = new ProductName();
                }

                string tenSp = txtTenSp.Text;
                int loaiSp = (int)comboBoxLoaiSanPham.SelectedValue;
                int nhasx = (int)comboBoxNhasx.SelectedValue;
                string giaban = txtGiaban.Text;

                //if (strPassword != strPasswordConfirm)
                //{
                //    MessageBox.Show("Mật khẩu không trùng nhau. Vui lòng nhập lại", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
    
                productNameEntity.ProdName = tenSp;
                productNameEntity.CategoryId = loaiSp;
                productNameEntity.ManId = nhasx;
          
                //Do save new entity
                productNameManager.SaveOrUpdate(productNameEntity);

                //Show message success
                if (MODE == Constants.MODE.ADD)
                {
                    MessageBox.Show("Tạo mới tên sản phẩm [" + productNameEntity.ID + " ] thành công", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MODE == Constants.MODE.UPDATE)
                {
                    ht = new HoTro();
                    int maTenSP = productNameEntity.ID;
                    if (txtGiaban.Text.Length != 0) {
                        SqlCommand command = new SqlCommand("update Product set salePrice= @Giaban where ProductNameId=@ProductNameId");
                        command.Parameters.Add("@ProductNameId", maTenSP);
                        command.Parameters.Add("@Giaban", giaban);
                        ht.CapNhatDuLieu(command);
                    }
                    if (txtGiamGia.Text.Length != 0)
                    {
                        SqlCommand command = new SqlCommand("update Product set discount= @GiamGia where ProductNameId=@ProductNameId");
                        command.Parameters.Add("@ProductNameId", maTenSP);
                        command.Parameters.Add("@GiamGia", Int32.Parse(txtGiamGia.Text));
                        ht.CapNhatDuLieu(command);
                    }                    
                    MessageBox.Show("Cập nhật tên sản phẩm [" + productNameEntity.ID + " ] thành công", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MODE = Constants.MODE.ADD;
                    btnThemTenSanPham.Text = "&Thêm mới";
                    this.ResetForm();
                }

                //Refresh grid view after insert successfully
                this.RefreshGridViewProductNames();
                
            }
            catch (Exception ex)
            {
                logger.Debug(ex.Message);
                logger.Debug(ex.StackTrace);
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }

        }

        private void tpQuanLySanPham_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click_1(object sender, EventArgs e)
        {

        }

        private void gvSanPhamDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int khoa = Int32.Parse(cboTenSanPham.SelectedValue.ToString());            
                ProductName productName = productNameManager.GetById(khoa, true);
                cboLoaiSanPham.SelectedValue = productName.CategoryIdLookup.ID;
                cboNhaSanXuat.SelectedValue = productName.ManIdLookup.ID;
                Manufacturer man = manufacturerManager.GetById(productName.ManIdLookup.ID, true) ;
                cboNguonGoc.SelectedValue = man.CountryIdLookup.ID;
            }
            catch (Exception ex) { }
        }

        private void gvSanPham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvTenSanPham.SelectedCells.Count > 0)
            {
                txtGiaban.Text = "";
                txtGiamGia.Text = "";
                btnThemTenSanPham.TextAlign = ContentAlignment.MiddleRight;
                btnThemTenSanPham.Text = "&Cập Nhật";
                btnThemTenSanPham.ImageIndex = 2;
                int selectedRowIndex = gvTenSanPham.SelectedCells[0].RowIndex;
                BindingProductNameToForm(selectedRowIndex);
                MODE = Constants.MODE.UPDATE;
                updateProductNameId = (Int32)gvTenSanPham.Rows[selectedRowIndex].Cells["ProductNameId"].Value;
            }
        }

        private void btnXoaTrangQuanLySanPham_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtGiaban.Text = "";
            txtTenSp.Text = "";
            comboBoxLoaiSanPham.SelectedIndex = -1;
            comboBoxNhasx.SelectedIndex = -1;

            btnThemTenSanPham.Text = "&Thêm mới";
            btnThemTenSanPham.ImageIndex = 1;
            MODE = Constants.MODE.ADD;
        }

        private void btnTaiLaiTatCaQuanLySanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiLaiQuanLySanPham_Click(object sender, EventArgs e)
        {
            searchEntityProductName = new ProductName();
            SearchResult<ProductName> searchResult = productNameManager.GetProductNameListByParam(searchEntityProductName, searchParamProductName);
            currentListProductName = searchResult.SearchList;

            //Binding list product name to gridview
            dataSetProductName.Clear();
            IList2DataTableProductName(currentListProductName, dataSetProductName.Tables["ProductName"]);
            listPagesProductName = new List<Int32>();
            BindingDataToBindingNagivatorProductName(searchResult.SearchSize, 0);
        }

        private void toolStripButtonNextProdcutName_Click(object sender, EventArgs e)
        {

        }

        private void chkTenSp_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvTenSanPham, chkTenSp, "ProdName");
        }

        private void chkId_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkLoaiSp_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvTenSanPham, chkLoaiSp, "CategoryName");
        }

        private void chkNhaSx_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvTenSanPham, chkNhaSx, "ManName");
        }

        private void chkTatCaHienThiTenSanPham_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTatCaHienThiTenSanPham.Checked == true)
            {
                DisplayAllTenSp();
            }
            else
            {
                chkLoaiSp.Checked = false;
                chkNhaSx.Checked = false;
                chkTenSp.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                DisplayAll();
            }
            else
            {
                checkBoxHTGiaban.Checked = false;
                checkBoxHTGiamGia.Checked = false;
                checkBoxHTGiaMua.Checked = false;
                checkBoxHTMaBan.Checked = false;
                checkBoxHTMamua.Checked = false;
                checkBoxHTNgayHethan.Checked = false;
                checkBoxHTNgaySx.Checked = false;
                checkBoxHTStatus.Checked = false;
                checkBoxHTMota.Checked = false;
                checkBoxHTTenSp.Checked = false;
                checkBoxHTDonVi.Checked = false;
            }
        }

        private void checkBoxHTNgaySx_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTNgaySx, "MfgDate");
        }

        private void checkBoxHTNgayHethan_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTNgayHethan, "ExpDate");
        }

        private void checkBoxHTTenSp_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTTenSp, "ProdName");
        }

        private void checkBoxHTGiaMua_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTGiaMua, "PurchasePrice");
        }

        private void checkBoxHTGiaban_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTGiaban, "SalePrice");
        }

        private void checkBoxHTGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTGiamGia, "Discount");
        }

        private void checkBoxHTStatus_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTStatus, "Status");
        }

        private void checkBoxHTMamua_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTMamua, "BillPurchaseId");
        }

        private void checkBoxHTMaBan_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTMaBan, "BillSaleId");
        }

        private void checkBoxHTDonVi_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTDonVi, "Unit");
        }

        private void checkBoxHTMota_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvSanPhamDanhMuc, checkBoxHTMota, "Description");
        }
    }
}