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

                command = new SqlCommand("select StatusId from Product where ProductId = @id", conn);
                command.Parameters.Add("@id", Int64.Parse(comboBoxId.Text));
                int statusId = Int32.Parse(command.ExecuteScalar().ToString());
                if (statusId != 1) {
                    HoTro.baoLoi("Sản phẩm này đã được bán");
                    conn.Close();
                    return;
                }

                foreach (DataGridViewRow row in dataGridViewDS.Rows) {
                    if (row.Cells[0].Value.ToString().Contains(comboBoxId.Text)) {
                        HoTro.baoLoi("Sản phẩm này đã có trong phiếu");
                        conn.Close();
                        return;
                    }
                }

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
                if (giaBan.Length == 0)
                {
                    HoTro.baoLoi("Sản phẩm này chưa được định giá bán.");
                    conn.Close();
                    return;
                }

                command = new SqlCommand("select Discount from Product where ProductId = @id", conn);
                command.Parameters.Add("@id", Int64.Parse(comboBoxId.Text));
                String giamGia = command.ExecuteScalar().ToString();

                conn.Close();
                String[] data = new String[] { comboBoxId.Text, khachHang, tenSp, donvi, giaBan, giamGia };
                dataGridViewDS.Rows.Add(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (dataGridViewDS.Rows.Count < 1) {
                    HoTro.baoLoi("Nhập dữ liệu để cập nhật");
                    return;
                }

                HoTro ht = new HoTro() ;
                SqlConnection conn = ht.KetNoi();
                conn.Open();
                SqlCommand command = new SqlCommand();

                int maNguoiDung = DangNhap.idNguoiDung;
                for (int i = 0; i < dataGridViewDS.Rows.Count; i++)
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
                dataGridViewDS.Rows.Clear();
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

        public void taiDuLieu() {
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
            
        }

        private void cellClick(Int64 maPhieu)
        {
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

        private void taiCrystalReport()
        {
            try
            {
                string tuNgay, denNgay;
                if (checkBoxNgay.Checked)
                {
                    tuNgay = dateTimePicker1.Value.ToShortDateString();
                    denNgay = dateTimePicker2.Value.ToShortDateString();
                }
                else
                {
                    tuNgay = "1/1/2009";
                    denNgay = DateTime.Now.ToShortDateString();
                }
                HoTro ht = new HoTro();
                SqlConnection conn = ht.KetNoi();
                string command = "select ProductId,convert(varchar,MfgDate,103) as 'MfgDate',convert(varchar,ExpDate,103) as 'ExpDate' , ProdName, PurchasePrice, SalePrice,DisCount,convert(varchar,BillSale.CreateDate,103) as 'CreateDate' "
                                    + " from product join ProductName"
                                    + " on Product.productNameid =  ProductName.productNameid"
                                    + " join BillSale"
                                    + " on Product.BillSaleId =  BillSale.BillSaleId"
                + " where BillSale.CreateDate >= '" + tuNgay + "' and BillSale.CreateDate <= '" + denNgay + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
                BaoCao.DataSet2 dataset = new SSMP.BaoCao.DataSet2();
                adapter.Fill(dataset, "DataTable1");

                BaoCao.TestXuatCrystalReport report = new SSMP.BaoCao.TestXuatCrystalReport();
                report.SetDataSource(dataset);
                crystalReportViewer1.ReportSource = report;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            taiCrystalReport();
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
            taiCrystalReport();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void btnTimKiemQuanLy_Click(object sender, EventArgs e)
        {
            try {
                dataGridViewHangHoa.DataSource = null;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
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
            try
            {
                Int64 maPhieu = Int64.Parse(dataGridViewDSPhieuBan.Rows[0].Cells[0].Value.ToString());
                cellClick(maPhieu);
            }
            catch (Exception ex) { }
        }

        private void btnXoaCacTruong_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDS.SelectedRows) {
                dataGridViewDS.Rows.Remove(row);
            }
        }

        private void btnReloadAll_Click(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void dataGridViewDSPhieuBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Int64 maPhieu = Int64.Parse(dataGridViewDSPhieuBan.Rows[e.RowIndex].Cells[0].Value.ToString());
            cellClick(maPhieu);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewDSPhieuBan.SelectedRows[0];
            if (selectedRow != null)
            {
                FormSuaHoaDonBan f = new FormSuaHoaDonBan(this);
                f.fillData(selectedRow);
                f.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // kiem tra xem co xoa dc ko
                if (HoTro.confirm("Bạn có chắc muốn xóa hóa đơn này ?", "Xác nhận").Equals("No")) return;


                Int64 maPhieu = Int64.Parse(dataGridViewDSPhieuBan.SelectedRows[0].Cells[0].Value.ToString());
                HoTro ht = new HoTro();
                SqlCommand com = new SqlCommand("update Product set BillSaleId=NULL, StatusId=1 where BillSaleId=" + maPhieu, ht.KetNoi());
                ht.CapNhatDuLieu(com);
                com = new SqlCommand("delete BillSale where BillSaleId=" + maPhieu, ht.KetNoi());
                ht.CapNhatDuLieu(com);

                taiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}