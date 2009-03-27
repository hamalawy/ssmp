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
    public partial class frmQuanLyHanhDong : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        HoTro ht;

        public frmQuanLyHanhDong()
        {
            InitializeComponent();
        }

        private string DanhSachTruong()
        {
            string dst = "";
            if (chkTatCaHienThiQuanLy.Checked)
                dst = "MaHanhDong as [Mã Hành động], HanhDong as [Hành động], MoTa as [Mô tả]";
            else
            {
                dst = "MaHanhDong as [Mã Hành động]";
                if (chkHanhDongHienThiQuanLy.Checked)
                    dst += ", HanhDong as [Hành động]";
                if (chkMoTaHienThiQuanLy.Checked)
                    dst += ", MoTa as [Mô tả]";
            }
            return dst;
        }

        private string DieuKienTimKiem()
        {
            string Dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                Dk = " where MaHanhDong like '%" + txtTimKiemQuanLy.Text + "%' or HanhDong like N'%" + txtTimKiemQuanLy.Text + "%' or MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";
            else
            {
                if (chkMaHanhDongTimKiemQuanLy.Checked)
                    Dk += " or MaHanhDong like '%" + txtTimKiemQuanLy.Text + "%'";
                if (chkHanhDongTimKiemQuanLy.Checked)
                    Dk += " or HanhDong like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkMoTaTimKiemQuanLy.Checked)
                    Dk += " or MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";

                if (Dk.Trim().Length > 0)
                    Dk = " where " + Dk.Substring(4);
            }
            return Dk;
        }

        private void frmQuanLyHanhDong_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);

            ht = new HoTro();
            conn = ht.KetNoi();

            string CauLenh = "";
            CauLenh="select "+DanhSachTruong()+" from HanhDong";
            ht.HienThiVaoDataGridView(dgvQuanLy,CauLenh);
        }

        private void btnTaiLaiTatCaQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from HanhDong";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select "+DanhSachTruong()+" from HanhDong "+HoTro.DieuKienTaiLai(dgvQuanLy,"MaHanhDong");
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnDongQuanLy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvQuanLy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Int32 SoDong = 0;
            SoDong = dgvQuanLy.Rows.Count;
            if (SoDong > 0)
                --SoDong;
            txtTongSoQuanLy.Text= SoDong.ToString();
        }

        private void dgvQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLy.Rows[e.RowIndex] == null) return;
            if (dgvQuanLy.Rows[e.RowIndex].Cells[0].Value == null) return;

            Int32 MaHanhDong = (Int32)dgvQuanLy.Rows[e.RowIndex].Cells[0].Value;

            string CauLenh = "select * from HanhDong where MaHanhDong="+MaHanhDong;
            try
            {
                cmd = new SqlCommand(CauLenh, conn);
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtMaHanhDong.Text = dr.GetInt32(0).ToString();
                    txtTenHanhDong.Text = dr.GetString(1);
                    txtMoTa.Text = dr.GetString(2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc dữ liệu trong cơ sở dữ liệu!" , "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Bạn chưa nhập vào xâu tìm kiếm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTimKiemQuanLy.Focus();
                return;
            }

            string CauLenh = "";
            CauLenh = "select "+DanhSachTruong()+" from HanhDong "+DieuKienTimKiem();
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ten hanh dong khac rong
            if (txtTenHanhDong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập vào tên hành động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHanhDong.Focus();
                return;
            }

            string CauLenh = "";
            CauLenh = "insert HanhDong(HanhDong,MoTa) values(N'" + txtTenHanhDong.Text + "',N'" + txtMoTa.Text + "')";
            //ht.CapNhatDuLieu(CauLenh);

            CauLenh = "select "+DanhSachTruong()+" from HanhDong";
            ht.HienThiVaoDataGridView(dgvQuanLy,CauLenh);
        }

        private void btnXoaTrangQuanLy_Click(object sender, EventArgs e)
        {
            txtMaHanhDong.Text = "";
            txtTenHanhDong.Text = "";
            txtMoTa.Text = "";
        }
    }
}