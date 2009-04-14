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

        }

        private void BanHang_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                Int64 id = Int64.Parse(txtId.Text);
                string CauLenh = "select ProdName from ProductName where ProductNameId = (select max(ProductNameId) " +
                    " from  Product where ProductId = " + id + ")";
                HoTro ht = new HoTro();
                SqlConnection conn = ht.KetNoi();
                conn.Open();
                SqlCommand com = new SqlCommand(CauLenh, conn);
                string name = com.ExecuteScalar().ToString();
                labelTenSp.Text = name;

                //CauLenh = "select 

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}