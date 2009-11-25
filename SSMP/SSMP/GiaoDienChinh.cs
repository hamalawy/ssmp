using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SSMP.Data;

namespace SSMP
{
    public partial class frmGiaoDienChinh : Form
    {
        public FrmConfig frmConfig;
        public frmDoiMatKhau DoiMatKhau;
        public frmDanhMucQuocGia DanhMucQuocGia;
        public FrmUserRole QuanLyNhomNguoiDung;
        public FrmCategory DanhMucLoaiSanPham;
        public FrmProvider frmProvider;
        public FrmUser QuanLyNguoiDung;
        public FrmUnit QuanLyDonVi;
        public FrmManufacturer frmManufacturer;
        public FrmAction frmAction;
        public frmNhapHang NhapHang;
        public BanHang frmBanHang;
        public FrmUserTitle QuanLyChucVu;
        public FrmDanhMucSanPham DanhMucSanPham;
        public DangNhap frmDangNhap;
        public FrmUserStatus frmUserStatus;
        private FrmProductStatus frmProductStatus;
        private FrmActionDetail frmActionDetail;
        private FrmCustomer frmCustomer;

        public string MaNguoiDung;

        public frmGiaoDienChinh()
        {
            InitializeComponent();
            NHibernateSessionManager.Instance.GetSession();
        }

        public void enableMenu(int role) {
           
            tsmiBanHang.Enabled = true;
        }

        public void disableMenu(int role)
        {
            tsmiBanHang.Enabled = false;
        }

        private void tsmiCauHinh_Click(object sender, EventArgs e)
        {
            if (frmConfig == null || frmConfig.IsDisposed)
            {
                frmConfig = new FrmConfig();
                frmConfig.MdiParent = this;
                frmConfig.Show();
            }
            frmConfig.BringToFront();
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr;
            //dr=MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?","Xác nhận",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            //if (dr==DialogResult.Cancel)
            //    e.Cancel=true;
        }

        private void tsbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (DoiMatKhau == null || DoiMatKhau.IsDisposed)
            {
                DoiMatKhau = new frmDoiMatKhau();
                DoiMatKhau.MdiParent = this;
                DoiMatKhau.Show();
            }
            DoiMatKhau.BringToFront();
        }

        private void tsmiDanhMucQuocGia_Click(object sender, EventArgs e)
        {
            if (DanhMucQuocGia == null || DanhMucQuocGia.IsDisposed)
            {
                DanhMucQuocGia = new frmDanhMucQuocGia();
                DanhMucQuocGia.MdiParent = this;
                DanhMucQuocGia.Show();
            }
            DanhMucQuocGia.BringToFront();
        }

        private void tsbQuanLyDanhMucQuocGia_Click(object sender, EventArgs e)
        {
            if (DanhMucQuocGia == null || DanhMucQuocGia.IsDisposed)
            {
                DanhMucQuocGia = new frmDanhMucQuocGia();
                DanhMucQuocGia.MdiParent = this;
                DanhMucQuocGia.Show();
            }
            DanhMucQuocGia.BringToFront();
        }

        private void tsmiQuanLyNhomNguoiDung_Click(object sender, EventArgs e)
        {
            if (QuanLyNhomNguoiDung == null || QuanLyNhomNguoiDung.IsDisposed)
            {
                QuanLyNhomNguoiDung = new FrmUserRole();
                QuanLyNhomNguoiDung.MdiParent = this;
                QuanLyNhomNguoiDung.Show();
            }
            QuanLyNhomNguoiDung.BringToFront();
        }

        private void tsbQuanLyDanhMucLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (DanhMucLoaiSanPham == null || DanhMucLoaiSanPham.IsDisposed)
            {
                DanhMucLoaiSanPham = new FrmCategory();
                DanhMucLoaiSanPham.MdiParent = this;
                DanhMucLoaiSanPham.Show();
            }
            DanhMucLoaiSanPham.BringToFront();
        }

        private void tsmiDanhMucLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (DanhMucLoaiSanPham == null || DanhMucLoaiSanPham.IsDisposed)
            {
                DanhMucLoaiSanPham = new FrmCategory();
                DanhMucLoaiSanPham.MdiParent = this;
                DanhMucLoaiSanPham.Show();
            }
            DanhMucLoaiSanPham.BringToFront();
        }

        private void tsmiDanhMucNhaCungCap_Click(object sender, EventArgs e)
        {
            if (frmProvider == null || frmProvider.IsDisposed)
            {
                frmProvider = new FrmProvider();
                frmProvider.MdiParent = this;
                frmProvider.Show();
            }
            frmProvider.BringToFront();
        }

        private void tsbQuanLyDanhMucNhaCungCap_Click(object sender, EventArgs e)
        {
            if (frmProvider == null || frmProvider.IsDisposed)
            {
                frmProvider = new FrmProvider();
                frmProvider.MdiParent = this;
                frmProvider.Show();
            }
            frmProvider.BringToFront();
        }

        private void tsmiQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            if (QuanLyNguoiDung == null || QuanLyNguoiDung.IsDisposed)
            {
                QuanLyNguoiDung = new FrmUser();
                QuanLyNguoiDung.MdiParent = this;
                QuanLyNguoiDung.Show();
            }
            QuanLyNguoiDung.BringToFront();
        }

        private void tsmiXepTheoTangThangDung_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiXepTheoTangNamNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsmiXepChongLenNhau_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiXapXepCacBieuTuong_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void tsmiDongTatCaCuaSo_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
                child.Dispose();
        }

        private void tsmiDanhMucDonVi_Click(object sender, EventArgs e)
        {
            if (QuanLyDonVi == null || QuanLyDonVi.IsDisposed)
            {
                QuanLyDonVi = new FrmUnit();
                QuanLyDonVi.MdiParent = this;
                QuanLyDonVi.Show();
            }
            QuanLyDonVi.BringToFront();
        }

        private void tsmiDanhMucNhaSanXuat_Click(object sender, EventArgs e)
        {
            if (frmManufacturer == null || frmManufacturer.IsDisposed)
            {
                frmManufacturer = new FrmManufacturer();
                frmManufacturer.MdiParent = this;
                frmManufacturer.Show();
            }
            frmManufacturer.BringToFront();

        }

        private void tsbDanhMucNhaSanXuat_Click(object sender, EventArgs e)
        {
            if (frmManufacturer == null || frmManufacturer.IsDisposed)
            {
                frmManufacturer = new FrmManufacturer();
                frmManufacturer.MdiParent = this;
                frmManufacturer.Show();
            }
            frmManufacturer.BringToFront();
        }

        private void tsmiQuanLyHanhDong_Click(object sender, EventArgs e)
        {
            if (frmAction == null || frmAction.IsDisposed)
            {
                frmAction = new FrmAction();
                frmAction.MdiParent = this;
                frmAction.Show();
            }
            frmAction.BringToFront();
        }

        private void tsmiLapPhieuNhapHangHoa_Click(object sender, EventArgs e)
        {
            if (NhapHang == null || NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(0);
                NhapHang.Show();
            }
            NhapHang.BringToFront();
            
        }

        private void tsmiQuanLyChucVu_Click(object sender, EventArgs e)
        {
            if (QuanLyChucVu == null || QuanLyChucVu.IsDisposed)
            {
                QuanLyChucVu = new FrmUserTitle();
                QuanLyChucVu.MdiParent = this;
                QuanLyChucVu.Show();
            }
            QuanLyChucVu.BringToFront();
        }

        private void tsmiDanhMucSanPham_Click(object sender, EventArgs e)
        {
            if (DanhMucSanPham == null || DanhMucSanPham.IsDisposed)
            {
                DanhMucSanPham = new FrmDanhMucSanPham();
                DanhMucSanPham.MdiParent = this;
                DanhMucSanPham.Show();
            }
            DanhMucSanPham.BringToFront();
        }

        private void frmGiaoDienChinh_Load(object sender, EventArgs e)
        {
            
            
            if (!File.Exists(Constants.CONFIG_FILE))
            {
                MessageBox.Show("Because this is the first time use program, please config database", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (frmConfig == null)
                {
                    frmConfig = new FrmConfig();
                    frmConfig.MdiParent = this;
                    frmConfig.Show();
                }
                if (frmConfig.IsDisposed)
                {
                    frmConfig = new FrmConfig();
                    frmConfig.MdiParent = this;
                    frmConfig.Show();
                }
            }
            else
            {
                System.Console.WriteLine("Config file existed!");
            }
        }

        private void tsmiLapPhieuBanHang_Click(object sender, EventArgs e)
        {
            if (frmBanHang == null || frmBanHang.IsDisposed)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(0);
                frmBanHang.Show();
            }
            frmBanHang.BringToFront();
        }

        private void tsmiQuanLyPhieuNhapHang_Click(object sender, EventArgs e)
        {
            if (NhapHang == null || NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(1);
                NhapHang.Show();
            }
            NhapHang.BringToFront();            
        }

        private void tsmiBaoCaoNhapHang_Click(object sender, EventArgs e)
        {
            if (NhapHang == null || NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(2);
                NhapHang.Show();
            }
            NhapHang.BringToFront();    
            
        }

        private void tsmiQuanLyHoaDonBanHang_Click(object sender, EventArgs e)
        {
            if (frmBanHang == null || frmBanHang.IsDisposed)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(1);
                frmBanHang.Show();
            }
            frmBanHang.BringToFront();
            
        }

        private void tsmiBaoCaoBanHang_Click(object sender, EventArgs e)
        {
           if (frmBanHang == null || frmBanHang.IsDisposed)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(2);
                frmBanHang.Show();
            }
            frmBanHang.BringToFront();
        }

        private void tsmiDangNhap_Click(object sender, EventArgs e)
        {
            if (frmDangNhap == null || frmDangNhap.IsDisposed)
            {
                frmDangNhap = new DangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.Show();
            }
            frmDangNhap.BringToFront();
        }

        private void tsbDangNhap_Click(object sender, EventArgs e)
        {
            if (frmDangNhap == null || frmDangNhap.IsDisposed)
            {
                frmDangNhap = new DangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.setGiaoDienChinh(this);
                frmDangNhap.Show();
            }
            frmDangNhap.BringToFront();
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap.idNguoiDung = 0;
            DangNhap.tenDangNhap = null;
            DangNhap.quyenNguoiDung = 0;
            MessageBox.Show(this, "Đăng xuất thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap.idNguoiDung = 0;
            DangNhap.tenDangNhap = null;
            DangNhap.quyenNguoiDung = 0;
            MessageBox.Show(this, "Đăng xuất thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsdbBanHang_Click(object sender, EventArgs e)
        {
            if (frmBanHang == null || frmBanHang.IsDisposed)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(0);
                frmBanHang.Show();
            }
            frmBanHang.BringToFront();            
        }

        private void tsdbNhapHang_Click(object sender, EventArgs e)
        {
            if (NhapHang == null || NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(0);
                NhapHang.Show();
            }
            NhapHang.BringToFront();
            
        }

        private void báoCáoNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemUserStatus_Click(object sender, EventArgs e)
        {
            if (frmUserStatus == null || frmUserStatus.IsDisposed)
            {
                frmUserStatus = new FrmUserStatus();
                frmUserStatus.MdiParent = this;
                frmUserStatus.Show();
            }
            frmUserStatus.BringToFront();
        }

        private void toolStripMenuItemProductStatus_Click(object sender, EventArgs e)
        {
            if (frmProductStatus == null || frmProductStatus.IsDisposed)
            {
                frmProductStatus = new FrmProductStatus();
                frmProductStatus.MdiParent = this;
                frmProductStatus.Show();
            }
            frmProductStatus.BringToFront();
        }

        private void tsmiQuanLyDauVet_Click(object sender, EventArgs e)
        {
            if (frmActionDetail == null || frmActionDetail.IsDisposed)
            {
                frmActionDetail = new FrmActionDetail();
                frmActionDetail.MdiParent = this;
                frmActionDetail.Show();
            }
            frmActionDetail.BringToFront();
        }

        private void toolStripMnuItmCustomer_Click(object sender, EventArgs e)
        {
            if (frmCustomer == null || frmCustomer.IsDisposed)
            {
                frmCustomer = new FrmCustomer();
                frmCustomer.MdiParent = this;
                frmCustomer.Show();
            }
            frmCustomer.BringToFront();
        }
    }
}