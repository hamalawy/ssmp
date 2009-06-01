using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SSMP
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }

        public void setSelectedTab(int selectedTab)
        {
            tabControl1.SelectedIndex = selectedTab;
        }

        private void btnDuaVaoPhieuXuat_Click(object sender, EventArgs e)
        {
            try
            {

                Int64.Parse(comboBoxId.Text);
                Int32.Parse(comboBoxIdKh.Text);
                HoTro ht = new HoTro();
                SqlConnection conn = ht.KetNoi() ;
                conn.Open() ;
                SqlCommand command = new SqlCommand("select CustomerName from Customer where CustomerId = @khachhang", conn);
                command.Parameters.Add("@khachhang", comboBoxIdKh.Text);
                String khachHang = command.ExecuteScalar().ToString();

                command = new SqlCommand("select ProdName from ProductName where ProductNameId = (select max(ProductNameId) " +
                    " from  Product where ProductId = @id)", conn);
                command.Parameters.Add("@id", Int64.Parse(comboBoxId.Text));
                String tenSp = command.ExecuteScalar().ToString();

                command = new SqlCommand("select UnitName from Units where UnitId = (select max (UnitId) from Product " +
                    "where ProductId = @id)", conn);
                command.Parameters.Add("@id", comboBoxId.Text);
                String donvi = command.ExecuteScalar().ToString();

                command = new SqlCommand("select SalePrice from Product where ProductId = @id", conn);
                command.Parameters.Add("@id", Int64.Parse(comboBoxId.Text));
                String giaBan = command.ExecuteScalar().ToString();

                command = new SqlCommand("select Discount from Product where ProductId = @id", conn);
                command.Parameters.Add("@id", Int64.Parse(comboBoxId.Text));
                String giamGia = command.ExecuteScalar().ToString();

                conn.Close();
                String[] data = new String[] { comboBoxId.Text, khachHang, tenSp, donvi, giaBan, giamGia };
                dataGridViewDS.Rows.Add(data);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.StackTrace);
                HoTro.baoLoi("Dữ liệu nhập sai !");
            }
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            txtNgayThang.Text = DateTime.Now.ToString("dd/MM/yyyy");    
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                HoTro ht = new HoTro() ;
                SqlConnection conn = ht.KetNoi();
                conn.Open();
                SqlCommand command = new SqlCommand();
                
                int maNguoiDung = ht.LayGiaTriTruongKhoaVuaChen("Users", "UserId");
                for (int i = 0; i < dataGridViewDS.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridViewDS.Rows[i];
                    // insert PhieuXuatKho
                    command = new SqlCommand("select CustomerId from Customer where CusTomerName=@Cusname", conn);
                    command.Parameters.Add("@CusNAme", row.Cells[1].Value.ToString());
                    int cusId = Int32.Parse(command.ExecuteScalar().ToString()) ;

                    command = new SqlCommand("insert into BillSale values(@ngaythang, @nguoiMua, @manguoiDung)");
                    command.Parameters.Add("@ngaythang", ht.toSQLDateTime(txtNgayThang.Text));
                    command.Parameters.Add("@nguoiMua", cusId);
                    command.Parameters.Add("@manguoiDung", maNguoiDung);
                    ht.CapNhatDuLieu(command);
                    
                    // update Product 
                    Int64 billSaleId = ht.LayGiaTriTruongKhoaVuaChen2("BillSale", "BillSaleId");

                    command = new SqlCommand("update Product set StatusId = 2, billSaleId=@billSaleId where ProductId = @id");
                    command.Parameters.Add("@id", Int64.Parse(row.Cells[0].Value.ToString()));
                    command.Parameters.Add("@billSaleId", billSaleId);
                    ht.CapNhatDuLieu(command);
                }
                HoTro.thongBao("Đã cập nhật !");
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.StackTrace);
                HoTro.baoLoi(ex.Message);
            }
        }

        private void checkBoxId_CheckedChanged(object sender, EventArgs e)
        {
            idProduct.Visible = (!idProduct.Visible);
        }

        private void checkBoxKh_CheckedChanged(object sender, EventArgs e)
        {
            cltenKhachhang.Visible = (!cltenKhachhang.Visible);
        }

        private void checkBoxTen_CheckedChanged(object sender, EventArgs e)
        {
            clTenSp.Visible = (!clTenSp.Visible);
        }

        private void checkBoxDonVi_CheckedChanged(object sender, EventArgs e)
        {
            clDonVi.Visible = (!clDonVi.Visible);
        }

        private void checkBoxGiaBan_CheckedChanged(object sender, EventArgs e)
        {
            clGiaBan.Visible = (!clGiaBan.Visible);
        }

        private void checkBoxGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            clGiamGia.Visible = (!clGiamGia.Visible);
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void taiDuLieu() {
            HoTro ht = new HoTro();
            if (tabControl1.SelectedIndex == 0)
            {
                ht.TaiDuLieu(comboBoxId, "Product", "ProductId", "ProductId");
                ht.TaiDuLieu(comboBoxIdKh, "Customer", "CustomerId", "CustomerId");
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                string caulenh = "select BillSaleId as 'Mã phiếu', convert(varchar,createDate,103)  as 'Ngày tạo',Customername as 'Tên khách hàng', FullName as 'Người lập phiếu' " +
                             "from BillSale join Customer" +
                             " on BillSale.CustomerId = Customer.CustomerId" +
                             " inner join Users " +
                             "on BillSale.UserId = Users.UserId";
                ht.HienThiVaoDataGridView(dataGridViewDSPhieuBan, caulenh);
            }
        }


        private void checkBoxMaPhieu_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewDSPhieuBan.Columns[0].Visible = !dataGridViewDSPhieuBan.Columns[0].Visible;
        }

        private void cbngaytao_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewDSPhieuBan.Columns[1].Visible = !dataGridViewDSPhieuBan.Columns[1].Visible;
        }

        private void chkNhanviengh_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewDSPhieuBan.Columns[2].Visible = !dataGridViewDSPhieuBan.Columns[2].Visible;
        }

        private void chkNguoiLapPhieu_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewDSPhieuBan.Columns[3].Visible = !dataGridViewDSPhieuBan.Columns[3].Visible;
        }

        private void dataGridViewHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewDSPhieuBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int64 maPhieu = Int64.Parse(dataGridViewDSPhieuBan.Rows[e.RowIndex].Cells[0].Value.ToString());
            HoTro ht = new HoTro();
            string caulenh = "select ProductId 'Mã sản phẩm', ProdName 'Tên sản phẩm', convert(varchar,mfgDate,103) 'Ngày sản xuất', convert(varchar,ExpDate,103) 'Ngày hết hạn', UnitName 'Đơn vị', PurchasePrice 'Giá bán', SalePrice 'Giá mua', discount 'Giảm giá', StatusName 'Trạng thái' " +
                             " from Product join ProductName" +
                             " on Product.ProductNameId = ProductName.ProductNameId" +
                             " join Units" +
                             " on Product.UnitId = Units.UnitId" +
                             " join ProductStatus" +
                             " on Product.StatusId = ProductStatus.StatusId" +
                             " where BillSaleId = " + maPhieu;
            ht.HienThiVaoDataGridView(dataGridViewHangHoa, caulenh);
        }

        private void checkBoxMasp_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[0].Visible = !dataGridViewHangHoa.Columns[0].Visible;
        }

        private void checkBoxTenSp_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[1].Visible = !dataGridViewHangHoa.Columns[1].Visible;
        }

        private void checkBoxDv_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[4].Visible = !dataGridViewHangHoa.Columns[4].Visible;
        }

        private void checkBoxNgaySx_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[2].Visible = !dataGridViewHangHoa.Columns[2].Visible;
        }

        private void checkBoxNgayHethan_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[3].Visible = !dataGridViewHangHoa.Columns[3].Visible;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[5].Visible = !dataGridViewHangHoa.Columns[5].Visible;
        }

        private void checkBoxGiaMua_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[6].Visible = !dataGridViewHangHoa.Columns[6].Visible;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[7].Visible = !dataGridViewHangHoa.Columns[7].Visible;
        }

        private void checkBoxTrangthai_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[8].Visible = !dataGridViewHangHoa.Columns[8].Visible;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            BaoCao.BaoCaoXuat report = new SSMP.BaoCao.BaoCaoXuat();
            report.SetParameterValue("tungay", "1/1/2009");
            report.SetParameterValue("denngay", DateTime.Now);
            crystalReportViewer1.ReportSource = report;
        }

        private void crystalReportViewerProduct_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBoxNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNgay.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxNgay.Checked)
            {
                BaoCao.BaoCaoXuat report = new SSMP.BaoCao.BaoCaoXuat();
                ParameterFields parameters = new ParameterFields();

                report.Load();
                report.SetParameterValue("tungay", dateTimePicker1.Value);
                report.SetParameterValue("denngay", dateTimePicker2.Value);
                crystalReportViewer1.ReportSource = report;
            }
            else
            {
                BaoCao.BaoCaoXuat report = new SSMP.BaoCao.BaoCaoXuat();
                report.SetParameterValue("tungay", "1/1/2009");
                report.SetParameterValue("denngay", DateTime.Now);
                crystalReportViewer1.ReportSource = report;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void btnTimKiemQuanLy_Click(object sender, EventArgs e)
        {
            if (txtTimKiemQuanLy.Text.Length == 0) {
                HoTro.baoLoi("Nhập thông tin để tìm kiếm") ;
                return ;
            }
            if (!checkBoxMaPhieu.Checked && !chkNhanviengh.Checked && !cbngaytao.Checked && !chkNguoiLapPhieu.Checked) {
                HoTro.baoLoi("Chọn trường để tìm kiếm");
                return;
            }

            HoTro ht = new HoTro(); 
            string caulenh = "select BillSaleId as 'Mã phiếu', createDate as 'Ngày tạo',Customername as 'Tên khách hàng', FullName as 'Người lập phiếu' " +
                         "from BillSale join Customer" +
                         " on BillSale.CustomerId = Customer.CustomerId" +
                         " inner join Users " +
                         "on BillSale.UserId = Users.UserId";
            StringBuilder builder = new StringBuilder();
            if (checkBoxMaPhieu.Checked) { 
                try {
                    builder.Append("BillSale.BillSaleId = " + Int64.Parse(txtTimKiemQuanLy.Text));
                } catch (Exception ex) { }                
            }
            if (chkNhanviengh.Checked) {
                if (builder.Length > 0) builder.Append(" or ") ;
                builder.Append("Customer.Customername like '%" + txtTimKiemQuanLy.Text + "%' " );
            }
            if (cbngaytao.Checked && ht.toSQLDateTime(txtTimKiemQuanLy.Text) != null)
            {
                if (builder.Length > 0) builder.Append(" or ");
                builder.Append("BillSale.createDate ='" + ht.toSQLDateTime(txtTimKiemQuanLy.Text).ToShortDateString() + "' " );    
            }
            if (chkNguoiLapPhieu.Checked)
            {
                if (builder.Length > 0) builder.Append(" or ");
                builder.Append("Users.FullName like '%" + txtTimKiemQuanLy.Text + "%' ");
            }
            if (builder.Length > 0) {
                builder.Insert(0, " where ");                
            }
            caulenh += builder.ToString();
            ht.HienThiVaoDataGridView(dataGridViewDSPhieuBan, caulenh);
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnXoaCacTruong_Click(object sender, EventArgs e)
        {

        }
    }
}