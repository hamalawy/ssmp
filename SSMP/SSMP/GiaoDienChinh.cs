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
        public frmDanhMucLoaiSanPham DanhMucLoaiSanPham;
        public frmDanhMucNhaCungCap DanhMucNhaCungCap;
        public FrmUser QuanLyNguoiDung;
        public FrmUnit QuanLyDonVi;
        public frmDanhMucNhaSanXuat DanhMucNhaSanXuat;
        public FrmAction frmAction;
        public frmNhapHang NhapHang;
        public BanHang frmBanHang;
        public FrmUserTitle QuanLyChucVu;
        public frmDanhMucSanPham DanhMucSanPham;
        public DangNhap frmDangNhap;
        public FrmUserStatus frmUserStatus;

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
            if (DoiMatKhau == null)
            {
                DoiMatKhau = new frmDoiMatKhau();
                DoiMatKhau.MdiParent = this;
                DoiMatKhau.Show();
            }
            if (DoiMatKhau.IsDisposed)
            {
                DoiMatKhau = new frmDoiMatKhau();
                DoiMatKhau.MdiParent = this;
                DoiMatKhau.Show();
            }
        }

        private void tsmiDanhMucQuocGia_Click(object sender, EventArgs e)
        {
            if (DanhMucQuocGia == null)
            {
                DanhMucQuocGia = new frmDanhMucQuocGia();
                DanhMucQuocGia.MdiParent = this;
                DanhMucQuocGia.Show();
            }
            if (DanhMucQuocGia.IsDisposed)
            {
                DanhMucQuocGia = new frmDanhMucQuocGia();
                DanhMucQuocGia.MdiParent = this;
                DanhMucQuocGia.Show();
            }
        }

        private void tsbQuanLyDanhMucQuocGia_Click(object sender, EventArgs e)
        {
            if (DanhMucQuocGia == null)
            {
                DanhMucQuocGia = new frmDanhMucQuocGia();
                DanhMucQuocGia.MdiParent = this;
                DanhMucQuocGia.Show();
            }
            if (DanhMucQuocGia.IsDisposed)
            {
                DanhMucQuocGia = new frmDanhMucQuocGia();
                DanhMucQuocGia.MdiParent = this;
                DanhMucQuocGia.Show();
            }
        }

        private void tsmiQuanLyNhomNguoiDung_Click(object sender, EventArgs e)
        {
            if (QuanLyNhomNguoiDung == null)
            {
                QuanLyNhomNguoiDung = new FrmUserRole();
                QuanLyNhomNguoiDung.MdiParent = this;
                QuanLyNhomNguoiDung.Show();
            }
            if (QuanLyNhomNguoiDung.IsDisposed)
            {
                QuanLyNhomNguoiDung = new FrmUserRole();
                QuanLyNhomNguoiDung.MdiParent = this;
                QuanLyNhomNguoiDung.Show();
            }
        }

        private void tsbQuanLyDanhMucLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (DanhMucLoaiSanPham == null)
            {
                DanhMucLoaiSanPham = new frmDanhMucLoaiSanPham();
                DanhMucLoaiSanPham.MdiParent = this;
                DanhMucLoaiSanPham.Show();
            }
            if (DanhMucLoaiSanPham.IsDisposed)
            {
                DanhMucLoaiSanPham = new frmDanhMucLoaiSanPham();
                DanhMucLoaiSanPham.MdiParent = this;
                DanhMucLoaiSanPham.Show();
            }
        }

        private void tsmiDanhMucLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (DanhMucLoaiSanPham == null)
            {
                DanhMucLoaiSanPham = new frmDanhMucLoaiSanPham();
                DanhMucLoaiSanPham.MdiParent = this;
                DanhMucLoaiSanPham.Show();
            }
            if (DanhMucLoaiSanPham.IsDisposed)
            {
                DanhMucLoaiSanPham = new frmDanhMucLoaiSanPham();
                DanhMucLoaiSanPham.MdiParent = this;
                DanhMucLoaiSanPham.Show();
            }
        }

        private void tsmiDanhMucNhaCungCap_Click(object sender, EventArgs e)
        {
            if (DanhMucNhaCungCap == null)
            {
                DanhMucNhaCungCap = new frmDanhMucNhaCungCap();
                DanhMucNhaCungCap.MdiParent = this;
                DanhMucNhaCungCap.Show();
            }
            if (DanhMucNhaCungCap.IsDisposed)
            {
                DanhMucNhaCungCap = new frmDanhMucNhaCungCap();
                DanhMucNhaCungCap.MdiParent = this;
                DanhMucNhaCungCap.Show();
            }
        }

        private void tsbQuanLyDanhMucNhaCungCap_Click(object sender, EventArgs e)
        {
            if (DanhMucNhaCungCap == null)
            {
                DanhMucNhaCungCap = new frmDanhMucNhaCungCap();
                DanhMucNhaCungCap.MdiParent = this;
                DanhMucNhaCungCap.Show();
            }
            if (DanhMucNhaCungCap.IsDisposed)
            {
                DanhMucNhaCungCap = new frmDanhMucNhaCungCap();
                DanhMucNhaCungCap.MdiParent = this;
                DanhMucNhaCungCap.Show();
            }
        }

        private void tsmiQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            if (QuanLyNguoiDung == null)
            {
                QuanLyNguoiDung = new FrmUser();
                QuanLyNguoiDung.MdiParent = this;
                QuanLyNguoiDung.Show();
            }
            if (QuanLyNguoiDung.IsDisposed)
            {
                QuanLyNguoiDung = new FrmUser();
                QuanLyNguoiDung.MdiParent = this;
                QuanLyNguoiDung.Show();
            }
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
            if (QuanLyDonVi == null)
            {
                QuanLyDonVi = new FrmUnit();
                QuanLyDonVi.MdiParent = this;
                QuanLyDonVi.Show();
            }
            if (QuanLyDonVi.IsDisposed)
            {
                QuanLyDonVi = new FrmUnit();
                QuanLyDonVi.MdiParent = this;
                QuanLyDonVi.Show();
            }
        }

        private void tsmiDanhMucNhaSanXuat_Click(object sender, EventArgs e)
        {
            if (DanhMucNhaSanXuat == null)
            {
                DanhMucNhaSanXuat = new frmDanhMucNhaSanXuat();
                DanhMucNhaSanXuat.MdiParent = this;
                DanhMucNhaSanXuat.Show();
            }
            if (DanhMucNhaSanXuat.IsDisposed)
            {
                DanhMucNhaSanXuat = new frmDanhMucNhaSanXuat();
                DanhMucNhaSanXuat.MdiParent = this;
                DanhMucNhaSanXuat.Show();
            }
        }

        private void tsbDanhMucNhaSanXuat_Click(object sender, EventArgs e)
        {
            if (DanhMucNhaSanXuat == null)
            {
                DanhMucNhaSanXuat = new frmDanhMucNhaSanXuat();
                DanhMucNhaSanXuat.MdiParent = this;
                DanhMucNhaSanXuat.Show();
            }
            if (DanhMucNhaSanXuat.IsDisposed)
            {
                DanhMucNhaSanXuat = new frmDanhMucNhaSanXuat();
                DanhMucNhaSanXuat.MdiParent = this;
                DanhMucNhaSanXuat.Show();
            }
        }

        private void tsmiQuanLyHanhDong_Click(object sender, EventArgs e)
        {
            if (frmAction == null)
            {
                frmAction = new FrmAction();
                frmAction.MdiParent = this;
                frmAction.Show();
            }
            if (frmAction.IsDisposed)
            {
                frmAction = new FrmAction();
                frmAction.MdiParent = this;
                frmAction.Show();
            }
        }

        private void tsmiLapPhieuNhapHangHoa_Click(object sender, EventArgs e)
        {
            if (NhapHang == null)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(0);
                NhapHang.Show();
            }
            if (NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(0);
                NhapHang.Show();
            }
            
        }

        private void tsmiQuanLyChucVu_Click(object sender, EventArgs e)
        {
            if (QuanLyChucVu == null)
            {
                QuanLyChucVu = new FrmUserTitle();
                QuanLyChucVu.MdiParent = this;
                QuanLyChucVu.Show();
            }
            if (QuanLyChucVu.IsDisposed)
            {
                QuanLyChucVu = new FrmUserTitle();
                QuanLyChucVu.MdiParent = this;
                QuanLyChucVu.Show();
            }
        }

        private void tsmiDanhMucSanPham_Click(object sender, EventArgs e)
        {
            if (DanhMucSanPham == null)
            {
                DanhMucSanPham = new frmDanhMucSanPham();
                DanhMucSanPham.MdiParent = this;
                DanhMucSanPham.Show();
            }
            if (DanhMucSanPham.IsDisposed)
            {
                DanhMucSanPham = new frmDanhMucSanPham();
                DanhMucSanPham.MdiParent = this;
                DanhMucSanPham.Show();
            }
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
            if (frmBanHang == null)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(0);
                frmBanHang.Show();
            }
            if (frmBanHang.IsDisposed)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(0);
                frmBanHang.Show();
            }
            
        }

        private void tsmiQuanLyPhieuNhapHang_Click(object sender, EventArgs e)
        {
            if (NhapHang == null)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(1);
                NhapHang.Show();
            }
            if (NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(1);
                NhapHang.Show();
            }
            
        }

        private void tsmiBaoCaoNhapHang_Click(object sender, EventArgs e)
        {
            if (NhapHang == null)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(2);
                NhapHang.Show();
            }
            if (NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(2);
                NhapHang.Show();
            }
            
        }

        private void tsmiQuanLyHoaDonBanHang_Click(object sender, EventArgs e)
        {
            if (frmBanHang == null)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(1);
                frmBanHang.Show();
            }
            if (frmBanHang.IsDisposed)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(1);
                frmBanHang.Show();
            }
            
        }

        private void tsmiBaoCaoBanHang_Click(object sender, EventArgs e)
        {
            if (frmBanHang == null)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(2);
                frmBanHang.Show();
            }
            if (frmBanHang.IsDisposed)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(2);
                frmBanHang.Show();
            }
            
        }

        private void tsmiDangNhap_Click(object sender, EventArgs e)
        {
            if (frmDangNhap == null)
            {
                frmDangNhap = new DangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.Show();
            }
            if (frmDangNhap.IsDisposed)
            {
                frmDangNhap = new DangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.Show();
            }
        }

        private void tsbDangNhap_Click(object sender, EventArgs e)
        {
            if (frmDangNhap == null)
            {
                frmDangNhap = new DangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.setGiaoDienChinh(this);
                frmDangNhap.Show();
            }
            if (frmDangNhap.IsDisposed)
            {
                frmDangNhap = new DangNhap();
                frmDangNhap.setGiaoDienChinh(this);
                frmDangNhap.MdiParent = this;
                frmDangNhap.Show();
            }
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
            if (frmBanHang == null)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(0);
                frmBanHang.Show();
            }
            if (frmBanHang.IsDisposed)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.setSelectedTab(0);
                frmBanHang.Show();
            }
            
        }

        private void tsdbNhapHang_Click(object sender, EventArgs e)
        {
            if (NhapHang == null)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(0);
                NhapHang.Show();
            }
            if (NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.setSelectedTab(0);
                NhapHang.Show();
            }
            
        }

        private void báoCáoNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemUserStatus_Click(object sender, EventArgs e)
        {
            if (frmUserStatus == null)
            {
                frmUserStatus = new FrmUserStatus();
                frmUserStatus.MdiParent = this;
                frmUserStatus.Show();
            }
            if (frmUserStatus.IsDisposed)
            {
                frmUserStatus = new FrmUserStatus();
                frmUserStatus.MdiParent = this;
                frmUserStatus.Show();
            }
        }
    }
}