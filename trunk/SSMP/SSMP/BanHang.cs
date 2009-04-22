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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }

        private void btnDuaVaoPhieuXuat_Click(object sender, EventArgs e)
        {
            try
            {
                Int64.Parse(txtId.Text);
                Int32.Parse(txtKhachHang.Text);
                HoTro ht = new HoTro();
                SqlConnection conn = ht.KetNoi() ;
                conn.Open() ;
                SqlCommand command = new SqlCommand("select CustomerName from Customers where CustomerId = @khachhang", conn);
                command.Parameters.Add("@khachhang", txtKhachHang.Text);
                String khachHang = command.ExecuteScalar().ToString();

                command = new SqlCommand("select ProdName from ProductName where ProductNameId = (select max(ProductNameId) " +
                    " from  Product where ProductId = @id)", conn);
                command.Parameters.Add("@id", Int64.Parse(txtId.Text));
                String tenSp = command.ExecuteScalar().ToString();

                command = new SqlCommand("select UnitName from Units where UnitId = (select max (UnitId) from Product " +
                    "where ProductId = @id)", conn);
                command.Parameters.Add("@id", txtId.Text);
                String donvi = command.ExecuteScalar().ToString();

                command = new SqlCommand("select SalePrice from Product where ProductId = @id", conn);
                command.Parameters.Add("@id", Int64.Parse(txtId.Text));
                String giaBan = command.ExecuteScalar().ToString();

                command = new SqlCommand("select Discount from Product where ProductId = @id", conn);
                command.Parameters.Add("@id", Int64.Parse(txtId.Text));
                String giamGia = command.ExecuteScalar().ToString();

                conn.Close();
                String[] data = new String[] { txtId.Text, khachHang, tenSp, donvi, giaBan, giamGia };
                dataGridViewDS.Rows.Add(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            txtNgayThang.Text = DateTime.Now.ToString("MM/dd/yyyy");
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
                    command = new SqlCommand("select CustomerId from Customers where CusTomerName=@Cusname", conn);
                    command.Parameters.Add("@CusNAme", row.Cells[1].Value.ToString());
                    int cusId = Int32.Parse(command.ExecuteScalar().ToString()) ;

                    command = new SqlCommand("insert into BillSale values(@ngaythang, @nguoiMua, @manguoiDung)");
                    command.Parameters.Add("@ngaythang", txtNgayThang.Text);
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
                MessageBox.Show("cap nhat xong");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

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
    }
}