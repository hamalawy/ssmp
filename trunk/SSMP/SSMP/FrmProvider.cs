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
    public partial class FrmProvider : Form
    {
        //Manager object
        private ProviderManager manufacturerManager;
        private CountryManager countryManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmProvider));
        private Provider searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetProvider;
        private List<Int32> listPages;
        private bool isAdd;
        private IList<Provider> currentListProvider;

        public FrmProvider()
        {
            InitializeComponent();

            //
            manufacturerManager = new ProviderManager();
            countryManager = new CountryManager();
        }

        private void FrmProvider_Load(object sender, EventArgs e)
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
            searchEntity = new Provider();

            //
            SearchResult<Provider> searchResult = manufacturerManager.GetProviderListByParam(searchEntity, searchParam);
            currentListProvider = searchResult.SearchList;

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetProvider.Tables["Provider"]);

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
            //Create DataTable of Provider
            DataTable dataTableProvider = new DataTable("Provider");
            dataTableProvider.Columns.Add("ManId", typeof(int));
            dataTableProvider.Columns.Add("ProviderName", typeof(string));
            dataTableProvider.Columns.Add("Address", typeof(string));
            dataTableProvider.Columns.Add("TelNo", typeof(string));
            dataTableProvider.Columns.Add("FaxNo", typeof(string));
            dataTableProvider.Columns.Add("Email", typeof(string));
            dataTableProvider.Columns.Add("Website", typeof(string));
            dataTableProvider.Columns.Add("CountryId", typeof(int));
            dataTableProvider.Columns.Add("CountryName", typeof(string));

            //Create DataSet of Provider
            dataSetProvider = new DataSet();
            dataSetProvider.Tables.Add(dataTableProvider);

            //Config detail of column in grid view
            gvProvider.DataSource = dataSetProvider;
            gvProvider.DataMember = "Provider";
            gvProvider.Columns["ManId"].HeaderText = "Mã nhà cung cấp";
            gvProvider.Columns["ProviderName"].HeaderText = "Tên nhà cung cấp";
            gvProvider.Columns["Address"].HeaderText = "Địa chỉ";
            gvProvider.Columns["TelNo"].HeaderText = "Điện thoại";
            gvProvider.Columns["FaxNo"].HeaderText = "Fax";
            gvProvider.Columns["Email"].HeaderText = "Email";
            gvProvider.Columns["Website"].HeaderText = "Website";
            gvProvider.Columns["CountryId"].HeaderText = "CountryId";
            gvProvider.Columns["CountryId"].Visible = false;
            gvProvider.Columns["CountryName"].HeaderText = "Quốc gia";            
        }

        private void IList2DataTable(IList<Provider> listProvider, DataTable dataTableProvider)
        {
            if (listProvider != null)
            {
                dataTableProvider.Clear();

                foreach (Provider objProvider in listProvider)
                {
                    DataRow rowTemp = dataTableProvider.NewRow();

                    rowTemp["ManId"] = objProvider.ID;
                    rowTemp["ProviderName"] = objProvider.ProviderName;
                    rowTemp["Address"] = objProvider.Address;
                    rowTemp["TelNo"] = objProvider.TelNo;
                    rowTemp["FaxNo"] = objProvider.FaxNo;
                    rowTemp["Email"] = objProvider.Email;
                    rowTemp["Website"] = objProvider.Website;
                    rowTemp["CountryId"] = objProvider.CountryId;
                    if (objProvider.CountryIdLookup != null)
                    {
                        rowTemp["CountryName"] = objProvider.CountryIdLookup.CountryName;
                    }
                    else
                    {
                        rowTemp["CountryName"] = countryManager.GetById(objProvider.CountryId, false).CountryName;
                    }

                    dataTableProvider.Rows.Add(rowTemp);
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

            bindingNavigatorProvider.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorProvider.BindingSource.Position = position;
            bindingNavigatorProvider.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số nhà cung cấp: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProviderName.Text.Trim().Length == 0)
            {
                HoTro.baoLoi("Điền tên nhà cung cấp");
                return;
            }
            Provider entity;

            if (isAdd)
            {
                entity = new Provider();
            }
            else
            {
                int idxInList = -1;

                foreach (Provider obj in currentListProvider)
                {
                    if (obj.ID == (int)gvProvider.CurrentRow.Cells["ManId"].Value)
                    {
                        idxInList = currentListProvider.IndexOf(obj);
                    }
                }

                entity = currentListProvider[idxInList];
            }

            entity.ProviderName = txtProviderName.Text.Trim();
            entity.Address = txtAddress.Text.Trim();
            entity.TelNo = txtTelNo.Text.Trim();
            entity.FaxNo = txtFaxNo.Text.Trim();
            entity.Email = txtEmail.Text.Trim();
            entity.Website = txtWebsite.Text.Trim();
            entity.CountryId = Convert.ToInt32(cbbCountry.SelectedValue);

            manufacturerManager.SaveOrUpdate(entity);
            RefreshGridView(new Provider());
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
            if (gvProvider.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvProvider.SelectedCells[0].RowIndex;
                int deleteProviderId = (int)gvProvider.Rows[selectedRowIndex].Cells["ManId"].Value;
                string deleteProviderName = (string)gvProvider.Rows[selectedRowIndex].Cells["ProviderName"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp [" + deleteProviderName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idxInList = -1;

                    foreach (Provider obj in currentListProvider)
                    {
                        if (obj.ID == deleteProviderId)
                        {
                            idxInList = currentListProvider.IndexOf(obj);
                        }
                    }

                    manufacturerManager.Delete(currentListProvider[idxInList]);
                    
                    //Refresh grid view after delete successfully
                    RefreshGridView(new Provider());
                }
            }
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new Provider());
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProvider.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorProvider.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<Provider> searchResult = manufacturerManager.GetProviderListByParam(searchEntity, searchParam);
            currentListProvider = searchResult.SearchList;

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetProvider.Tables["Provider"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtProviderName.ReadOnly = state;
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
                txtProviderID.ResetText();
            }
            
            txtProviderName.ResetText();
            txtAddress.ResetText();
            txtTelNo.ResetText();
            txtFaxNo.ResetText();
            txtEmail.ResetText();
            txtWebsite.ResetText();
            cbbCountry.ResetText();
        }

        private void RefreshGridView(Provider searchEntity)
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
            SearchResult<Provider> searchResult = manufacturerManager.GetProviderListByParam(searchEntity, searchParam);
            currentListProvider = searchResult.SearchList;

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetProvider.Tables["Provider"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvProvider_SelectionChanged(object sender, EventArgs e)
        {
            if (gvProvider.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvProvider.SelectedCells[0].RowIndex;
                BindingProviderToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingProviderToForm(int rowIndex)
        {
            txtProviderID.Text = (int)gvProvider.Rows[rowIndex].Cells["ManId"].Value + "";
            txtProviderName.Text = (string)gvProvider.Rows[rowIndex].Cells["ProviderName"].Value;
            txtAddress.Text = (string)gvProvider.Rows[rowIndex].Cells["Address"].Value;
            txtTelNo.Text = (string)gvProvider.Rows[rowIndex].Cells["TelNo"].Value;
            txtFaxNo.Text = (string)gvProvider.Rows[rowIndex].Cells["FaxNo"].Value;
            txtEmail.Text = (string)gvProvider.Rows[rowIndex].Cells["Email"].Value;
            txtWebsite.Text = (string)gvProvider.Rows[rowIndex].Cells["Website"].Value;
            cbbCountry.SelectedValue = (int)gvProvider.Rows[rowIndex].Cells["CountryId"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearch.Text.Trim();            

            if (chkSearchProviderID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new Provider(idSearch);
                }
                else
                {
                    searchEntity = new Provider(-1);
                }
            }
            else
            {
                searchEntity = new Provider();
            }

            if (chkSearchProviderName.Checked)
            {
                searchEntity.ProviderName = strSearch;
            }

            RefreshGridView(searchEntity);
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchProviderID.Checked = true;
                chkSearchProviderName.Checked = true;
            }
            else
            {
                chkSearchProviderID.Checked = false;
                chkSearchProviderName.Checked = false;
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

        private void chkDispProviderName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvProvider, chkDispProviderName, "ProviderName");
        }

        private void chkDispProviderID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvProvider, chkDispProviderID, "ProviderID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispProviderID.Checked = true;
                chkDispProviderName.Checked = true;
                //chkDispProviderDesc.Checked = true;
            }
            else
            {
                //chkDispProviderID.Checked = false;
                chkDispProviderName.Checked = false;
                //chkDispProviderDesc.Checked = false;
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