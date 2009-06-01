using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SSMP.Data.Manager;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using log4net;

namespace SSMP
{
    public partial class frmDanhMucQuocGia : Form
    {
        //Manager object
        private CountryManager countryManager;

        //ILog object
        private static readonly ILog logger = LogManager.GetLogger(typeof(frmDanhMucQuocGia));

        //DataSet object
        private DataSet dataSetCountry;

        //Current list country
        IList<Country> currentListCountry;

        //Update - Delete countryId
        int updateCountryId = 0;

        public frmDanhMucQuocGia()
        {
            InitializeComponent();

            //Create Manager which will use in form
            countryManager = new CountryManager();
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of Country
            DataTable dataTableCountry = new DataTable("Country");
            dataTableCountry.Columns.Add("CountryId", typeof(int));
            dataTableCountry.Columns.Add("CountryName", typeof(string));
           
            //Create DataSet of Country
            dataSetCountry = new DataSet();
            dataSetCountry.Tables.Add(dataTableCountry);

            //Config detail of column in grid view
            gvCountry.DataSource = dataSetCountry;
            gvCountry.DataMember = "Country";
            gvCountry.Columns["CountryId"].HeaderText = "Mã quốc gia";
            gvCountry.Columns["CountryName"].HeaderText = "Quốc Gia";
        }

        private void IList2DataTable(IList<Country> listCountry, DataTable dataTableCountry)
        {
            if (listCountry != null)
            {
                dataTableCountry.Clear();

                foreach (Country objCountry in listCountry)
                {
                    DataRow rowTemp = dataTableCountry.NewRow();

                    rowTemp["CountryId"] = objCountry.ID;
                    rowTemp["CountryName"] = objCountry.CountryName;
                                        
                    dataTableCountry.Rows.Add(rowTemp);
                }
            }
        }

        private void frmDanhMucQuocGia_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.MdiParent.ClientSize.Width-this.Width)/2,(this.MdiParent.ClientSize.Height-this.Height)/2-50);

            //Create column of gridview
            ContructGridViewColumn();

            //Get All Object
            GetAll();
        }

        private void GetAll()
        {
            //Get list Country
            currentListCountry = countryManager.GetAll();

            //Binding list Country to gridview
            IList2DataTable(currentListCountry, dataSetCountry.Tables["Country"]);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Country searchEntity = new Country();
            string strSearch = txtSearch.Text.Trim();

            searchEntity.CountryName = strSearch;

            currentListCountry = countryManager.GetByExample(searchEntity, new string[0]);

            IList2DataTable(currentListCountry, dataSetCountry.Tables["Country"]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strCountryName = txtCountryName.Text.Trim();

            Country newCountry = new Country();
            newCountry.CountryName = strCountryName;

            countryManager.SaveOrUpdate(newCountry);

            GetAll();

            ResetForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idxInList = -1;

            foreach (Country objCountry in currentListCountry)
            {
                if (objCountry.ID == updateCountryId)
                {
                    idxInList = currentListCountry.IndexOf(objCountry);
                }
            }

            Country updateCountry = currentListCountry[idxInList];
            updateCountry.CountryName = txtCountryName.Text.Trim();

            countryManager.SaveOrUpdate(updateCountry);

            GetAll();

            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idxInList = -1;

            foreach (Country objCountry in currentListCountry)
            {
                if (objCountry.ID == updateCountryId)
                {
                    idxInList = currentListCountry.IndexOf(objCountry);
                }
            }

            Country deleteCountry = currentListCountry[idxInList];

            countryManager.Delete(deleteCountry);

            GetAll();

            ResetForm();
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void ResetForm()
        {
            txtCountryId.Text = "";
            txtCountryName.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void gvCountry_SelectionChanged(object sender, EventArgs e)
        {
            if (gvCountry.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvCountry.SelectedCells[0].RowIndex;

                BindingCountryToForm(selectedRowIndex);

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                updateCountryId = (int)gvCountry.Rows[selectedRowIndex].Cells["CountryId"].Value;
            }
        }

        private void BindingCountryToForm(int rowIndex)
        {
            txtCountryId.Text = gvCountry.Rows[rowIndex].Cells["CountryId"].Value.ToString();
            txtCountryName.Text = (string)gvCountry.Rows[rowIndex].Cells["CountryName"].Value;
        }
    }
}