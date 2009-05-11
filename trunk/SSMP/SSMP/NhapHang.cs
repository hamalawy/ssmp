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

            //dien thong tin nguoi dung va ngay thang
            txtNgayThang.Text = DateTime.Now.ToString("MM/dd/yyyy");

            ht = new HoTro();

            //tai thong tin nha cung cap
            ht.TaiDuLieu(cboNhaCungCap, "Provider", "ProviderId", "ProviderName");

            //tai ma loai san pham
            ht.TaiDuLieu(cboLoaiSanPham, "Category", "CategoryId", "CategoryName");

            //tai don vi tinh
            ht.TaiDuLieu(cboDonViTinh, "Units", "UnitId", "UnitName");

            //tai ten san pham
            ht.TaiDuLieu(cboTenSanPham, "ProductName", "ProductNameId", "ProdName");

            //tai quoc gia
            ht.TaiDuLieu(cboNguonGoc, "Country", "CountryId", "CountryName");

            //tai nha san xuat
            ht.TaiDuLieu(cboNhaSanXuat, "Manufacturer", "ManId", "ManName");
        }

        private void btnDuaVaoPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(txtSoLuong.Text);
                Int32.Parse(txtGiaMua.Text);
                String[] data = new String[] {cboTenSanPham.Text, txtSoLuong.Text, ngaySanXuat.Value.ToShortDateString()
                    , ngayHetHan.Value.ToShortDateString(), cboDonViTinh.Text, cboNhaSanXuat.Text, cboNguonGoc.Text
                    , txtGiaMua.Text, txtNhanVienGiaoHang.Text } ;
                dataGridViewDanhSach.Rows.Add(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);                
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
                int maNguoiDung = ht.LayGiaTriTruongKhoaVuaChen("Users", "UserId");
                for (int i = 0; i < dataGridViewDanhSach.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridViewDanhSach.Rows[i];                    
                    // insert PhieuNhapKho                
                    int maNhaCungCap = ht.LayVeKhoa("Provider", "ProviderId", "ProviderName", row.Cells[0].Value.ToString());
                    command = new SqlCommand("insert into BillPurchase values(@ngaythang, @giaohang, @maNhacungcap, @manguoiDung)");
                    command.Parameters.Add("@ngaythang", txtNgayThang.Text);
                    command.Parameters.Add("@giaohang", row.Cells[8].Value.ToString());
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
                            "null, @statusId, @billPurchaseId, null, @UnitId)");
                        command.Parameters.Add("@ngaysx", row.Cells[2].Value.ToString());
                        command.Parameters.Add("@ngayHetHan", row.Cells[3].Value.ToString());
                        command.Parameters.Add("@IdtenSP", IdtenSp);
                        command.Parameters.Add("@PurchasePrice", row.Cells[7].Value.ToString());
                        command.Parameters.Add("@statusId", 1);
                        command.Parameters.Add("@billPurchaseId", billPurchaseId);
                        command.Parameters.Add("@UnitId", donvi);
                        ht.CapNhatDuLieu(command);
                    }
                }
                MessageBox.Show("cap nhat xong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

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

        private void tpQuanLyPhieuNhapHangHoa_Enter(object sender, EventArgs e)
        {
            HoTro ht = new HoTro();
            string caulenh = "select BillPurchaseId as 'Mã phiếu', createDate as 'Ngày tạo', DeliveryStaff as 'Nhân viên giao hàng', ProviderName as 'Nhà cung cấp', FullName as 'Người lập phiếu' " +
                             "from BillPurchase join Provider" +
                             " on BillPurchase.ProviderId = Provider.ProviderId" + 
                             " inner join Users " + 
                             "on BillPurchase.UserId = Users.UserId" ;
            ht.HienThiVaoDataGridView(dataGridViewPhieuNhapHAng, caulenh);
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
            Int64 maPhieu = Int64.Parse(dataGridViewPhieuNhapHAng.Rows[e.RowIndex].Cells[0].Value.ToString());
            HoTro ht = new HoTro();
            string caulenh = "select ProductId 'Mã sản phẩm', ProdName 'Tên sản phẩm', mfgDate 'Ngày sản xuất', ExpDate 'Ngày hết hạn', UnitName 'Đơn vị', PurchasePrice 'Giá bán', SalePrice 'Giá mua', discount 'Giảm giá', StatusName 'Trạng thái' " +
                             " from Product join ProductName" +
                             " on Product.ProductNameId = ProductName.ProductNameId" +
                             " join Units" +
                             " on Product.UnitId = Units.UnitId" + 
                             " join ProductStatus" +
                             " on Product.StatusId = ProductStatus.StatusId" +
                             " where BillPurchaseId = " + maPhieu ;
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
            BaoCao.BaoCaoNhap report = new SSMP.BaoCao.BaoCaoNhap();
            crystalReportViewer1.ReportSource = report;
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
            if (checkBoxNgay.Checked)
            {
                BaoCao.BaoCaoNhap report = new SSMP.BaoCao.BaoCaoNhap();
                ParameterFields parameters = new ParameterFields();

                report.Load();
                report.SetParameterValue("tungay", dateTimePicker1.Value);
                report.SetParameterValue("denngay", dateTimePicker2.Value);
                crystalReportViewer1.ReportSource = report;
            }
            else {
                BaoCao.BaoCaoNhap report = new SSMP.BaoCao.BaoCaoNhap();
                crystalReportViewer1.ReportSource = report;
            }
        }
    }
}