using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SSMP
{
    public partial class frmDanhMucNhaSanXuat : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        HoTro ht;

        public frmDanhMucNhaSanXuat()
        {
            InitializeComponent();
        }

        private string DanhSachTruong()
        {
            string dst = "";
            if (chkTatCaHienThiQuanLy.Checked)
                dst = "NhaSanXuat.MaNhaSanXuat as [Mã Nhà sản xuất], NhaSanXuat.TenNhaSanXuat as [Nhà sản xuất], QuocGia.QuocGia as [Quốc gia], NhaSanXuat.DienThoai as [Điện thoại], NhaSanXuat.TrangChu as [Trang chủ], NhaSanXuat.MoTa as [Mô tả]";
            else
            {
                dst = "NhaSanXuat.MaNhaSanXuat as [Mã Nhà sản xuất]";
                if (chkNhaSanXuatHienThiQuanLy.Checked)
                    dst += ", NhaSanXuat.TenNhaSanXuat as [Nhà sản xuất]";
                if (chkQuocGiaHienThiQuanLy.Checked)
                    dst += ", QuocGia.QuocGia as [Quốc gia]";
                if (chkDienThoaiHienThiQuanLy.Checked)
                    dst += ", NhaSanXuat.DienThoai as [Điện thoại]";
                if (chkTrangChuHienThiQuanLy.Checked)
                    dst += ", NhaSanXuat.TrangChu as [Trang chủ]";
                if (chkMoTaHienThiQuanLy.Checked)
                    dst += ", MoTa as [Mô tả]";
            }
            return dst;
        }

        private string DieuKienTimKiem()
        {
            string Dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                Dk = " where NhaSanXuat.MaNhaSanXuat like '%" + txtTimKiemQuanLy.Text + "%' or NhaSanXuat.TenNhaSanXuat like N'%" + txtTimKiemQuanLy.Text + "%' or NhaSanXuat.DienThoai like N'%" + txtTimKiemQuanLy.Text + "%' or NhaSanXuat.TrangChu like N'%" + txtTimKiemQuanLy.Text + "%' or QuocGia.QuocGia like N'%" + txtTimKiemQuanLy.Text + "%' or NhaSanXuat.MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";
            else
            {
                if (chkMaNhaSanXuatTimKiemQuanLy.Checked)
                    Dk += " or NhaSanXuat.MaNhaSanXuat like '%" + txtTimKiemQuanLy.Text + "%'";
                if (chkNhaSanXuatTimKiemQuanLy.Checked)
                    Dk += " or NhaSanXuat.TenNhaSanXuat like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkDienThoaiTimKiemQuanLy.Checked)
                    Dk += " or NhaSanXuat.DienThoai like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkTrangChuTimKiemQuanLy.Checked)
                    Dk += " or NhaSanXuat.TrangChu like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkQuocGiaTimKiemQuanLy.Checked)
                    Dk += " or QuocGia.QuocGia like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkMoTaTimKiemQuanLy.Checked)
                    Dk += " or NhaSanXuat.MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";

                if (Dk.Trim().Length > 0)
                    Dk = " where " + Dk.Substring(4);
            }
            return Dk;
        }

        private void frmDanhMucNhaSanXuat_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);
            ht = new HoTro();
            conn = ht.KetNoi();

            ht.TaiDuLieu(cboQuocGia, "QuocGia", "MaQuocGia", "QuocGia");

            string CauLenh = "";
            CauLenh = "select "+DanhSachTruong()+" from NhaSanXuat inner join QuocGia on NhaSanXuat.MaQuocGia=QuocGia.MaQuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy,CauLenh);
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from NhaSanXuat inner join QuocGia on NhaSanXuat.MaQuocGia=QuocGia.MaQuocGia " +HoTro.DieuKienTaiLai(dgvQuanLy,"NhaSanXuat.MaNhaSanXuat");
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiToanBoQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from NhaSanXuat inner join QuocGia on NhaSanXuat.MaQuocGia=QuocGia.MaQuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnDongQuanLy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvQuanLy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int SoDong = 0;
            SoDong=dgvQuanLy.Rows.Count;
            if (SoDong > 0)
                --SoDong;
            txtTongSoQuanLy.Text = SoDong.ToString();
        }

        private void dgvQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLy.Rows[e.RowIndex] == null) return;
            if (dgvQuanLy.Rows[e.RowIndex].Cells[0].Value == null) return;

            Int32 MaNhaSanXuat = (Int32)dgvQuanLy.Rows[e.RowIndex].Cells[0].Value;

            string CauLenh = "";
            CauLenh = "select * from NhaSanXuat where MaNhaSanXuat=" + MaNhaSanXuat;

            try
            {
                cmd = new SqlCommand(CauLenh, conn);
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtMaNhaSanXuat.Text = dr.GetInt32(0).ToString();
                    txtTenNhaSanXuat.Text = dr.GetString(1);
                    txtDienThoai.Text = dr.GetString(3);
                    txtTrangChu.Text = dr.GetString(4);
                    cboQuocGia.SelectedValue = dr.GetInt32(2);
                    txtMoTa.Text = dr.GetString(5);
                }
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
                    MessageBox.Show("Lỗi đóng kết nối đến cơ sở dữ liệu!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiemQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra xau tim kiem khac rong
            if (txtTimKiemQuanLy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập xâu tìm kiếm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTimKiemQuanLy.Focus();
                return;
            }

            if (DieuKienTimKiem().Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimKiemQuanLy.Focus();
                txtTimKiemQuanLy.SelectAll();
                return;
            }

            string CauLenh = "select "+DanhSachTruong()+" from NhaSanXuat inner join QuocGia on NhaSanXuat.MaQuocGia=QuocGia.MaQuocGia "+DieuKienTimKiem() ;
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaTrangQuanLy_Click(object sender, EventArgs e)
        {
            txtMaNhaSanXuat.Text = "";
            txtTenNhaSanXuat.Text = "";
            cboQuocGia.SelectedIndex = -1;
            txtDienThoai.Text = "";
            txtTrangChu.Text = "";
            txtMoTa.Text = "";
        }

        private void KiemTraCacTruong()
        {
            //kiem tra ten nha cung cap
            if (txtTenNhaSanXuat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhà sản xuất!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhaSanXuat.Focus();
                return;
            }

            //kiem tra so dien thoai
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập điện thoại nhà sản xuất!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }

            string DienThoaiMau = @"^\(\d{3}\)\(\d{2,3}\)\d{1}\d{5,9}$";
            bool KetQuaDienThoai = Regex.IsMatch(txtDienThoai.Text, DienThoaiMau);
            if (!KetQuaDienThoai)
            {
                MessageBox.Show("Điện thoại nhà sản xuất không đúng định dạng!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                txtDienThoai.SelectAll();
                return;
            }

            //kiem tra trang chu
            if (txtTrangChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập website của nhà sản xuất!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrangChu.Focus();
                return;
            }

            string WebSiteMau = @"^(http://)?(www\.)?\w+\.\w{2,3}(\.\w{2})?$";
            bool KetQuaWebSite = Regex.IsMatch(txtTrangChu.Text, WebSiteMau);
            if (!KetQuaWebSite)
            {
                MessageBox.Show("Bạn nhập website nhà sản xuất không đúng định dạng!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrangChu.Focus();
                txtTrangChu.SelectAll();
                return;
            }

            //kiem tra quoc gia duoc lua chon
            if (cboQuocGia.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa lựa chọn tên quốc gia!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboQuocGia.Focus();
                return;
            }
        }

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            KiemTraCacTruong();

            string CauLenh = "";
            CauLenh = "insert NhaSanXuat(TenNhaSanXuat,MaQuocGia,DienThoai,TrangChu,MoTa) values(N'"+txtTenNhaSanXuat.Text+"',"+cboQuocGia.SelectedValue.ToString()+",N'"+txtDienThoai.Text+"',N'"+txtTrangChu.Text+"',N'"+txtMoTa.Text+"')";
            //ht.CapNhatDuLieu(CauLenh);

            CauLenh = "select " + DanhSachTruong() + " from NhaSanXuat inner join QuocGia on NhaSanXuat.MaQuocGia=QuocGia.MaQuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnCapNhatQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma nha san xuat khac trong
            if (txtMaNhaSanXuat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn nhà sản xuất để sửa thông tin!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Int32 MaNhaSanXuat = Int32.Parse(txtMaNhaSanXuat.Text);

            KiemTraCacTruong();

            string CauLenh = "";
            CauLenh = "update NhaSanXuat set TenNhaSanXuat=N'" + txtTenNhaSanXuat.Text + "', MaQuocGia=" + cboQuocGia.SelectedValue.ToString() + ", DienThoai=N'"+txtDienThoai.Text+"', TrangChu=N'" + txtTrangChu.Text + "', MoTa=N'" + txtMoTa.Text + "' where MaNhaSanXuat="+MaNhaSanXuat;
            //ht.CapNhatDuLieu(CauLenh);

            CauLenh = "select " + DanhSachTruong() + " from NhaSanXuat inner join QuocGia on NhaSanXuat.MaQuocGia=QuocGia.MaQuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma nha san xuat khac trong
            if (txtMaNhaSanXuat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn nhà sản xuất để sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int32 MaNhaSanXuat = Int32.Parse(txtMaNhaSanXuat.Text);

            string CauLenh = "";
            CauLenh = "delete NhaSanXuat where MaNhaSanXuat=" + MaNhaSanXuat;
           // ht.CapNhatDuLieu(CauLenh);

            CauLenh = "select " + DanhSachTruong() + " from NhaSanXuat inner join QuocGia on NhaSanXuat.MaQuocGia=QuocGia.MaQuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }
    }
}