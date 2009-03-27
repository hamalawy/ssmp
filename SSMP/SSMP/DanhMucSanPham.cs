using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        public frmDanhMucSanPham()
        {
            InitializeComponent();
        }

        private string DieuKienTimKiem()
        {
            string dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                dk = " where SanPham.MaSanPham like '%" + txtTimKiemQuanLy.Text + "%' or SanPham.TenSanPham like N'%" + txtTimKiemQuanLy.Text + "%' or LoaiSanPham.LoaiSanPham like N'%" + txtTimKiemQuanLy.Text + "%' or DonVi.DonVi like N'%" + txtTimKiemQuanLy.Text + "%' or QuocGia.QuocGia like N'%" + txtTimKiemQuanLy.Text + "%' or NhaSanXuat.TenNhaSanXuat like N'%" + txtTimKiemQuanLy.Text + "%' or NhaCungCap.NhaCungCap like N'%" + txtTimKiemQuanLy.Text + "%' or SanPham.MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";
            else
            {
                if (chkMaSanPhamTimKiemQuanLy.Checked)
                    dk += " or SanPham.MaSanPham like '%" + txtTimKiemQuanLy.Text+"%'";
                if (chkTenSanPhamTimKiemQuanLy.Checked)
                    dk += " or SanPham.TenSanPham like N'%" + txtTimKiemQuanLy.Text+"%'";
                if (chkLoaiSanPhamTimKiemQuanLy.Checked)
                    dk += " or LoaiSanPham.LoaiSanPham like N'%" + txtTimKiemQuanLy.Text+"%'";
                if (chkDonViTimKiemQuanLy.Checked)
                    dk += " or DonVi.DonVi like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkNguonGocTimKiemQuanLy.Checked)
                    dk += " or QuocGia.QuocGia like N'%"+ txtTimKiemQuanLy.Text+"%'";
                if (chkNhaSanXuatTimKiemQuanLy.Checked)
                    dk += "or NhaSanXuat.TenNhaSanXuat like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkNhaCungCapTimKiemQuanLy.Checked)
                    dk += " or NhaCungCap.NhaCungCap like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkMoTaTimKiemQuanLy.Checked)
                    dk += " or SanPham.MoTa like N'%" + txtTimKiemQuanLy.Text+"%'";

                if (dk.Trim().Length > 0)
                    dk = " where "+dk.Substring(4);
            }

            return dk;
        }


        private void frmDanhMucSanPham_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);
            ht = new HoTro();
            //tai ma loai san pham
            ht.TaiDuLieu(cboLoaiSanPhamQuanLySanPham, "Category", "CategoryId", "CategoryName");

            //tai ten san pham
            ht.TaiDuLieu(cboTenSanPham, "ProductName", "ProductNameId", "ProductName");

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
            if (txtTimKiemQuanLy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa đánh vào từ tìm kiếm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTimKiemQuanLy.Focus();
                return;
            }

            if (DieuKienTimKiem().Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn điều kiện tìm kiếm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTimKiemQuanLy.Focus();
                txtTimKiemQuanLy.SelectAll();
                return;
            }

            string CauLenh = "";
            CauLenh = CauLenh = "select SanPham.MaSanPham, SanPham.TenSanPham, LoaiSanPham.MaLoaiSanPham, DonVi.MaDonVi, QuocGia.MaQuocGia, NhaSanXuat.MaNhaSanXuat, NhaCungCap.MaNhaCungCap, SanPham.MoTa from SanPham, LoaiSanPham, DonVi, QuocGia, NhaSanXuat, NhaCungCap, ChiTietSanPham where (SanPham.MaLoaiSanPham=LoaiSanPham.MaLoaiSanPham) and (SanPham.MaSanPham=ChiTietSanPham.MaSanPham) and (QuocGia.MaQuocGia=ChiTietSanPham.MaQuocGia)and (DonVi.MaDonVi=ChiTietSanPham.MaDonVi) and (NhaSanXuat.MaNhaSanXuat=ChiTietSanPham.MaNhaSanXuat) and (NhaCungCap.MaNhaCungCap=ChiTietSanPham.MaNhaCungCap)";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
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
            if (dgvQuanLy.Rows[e.RowIndex] == null) return;
            if (dgvQuanLy.Rows[e.RowIndex].Cells[0].Value == null) return;

            DongHienTai = e.RowIndex;

            txtMaSanPham.Text = dgvQuanLy.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenSanPham.Text = dgvQuanLy.Rows[e.RowIndex].Cells[1].Value.ToString();
            cboLoaiSanPham.SelectedIndex = cboLoaiSanPham.FindStringExact(dgvQuanLy.Rows[e.RowIndex].Cells[2].Value.ToString());

            cboDonVi.SelectedIndex = cboDonVi.FindStringExact(dgvQuanLy.Rows[e.RowIndex].Cells[3].Value.ToString());
            cboNguonGoc.SelectedIndex = cboNguonGoc.FindStringExact(dgvQuanLy.Rows[e.RowIndex].Cells[4].Value.ToString());
            cboNhaSanXuat.SelectedIndex = cboNhaSanXuat.FindStringExact(dgvQuanLy.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtMoTa.Text = dgvQuanLy.Rows[e.RowIndex].Cells[6].Value.ToString();
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
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            cboLoaiSanPham.SelectedIndex = -1;
            cboDonVi.SelectedIndex = -1;
            cboNguonGoc.SelectedIndex = -1;
            cboNhaSanXuat.SelectedIndex = -1;
            txtMoTa.Text = "";
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select SanPham.MaSanPham as [Mã sản phẩm], SanPham.TenSanPham as [Tên sản phẩm], LoaiSanPham.LoaiSanPham as [Loại sản phẩm], DonVi.DonVi as [Đơn vị], QuocGia.QuocGia as [Quốc gia], NhaSanXuat.TenNhaSanXuat [Nhà sản xuất], SanPham.MoTa as [Mô tả] from SanPham, LoaiSanPham, DonVi, QuocGia, NhaSanXuat, ChiTietSanPham where (SanPham.MaLoaiSanPham=LoaiSanPham.MaLoaiSanPham) and (SanPham.MaSanPham=ChiTietSanPham.MaSanPham) and (QuocGia.MaQuocGia=ChiTietSanPham.MaQuocGia)and (DonVi.MaDonVi=ChiTietSanPham.MaDonVi) and (NhaSanXuat.MaNhaSanXuat=ChiTietSanPham.MaNhaSanXuat)";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
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
      
            int maTenSP = ht.LayVeKhoa("ProductName", "ProductNameId", "ProductName", cboTenSanPham.Text) ;
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
    }
}