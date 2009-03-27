using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SSMP
{
    public partial class frmQuanLyChucVu : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        HoTro ht;

        public frmQuanLyChucVu()
        {
            InitializeComponent();
        }

        private string DanhSachTruong()
        {
            string dst = "";
            if (chkTatCaHienThiQuanLy.Checked)
                dst = "MaChucVu as [Mã Chức vụ], ChucVu as [Chức vụ], MoTa as [Mô tả]";
            else
            {
                dst = "MaChucVu as [Mã Chức vụ]";
                if (chkChucVuHienThiQuanLy.Checked)
                    dst += ", ChucVu as [Chức vụ]";
                if (chkMoTaHienThiQuanLy.Checked)
                    dst += ", MoTa as [Mô tả]";
            } 
            return dst;
        }

        private string DieuKienTimKiem()
        {
            string dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                dk = " where MaChucVu like '%" + txtTimKiemQuanLy.Text + "%' or ChucVu like N'%" + txtTimKiemQuanLy.Text + "%' or MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";
            else
            {
                if (chkMaChucVuTimKiemQuanLy.Checked)
                    dk += " or MaChucVu like '%" + txtTimKiemQuanLy.Text+"%'";
                if (chkChucVuHienThiQuanLy.Checked)
                    dk += " or ChucVu like '%" + txtTimKiemQuanLy.Text+"%'";
                if (chkMoTaHienThiQuanLy.Checked)
                    dk += " or MoTa like '%"+txtTimKiemQuanLy.Text+"%'";

                if (dk.Trim().Length > 0)
                    dk = " where " + dk.Substring(4);
            }
            return dk;
        }

        private void QuanLyChucVu_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);

            ht = new HoTro();
            conn = ht.KetNoi();

            string CauLenh = "";
            CauLenh = "select "+DanhSachTruong()+" from ChucVu";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiToanBoQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from ChucVu";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from ChucVu "+HoTro.DieuKienTaiLai(dgvQuanLy,"MaChucVu");
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnDongQuanLy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTimKiemQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra xau tim kiem khac rong
            //if (txtTimKiemQuanLy.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa nhập vào xâu tìm kiêm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    txtTimKiemQuanLy.Focus();
            //    return;
            //}

            //string CauLenh = "";
            //CauLenh = "select " + DanhSachTruong() + " from ChucVu "+DieuKienTimKiem();
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaChucVu.Text = "";
            txtChucVu.Text = "";
            txtMoTa.Text = "";
        }

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ten chuc vu khac rong
            //if (txtChucVu.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa nhập vào tên chức vụ!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    txtChucVu.Focus();
            //    return;
            //}

            //string CauLenh = "";
            //CauLenh = "insert ChucVu(ChucVu,MoTa) values(N'"+txtChucVu.Text+"',N'"+txtChucVu.Text+"')" ;
            //ht.CapNhatDuLieu(CauLenh);

            //CauLenh = "select " + DanhSachTruong() + " from ChucVu";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void dgvQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvQuanLy.Rows[e.RowIndex] == null) return;
            //if (dgvQuanLy.Rows[e.RowIndex].Cells[0].Value == null) return;

            //Int32 MaChucVu = 0;

            //MaChucVu = (Int32)dgvQuanLy.Rows[e.RowIndex].Cells[0].Value;

            //string CauLenh = "";
            //CauLenh = "select * from ChucVu where MaChucVu="+MaChucVu;
            //try
            //{
            //    cmd = new SqlCommand(CauLenh,conn);
            //    cmd.Connection.Open();
            //    dr = cmd.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        txtMaChucVu.Text = dr.GetInt32(0).ToString();
            //        txtChucVu.Text = dr.GetString(1);
            //        txtMoTa.Text = dr.GetString(2);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi đọc dữ liệu trong cơ sở dữ liệu!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    try
            //    {
            //        if (dr != null) dr.Close();
            //        if (cmd != null) cmd.Connection.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi đóng kết nối đến cơ sở dữ liệu!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //kiem tra ma chuc vu khac rong
            //if (txtMaChucVu.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa lựa chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtMaChucVu.Focus();
            //    return;
            //}

            //Int32 MaChucVu = Int32.Parse(txtMaChucVu.Text);

            ////kiem tra ten chuc vu khac rong
            //if (txtChucVu.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa nhập vào tên chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtChucVu.Focus();
            //    return;
            //}

            //string CauLenh = "";
            //CauLenh = "update ChucVu set ChucVu=N'" + txtChucVu.Text + "', MoTa=N'" + txtMoTa.Text + "' where MaChucVu="+MaChucVu;
            //ht.CapNhatDuLieu( CauLenh);

            //CauLenh = "select " + DanhSachTruong() + " from ChucVu";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma chuc vu khac rong
            //if (txtMaChucVu.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa lựa chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtMaChucVu.Focus();
            //    return;
            //}

            //Int32 MaChucVu = Int32.Parse(txtMaChucVu.Text);

            //string CauLenh = "";
            //CauLenh = "delete ChucVu where MaChucVu="+MaChucVu;
            //ht.CapNhatDuLieu(CauLenh);

            //CauLenh = "select " + DanhSachTruong() + " from ChucVu";
            //ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }
    }
}