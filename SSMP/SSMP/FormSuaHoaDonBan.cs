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
    public partial class FormSuaHoaDonBan : Form
    {
        BanHang parent = null;
        public FormSuaHoaDonBan(BanHang f)
        {
            InitializeComponent();
            parent = f;
        }

        private void FormSuaHoaDonBan_Load(object sender, EventArgs e)
        {

        }

        public void fillData(DataGridViewRow row)
        {
            try
            {
                textBoxMaPhieu.Text = row.Cells[0].Value.ToString();
                textBoxNgayTao.Text = row.Cells[1].Value.ToString();
                textBoxNguoiLapPhieu.Text = row.Cells[3].Value.ToString();

                HoTro ht = new HoTro();
                ht.TaiDuLieu(comboBoxKh, "Customer", "CustomerId", "CustomerName");
                string CusName = row.Cells[2].Value.ToString();
                CustomerManager pl = new CustomerManager();
                foreach (Customer p in pl.GetAll())
                {
                    if (p.CustomerName.Equals(CusName))
                    {
                        comboBoxKh.SelectedValue = p.ID;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HoTro ht = new HoTro();
                SqlCommand command = new SqlCommand("update BillSale set CustomerId=@maNguoiDung where BillSaleId=@ma");
                command.Parameters.Add("@maNguoiDung", Int32.Parse(comboBoxKh.SelectedValue.ToString()));
                command.Parameters.Add("@ma", Int64.Parse(textBoxMaPhieu.Text));
                ht.CapNhatDuLieu(command);
                HoTro.thongBao("Cập nhật thành công !");
                parent.taiDuLieu();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



    }
}