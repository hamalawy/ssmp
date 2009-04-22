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
    }
}