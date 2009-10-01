using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SSMP.Data.Manager;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using log4net;

namespace SSMP
{
    public partial class FrmManufacturer : Form
    {
        //Manager object
        private ManufacturerManager manufacturerManager;
        private CountryManager countryManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmManufacturer));
        private Manufacturer searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetManufacturer;
        private List<Int32> listPages;
        private bool isAdd;
        private IList<Manufacturer> currentListManufacturer;

        public FrmManufacturer()
        {
            InitializeComponent();

            //
            manufacturerManager = new ManufacturerManager();
            countryManager = new CountryManager();
        }

        private void FrmManufacturer_Load(object sender, EventArgs e)
        {
            //
            ContructGridViewColumn();

            //Get all user
            searchParam = new SearchParam();
            searchParam.Start = DEFAULT_START;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //
            searchEntity = new Manufacturer();

            //
            SearchResult<Manufacturer> searchResult = manufacturerManager.GetManufacturerListByParam(searchEntity, searchParam);
            currentListManufacturer = searchResult.SearchList;

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetManufacturer.Tables["Manufacturer"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);

            //Binding data to cbbCountry
            cbbCountry.DataSource = countryManager.GetAll();
            cbbCountry.ValueMember = "ID";
            cbbCountry.DisplayMember = "CountryName";

            //
            isAdd = true;
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of Manufacturer
            DataTable dataTableManufacturer = new DataTable("Manufacturer");
            dataTableManufacturer.Columns.Add("ManId", typeof(int));
            dataTableManufacturer.Columns.Add("ManName", typeof(string));
            dataTableManufacturer.Columns.Add("Address", typeof(string));
            dataTableManufacturer.Columns.Add("TelNo", typeof(string));
            dataTableManufacturer.Columns.Add("FaxNo", typeof(string));
            dataTableManufacturer.Columns.Add("Email", typeof(string));
            dataTableManufacturer.Columns.Add("Website", typeof(string));
            dataTableManufacturer.Columns.Add("CountryId", typeof(int));
            dataTableManufacturer.Columns.Add("CountryName", typeof(string));

            //Create DataSet of Manufacturer
            dataSetManufacturer = new DataSet();
            dataSetManufacturer.Tables.Add(dataTableManufacturer);

            //Config detail of column in grid view
            gvManufacturer.DataSource = dataSetManufacturer;
            gvManufacturer.DataMember = "Manufacturer";
            gvManufacturer.Columns["ManId"].HeaderText = "Mã nhà sản xuất";
            gvManufacturer.Columns["ManName"].HeaderText = "Tên nhà sản xuất";
            gvManufacturer.Columns["Address"].HeaderText = "Địa chỉ";
            gvManufacturer.Columns["TelNo"].HeaderText = "Điện thoại";
            gvManufacturer.Columns["FaxNo"].HeaderText = "Fax";
            gvManufacturer.Columns["Email"].HeaderText = "Email";
            gvManufacturer.Columns["Website"].HeaderText = "Website";
            gvManufacturer.Columns["CountryId"].HeaderText = "CountryId";
            gvManufacturer.Columns["CountryId"].Visible = false;
            gvManufacturer.Columns["CountryName"].HeaderText = "Quốc gia";            
        }

        private void IList2DataTable(IList<Manufacturer> listManufacturer, DataTable dataTableManufacturer)
        {
            if (listManufacturer != null)
            {
                dataTableManufacturer.Clear();

                foreach (Manufacturer objManufacturer in listManufacturer)
                {
                    DataRow rowTemp = dataTableManufacturer.NewRow();

                    rowTemp["ManId"] = objManufacturer.ID;
                    rowTemp["ManName"] = objManufacturer.ManName;
                    rowTemp["Address"] = objManufacturer.Address;
                    rowTemp["TelNo"] = objManufacturer.TelNo;
                    rowTemp["FaxNo"] = objManufacturer.FaxNo;
                    rowTemp["Email"] = objManufacturer.Email;
                    rowTemp["Website"] = objManufacturer.Website;
                    rowTemp["CountryId"] = objManufacturer.CountryId;
                    rowTemp["CountryName"] = objManufacturer.CountryIdLookup.CountryName;

                    dataTableManufacturer.Rows.Add(rowTemp);
                }
            }
        }

        private void BindingDataToBindingNagivator(int sizeOfList, int position)
        {
            int totalPage = 0;

            if (sizeOfList % DEFAULT_LIMIT > 0)
            {
                totalPage = (int)sizeOfList / DEFAULT_LIMIT + 1;
            }
            else
            {
                totalPage = (int)sizeOfList / DEFAULT_LIMIT;
            }

            logger.Debug("sizeOfList = " + sizeOfList);
            logger.Debug("totalPage = " + totalPage);

            listPages.Clear();

            for (int i = 0; i < totalPage; i++)
            {
                listPages.Add(i);
            }

            bindingNavigatorManufacturer.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorManufacturer.BindingSource.Position = position;
            bindingNavigatorManufacturer.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số nhà sản xuất: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Manufacturer entity;

            if (isAdd)
            {
                entity = new Manufacturer();
            }
            else
            {
                int idxInList = -1;

                foreach (Manufacturer obj in currentListManufacturer)
                {
                    if (obj.ID == (int)gvManufacturer.CurrentRow.Cells["ManId"].Value)
                    {
                        idxInList = currentListManufacturer.IndexOf(obj);
                    }
                }

                entity = currentListManufacturer[idxInList];
            }

            entity.ManName = txtManName.Text.Trim();
            entity.Address = txtAddress.Text.Trim();
            entity.TelNo = txtTelNo.Text.Trim();
            entity.FaxNo = txtFaxNo.Text.Trim();
            entity.Email = txtEmail.Text.Trim();
            entity.Website = txtWebsite.Text.Trim();
            entity.CountryId = Convert.ToInt32(cbbCountry.SelectedValue);

            manufacturerManager.SaveOrUpdate(entity);
            RefreshGridView(new Manufacturer());
            ResetForm();
            SetFormReadOnly(true);
        }

        #region Binding Navigator Event

        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ResetForm();            
            SetFormReadOnly(false);
            //toolStripBtnEdit.Enabled = false;
            //toolStripBtnDelete.Enabled = false;
        }

        private void toolStripBtnEdit_Click(object sender, EventArgs e)
        {
            isAdd = false;
            SetFormReadOnly(false);            
        }

        private void toolStripBtnDelete_Click(object sender, EventArgs e)
        {
            if (gvManufacturer.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvManufacturer.SelectedCells[0].RowIndex;
                int deleteManufacturerId = (int)gvManufacturer.Rows[selectedRowIndex].Cells["ManId"].Value;
                string deleteManufacturerName = (string)gvManufacturer.Rows[selectedRowIndex].Cells["ManName"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà sản xuất [" + deleteManufacturerName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idxInList = -1;

                    foreach (Manufacturer obj in currentListManufacturer)
                    {
                        if (obj.ID == deleteManufacturerId)
                        {
                            idxInList = currentListManufacturer.IndexOf(obj);
                        }
                    }

                    manufacturerManager.Delete(currentListManufacturer[idxInList]);
                    
                    //Refresh grid view after delete successfully
                    RefreshGridView(new Manufacturer());
                }
            }
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new Manufacturer());
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorManufacturer.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorManufacturer.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<Manufacturer> searchResult = manufacturerManager.GetManufacturerListByParam(searchEntity, searchParam);
            currentListManufacturer = searchResult.SearchList;

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetManufacturer.Tables["Manufacturer"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtManName.ReadOnly = state;
            txtAddress.ReadOnly = state;
            txtTelNo.ReadOnly = state;
            txtFaxNo.ReadOnly = state;
            txtEmail.ReadOnly = state;
            txtWebsite.ReadOnly = state;
            cbbCountry.Enabled = !state;
            btnSave.Enabled = !state;
            btnReset.Enabled = !state;

            if (state == false && isAdd == true)
            {
                toolStripBtnEdit.Enabled = false;
                toolStripBtnDelete.Enabled = false;
            }
            else if (state == true)
            {
                toolStripBtnEdit.Enabled = true;
                toolStripBtnDelete.Enabled = true;
            }
        }

        private void ResetForm()
        {
            if (isAdd)
            {
                txtManID.ResetText();
            }
            
            txtManName.ResetText();
            txtAddress.ResetText();
            txtTelNo.ResetText();
            txtFaxNo.ResetText();
            txtEmail.ResetText();
            txtWebsite.ResetText();
            cbbCountry.ResetText();
        }

        private void RefreshGridView(Manufacturer searchEntity)
        {
            //Get all user
            searchParam = new SearchParam();
            searchParam.Start = DEFAULT_START;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //
            this.searchEntity = searchEntity;

            //
            SearchResult<Manufacturer> searchResult = manufacturerManager.GetManufacturerListByParam(searchEntity, searchParam);
            currentListManufacturer = searchResult.SearchList;

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetManufacturer.Tables["Manufacturer"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvManufacturer_SelectionChanged(object sender, EventArgs e)
        {
            if (gvManufacturer.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvManufacturer.SelectedCells[0].RowIndex;
                BindingManufacturerToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingManufacturerToForm(int rowIndex)
        {
            txtManID.Text = (int)gvManufacturer.Rows[rowIndex].Cells["ManId"].Value + "";
            txtManName.Text = (string)gvManufacturer.Rows[rowIndex].Cells["ManName"].Value;
            txtAddress.Text = (string)gvManufacturer.Rows[rowIndex].Cells["Address"].Value;
            txtTelNo.Text = (string)gvManufacturer.Rows[rowIndex].Cells["TelNo"].Value;
            txtFaxNo.Text = (string)gvManufacturer.Rows[rowIndex].Cells["FaxNo"].Value;
            txtEmail.Text = (string)gvManufacturer.Rows[rowIndex].Cells["Email"].Value;
            txtWebsite.Text = (string)gvManufacturer.Rows[rowIndex].Cells["Website"].Value;
            cbbCountry.SelectedValue = (int)gvManufacturer.Rows[rowIndex].Cells["CountryId"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearch.Text.Trim();            

            if (chkSearchManufacturerID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new Manufacturer(idSearch);
                }
                else
                {
                    searchEntity = new Manufacturer(-1);
                }
            }
            else
            {
                searchEntity = new Manufacturer();
            }

            if (chkSearchManufacturerName.Checked)
            {
                searchEntity.ManName = strSearch;
            }

            RefreshGridView(searchEntity);
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchManufacturerID.Checked = true;
                chkSearchManufacturerName.Checked = true;
            }
            else
            {
                chkSearchManufacturerID.Checked = false;
                chkSearchManufacturerName.Checked = false;
            }
        }

        private void DisplayColumn(DataGridView gridView, CheckBox chk, string columnName)
        {
            if (chk.Checked)
            {
                gridView.Columns[columnName].Visible = true;
            }
            else
            {
                gridView.Columns[columnName].Visible = false;
            }
        }

        private void chkDispAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDispAll.Checked)
            {
                DisplayAllColumn(true);
            }
            else
            {
                DisplayAllColumn(false);
            }
        }

        private void chkDispManufacturerName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvManufacturer, chkDispManufacturerName, "ManufacturerName");
        }

        private void chkDispManufacturerID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvManufacturer, chkDispManufacturerID, "ManufacturerID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispManufacturerID.Checked = true;
                chkDispManufacturerName.Checked = true;
                //chkDispManufacturerDesc.Checked = true;
            }
            else
            {
                //chkDispManufacturerID.Checked = false;
                chkDispManufacturerName.Checked = false;
                //chkDispManufacturerDesc.Checked = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}