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
    public partial class FormSuaHoaDonNhap : Form
    {
        frmNhapHang parent = null;
        public FormSuaHoaDonNhap(frmNhapHang f)
        {
            InitializeComponent();
            parent = f;
        }

        public void fillData(DataGridViewRow row) {
            try
            {
                textBoxMaPhieu.Text = row.Cells[0].Value.ToString();
                textBoxNgayTao.Text = row.Cells[1].Value.ToString();
                textBoxNguoiLapPhieu.Text = row.Cells[4].Value.ToString();
                textBoxNhanVienGH.Text = row.Cells[2].Value.ToString();
                
                HoTro ht = new HoTro();
                ht.TaiDuLieu(comboBoxNhaCungCap, "Provider", "ProviderId", "ProviderName");
                string providerName = row.Cells[3].Value.ToString();
                ProviderManager pl = new ProviderManager();
                foreach (Provider p in pl.GetAll()) {
                    if (p.ProviderName.Equals(providerName)) {
                        comboBoxNhaCungCap.SelectedValue = p.ID;
                        break;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HoTro ht = new HoTro();
                SqlCommand command = new SqlCommand("update BillPurchase set DeliveryStaff=@giaohang, ProviderId=@maNhacungcap where BillPurchaseId=@ma");
                command.Parameters.Add("@giaohang", textBoxNhanVienGH.Text);
                command.Parameters.Add("@maNhacungcap", Int32.Parse(comboBoxNhaCungCap.SelectedValue.ToString()));
                command.Parameters.Add("@ma", Int64.Parse(textBoxMaPhieu.Text ));
                ht.CapNhatDuLieu(command);
                HoTro.thongBao("Cập nhật thành công !");
                parent.taiDuLieu();
                this.Dispose();                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBoxNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNhanVienGH_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNgayTao_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaPhieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNguoiLapPhieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}