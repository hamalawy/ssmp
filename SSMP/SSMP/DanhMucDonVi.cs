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
    public partial class frmQuanLyDonVi : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;
        HoTro ht;

        public frmQuanLyDonVi()
        {
            InitializeComponent();
        }

        private void frmQuanLyDonVi_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);

            ht = new HoTro();
            conn = ht.KetNoi();
            string CauLenh = "select "+DanhSachTruong()+" from DonVi";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private string DanhSachTruong()
        {
            string dst = "";
            if (chkTatCaHienThiQuanLy.Checked)
                dst = "MaDonVi as [Mã Đơn vị], DonVi as [Đơn vị], MoTa as [Mô tả]";
            else
            {
                dst = "MaDonVi as [Mã Đơn vị]";
                if (chkDonViHienThiQuanLy.Checked)
                    dst += ", DonVi as [Đơn vị]";
                if (chkMoTaHienThiQuanLy.Checked)
                    dst += ", MoTa as [Mô tả]";
            }
            return dst;
        }

        private string DieuKienTimKiem()
        {
            string Dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                Dk = " where MaDonVi like '%" + txtTimKiemQuanLy.Text + "%' or DonVi like N'%" + txtTimKiemQuanLy.Text + "%' or MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";
            else
            {
                if (chkMaDonViTimKiemQuanLy.Checked)
                    Dk += " or MaDonVi like '%" + txtTimKiemQuanLy.Text + "%'";
                if (chkDonViTimKiemQuanLy.Checked)
                    Dk += " or DonVi like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkMoTaTimKiemQuanLy.Checked)
                    Dk += " or MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";

                if (Dk.Trim().Length > 0)
                    Dk = " where " + Dk.Substring(4);
            }
            return Dk;
        }

        private void btnTaiLaiToanBoQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "select " + DanhSachTruong() + " from DonVi";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "select " + DanhSachTruong() + " from DonVi "+HoTro.DieuKienTaiLai(dgvQuanLy,"MaDonVi");
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnDongQuanLy_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

            string CauLenh = "select " + DanhSachTruong() + " from DonVi " + DieuKienTimKiem();
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void dgvQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLy.Rows[e.RowIndex] == null) return;
            if (dgvQuanLy.Rows[e.RowIndex].Cells[0].Value == null) return;

            Int32 MaDonVi = (Int32)dgvQuanLy.Rows[e.RowIndex].Cells[0].Value;

            string CauLenh = "select * from DonVi where MaDonVi=" + MaDonVi;

            try
            {
                cmd = new SqlCommand(CauLenh, ht.KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtMaDonVi.Text = dr.GetInt32(0).ToString();
                    txtTenDonVi.Text = dr.GetString(1);
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

        private void btnXoaTrangQuanLy_Click(object sender, EventArgs e)
        {
            txtMaDonVi.Text = "";
            txtTenDonVi.Text = "";
            txtMoTa.Text = "";
        }

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ten don vi khac rong
            if (txtTenDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập vào tên đơn vị!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTenDonVi.Focus();
                return;
            }

            string CauLenh = "";
            CauLenh = "insert DonVi(DonVi,MoTa) values(N'"+txtTenDonVi.Text+"',N'"+txtMoTa.Text+"')";
            //ht.CapNhatDuLieu(CauLenh);
            CauLenh = "select "+DanhSachTruong()+" from DonVi";
            ht.HienThiVaoDataGridView(dgvQuanLy,CauLenh);
        }

        private void dgvQuanLy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int SoDong = 0;
            SoDong = dgvQuanLy.Rows.Count;
            if (SoDong > 0)
                --SoDong;
            txtTongSoQuanLy.Text = SoDong.ToString();
        }

        private void btnCapNhatQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma don vi khac trong
            if (txtMaDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn đơn vị để sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //kiem tra ten don vi khac rong
            if (txtTenDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập vào tên đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDonVi.Focus();
                return;
            }

            Int32 MaDonVi = Int32.Parse(txtMaDonVi.Text);

            string CauLenh = "";
            CauLenh = "update DonVi set DonVi=N'" + txtTenDonVi.Text + "',MoTa=N'" + txtMoTa.Text + "' where MaDonVi="+MaDonVi;
            //ht.CapNhatDuLieu(CauLenh);
            CauLenh = "select " + DanhSachTruong() + " from DonVi";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma don vi khac trong
            if (txtMaDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn đơn vị để sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int32 MaDonVi = Int32.Parse(txtMaDonVi.Text);

            string CauLenh = "";
            CauLenh = "delete DonVi where MaDonVi=" + MaDonVi;
            //ht.CapNhatDuLieu(CauLenh);
            CauLenh = "select " + DanhSachTruong() + " from DonVi";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }
    }
}