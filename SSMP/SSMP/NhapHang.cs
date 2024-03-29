using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using System.Xml;
using SSMP.Data.Manager;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using log4net;

namespace SSMP
{
    public partial class frmNhapHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        HoTro ht;

        public frmNhapHang()
        {
            InitializeComponent();            
        }

        public void setSelectedTab(int selectedTab) {
            tabQuanLyPhieuNhap.SelectedIndex = selectedTab;
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width - this.Width) / 2, (this.MdiParent.ClientSize.Height - this.Height) / 2 - 50);
            xoaTrang();
            //dien thong tin nguoi dung va ngay thang
            
        }

        private void xoaTrang()
        {
           
            cboTenSanPham.SelectedIndex = -1;
  
        }

        private void btnDuaVaoPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(txtSoLuong.Text);
            }
            catch (Exception ex) {
                HoTro.baoLoi("Trường số lượng nhập không đúng !");
                return;
            }
            if (!HoTro.IsWholeNumber(txtGiaMua.Text)) {
                HoTro.baoLoi("Trường giá mua nhập không đúng !");
                return;
            }

            if (ngaySanXuat.Value >= ngayHetHan.Value) {
                HoTro.baoLoi("Trường ngày hết hạn phải lớn hơn ngày sản xuất !");
                return;
            }
            if (txtGiaMua.Text.Length == 0 || !HoTro.IsWholeNumber(txtGiaMua.Text)) {
                HoTro.baoLoi("Trường giá mua nhập không đúng");
                return;
            }

            try
            {  
                String[] data = new String[] {cboTenSanPham.Text, txtSoLuong.Text, ngaySanXuat.Value.ToShortDateString()
                    , ngayHetHan.Value.ToShortDateString(), cboDonViTinh.Text, cboNhaSanXuat.Text, cboNguonGoc.Text
                    , txtGiaMua.Text, cboNhaCungCap.Text , txtNhanVienGiaoHang.Text } ;
                dataGridViewDanhSach.Rows.Add(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }

        }

        private void btnCapNhatQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            try
            {
                ht = new HoTro();
                SqlCommand command = new SqlCommand();
                int maNguoiDung = DangNhap.idNguoiDung;
                
                
                for (int i = 0; i < dataGridViewDanhSach.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridViewDanhSach.Rows[i];                    
                    // insert PhieuNhapKho                
                    int maNhaCungCap = ht.LayVeKhoa("Provider", "ProviderId", "ProviderName", row.Cells[8].Value.ToString());
                    command = new SqlCommand("insert into BillPurchase values(@ngaythang, @giaohang, @maNhacungcap, @manguoiDung)");
                    command.Parameters.Add("@ngaythang", ht.toSQLDateTime(txtNgayThang.Text));
                    command.Parameters.Add("@giaohang", row.Cells[9].Value.ToString());
                    command.Parameters.Add("@maNhacungcap", maNhaCungCap);
                    command.Parameters.Add("@manguoiDung", maNguoiDung);
                    ht.CapNhatDuLieu(command);

                    int soLuong = Int32.Parse(row.Cells[1].Value.ToString());
                    int donvi = ht.LayVeKhoa("Units", "UnitId", "UnitName", row.Cells[4].Value.ToString());
                    Int64 billPurchaseId = ht.LayGiaTriTruongKhoaVuaChen2("BillPurchase", "BillPurchaseId");
                    for (int j = 0; j < soLuong; j++)
                    {
                        // insert SanPham
                        int IdtenSp = ht.LayVeKhoa("ProductName", "ProductNameId", "ProdName", row.Cells[0].Value.ToString());
                        command = new SqlCommand("insert into Product values(" +
                            "@ngaysx, @ngayHetHan, @IdtenSP, @PurchasePrice, null," +
                            "null, @statusId, @billPurchaseId, null, @UnitId, @mota)");
                        command.Parameters.Add("@ngaysx", row.Cells[2].Value.ToString());
                        command.Parameters.Add("@ngayHetHan", row.Cells[3].Value.ToString());
                        command.Parameters.Add("@IdtenSP", IdtenSp);
                        command.Parameters.Add("@PurchasePrice", Int32.Parse(row.Cells[7].Value.ToString())); //VietLH change string to int on 9 Dec 2009
                        command.Parameters.Add("@statusId", 1);
                        command.Parameters.Add("@billPurchaseId", billPurchaseId);
                        command.Parameters.Add("@UnitId", donvi);
                        command.Parameters.Add("@mota", richTextBoxMota.Text);
                        ht.CapNhatDuLieu(command);
                    }
                }
                HoTro.thongBao("Nhập hàng thành công !");
                dataGridViewDanhSach.Rows.Clear();
            }
            catch (Exception ex)
            {
                HoTro.baoLoi(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            clsoLuong.Visible = (!clsoLuong.Visible);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            clDonVi.Visible = (!clsoLuong.Visible);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            clngaySanXuat.Visible = (!clngaySanXuat.Visible);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            clNgayHetHan.Visible = (!clNgayHetHan.Visible);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            clNhaSx.Visible = (!clNhaSx.Visible);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            clNguonGoc.Visible = (!clNguonGoc.Visible);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            clGiaMua.Visible = (!clGiaMua.Visible);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            clNhanVienGiaoHang.Visible = (!clNhanVienGiaoHang.Visible);
        }

        private void tpQuanLyPhieuNhapHangHoa_Click(object sender, EventArgs e)
        {
        }

        private void tcNhapKhoHangHoa_Enter(object sender, EventArgs e)
        {
            
        }

        public void taiDuLieu() {
            HoTro ht = new HoTro();
            if (tabQuanLyPhieuNhap.SelectedIndex == 0) {
                txtNgayThang.Text = DateTime.Now.ToString("dd/MM/yyyy");                
                ht.TaiDuLieu(cboNhaCungCap, "Provider", "ProviderId", "ProviderName");    
                ht.TaiDuLieu(cboLoaiSanPham, "Category", "CategoryId", "CategoryName");             
                ht.TaiDuLieu(cboDonViTinh, "Units", "UnitId", "UnitName");            
                ht.TaiDuLieu(cboTenSanPham, "ProductName", "ProductNameId", "ProdName");             
                ht.TaiDuLieu(cboNguonGoc, "Country", "CountryId", "CountryName");               
                ht.TaiDuLieu(cboNhaSanXuat, "Manufacturer", "ManId", "ManName");
            }
            else if (tabQuanLyPhieuNhap.SelectedIndex == 1) {
                string caulenh = "select BillPurchaseId as 'Mã phiếu', convert(varchar,createDate,103) as 'Ngày tạo', DeliveryStaff as 'Nhân viên giao hàng', ProviderName as 'Nhà cung cấp', FullName as 'Người lập phiếu' " +
                             "from BillPurchase join Provider" +
                             " on BillPurchase.ProviderId = Provider.ProviderId" +
                             " inner join Users " +
                             "on BillPurchase.UserId = Users.UserId";
                ht.HienThiVaoDataGridView(dataGridViewPhieuNhapHAng, caulenh);
            }
        }

        private void tpQuanLyPhieuNhapHangHoa_Enter(object sender, EventArgs e)
        {
            
        }

        private void checkBoxMaPhieu_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewPhieuNhapHAng.Columns[0].Visible = !dataGridViewPhieuNhapHAng.Columns[0].Visible;
        }

        private void cbngaytao_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewPhieuNhapHAng.Columns[1].Visible = !dataGridViewPhieuNhapHAng.Columns[1].Visible;
        }

        private void chkNhanviengh_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewPhieuNhapHAng.Columns[2].Visible = !dataGridViewPhieuNhapHAng.Columns[2].Visible;
        }

        private void chkNhacungcap_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewPhieuNhapHAng.Columns[3].Visible = !dataGridViewPhieuNhapHAng.Columns[3].Visible;
        }

        private void chkNguoiLapPhieu_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewPhieuNhapHAng.Columns[4].Visible = !dataGridViewPhieuNhapHAng.Columns[4].Visible;
        }

        private void dataGridViewPhieuNhapHAng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewPhieuNhapHAng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cellClick(Int64 maPhieu) {
            HoTro ht = new HoTro();
            string caulenh = "select ProductId 'Mã sản phẩm', ProdName 'Tên sản phẩm', convert(varchar,mfgDate,103) 'Ngày sản xuất', convert(varchar,ExpDate,103) 'Ngày hết hạn', UnitName 'Đơn vị', PurchasePrice 'Giá bán', SalePrice 'Giá mua', discount 'Giảm giá', StatusName 'Trạng thái' " +
                             " from Product join ProductName" +
                             " on Product.ProductNameId = ProductName.ProductNameId" +
                             " join Units" +
                             " on Product.UnitId = Units.UnitId" +
                             " join ProductStatus" +
                             " on Product.StatusId = ProductStatus.StatusId" +
                             " where BillPurchaseId = " + maPhieu;
            ht.HienThiVaoDataGridView(dataGridViewHangHoa, caulenh);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[0].Visible = !dataGridViewHangHoa.Columns[0].Visible;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[1].Visible = !dataGridViewHangHoa.Columns[1].Visible;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[4].Visible = !dataGridViewHangHoa.Columns[4].Visible;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[2].Visible = !dataGridViewHangHoa.Columns[2].Visible;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[3].Visible = !dataGridViewHangHoa.Columns[3].Visible;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[5].Visible = !dataGridViewHangHoa.Columns[5].Visible;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[6].Visible = !dataGridViewHangHoa.Columns[6].Visible;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[7].Visible = !dataGridViewHangHoa.Columns[7].Visible;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHangHoa.Columns[8].Visible = !dataGridViewHangHoa.Columns[8].Visible;
        }

        private void tabQuanLyPhieuNhap_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            taiCrystalReport();   
        }

        private void taiCrystalReport() {
            try
            {
                HoTro ht = new HoTro();
                SqlConnection conn = ht.KetNoi();
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

                string command = "select ProductId, convert(varchar,MfgDate,103) as 'MfgDate',convert(varchar,ExpDate,103) as 'ExpDate', ProdName, PurchasePrice, SalePrice,DisCount,StatusName,  convert(varchar,BillPurchase.CreateDate,103) as 'CreateDate' "
                                    + " from product join ProductName"
                                    + " on Product.productNameid =  ProductName.productNameid"
                                    + " join ProductStatus"
                                    + " on Product.StatusId =  ProductStatus.StatusId"
                                    + " join BillPurchase"
                                    + " on Product.BillPurchaseId =  BillPurchase.BillPurchaseId"
                +" where BillPurchase.CreateDate >= '" + tuNgay + "' and BillPurchase.CreateDate <= '" + denNgay + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
                BaoCao.DataSet1 dataset = new SSMP.BaoCao.DataSet1();
                adapter.Fill(dataset, "DataTable1");
                BaoCao.TestNhapCrystalReport report = new SSMP.BaoCao.TestNhapCrystalReport();                
                report.SetDataSource(dataset);
                crystalReportViewer1.ReportSource = report;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void checkBoxNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNgay.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taiCrystalReport();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaCacTruong_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = "";
            txtGiaMua.Text = "";
            txtNhanVienGiaoHang.Text = "";
            cboNhaCungCap.SelectedIndex = 0;
            cboLoaiSanPham.SelectedIndex = 0;
            cboDonViTinh.SelectedIndex = 0;
            cboTenSanPham.SelectedIndex = 0;
            cboNguonGoc.SelectedIndex = 0;
            cboNhaSanXuat.SelectedIndex = 0;
            ngaySanXuat.Value = DateTime.Now;
            ngayHetHan.Value = DateTime.Now;
        }

        private void btnTimKiemQuanLy_Click(object sender, EventArgs e)
        {
            if (txtTimKiemQuanLy.Text.Length == 0)
            {
                HoTro.baoLoi("Nhập thông tin để tìm kiếm");
                return;
            }
            if (!checkBoxMaPhieu.Checked && !chkNhanviengh.Checked && !cbngaytao.Checked && !chkNguoiLapPhieu.Checked && !chkNhacungcap.Checked)
            {
                HoTro.baoLoi("Chọn trường để tìm kiếm");
                return;
            }

            HoTro ht = new HoTro();
            string caulenh = "select BillPurchaseId as 'Mã phiếu', createDate as 'Ngày tạo', DeliveryStaff as 'Nhân viên giao hàng', ProviderName as 'Nhà cung cấp', FullName as 'Người lập phiếu' " +
                             "from BillPurchase join Provider" +
                             " on BillPurchase.ProviderId = Provider.ProviderId" +
                             " inner join Users " +
                             "on BillPurchase.UserId = Users.UserId";
            
            StringBuilder builder = new StringBuilder();
            if (checkBoxMaPhieu.Checked)
            {
                try
                {
                    builder.Append("BillPurchase.BillPurchaseId = " + Int64.Parse(txtTimKiemQuanLy.Text));
                }
                catch (Exception ex) { }
            }
            if (chkNhanviengh.Checked)
            {
                if (builder.Length > 0) builder.Append(" or ");
                builder.Append("BillPurchase.DeliveryStaff like '%" + txtTimKiemQuanLy.Text + "%' ");
            }
            if (cbngaytao.Checked && ht.toSQLDateTime(txtTimKiemQuanLy.Text) != null)
            {
                if (builder.Length > 0) builder.Append(" or ");
                builder.Append("BillPurchase.createDate ='" + ht.toSQLDateTime(txtTimKiemQuanLy.Text).ToShortDateString() + "' ");
            }
            if (chkNhacungcap.Checked)
            {
                if (builder.Length > 0) builder.Append(" or ");
                builder.Append("Provider.ProviderName like '%" + txtTimKiemQuanLy.Text + "%' ");
            }
            if (chkNguoiLapPhieu.Checked)
            {
                if (builder.Length > 0) builder.Append(" or ");
                builder.Append("Users.FullName like '%" + txtTimKiemQuanLy.Text + "%' ");
            }
            if (builder.Length > 0)
            {
                builder.Insert(0, " where ");
            }
            caulenh += builder.ToString();
            ht.HienThiVaoDataGridView(dataGridViewPhieuNhapHAng, caulenh);
        }

        private void tabNhapKhoHangHoa_Enter(object sender, EventArgs e)
        {
             taiDuLieu();
        }

        private void tabQuanLyPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            taiDuLieu();
            try
            {
                Int64 maPhieu = Int64.Parse(dataGridViewPhieuNhapHAng.Rows[0].Cells[0].Value.ToString());
                cellClick(maPhieu);
            }
            catch (Exception ex) { }
        }

        private void cboNhaSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ht = new HoTro() ;
            int manId = ht.LayVeKhoa("Manufacturer", "ManId", "ManName", cboNhaSanXuat.Text) ;            
            SqlConnection conn = ht.KetNoi();
            try {
                int countryId = 0;                
                string CauLenh = "select  countryId from Manufacturer where manId= " + manId;
                SqlCommand cmd = new SqlCommand(CauLenh, conn);
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cboNguonGoc.SelectedValue = (Object)dr.GetInt32(0);
                }

            } catch(Exception ex) {
                MessageBox.Show(ex.Message) ;
                conn.Close() ;
            }

        }

        private void cboTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboTenSanPham.SelectedValue.ToString().Length == 0) return;
                int khoa = Int32.Parse(cboTenSanPham.SelectedValue.ToString());
                ProductNameManager productNameManager = new ProductNameManager();
                ProductName productName = productNameManager.GetById(khoa, true);
                cboLoaiSanPham.SelectedValue = productName.CategoryIdLookup.ID;
                cboNhaSanXuat.SelectedValue = productName.ManIdLookup.ID;
                ManufacturerManager manufacturerManager = new ManufacturerManager();
                Manufacturer man = manufacturerManager.GetById(productName.ManIdLookup.ID, true);
                cboNguonGoc.SelectedValue = man.CountryIdLookup.ID;
            }
            catch (Exception ex) {}

        }

        private void buttonXoaDong_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDanhSach.SelectedRows)
            {
                dataGridViewDanhSach.Rows.Remove(row);
            }
        }

        private void btnReloadAll_Click(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void dataGridViewPhieuNhapHAng_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Int64 maPhieu = Int64.Parse(dataGridViewPhieuNhapHAng.Rows[e.RowIndex].Cells[0].Value.ToString());
            cellClick(maPhieu);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewPhieuNhapHAng.SelectedRows[0];
            if (selectedRow != null) {
                FormSuaHoaDonNhap f = new FormSuaHoaDonNhap(this);
                f.fillData(selectedRow);
                f.Show();
            }
        }

        private void tpLapPhieuNhapHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // kiem tra xem co xoa dc ko
                if (HoTro.confirm("Bạn có chắc muốn xóa hóa đơn này ?", "Xác nhận").Equals("No")) return;


                Int64 maPhieu = Int64.Parse(dataGridViewPhieuNhapHAng.SelectedRows[0].Cells[0].Value.ToString());
                ht = new HoTro();
                SqlCommand com = new SqlCommand("select * from Product where BillPurchaseId=" + maPhieu + " and BillSaleId is not NULL", ht.KetNoi());
                com.Connection.Open();
                if (com.ExecuteScalar() != null)
                {
                    HoTro.baoLoi("Không xóa được hóa đơn mua này, có sản phẩm đã được bán");
                    return;
                }
                com.Connection.Close();
                com = new SqlCommand("delete Product where BillPurchaseId=" + maPhieu, ht.KetNoi());
                ht.CapNhatDuLieu(com);
                com = new SqlCommand("delete BillPurchase where BillPurchaseId=" + maPhieu, ht.KetNoi());
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