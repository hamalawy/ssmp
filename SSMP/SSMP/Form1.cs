using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SSMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HoTro ht = new HoTro();
                string command = "select ProductId, MfgDate, ExpDate, ProdName, PurchasePrice, SalePrice,DisCount,StatusName, BillPurchase.CreateDate"
                                    + " from product join ProductName"
                                    + " on Product.productNameid =  ProductName.productNameid"
                                    + " join ProductStatus"
                                    + " on Product.StatusId =  ProductStatus.StatusId"
                                    + " join BillPurchase"
                                    + " on Product.BillPurchaseId =  BillPurchase.BillPurchaseId";

                SqlDataAdapter adapter = new SqlDataAdapter(command, ht.KetNoi());
                BaoCao.DataSet1 dataset = new SSMP.BaoCao.DataSet1();
                adapter.Fill(dataset, "DataTable1");
                BaoCao.TestNhapCrystalReport report = new SSMP.BaoCao.TestNhapCrystalReport();
                report.SetDataSource(dataset);
                crystalReportViewer1.ReportSource = report;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                HoTro ht = new HoTro();
                string command = "select ProductId, MfgDate, ExpDate, ProdName, PurchasePrice, SalePrice,DisCount, BillSale.CreateDate"
                                    + " from product join ProductName"
                                    + " on Product.productNameid =  ProductName.productNameid"
                                    + " join BillSale"
                                    + " on Product.BillSaleId =  BillSale.BillSaleId";

                SqlDataAdapter adapter = new SqlDataAdapter(command, ht.KetNoi());
                BaoCao.DataSet2 dataset = new SSMP.BaoCao.DataSet2();
                adapter.Fill(dataset, "DataTable1");

                BaoCao.TestXuatCrystalReport report = new SSMP.BaoCao.TestXuatCrystalReport();
                report.SetDataSource(dataset);
                crystalReportViewer1.ReportSource = report;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}