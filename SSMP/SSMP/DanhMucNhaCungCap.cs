using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;

namespace SSMP
{
    public partial class frmDanhMucNhaCungCap : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;
        SqlCommand cmd;
        HoTro ht;

        public frmDanhMucNhaCungCap()
        {
            InitializeComponent();
        }

        private string DanhSachTruong()
        {
            string dst = "";
            if (chkTatCaHienThiQuanLy.Checked)
                dst = "NhaCungCap.MaNhaCungCap as [Mã Nhà cung cấp], NhaCungCap.NhaCungCap as [Nhà cung cấp], NhaCungCap.DiaChi as [Địa chỉ], NhaCungCap.DienThoai as [Điện thoại], NhaCungCap.Fax as [Fax], NhaCungCap.WebSite as [Trang chủ], NhaCungCap.ThuDienTu as [Thư điện tử],QuocGia.QuocGia as [Quốc gia], NhaCungCap.MoTa as [Mô tả]";
            else
            {
                dst = "NhaCungCap.MaNhaCungCap as [Mã Nhà cung cấp]";
                if (chkQuocGiaHienThiQuanLy.Checked)
                    dst += ", NhaCungCap.NhaCungCap as [Nhà cung cấp]";
                if (chkDiaChiHienThiQuanLy.Checked)
                    dst += ", NhaCungCap.DiaChi as [Địa chỉ]";
                if (chkDienThoaiHienThiQuanLy.Checked)
                    dst += ", NhaCungCap.DienThoai as [Điện thoại]";
                if (chkFaxHienThiQuanLy.Checked)
                    dst += ", NhaCungCap.Fax as [Fax]";
                if (chkWebSiteHienThiQuanLy.Checked)
                    dst += ", NhaCungCap.WebSite as [Trang chủ]";
                if (chkThuDienTuHienThiQuanLy.Checked)
                    dst += ", NhaCungCap.ThuDienTu as [Thư điện tử]";
                if (chkQuocGiaHienThiQuanLy.Checked)
                    dst += ", QuocGia.QuocGia as [Quốc gia]";
                if (chkMoTaHienThiQuanLy.Checked)
                    dst += ", MoTa as [Mô tả]";
            }
            return dst;
        }

        private string DieuKienTimKiem()
        {
            string Dk = "";
            if (chkTatCaTimKiemQuanLy.Checked)
                Dk = " where NhaCungCap.MaNhaCungCap like '%" + txtTimKiemQuanLy.Text + "%' or NhaCungCap.NhaCungCap like N'%" + txtTimKiemQuanLy.Text + "%' or DiaChi like N'%" + txtTimKiemQuanLy.Text + "%' or NhaCungCap.DienThoai like N'%"+txtTimKiemQuanLy.Text+"%' or NhaCungCap.Fax like N'%"+txtTimKiemQuanLy.Text+"%' or NhaCungCap.WebSite like N'%"+txtTimKiemQuanLy.Text+"%' or NhaCungCap.ThuDienThu like N'%"+txtTimKiemQuanLy.Text+"' or QuocGia.QuocGia like N'%"+txtTimKiemQuanLy.Text+"%' or NhaCungCap.MoTa like N'%"+txtTimKiemQuanLy.Text+"%'";
            else
            {
                if (chkMaNhaCungCapTimKiemQuanLy.Checked)
                    Dk += " or NhaCungCap.MaNhaCungCap like '%" + txtTimKiemQuanLy.Text + "%'";
                if (chkNhaCungCapTimKiemQuanLy.Checked)
                    Dk += " or NhaCungCap.NhaCungCap like N'%" + txtTimKiemQuanLy.Text + "%'";
                if (chkDiachiTimKiemQuanLy.Checked)
                    Dk += " or NhaCungCap.DiaChi like N'%"+txtTimKiemQuanLy.Text+"%'";
                if (chkDienThoaiTimKiemQuanLy.Checked)
                    Dk += " or NhaCungCap.DienThoai like N'%"+txtTimKiemQuanLy.Text+"%'";
                if (chkFaxTimKiemQuanLy.Checked)
                    Dk += " or NhaCungCap.Fax like N'%"+txtFax.Text+"%'";
                if (chkWebSiteTimKiemQuanLy.Checked)
                    Dk += " or NhaCungCap.WebSite like N'%"+txtTimKiemQuanLy.Text+"%'";
                if (chkThuDienTuTimKiemQuanLy.Checked)
                    Dk += " or NhaCungCap.ThuDienTu like N'%"+txtTimKiemQuanLy.Text+"%'";
                if (chkQuocGiaTimKiemQuanLy.Checked)
                    Dk += " or QuocGia.QuocGia like N'%"+txtTimKiemQuanLy.Text+"%'";
                if (chkMoTaTimKiemQuanLy.Checked)
                    Dk += " or NhaCungCap.MoTa like N'%" + txtTimKiemQuanLy.Text + "%'";

                if (Dk.Trim().Length > 0)
                    Dk = " where " + Dk.Substring(4);
            }
            return Dk;
        }

        private void frmDanhMucNhaCungCap_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2);

            ht = new HoTro();
            conn = ht.KetNoi();
            
            ht.TaiDuLieu(cboQuocGia, "QuocGia", "MaQuocGia", "QuocGia");
            string CauLenh = "";
            CauLenh = "select "+DanhSachTruong()+" from NhaCungCap inner join QuocGia on NhaCungCap.MaQuocGia=QuocGia.MaQuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy,CauLenh);
        }

        private void KiemTraCacTruong()
        {
            //kiem tra ten nha cung cap
            if (txtTenNhaCungCap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtTenNhaCungCap.Focus();
                return;
            }

            //kiem tra dia chi
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhà cung cấp!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return;
            }

            //kiem tra so dien thoai
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập điện thoại nhà cung cấp!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                return;
            }

            string DienThoaiMau = @"^\(\d{3}\)\(\d{2,3}\)\d{1}\d{5,9}$";
            bool KetQuaDienThoai = Regex.IsMatch(txtDienThoai.Text, DienThoaiMau);
            if (!KetQuaDienThoai)
            {
                MessageBox.Show("Điện thoại nhà cung cấp không đúng định dạng!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                txtDienThoai.SelectAll();
                return;
            }

            //kiem tra fax
            if (txtFax.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số fax nhà cung cấp!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFax.Focus();
                return;
            }

            string FaxMau = @"^\(\d{3}\)\(\d{2,3}\)\d{1}\d{5,9}$";
            bool KetQuaFax = Regex.IsMatch(txtFax.Text, FaxMau);
            if (!KetQuaFax)
            {
                MessageBox.Show("Số fax nhà cung cấp không đúng định dạng!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFax.Focus();
                txtFax.SelectAll();
                return;
            }

            //kiem tra website
            if (txtWebSite.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập website của nhà cung cấp!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtWebSite.Focus();
                return;
            }

            string WebSiteMau = @"^(http://)?(www\.)?\w+\.\w{2,3}(\.\w{2})?$";
            bool KetQuaWebSite = Regex.IsMatch(txtWebSite.Text, WebSiteMau);
            if (!KetQuaWebSite)
            {
                MessageBox.Show("Bạn nhập website nhà cung cấp không đúng định dạng!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWebSite.Focus();
                txtWebSite.SelectAll();
                return;
            }

            //kiem tra thu dien tu
            if (txtThuDienTu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ thư điện tử của nhà cung cấp!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThuDienTu.Focus();
                return;
            }

            string ThuDienTuMau = @"^\w+\.?\w+\@\w+\.\w{2,3}(\.\w{2,3})?$";
            bool KetQuaThuDienTu = Regex.IsMatch(txtThuDienTu.Text, ThuDienTuMau);
            if (!KetQuaThuDienTu)
            {
                MessageBox.Show("Bạn nhập thư điện tử nhà sản xuất không đúng định dạng!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThuDienTu.Focus();
                txtThuDienTu.SelectAll();
                return;
            }

            //kiem tra quoc gia duoc lua chon
            if (cboQuocGia.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa lựa chọn tên quốc gia!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboQuocGia.Focus();
                return;
            }
        }

        private void btnTaiLaiToanBoQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from NhaCungCap inner join QuocGia on NhaCungCap.MaQuocGia=QuocGia.MaQuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnTaiLaiQuanLy_Click(object sender, EventArgs e)
        {
            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from NhaCungCap inner join QuocGia on NhaCungCap.MaQuocGia=QuocGia.MaQuocGia"+HoTro.DieuKienTaiLai(dgvQuanLy,"NhaCungCap.MaNhaCungCap");
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void dgvQuanLy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLy.Rows[e.RowIndex] == null) return;
            if (dgvQuanLy.Rows[e.RowIndex].Cells[0].Value == null) return;

            Int32 MaNhaCungCap = (Int32)dgvQuanLy.Rows[e.RowIndex].Cells[0].Value;

            string CauLenh = "";
            CauLenh = "select * from NhaCungCap where MaNhaCungCap="+MaNhaCungCap;

            try
            {
                cmd = new SqlCommand(CauLenh, conn);
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtMaNhaCungCap.Text = dr.GetInt32(0).ToString();
                    txtTenNhaCungCap.Text = dr.GetString(1);
                    txtDiaChi.Text = dr.GetString(2);
                    txtDienThoai.Text = dr.GetString(3);
                    txtFax.Text = dr.GetString(4);
                    txtWebSite.Text = dr.GetString(5);
                    txtThuDienTu.Text = dr.GetString(6);
                    cboQuocGia.SelectedValue = dr.GetInt32(7);
                    txtMoTa.Text = dr.GetString(8);
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
                    MessageBox.Show("Lỗi đóng kết nối đến cơ sở dữ liệu!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiemQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra xau tim kiem khac rong
            if (txtTimKiemQuanLy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập vào xâu tìm kiếm!","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTimKiemQuanLy.Focus();
                return;
            }

            if (DieuKienTimKiem().Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn điều kiện tìm kiếm!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimKiemQuanLy.Focus();
                txtTimKiemQuanLy.SelectAll();
                return;
            }

            string CauLenh = "";
            CauLenh = "select " + DanhSachTruong() + " from NhaCungCap inner join QuocGia on NhaCungCap.MaQuocGia=QuocGia.MaQuocGia " + DieuKienTimKiem();
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void dgvQuanLy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int SoDong = 0;
            SoDong = dgvQuanLy.Rows.Count;
            if (SoDong>0)
                --SoDong;
            txtTongSoQuanLy.Text = SoDong.ToString();
        }

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            KiemTraCacTruong();

            string CauLenh = "";
            CauLenh = "insert NhaCungCap(NhaCungCap,DiaChi,DienThoai,Fax,WebSite,ThuDienTu,MaQuocGia,MoTa) values(N'" + txtTenNhaCungCap.Text + "',N'" + txtDiaChi.Text + "',N'" + txtDienThoai.Text + "',N'" + txtFax.Text + "',N'" + txtWebSite.Text + "',N'" + txtThuDienTu.Text + "'," + cboQuocGia.SelectedValue.ToString() + ",N'" + txtMoTa.Text + "')";
            //ht.CapNhatDuLieu(CauLenh);

            CauLenh = "select " + DanhSachTruong() + " from NhaCungCap inner join QuocGia on NhaCungCap.MaQuocGia=QuocGia.MaQuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnCapNhatQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma nha cung cap khac rong
            if (txtMaNhaCungCap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn nhà cung cấp để sửa đổi thông tin!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Int32 MaNhaCungCap = 0;
            MaNhaCungCap = Int32.Parse(txtMaNhaCungCap.Text);

            KiemTraCacTruong();

            string CauLenh = "";
            CauLenh = CauLenh = "update NhaCungCap set NhaCungCap=N'" + txtTenNhaCungCap.Text + "',DiaChi=N'" + txtDiaChi.Text + "',DienThoai=N'" + txtDienThoai.Text + "',Fax=N'" + txtFax.Text + "',WebSite=N'" + txtWebSite.Text + "',ThuDienTu=N'" + txtThuDienTu.Text + "',MaQuocGia=" + cboQuocGia.SelectedValue.ToString() + ",MoTa=N'" + txtMoTa.Text + "' where MaNhaCungCap=" + MaNhaCungCap;
            //ht.CapNhatDuLieu(CauLenh);

            CauLenh = "select " + DanhSachTruong() + " from NhaCungCap inner join QuocGia on NhaCungCap.MaQuocGia=QuocGia.MaQuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaQuanLy_Click(object sender, EventArgs e)
        {
            //kiem tra ma nha cung cap khac rong
            if (txtMaNhaCungCap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa lựa chọn nhà cung cấp để sửa đổi thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int32 MaNhaCungCap = 0;
            MaNhaCungCap = Int32.Parse(txtMaNhaCungCap.Text);

            string CauLenh = "";
            CauLenh = CauLenh = "delete NhaCungCap where MaNhaCungCap=" + MaNhaCungCap;
            //ht.CapNhatDuLieu(CauLenh);

            CauLenh = "select " + DanhSachTruong() + " from NhaCungCap inner join QuocGia on NhaCungCap.MaQuocGia=QuocGia.MaQuocGia";
            ht.HienThiVaoDataGridView(dgvQuanLy, CauLenh);
        }

        private void btnXoaTrangQuanLy_Click(object sender, EventArgs e)
        {
            txtMaNhaCungCap.Text = "";
            txtTenNhaCungCap.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtFax.Text = "";
            txtWebSite.Text = "";
            txtThuDienTu.Text = "";
            txtMoTa.Text = "";
            cboQuocGia.SelectedIndex = -1;
        }
    }
}