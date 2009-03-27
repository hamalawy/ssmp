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
    public partial class frmDanhMucQuocGia : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        HoTro ht;

        public frmDanhMucQuocGia()
        {
            InitializeComponent();
        }

        private string DanhSachTruong()
        {
            string dst = "";
            if (chkTatCaHienThiQuanLy.Checked)
                dst = "MaQuocGia as [Mã Quốc gia], QuocGia as [Quốc gia], MoTa as [Mô tả]";
            else
            {
                dst = "MaQuocGia as [Mã Quốc gia]";
                if (chkQuocGiaHienThiQuanLy.Checked)
                    dst += ", QuocGia as [Quốc gia]";
                if (chkMoTaHienThiQuanLy.Checked)
                    dst += ", MoTa as [Mô tả]";
            }
            return dst;
        }

        private string DieuKienTimKiem()
        {
            string Dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                Dk = " where MaQuocGia like '%" + txtTimKiemQuanLy.Text + "%' or QuocGia like N'%" + txtTimKiemQuanLy.Text + "%' or MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";
            else
            {
                if (chkMaQuocGiaTimKiemQuanLy.Checked)
                    Dk += " or MaQuocGia like '%" + txtTimKiemQuanLy.Text + "%'";
                if (chkQuocGiaTimKiemQuanLy.Checked)
                    Dk += " or QuocGia like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkMoTaTimKiemQuanLy.Checked)
                    Dk += " or MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";

                if (Dk.Trim().Length > 0)
                    Dk = " where " + Dk.Substring(4);
            }
            return Dk;
        }

        private void frmDanhMucQuocGia_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);

            ht = new HoTro();
            conn = ht.KetNoi();
            string CauLenh = "";
            CauLenh = "select "+DanhSachTruong()+" from QuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy,CauLenh);
        }

        private void btnTaiLaiTatCaQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from QuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from QuocGia "+HoTro.DieuKienTaiLai(dgvQuanLy,"MaQuocGia");
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

            string CauLenh = "select " + DanhSachTruong() + " from QuocGia " + DieuKienTimKiem();
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void dgvQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLy.Rows[e.RowIndex] == null) return;
            if (dgvQuanLy.Rows[e.RowIndex].Cells[0].Value == null) return;

            Int32 MaQuocGia = (Int32)dgvQuanLy.Rows[e.RowIndex].Cells[0].Value;

            string CauLenh = "select * from QuocGia where MaQuocGia=" + MaQuocGia;

            try
            {
                cmd = new SqlCommand(CauLenh, ht.KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtMaQuocGia.Text = dr.GetInt32(0).ToString();
                    txtTenQuocGia.Text = dr.GetString(1);
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

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ten quoc gia khac trong
            if (txtTenQuocGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập vào tên quốc gia!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenQuocGia.Focus();
                return;
            }

            string CauLenh = "";
            CauLenh = "insert QuocGia(QuocGia,MoTa) values(N'"+txtTenQuocGia.Text+"',N'"+txtMoTa.Text+"')";
           // ht.CapNhatDuLieu(CauLenh);
            CauLenh = "select "+DanhSachTruong()+" from QuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy,CauLenh);
        }

        private void btnCapNhatQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma quoc gia khac trong
            if (txtMaQuocGia.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn chưa lựa chọn quốc gia để cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenQuocGia.Focus();
                txtTenQuocGia.SelectAll();
                return;
            }

            //kiem tra ten quoc gia khac trong
            if (txtTenQuocGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập vào tên quốc gia!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTenQuocGia.Focus();
                return;
            }

            Int32 MaQuocGia = Int32.Parse(txtMaQuocGia.Text);
            string CauLenh = "";
            CauLenh = "update QuocGia set QuocGia=N'" + txtTenQuocGia.Text + "',MoTa=N'" + txtMoTa.Text + "' where MaQuocGia="+MaQuocGia;
           // ht.CapNhatDuLieu(CauLenh);
            CauLenh = "select " + DanhSachTruong() + " from QuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma quoc gia khac trong
            if (txtMaQuocGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn quốc gia để cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenQuocGia.Focus();
                txtTenQuocGia.SelectAll();
                return;
            }

            Int32 MaQuocGia = Int32.Parse(txtMaQuocGia.Text);
            string CauLenh = "";
            CauLenh = "delete QuocGia where MaQuocGia=" + MaQuocGia;
            //ht.CapNhatDuLieu(CauLenh);
            CauLenh = "select " + DanhSachTruong() + " from QuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaTrangQuanLy_Click(object sender, EventArgs e)
        {
            txtMaQuocGia.Text = "";
            txtTenQuocGia.Text = "";
            txtMoTa.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvQuanLy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int SoDong = 0;
            SoDong = dgvQuanLy.Rows.Count;
            if (SoDong > 0)
                --SoDong;
            txtTongSoQuanLy.Text = SoDong.ToString();
        }
    }
}