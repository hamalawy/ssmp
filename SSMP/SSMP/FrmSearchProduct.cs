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

        public FrmSearchProduct()
        {
            InitializeComponent();

            productManager = new ProductManager();
            productNameManager = new ProductNameManager();
            categoryManager = new CategoryManager();
            unitManager = new UnitManager();
            countryManager = new CountryManager();
            manufacturerManager = new ManufacturerManager();
            productStatusManager = new ProductStatusManager();
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {
            cboTenSanPham.DataSource = productNameManager.GetAll();
            cboTenSanPham.DisplayMember = "ProdName";
            cboTenSanPham.ValueMember = "ID";

            cboLoaiSanPham.DataSource = categoryManager.GetAll();
            cboLoaiSanPham.DisplayMember = "CategoryName";
            cboLoaiSanPham.ValueMember = "ID";

            cboDonVi.DataSource = unitManager.GetAll();
            cboDonVi.DisplayMember = "UnitName";
            cboDonVi.ValueMember = "ID";

            cboNguonGoc.DataSource = countryManager.GetAll();
            cboNguonGoc.DisplayMember = "CountryName";
            cboNguonGoc.ValueMember = "ID";

            cboNhaSanXuat.DataSource = manufacturerManager.GetAll();
            cboNhaSanXuat.DisplayMember = "ManName";
            cboNhaSanXuat.ValueMember = "ID";

            cboTrangThai.DataSource = productStatusManager.GetAll();
            cboTrangThai.DisplayMember = "StatusName";
            cboTrangThai.ValueMember = "ID";

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
                }
            }
        }
    }
}