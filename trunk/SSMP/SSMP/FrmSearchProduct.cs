using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SSMP.Data.Manager;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using log4net;

namespace SSMP
{
    public partial class FrmSearchProduct : Form
    {
        //Parent form
        private FrmDanhMucSanPham frmParent;

        //Manager object
        private ProductManager productManager;
        private ProductNameManager productNameManager;
        private CategoryManager categoryManager;
        private UnitManager unitManager;
        private CountryManager countryManager;
        private ManufacturerManager manufacturerManager;
        private ProductStatusManager productStatusManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmSearchProduct));

        public FrmSearchProduct(FrmDanhMucSanPham frmParent)
        {
            InitializeComponent();

            productManager = new ProductManager();
            productNameManager = new ProductNameManager();
            categoryManager = new CategoryManager();
            unitManager = new UnitManager();
            countryManager = new CountryManager();
            manufacturerManager = new ManufacturerManager();
            productStatusManager = new ProductStatusManager();

            this.frmParent = frmParent;
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {
            cboTenSanPham.DataSource = productNameManager.GetAll();
            cboTenSanPham.DisplayMember = "ProdName";
            cboTenSanPham.ValueMember = "ID";
            cboTenSanPham.SelectedIndex = -1;

            cboLoaiSanPham.DataSource = categoryManager.GetAll();
            cboLoaiSanPham.DisplayMember = "CategoryName";
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.SelectedIndex = -1;

            cboDonVi.DataSource = unitManager.GetAll();
            cboDonVi.DisplayMember = "UnitName";
            cboDonVi.ValueMember = "ID";
            cboDonVi.SelectedIndex = -1;

            cboNguonGoc.DataSource = countryManager.GetAll();
            cboNguonGoc.DisplayMember = "CountryName";
            cboNguonGoc.ValueMember = "ID";
            cboNguonGoc.SelectedIndex = -1;

            cboNhaSanXuat.DataSource = manufacturerManager.GetAll();
            cboNhaSanXuat.DisplayMember = "ManName";
            cboNhaSanXuat.ValueMember = "ID";
            cboNhaSanXuat.SelectedIndex = -1;

            cboTrangThai.DataSource = productStatusManager.GetAll();
            cboTrangThai.DisplayMember = "StatusName";
            cboTrangThai.ValueMember = "ID";
            cboTrangThai.SelectedIndex = -1;

            cboDieuKienGiaBan.DataSource = Constants.GetListDieuKien();
            cboDieuKienGiaBan.DisplayMember = "Text";
            cboDieuKienGiaBan.ValueMember = "Value";
            cboDieuKienGiaBan.SelectedIndex = 3;

            cboDieuKienGiaMua.DataSource = Constants.GetListDieuKien();
            cboDieuKienGiaMua.DisplayMember = "Text";
            cboDieuKienGiaMua.ValueMember = "Value";
            cboDieuKienGiaMua.SelectedIndex = 3;

            cboDieuKienGiamGia.DataSource = Constants.GetListDieuKien();
            cboDieuKienGiamGia.DisplayMember = "Text";
            cboDieuKienGiamGia.ValueMember = "Value";
            cboDieuKienGiamGia.SelectedIndex = 3;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Product searchProduct = new Product();

            if (cboTenSanPham.SelectedIndex >= 0)
            {
                int pnID = Int32.Parse(cboTenSanPham.SelectedValue.ToString());
                searchProduct.ProductNameId = pnID;
            }

            if (cboLoaiSanPham.SelectedIndex >= 0)
            {
                int catID = Int32.Parse(cboLoaiSanPham.SelectedValue.ToString());
                searchProduct.SearchCategoryID = catID;
            }

            if (cboDonVi.SelectedIndex >= 0)
            {
                int unitID = Int32.Parse(cboDonVi.SelectedValue.ToString());
                searchProduct.UnitId = unitID;
            }

            if (cboNguonGoc.SelectedIndex >= 0)
            {
                int countryID = Int32.Parse(cboNguonGoc.SelectedValue.ToString());
                searchProduct.SearchCountryID = countryID;
            }

            if (cboNhaSanXuat.SelectedIndex >= 0)
            {
                int manID = Int32.Parse(cboNhaSanXuat.SelectedValue.ToString());
                searchProduct.SearchManufacturerID = manID;
            }

            if (cboTrangThai.SelectedIndex >= 0)
            {
                int statusID = Int32.Parse(cboTrangThai.SelectedValue.ToString());
                searchProduct.StatusId = statusID;
            }

            if (dateTimeNgaySXFrom.Value <= dateTimeNgaySXTo.Value)
            {
                searchProduct.MfgDateFrom = dateTimeNgaySXFrom.Value;
                searchProduct.MfgDateTo = dateTimeNgaySXTo.Value;
            }

            if (dateTimeNgayHetHanFrom.Value <= dateTimeNgayHetHanTo.Value)
            {
                searchProduct.ExpDateFrom = dateTimeNgayHetHanFrom.Value;
                searchProduct.ExpDateTo = dateTimeNgayHetHanTo.Value;
            }

            if (!string.IsNullOrEmpty(txtGiaBanFrom.Text))
            {
                searchProduct.SalePriceFrom = Int32.Parse(txtGiaBanFrom.Text);
            }
            if (!string.IsNullOrEmpty(txtGiaBanTo.Text))
            {
                searchProduct.SalePriceTo = Int32.Parse(txtGiaBanTo.Text);
            }
            if (cboDieuKienGiaBan.SelectedValue != null)
            {
                searchProduct.SalePriceCompare = Int32.Parse(cboDieuKienGiaBan.SelectedValue.ToString());
            }            

            if (!string.IsNullOrEmpty(txtGiaMuaFrom.Text))
            {
                searchProduct.PurchasePriceFrom = Int32.Parse(txtGiaMuaFrom.Text);
            }
            if (!string.IsNullOrEmpty(txtGiaMuaTo.Text))
            {
                searchProduct.PurchasePriceTo = Int32.Parse(txtGiaMuaTo.Text);
            }
            if (cboDieuKienGiaMua.SelectedValue != null)
            {
                searchProduct.PurchasePriceCompare = Int32.Parse(cboDieuKienGiaMua.SelectedValue.ToString());
            }

            if (!string.IsNullOrEmpty(txtGiamGiaFrom.Text))
            {
                searchProduct.DiscountFrom = Int32.Parse(txtGiamGiaFrom.Text);
            }
            if (!string.IsNullOrEmpty(txtGiamGiaTo.Text))
            {
                searchProduct.DiscountTo = Int32.Parse(txtGiamGiaTo.Text);
            }
            if (cboDieuKienGiamGia.SelectedValue != null)
            {
                searchProduct.DiscountCompare = Int32.Parse(cboDieuKienGiamGia.SelectedValue.ToString());
            }            
            
            frmParent.AdvanceSearchProduct(searchProduct);
            //this.Close();
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void cboDieuKienGiaMua_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (Int32.TryParse(cboDieuKienGiaMua.SelectedValue.ToString(), out value))
            {
                switch (value)
                {
                    case 0:
                        lblTuGiaMua.Text = " = ";
                        lblDenGiaMua.Hide();
                        txtGiaMuaTo.Hide();
                        break;
                    case 1:
                        lblTuGiaMua.Text = " <= ";
                        lblDenGiaMua.Hide();
                        txtGiaMuaTo.Hide();
                        break;
                    case 2:
                        lblTuGiaMua.Text = " >= ";
                        lblDenGiaMua.Hide();
                        txtGiaMuaTo.Hide();
                        break;
                    case 3:
                        lblTuGiaMua.Text = "Từ";
                        lblDenGiaMua.Show();
                        txtGiaMuaTo.Show();
                        break;
                    default:
                        lblTuGiaMua.Text = "";
                        lblDenGiaMua.Hide();
                        txtGiaMuaTo.Hide();
                        break;
                }
            }
        }

        private void cboDieuKienGiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (Int32.TryParse(cboDieuKienGiaBan.SelectedValue.ToString(), out value))
            {
                switch (value)
                {
                    case 0:
                        lblTuGiaBan.Text = " = ";
                        lblDenGiaBan.Hide();
                        txtGiaBanTo.Hide();
                        break;
                    case 1:
                        lblTuGiaBan.Text = " <= ";
                        lblDenGiaBan.Hide();
                        txtGiaBanTo.Hide();
                        break;
                    case 2:
                        lblTuGiaBan.Text = " >= ";
                        lblDenGiaBan.Hide();
                        txtGiaBanTo.Hide();
                        break;
                    case 3:
                        lblTuGiaBan.Text = "Từ";
                        lblDenGiaBan.Show();
                        txtGiaBanTo.Show();
                        break;
                    default:
                        lblTuGiaBan.Text = "";
                        lblDenGiaBan.Hide();
                        txtGiaBanTo.Hide();
                        break;
                }
            }
        }

        private void cboDieuKienGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (Int32.TryParse(cboDieuKienGiamGia.SelectedValue.ToString(), out value))
            {
                switch (value)
                {
                    case 0:
                        lblTuGiamGia.Text = " = ";
                        lblDenGiamGia.Hide();
                        txtGiamGiaTo.Hide();
                        break;
                    case 1:
                        lblTuGiamGia.Text = " <= ";
                        lblDenGiamGia.Hide();
                        txtGiamGiaTo.Hide();
                        break;
                    case 2:
                        lblTuGiamGia.Text = " >= ";
                        lblDenGiamGia.Hide();
                        txtGiamGiaTo.Hide();
                        break;
                    case 3:
                        lblTuGiamGia.Text = "Từ";
                        lblDenGiamGia.Show();
                        txtGiamGiaTo.Show();
                        break;
                    default:
                        lblTuGiamGia.Text = "";
                        lblDenGiamGia.Hide();
                        txtGiamGiaTo.Hide();
                        break;
                }
            }
        }
    }
}