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
    public partial class frmQuanLyNhomNguoiDung : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        HoTro ht;

        public frmQuanLyNhomNguoiDung()
        {
            InitializeComponent();
        }

        private string DanhSachTruong()
        {
            string dst = "";
            if (chkTatCaHienThiQuanLy.Checked)
                dst = "MaNhomNguoiDung as [Mã Nhóm người dùng], NhomNguoiDung as [Nhóm người dùng], MoTa as [Mô tả]";
            else
            {
                dst = "MaNhomNguoiDung as [Mã Nhóm người dùng]";
                if (chkNhomNguoiDungHienThiQuanLy.Checked)
                    dst += ", NhomNguoiDung as [Nhóm người dùng]";
                if (chkMoTaHienThiQuanLy.Checked)
                    dst += ", MoTa as [Mô tả]";
            }
            return dst;
        }

        private string DieuKienTimKiem()
        {
            string Dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                Dk = " where MaNhomNguoiDung like '%" + txtTimKiemQuanLy.Text + "%' or NhomNguoiDung like N'%" + txtTimKiemQuanLy.Text + "%' or MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";
            else
            {
                if (chkMaNhomNguoiDungTimKiemQuanLy.Checked)
                    Dk += " or MaNhomNguoiDung like '%" + txtTimKiemQuanLy.Text + "%'";
                if (chkNhomNguoiDungTimKiemQuanLy.Checked)
                    Dk += " or NhomNguoiDung like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkMoTaTimKiemQuanLy.Checked)
                    Dk += " or MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";

                if (Dk.Trim().Length > 0)
                    Dk = " where " + Dk.Substring(4);
            }
            return Dk;
        }

        private void frmQuanLyNhomNguoiDung_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);

            ht = new HoTro();
            conn = ht.KetNoi();

            string CauLenh = "select "+DanhSachTruong()+" from NhomNguoiDung";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiToanBoQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "select " + DanhSachTruong() + " from NhomNguoiDung";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "select " + DanhSachTruong() + " from NhomNguoiDung " + DieuKienTimKiem();
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTimKiemQuanLy_Click(object sender, EventArgs e)
        {
            if (txtTimKiemQuanLy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập vào xâu tìm kiếm!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTimKiemQuanLy.Focus();
                return;
            }

            if (DieuKienTimKiem().Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn điều kiện tìm kiếm!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTimKiemQuanLy.Focus();
                txtTimKiemQuanLy.SelectAll();
                return;
            }

            string CauLenh = "select " + DanhSachTruong() + " from NhomNguoiDung " + DieuKienTimKiem();
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnDongQuanLy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra nhom nguoi dung khac rong
            //if (txtTenNhomNguoiDung.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa cung cấp nhóm người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtTenNhomNguoiDung.Focus();
            //    return;
            //}

            //string CauLenh = "";
            //CauLenh = "insert NhomNguoiDung(NhomNguoiDung,MoTa) values(N'" + txtTenNhomNguoiDung.Text + "',N'" + txtMoTa.Text + "')";
            //ht.CapNhatDuLieu(CauLenh);

            //CauLenh = "select " + DanhSachTruong() + " from NhomNguoiDung";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnCapNhatQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma nhom nguoi dung khac trong
            //if (txtMaNhomNguoiDung.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa loại sản phẩm để cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            ////kiem tra nhom nguoi dung khac rong
            //if (txtTenNhomNguoiDung.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa cung cấp tên loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtTenNhomNguoiDung.Focus();
            //    return;
            //}

            //Int32 MaNhomNguoiDung = Int32.Parse(txtMaNhomNguoiDung.Text);
            //string CauLenh = "";
            //CauLenh = "update NhomNguoiDung set NhomNguoiDung=N'" + txtTenNhomNguoiDung.Text + "', MoTa=N'" + txtMoTa.Text + "' where MaNhomNguoiDung=" + MaNhomNguoiDung;
            //ht.CapNhatDuLieu(CauLenh);

            //CauLenh = "select " + DanhSachTruong() + " from NhomNguoiDung";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma loai san pham khac trong
            //if (txtMaNhomNguoiDung.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa loại sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //Int32 MaNhomNguoiDung = Int32.Parse(txtMaNhomNguoiDung.Text);
            //string CauLenh = "";
            //CauLenh = "delete NhomNguoiDung where MaNhomNguoiDung=" + MaNhomNguoiDung;
            //ht.CapNhatDuLieu(CauLenh);

            //CauLenh = "select " + DanhSachTruong() + " from NhomNguoiDung";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void dgvQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLy.Rows[e.RowIndex] == null) return;
            if (dgvQuanLy.Rows[e.RowIndex].Cells[0].Value == null) return;

            Int32 MaNhomNguoiDung = (Int32)dgvQuanLy.Rows[e.RowIndex].Cells[0].Value;

            string CauLenh = "select * from NhomNguoiDung where MaNhomNguoiDung=" + MaNhomNguoiDung;

            try
            {
                cmd = new SqlCommand(CauLenh, ht.KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtMaNhomNguoiDung.Text = dr.GetInt32(0).ToString();
                    txtTenNhomNguoiDung.Text = dr.GetString(1);
                    txtMoTa.Text = dr.GetString(2);
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

        private void dgvQuanLy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int SoDong = 0;
            SoDong = dgvQuanLy.Rows.Count;
            if (SoDong > 0)
                --SoDong;
            txtTongSoQuanLy.Text = SoDong.ToString();
        }

        private void btnXoaTrangQuanLy_Click(object sender, EventArgs e)
        {
            txtMaNhomNguoiDung.Text = "";
            txtTenNhomNguoiDung.Text = "";
            txtMoTa.Text = "";
        }

    }
}