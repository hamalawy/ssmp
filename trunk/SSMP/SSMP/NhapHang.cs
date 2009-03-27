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

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width - this.Width) / 2, (this.MdiParent.ClientSize.Height - this.Height) / 2 - 50);

            //dien thong tin nguoi dung va ngay thang
            txtNguoiVietPhieuNhapHang.Text = HoTro.NguoiDung;
            txtNgayThang.Text = DateTime.Now.ToString("MM/dd/yyyy");

            ht = new HoTro();

            //tai thong tin nha cung cap
            ht.TaiDuLieu(cboNhaCungCap, "Provider", "ProviderId", "ProviderName");

            //tai ma loai san pham
            ht.TaiDuLieu(cboLoaiSanPham, "Category", "CategoryId", "CategoryName");

            //tai don vi tinh
            ht.TaiDuLieu(cboDonViTinh, "Unit", "UnitId", "UnitName");

            //tai ten san pham
            ht.TaiDuLieu(cboTenSanPham, "ProductName", "ProductNameId", "ProductName");

            //tai quoc gia
            ht.TaiDuLieu(cboNguonGoc, "Country", "CountryId", "CountryName");

            //tai nha san xuat
            ht.TaiDuLieu(cboNhaSanXuat, "Manufacturer", "ManId", "ManName");
        }

        private void btnDuaVaoPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                ht = new HoTro();
                SqlCommand command = new SqlCommand() ;

                // insert PhieuNhapKho
                int maNguoiDung = ht.LayVeKhoa("Users", "UserId", "Username", txtNguoiVietPhieuNhapHang.Text);
                int maNhaCungCap = ht.LayVeKhoa("Provider", "ProviderId", "ProviderName", cboNhaCungCap.Text);
                
                command = new SqlCommand("insert into BillPurchase values(@ngaythang, @giaohang, @maNhacungcap, @manguoiDung)") ;
                command.Parameters.Add("@ngaythang", txtNgayThang.Text);
                command.Parameters.Add("@giaohang", txtNhanVienGiaoHang.Text);
                command.Parameters.Add("@maNhacungcap", maNhaCungCap);
                command.Parameters.Add("@manguoiDung", maNguoiDung);
                ht.CapNhatDuLieu(command);

                int soLuong = Int32.Parse(txtSoLuong.Text);
                for (int i = 0; i < soLuong; i++)
                {
                    // insert SanPham
                    int maLoaiSp = ht.LayVeKhoa("Category", "CategoryId", "CategoryName", cboLoaiSanPham.Text);
                    int maDonvi = ht.LayVeKhoa("Unit", "UnitId", "UnitName", cboDonViTinh.Text);
                    int maNhaSx = ht.LayVeKhoa("Manufacturer", "ManId", "ManName", cboNhaSanXuat.Text);
                    int IdtenSp = ht.LayVeKhoa("ProductName", "ProductNameId", "ProductName", cboTenSanPham.Text);
                    command = new SqlCommand("insert into Product values(" +
                        "@ngaysx, @ngayHetHan, @Mota, @IdtenSP, @PurchasePrice, @SalePrice, @CategoryId," +
                        "@ManId, @UnitId, @DisCount, @importDate, @exportDate)");
                    command.Parameters.Add("@ngaysx", ngaySanXuat.Value.ToString());
                    command.Parameters.Add("@ngayHetHan", ngayHetHan.Value.ToString());
                    command.Parameters.Add("@Mota", txtMota.Text);
                    command.Parameters.Add("@IdtenSP", IdtenSp);
                    command.Parameters.Add("@PurchasePrice", txtGiaMua.Text);
                    command.Parameters.Add("@SalePrice", txtGiaban.Text);
                    command.Parameters.Add("@CategoryId", maLoaiSp);
                    command.Parameters.Add("@ManId", maNhaSx);
                    command.Parameters.Add("@UnitId", maDonvi);
                    command.Parameters.Add("@DisCount", Int32.Parse(txtGiamgia.Text));
                    command.Parameters.Add("@importDate", ngayNhapHang.Value.ToString());
                    command.Parameters.Add("@exportDate", ngayXuathang.Value.ToString());
                    ht.CapNhatDuLieu(command);

                    // insert chiTietPhieunhapKho
                    int maSp = ht.LayGiaTriTruongKhoaVuaChen("Product", "ProductId");
                    int maPhieu = ht.LayGiaTriTruongKhoaVuaChen("BillPurchase", "BillPurchaseId");
                    command = new SqlCommand("insert into BillPurchaseDetail values(@maPhieu, @maSp)");
                    command.Parameters.Add("@maSp", maSp);
                    command.Parameters.Add("@maPhieu", maPhieu);
                    ht.CapNhatDuLieu(command);
                }

                MessageBox.Show("cap nhat xong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }
    }
}