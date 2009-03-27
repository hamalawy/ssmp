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
    public partial class frmDanhMucLoaiSanPham : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        HoTro ht;

        public frmDanhMucLoaiSanPham()
        {
            InitializeComponent();
        }

        private string DanhSachTruong()
        {
            string dst = "";
            if (chkTatCaHienThiQuanLy.Checked)
                dst = "MaLoaiSanPham as [Mã loại sản phẩm], LoaiSanPham as [Loại sản phẩm], MoTa as [Mô tả]";
            else
            {
                dst = "MaLoaiSanPham as [Mã loại sản phẩm]";
                if (chkLoaiSanPhamHienThiQuanLy.Checked)
                    dst += ", LoaiSanPham as [Loại sản phẩm]";
                if (chkMoTaHienThiQuanLy.Checked)
                    dst += ", MoTa as [Mô tả]";
            }
            return dst;
        }

        private string DieuKienTimKiem()
        {
            string Dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                Dk = " where MaLoaiSanPham like '%" + txtTimKiemQuanLy.Text + "%' or LoaiSanPham like N'%" + txtTimKiemQuanLy.Text + "%' or MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";
            else
            {
                if (chkMaLoaiSanPhamTimKiemQuanLy.Checked)
                    Dk += " or MaLoaiSanPham like '%" + txtTimKiemQuanLy.Text + "%'";
                if (chkLoaiSanPhamTimKiemQuanLy.Checked)
                    Dk += " or LoaiSanPham like N'%"+txtTimKiemQuanLy.Text+"%'";
                if (chkMoTaTimKiemQuanLy.Checked)
                    Dk += " or MoTa like N'%"+txtTimKiemQuanLy.Text+"%'";

                if (Dk.Trim().Length > 0)
                    Dk = " where " + Dk.Substring(4);
            }
            return Dk;
        }

        private void frmDanhMucLoaiSanPham_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);
            ht = new HoTro();
            conn = ht.KetNoi();
            string CauLenh = "select "+DanhSachTruong()+" from LoaiSanPham";
            ht.HienThiVaoDataGridView(dgvQuanLy,CauLenh);
        }

        private void btnDongQuanLy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra loai san pham khac rong
            if (txtTenLoaiSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa cung cấp tên loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoaiSanPham.Focus();
                return;
            }

            string CauLenh = "";
            CauLenh = "insert LoaiSanPham(LoaiSanPham,MoTa) values(N'"+txtTenLoaiSanPham.Text+"',N'"+txtMoTa.Text+"')";
           // ht.CapNhatDuLieu(CauLenh);

            CauLenh = "select "+DanhSachTruong()+" from LoaiSanPham";
            ht.HienThiVaoDataGridView(dgvQuanLy,CauLenh);
        }

        private void btnTaiLaiToanBoQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "select "+DanhSachTruong()+" from LoaiSanPham";
            ht.HienThiVaoDataGridView(dgvQuanLy,CauLenh);
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "select "+DanhSachTruong()+" from LoaiSanPham "+HoTro.DieuKienTaiLai(dgvQuanLy,"MaLoaiSanPham");
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTimKiemQuanLy_Click(object sender, EventArgs e)
        {
            if (txtTimKiemQuanLy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập vào xâu tìm kiếm!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtTimKiemQuanLy.Focus();
                return;
            }

            if (DieuKienTimKiem().Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn điều kiện tìm kiếm!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtTimKiemQuanLy.Focus();
                txtTimKiemQuanLy.SelectAll();
                return;
            }

            string CauLenh = "select "+DanhSachTruong()+" from LoaiSanPham "+DieuKienTimKiem();
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void dgvDanhSachCacLoaiSanPhamQuanLy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int SoDong = 0;
            SoDong = dgvQuanLy.Rows.Count;
            if (SoDong > 0)
                --SoDong;
            txtTongSoQuanLy.Text = SoDong.ToString();
        }

        private void dgvDanhSachCacLoaiSanPhamQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLy.Rows[e.RowIndex] == null) return;
            if (dgvQuanLy.Rows[e.RowIndex].Cells[0].Value == null) return;

            Int32 MaLoaiSanPham = (Int32)dgvQuanLy.Rows[e.RowIndex].Cells[0].Value;

            string CauLenh = "select * from LoaiSanPham where MaLoaiSanPham="+MaLoaiSanPham;

            try
            {
                cmd = new SqlCommand(CauLenh, ht.KetNoi());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtMaLoaiSanPham.Text = dr.GetInt32(0).ToString();
                    txtTenLoaiSanPham.Text = dr.GetString(1);
                    txtMoTa.Text = dr.GetString(2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc dữ liệu trong cơ sở dữ liệu!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            txtMaLoaiSanPham.Text = "";
            txtTenLoaiSanPham.Text = "";
            txtMoTa.Text = "";
        }

        private void btnCapNhatQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma loai san pham khac trong
            if (txtMaLoaiSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa loại sản phẩm để cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //kiem tra loai san pham khac rong
            if (txtTenLoaiSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa cung cấp tên loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoaiSanPham.Focus();
                return;
            }

            Int32 MaLoaiSanPham = Int32.Parse(txtMaLoaiSanPham.Text);
            string CauLenh = "";
            CauLenh = "update LoaiSanPham set LoaiSanPham=N'" + txtTenLoaiSanPham.Text + "', MoTa=N'" + txtMoTa.Text + "' where MaLoaiSanPham="+MaLoaiSanPham;
            //ht.CapNhatDuLieu(CauLenh);

            CauLenh = "select " + DanhSachTruong() + " from LoaiSanPham";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma loai san pham khac trong
            if (txtMaLoaiSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa loại sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int32 MaLoaiSanPham = Int32.Parse(txtMaLoaiSanPham.Text);
            string CauLenh = "";
            CauLenh = "delete LoaiSanPham where MaLoaiSanPham=" + MaLoaiSanPham;
            //ht.CapNhatDuLieu(CauLenh);

            CauLenh = "select " + DanhSachTruong() + " from LoaiSanPham";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }
    }
}