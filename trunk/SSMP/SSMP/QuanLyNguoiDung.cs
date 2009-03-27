using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SSMP
{
    public partial class frmQuanLyNguoiDung : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        HoTro ht;

        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private string DanhSachTruong()
        {
            string dst = "";
            if (chkTatCaHienThiQuanLy.Checked)
                dst = "NguoiDung.MaNguoiDung as [Mã Người dùng], NguoiDung.HoVaTen as[Họ và tên], ChucVu.ChucVu as [Chức vụ], NguoiDung.TenDangNhap as [Tên đăng nhập], TrangThai.TrangThai as [Trạng thái], NhomNguoiDung.NhomNguoiDung as[Nhóm người dùng], NguoiDung.MoTa as [Mô tả]";
            else
            {
                dst="NguoiDung.MaNguoiDung as [Mã Người dùng]";
                if (chkHoVaTenHienThiQuanLy.Checked)
                    dst += ", NguoiDung.HoVaTen as[Họ và tên]";
                if (chkChucVuHienThiQuanLy.Checked)
                    dst += ", ChucVu.ChucVu as [Chức vụ]";
                if (chkTenDangNhapHienThiQuanLy.Checked)
                    dst += ", NguoiDung.TenDangNhap as [Tên đăng nhập]";
                if (chkTrangThaiHienThiQuanLy.Checked)
                    dst += ", TrangThai.TrangThai as [Trạng thái]";
                if (chkNhomNguoiDungHienThiQuanLy.Checked)
                    dst += ", NhomNguoiDung.NhomNguoiDung as[Nhóm người dùng]";
                if (chkMoTaHienThiQuanLy.Checked)
                    dst += ", NguoiDung.MoTa as [Mô tả]";
            }
            return dst;
        }

        private string DieuKienTimKiem()
        {
            string dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                dk = " where NguoiDung.MaNguoiDung like '%" + txtTimKiemQuanLy.Text + "%' or NguoiDung.HoVaTen like N'%" + txtTimKiemQuanLy.Text + "%' or ChucVu.ChucVu like N'%" + txtTimKiemQuanLy.Text + "%' or NguoiDung.TenDangNhap like N'%" + txtTimKiemQuanLy.Text + "%' or TrangThai.TrangThai like N'%" + txtTimKiemQuanLy.Text + "%' or NhomNguoiDung.NhomNguoiDung like N'%" + txtTimKiemQuanLy.Text + "%' or NguoiDung.MoTa like N'%" + txtTimKiemQuanLy.Text+"%'";
            else
            {
                if (chkMaNguoiDungTimKiemQuanLy.Checked)
                    dk += " or NguoiDung.MaNguoiDung like '%" + txtTimKiemQuanLy.Text+"%'";
                if (chkHoVaTenTimKiemQuanLy.Checked)
                    dk += " or NguoiDung.HoVaTen like N'%" + txtTimKiemQuanLy.Text+"%'";
                if (chkChucVuTimKiemQuanLy.Checked)
                    dk += " or ChucVu.ChucVu like N'%" + txtTimKiemQuanLy.Text+"%'";
                if (chkTenDangNhapTimKiemQuanLy.Checked)
                    dk += " or NguoiDung.TenDangNhap like N'%" + txtTimKiemQuanLy.Text+"%'";
                if (chkTrangThaiTimKiemQuanLy.Checked)
                    dk += " or TrangThai.TrangThai like N'%" + txtTimKiemQuanLy.Text+"%'";
                if (chkNhomNguoiDungTimKiemQuanLy.Checked)
                    dk += " or NhomNguoiDung.NhomNguoiDung like N'%" + txtTimKiemQuanLy.Text+"%'";
                if (chkMoTaTimKiemQuanLy.Checked)
                    dk += " or NguoiDung.MoTa like N'%" + txtTimKiemQuanLy.Text+"%'";
            }

            if (dk.Trim().Length > 0)
                dk = " where " + dk.Substring(4);
            return dk;
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);

            ht = new HoTro();
            conn = ht.KetNoi();

            //tai du lieu vao cboChucVu
            ht.TaiDuLieu(cboChucVu, "ChucVu", "MaChucVu", "ChucVu");

            //load du lieu vao clbNhomNguoiDung
            string CauLenh = "select MaNhomNguoiDung, NhomNguoiDung from NhomNguoiDung";
            try
            {
                cmd = new SqlCommand(CauLenh, conn);
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    clbNhomNguoiDung.Items.Add(dr.GetString(1));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc dữ liệu trong cơ sở dữ liệu!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                try
                {
                    if (dr != null) dr.Close();
                    if (cmd != null) cmd.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đóng kết nối đến cơ sở dữ liệu!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            //tai du lieu vao cboTrangThai
            ht.TaiDuLieu(cboTrangThai, "TrangThai", "MaTrangThai", "TrangThai");

            //tai toan bo du lieu vao dgvQuanLy
            CauLenh = "select " + DanhSachTruong() + " from TrangThai inner join NguoiDung on TrangThai.MaTrangThai=NguoiDung.MaTrangThai inner join ChucVu on ChucVu.MaChucVu=NguoiDung.MaChucVu inner join ChiTietNguoiDung on NguoiDung.MaNguoiDung=ChiTietNguoiDung.MaNguoiDung inner join NhomNguoiDung on ChiTietNguoiDung.MaNhomNguoiDung=NhomNguoiDung.MaNhomNguoiDung";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiToanBoQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from TrangThai inner join NguoiDung on TrangThai.MaTrangThai=NguoiDung.MaTrangThai inner join ChucVu on ChucVu.MaChucVu=NguoiDung.MaChucVu inner join ChiTietNguoiDung on NguoiDung.MaNguoiDung=ChiTietNguoiDung.MaNguoiDung inner join NhomNguoiDung on ChiTietNguoiDung.MaNhomNguoiDung=NhomNguoiDung.MaNhomNguoiDung";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from TrangThai inner join NguoiDung on TrangThai.MaTrangThai=NguoiDung.MaTrangThai inner join ChucVu on ChucVu.MaChucVu=NguoiDung.MaChucVu inner join ChiTietNguoiDung on NguoiDung.MaNguoiDung=ChiTietNguoiDung.MaNguoiDung inner join NhomNguoiDung on ChiTietNguoiDung.MaNhomNguoiDung=NhomNguoiDung.MaNhomNguoiDung"+HoTro.DieuKienTaiLai(dgvQuanLy,"NguoiDung.MaNguoiDung");
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnDongQuanLy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BoDauKiem()
        {
            int Dem = 0;
            while (Dem < clbNhomNguoiDung.Items.Count)
            {
                clbNhomNguoiDung.SetItemChecked(Dem, false);
                ++Dem;
            }
        }

        private void btnXoaTrangQuanLy_Click(object sender, EventArgs e)
        {
            txtMaNguoiDung.Text = "";
            txtHoVaTen.Text = "";
            cboChucVu.SelectedIndex = -1;
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtMatKhauXacNhan.Text = "";
            cboTrangThai.SelectedIndex = -1;
            BoDauKiem();
            txtMoTa.Text = "";
        }

        private void dgvQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLy.Rows[e.RowIndex] == null) return;
            if (dgvQuanLy.Rows[e.RowIndex].Cells[0].Value == null) return;

            Int32 MaNguoiDung = (Int32)dgvQuanLy.Rows[e.RowIndex].Cells[0].Value;
            BoDauKiem();

            string CauLenh = "select NguoiDung.MaNguoiDung, NguoiDung.HoVaTen, NguoiDung.MaChucVu, NguoiDung.TenDangNhap, NguoiDung.MatKhau, NguoiDung.MaTrangThai, NhomNguoiDung.NhomNguoiDung, NguoiDung.MoTa from NguoiDung inner join ChiTietNguoiDung on NguoiDung.MaNguoiDung=ChiTietNguoiDung.MaNguoiDung inner join NhomNguoiDung on ChiTietNguoiDung.MaNhomNguoiDung=NhomNguoiDung.MaNhomNguoiDung where NguoiDung.MaNguoiDung=" + MaNguoiDung;

            try
            {
                cmd = new SqlCommand(CauLenh, conn);
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                int ChiSo = 0;
                
                while (dr.Read())
                {
                    txtMaNguoiDung.Text = dr.GetInt32(0).ToString();
                    txtHoVaTen.Text = dr.GetString(1);
                    cboChucVu.SelectedValue = dr.GetInt32(2);
                    txtTenDangNhap.Text = dr.GetString(3);
                    txtMatKhau.Text = dr.GetString(4);
                    txtMatKhauXacNhan.Text = dr.GetString(4);
                    cboTrangThai.SelectedValue = dr.GetInt32(5);
                    ChiSo = clbNhomNguoiDung.Items.IndexOf(dr.GetString(6));
                    clbNhomNguoiDung.SetItemChecked(ChiSo, true);
                    txtMoTa.Text = dr.GetString(7);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc dữ liệu trong cơ sở dữ liệu!" + ex.ToString(), "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                try
                {
                    if (dr != null) dr.Close();
                    if (cmd != null) cmd.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc dữ liệu trong cơ sở dữ liệu!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiemQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";

            //kiem tra xau tim kiem khac rong
            if (txtTimKiemQuanLy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập vào xâu tìm kiếm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTimKiemQuanLy.Focus();
                return;
            }

            //kiem tra lua con dieu kien tim kiem
            if (DieuKienTimKiem().Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn điều kiện tìm kiếm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTimKiemQuanLy.Focus();
                txtTimKiemQuanLy.SelectAll();
                return;
            }

            CauLenh = "select " + DanhSachTruong() + " from TrangThai inner join NguoiDung on TrangThai.MaTrangThai=NguoiDung.MaTrangThai inner join ChucVu on ChucVu.MaChucVu=NguoiDung.MaChucVu inner join ChiTietNguoiDung on NguoiDung.MaNguoiDung=ChiTietNguoiDung.MaNguoiDung inner join NhomNguoiDung on ChiTietNguoiDung.MaNhomNguoiDung=NhomNguoiDung.MaNhomNguoiDung "+DieuKienTimKiem();
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaQuanLy_Click(object sender, EventArgs e)
        {
            ////kiem tra ma nguoi dung khac rong
            //if (txtMaNguoiDung.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa lựa chọn người dùng!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    return;
            //}

            ////xoa du lieu trong bang ChiTietNguoiDung
            //Int32 MaNguoiDung = Int32.Parse(txtMaNguoiDung.Text);
            //string CauLenh = "";
            //CauLenh = "delete ChiTietNguoiDung where MaNguoiDung="+MaNguoiDung;
            //ht.CapNhatDuLieu(CauLenh);

            ////xoa du lieu trong bang NguoiDung
            //CauLenh = "delete NguoiDung where MaNguoiDung="+MaNguoiDung;
            //ht.CapNhatDuLieu(CauLenh);

            ////tai toan bo du lieu vao dgvQuanLy
            //CauLenh = "select " + DanhSachTruong() + " from TrangThai inner join NguoiDung on TrangThai.MaTrangThai=NguoiDung.MaTrangThai inner join ChucVu on ChucVu.MaChucVu=NguoiDung.MaChucVu inner join ChiTietNguoiDung on NguoiDung.MaNguoiDung=ChiTietNguoiDung.MaNguoiDung inner join NhomNguoiDung on ChiTietNguoiDung.MaNhomNguoiDung=NhomNguoiDung.MaNhomNguoiDung";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void KiemTraCacTruong()
        {
            //kiem tra ten nguoi dung khac rong
            if (txtHoVaTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ và tên cho người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
                return;
            }

            //kiem tra chuc vu
            if (cboChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa lựa chọn chức vụ cho người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChucVu.Focus();
                return;
            }

            //kiem tra ten dang nhap
            if (txtTenDangNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn tên đăng nhập cho người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            //kiem tra mat khau
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cho người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            //kiem tra xac nhan mat khau
            if (txtMatKhau.Text != txtMatKhauXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu & Mật khẩu xác nhận không trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauXacNhan.Focus();
                return;
            }

            //kiem tra trang thai
            if (cboTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa lựa chọn trạng thái cho người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrangThai.Focus();
                return;
            }

            //kiem tra nhom nguoi dung
            if (clbNhomNguoiDung.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa nhập nhóm người dùng cho người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clbNhomNguoiDung.Focus();
                return;
            }
        }

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            //KiemTraCacTruong();
            //string CauLenh = "";
            //string MatKhau = "";
            //Int32 MaNguoiDung = 0;
            //Int32 SoDongCuaBang = 0;
            //Int32 Dem = 0;
            //MatKhau = ht.DoiSangMaMD5(txtMatKhau.Text);

            ////chen du lieu vao trong bang NguoiDung
            //CauLenh = "insert NguoiDung(HoVaTen,MaChucVu,TenDangNhap,MatKhau,MaTrangThai,MoTa) values(N'" + txtHoVaTen.Text + "'," + cboChucVu.SelectedValue + ",N'" + txtTenDangNhap.Text + "',N'" + MatKhau + "'," + cboTrangThai.SelectedValue + ",N'" + txtMoTa.Text + "')";
            //ht.CapNhatDuLieu(CauLenh);

            //MaNguoiDung = ht.LayGiaTriTruongKhoaVuaChen("NguoiDung", "MaNguoiDung");

            //string DieuKien = "";
            //while (SoDongCuaBang < clbNhomNguoiDung.CheckedItems.Count)
            //{
            //    DieuKien += " or NhomNguoiDung=N'"+clbNhomNguoiDung.CheckedItems[SoDongCuaBang].ToString()+"'";
            //    ++SoDongCuaBang;
            //}

            //if (DieuKien.Trim().Length > 0)
            //    DieuKien = " where " + DieuKien.Substring(4);

            //CauLenh = "select MaNhomNguoiDung from NhomNguoiDung "+DieuKien;

            //Int32[] MangMaNhomNguoiDung = new Int32[SoDongCuaBang];

            ////lay ve cac ma nhom nguoi dung de chen vao bang ChiTietNguoiDung
            //MangMaNhomNguoiDung = ht.LayVeMangGiaTriKhoa(CauLenh);

            ////chen du lieu vao bang ChiTietNguoiDung
            //while (Dem < MangMaNhomNguoiDung.Length)
            //{
            //    CauLenh = "insert ChiTietNguoiDung(MaNguoiDung,MaNhomNguoiDung) values("+MaNguoiDung.ToString()+","+MangMaNhomNguoiDung[Dem].ToString()+")";
            //    ht.CapNhatDuLieu(CauLenh);
            //    ++Dem;
            //}

            ////tai toan bo du lieu vao dgvQuanLy
            //CauLenh = "select " + DanhSachTruong() + " from TrangThai inner join NguoiDung on TrangThai.MaTrangThai=NguoiDung.MaTrangThai inner join ChucVu on ChucVu.MaChucVu=NguoiDung.MaChucVu inner join ChiTietNguoiDung on NguoiDung.MaNguoiDung=ChiTietNguoiDung.MaNguoiDung inner join NhomNguoiDung on ChiTietNguoiDung.MaNhomNguoiDung=NhomNguoiDung.MaNhomNguoiDung";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnCapNhatQuanLy_Click(object sender, EventArgs e)
        {
            ////kiem tra ma nguoi dung khac rong
            //if (txtMaNguoiDung.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa lựa chọn người dùng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    return;
            //}

            //KiemTraCacTruong();

            //string CauLenh = "";
            //string MatKhau = "";
            //Int32 MaNguoiDung = 0;

            //MatKhau = ht.DoiSangMaMD5(txtMatKhau.Text);

            ////cap nhat cac truong vao bang nguoi dung
            //MaNguoiDung = Int32.Parse(txtMaNguoiDung.Text);
            //CauLenh = "update NguoiDung set HoVaTen=N'"+txtHoVaTen.Text+"', MaChucVu="+cboChucVu.SelectedValue+", TenDangNhap=N'"+txtTenDangNhap.Text+"', MatKhau=N'"+MatKhau+"', MaTrangThai="+cboTrangThai.SelectedValue+", MoTa=N'"+txtMoTa.Text+"' where MaNguoiDung="+MaNguoiDung;
            //ht.CapNhatDuLieu(CauLenh);

            ////cap nhat du lieu vao bang ChiTietNguoiDung
            //Int32 Dem = 0;
            //Int32 SoDong = 0;
            //string DieuKien = "";
            //Int32[] MangMaNhomNguoiDung = null;

            //while (SoDong < clbNhomNguoiDung.CheckedItems.Count)
            //{
            //    DieuKien += " or NhomNguoiDung=N'"+clbNhomNguoiDung.CheckedItems[SoDong].ToString()+"'";
            //    ++SoDong;
            //}

            //if (DieuKien.Trim().Length > 0)
            //    DieuKien = " where " + DieuKien.Substring(4);

            //MangMaNhomNguoiDung = new Int32[SoDong];
            //CauLenh = "select MaNhomNguoiDung from NhomNguoiDung "+DieuKien;
            //MangMaNhomNguoiDung = ht.LayVeMangGiaTriKhoa(CauLenh);

            ////xoa toan bo nhung ma nhom nguoi dung cua nguoi dung tuong ung
            ////trong bang 
            //CauLenh = "delete ChiTietNguoiDung where MaNguoiDung="+MaNguoiDung;
            //ht.CapNhatDuLieu(CauLenh);

            //Dem = 0;
            //while (Dem < MangMaNhomNguoiDung.Length)
            //{
            //    CauLenh = "insert ChiTietNguoiDung(MaNguoiDung,MaNhomNguoiDung) values("+MaNguoiDung+","+MangMaNhomNguoiDung[Dem].ToString()+")";
            //    ht.CapNhatDuLieu(CauLenh);
            //    ++Dem;
            //}

            ////tai toan bo du lieu vao dgvQuanLy
            //CauLenh = "select " + DanhSachTruong() + " from TrangThai inner join NguoiDung on TrangThai.MaTrangThai=NguoiDung.MaTrangThai inner join ChucVu on ChucVu.MaChucVu=NguoiDung.MaChucVu inner join ChiTietNguoiDung on NguoiDung.MaNguoiDung=ChiTietNguoiDung.MaNguoiDung inner join NhomNguoiDung on ChiTietNguoiDung.MaNhomNguoiDung=NhomNguoiDung.MaNhomNguoiDung";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void bindingNavigatorUser_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnInAnQuanLy_Click(object sender, EventArgs e)
        {

        }
    }
}