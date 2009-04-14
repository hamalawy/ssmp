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
        public frmQuanLyNhomNguoiDung QuanLyNhomNguoiDung;
        public frmDanhMucLoaiSanPham DanhMucLoaiSanPham;
        public frmDanhMucNhaCungCap DanhMucNhaCungCap;
        public FrmUser QuanLyNguoiDung;
        public frmQuanLyDonVi QuanLyDonVi;
        public frmDanhMucNhaSanXuat DanhMucNhaSanXuat;
        public frmQuanLyHanhDong QuanLyHanhDong;
        public frmNhapHang NhapHang;
        public BanHang frmBanHang;
        public frmQuanLyChucVu QuanLyChucVu;
        public frmDanhMucSanPham DanhMucSanPham;

        public string MaNguoiDung;

        public frmGiaoDienChinh()
        {
            InitializeComponent();
            NHibernateSessionManager.Instance.GetSession();
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
                QuanLyNhomNguoiDung = new frmQuanLyNhomNguoiDung();
                QuanLyNhomNguoiDung.MdiParent = this;
                QuanLyNhomNguoiDung.Show();
            }
            if (QuanLyNhomNguoiDung.IsDisposed)
            {
                QuanLyNhomNguoiDung = new frmQuanLyNhomNguoiDung();
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
                QuanLyDonVi = new frmQuanLyDonVi();
                QuanLyDonVi.MdiParent = this;
                QuanLyDonVi.Show();
            }
            if (QuanLyDonVi.IsDisposed)
            {
                QuanLyDonVi = new frmQuanLyDonVi();
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
            if (QuanLyHanhDong == null)
            {
                QuanLyHanhDong = new frmQuanLyHanhDong();
                QuanLyHanhDong.MdiParent = this;
                QuanLyHanhDong.Show();
            }
            if (QuanLyHanhDong.IsDisposed)
            {
                QuanLyHanhDong = new frmQuanLyHanhDong();
                QuanLyHanhDong.MdiParent = this;
                QuanLyHanhDong.Show();
            }
        }

        private void tsmiLapPhieuNhapHangHoa_Click(object sender, EventArgs e)
        {
            if (NhapHang == null)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.Show();
            }
            if (NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang();
                NhapHang.MdiParent = this;
                NhapHang.Show();
            }
        }

        private void tsmiQuanLyChucVu_Click(object sender, EventArgs e)
        {
            if (QuanLyChucVu == null)
            {
                QuanLyChucVu = new frmQuanLyChucVu();
                QuanLyChucVu.MdiParent = this;
                QuanLyChucVu.Show();
            }
            if (QuanLyChucVu.IsDisposed)
            {
                QuanLyChucVu = new frmQuanLyChucVu();
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
                frmBanHang.Show();
            }
            if (frmBanHang.IsDisposed)
            {
                frmBanHang = new BanHang();
                frmBanHang.MdiParent = this;
                frmBanHang.Show();
            }
        }
    }
}