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
    public partial class FrmCustomer : Form
    {
        //Manager object
        private CustomerManager customerManager;
        private CountryManager countryManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmCustomer));
        private Customer searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetCustomer;
        private List<Int32> listPages;
        private bool isAdd;
        private IList<Customer> currentListCustomer;

        public FrmCustomer()
        {
            InitializeComponent();

            //
            customerManager = new CustomerManager();
            countryManager = new CountryManager();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
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
            searchEntity = new Customer();

            //
            SearchResult<Customer> searchResult = customerManager.GetCustomerListByParam(searchEntity, searchParam);
            currentListCustomer = searchResult.SearchList;

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetCustomer.Tables["Customer"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);

            //Binding data to cbbCountry
            //cbbCountry.DataSource = countryManager.GetAll();
            //cbbCountry.ValueMember = "ID";
            //cbbCountry.DisplayMember = "CountryName";

            //
            isAdd = true;
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of Customer
            DataTable dataTableCustomer = new DataTable("Customer");
            dataTableCustomer.Columns.Add("CustomerId", typeof(int));
            dataTableCustomer.Columns.Add("CustomerName", typeof(string));
            dataTableCustomer.Columns.Add("Address", typeof(string));
            dataTableCustomer.Columns.Add("Sex", typeof(byte));
            dataTableCustomer.Columns.Add("Email", typeof(string));
            dataTableCustomer.Columns.Add("IdCardNo", typeof(string));
            dataTableCustomer.Columns.Add("Birthday", typeof(DateTime));
            dataTableCustomer.Columns.Add("PrivilegePoint", typeof(string));
            dataTableCustomer.Columns.Add("TelNo", typeof(string));

            //Create DataSet of Customer
            dataSetCustomer = new DataSet();
            dataSetCustomer.Tables.Add(dataTableCustomer);

            //Config detail of column in grid view
            gvCustomer.DataSource = dataSetCustomer;
            gvCustomer.DataMember = "Customer";
            gvCustomer.Columns["CustomerId"].HeaderText = "Mã khách hàng";
            gvCustomer.Columns["CustomerName"].HeaderText = "Tên khách hàng";
            gvCustomer.Columns["Address"].HeaderText = "Địa chỉ";
            gvCustomer.Columns["Sex"].HeaderText = "Giới tính";
            gvCustomer.Columns["Email"].HeaderText = "Email";
            gvCustomer.Columns["IdCardNo"].HeaderText = "Số CMT";
            gvCustomer.Columns["PrivilegePoint"].HeaderText = "Điểm thưởng";
            gvCustomer.Columns["TelNo"].HeaderText = "Điện thoại";
        }

        private void IList2DataTable(IList<Customer> listCustomer, DataTable dataTableCustomer)
        {
            if (listCustomer != null)
            {
                dataTableCustomer.Clear();

                foreach (Customer objCustomer in listCustomer)
                {
                    DataRow rowTemp = dataTableCustomer.NewRow();

                    rowTemp["CustomerId"] = objCustomer.ID;
                    rowTemp["CustomerName"] = objCustomer.CustomerName;
                    rowTemp["Address"] = objCustomer.Address;
                    rowTemp["Sex"] = objCustomer.Sex;
                    rowTemp["Email"] = objCustomer.Email;
                    rowTemp["IdCardNo"] = objCustomer.IdCardNo;
                    rowTemp["PrivilegePoint"] = objCustomer.PrivilegePoint;
                    rowTemp["TelNo"] = objCustomer.TelNo;

                    /* Co nen them Country cho Customer hay k?
                    if (objCustomer.CountryIdLookup != null)
                    {
                        rowTemp["CountryName"] = objCustomer.CountryIdLookup.CountryName;
                    }
                    else
                    {
                        if (objCustomer.CountryId != 0)
                        {
                            if (countryManager.GetById(objCustomer.CountryId, false) != null)
                            {
                                rowTemp["CountryName"] = countryManager.GetById(objCustomer.CountryId, false).CountryName;
                            }
                            else
                            {
                                rowTemp["CountryName"] = string.Empty;
                            }
                        }
                        else
                        {
                            rowTemp["CountryName"] = string.Empty;
                        }
                    } 
                    */

                    dataTableCustomer.Rows.Add(rowTemp);
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

            bindingNavigatorCustomer.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorCustomer.BindingSource.Position = position;
            bindingNavigatorCustomer.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số khách hàng: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer entity;

            if (isAdd)
            {
                entity = new Customer();
            }
            else
            {
                int idxInList = -1;

                foreach (Customer obj in currentListCustomer)
                {
                    if (obj.ID == (int)gvCustomer.CurrentRow.Cells["CustomerId"].Value)
                    {
                        idxInList = currentListCustomer.IndexOf(obj);
                    }
                }

                entity = currentListCustomer[idxInList];
            }

            entity.CustomerName = txtCustomerName.Text.Trim();
            entity.Address = txtAddress.Text.Trim();
            entity.Sex = radioMan.Checked ? (byte)1 : (byte)0;
            entity.TelNo = txtTelNo.Text.Trim();
            entity.Email = txtEmail.Text.Trim();
            entity.IdCardNo = txtIdCardNo.Text.Trim();
            entity.Birthday = txtBirthday.Value;
            int tempPrivilegePoint;
            if (Int32.TryParse(txtPrivilegePoint.Text.Trim(), out tempPrivilegePoint))
            {
                entity.PrivilegePoint = tempPrivilegePoint;
            }
            //entity.CountryId = Convert.ToInt32(cbbCountry.SelectedValue);

            customerManager.SaveOrUpdate(entity);
            RefreshGridView(new Customer());
            ResetForm();
            SetFormReadOnly(true);
        }

        #region Binding Navigator Event

        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ResetForm();            

            //Set default value
            txtPrivilegePoint.Text = "0";

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
            if (gvCustomer.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvCustomer.SelectedCells[0].RowIndex;
                int deleteCustomerId = (int)gvCustomer.Rows[selectedRowIndex].Cells["CustomerId"].Value;
                string deleteCustomerName = (string)gvCustomer.Rows[selectedRowIndex].Cells["CustomerName"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn khách hàng [" + deleteCustomerName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idxInList = -1;

                    foreach (Customer obj in currentListCustomer)
                    {
                        if (obj.ID == deleteCustomerId)
                        {
                            idxInList = currentListCustomer.IndexOf(obj);
                        }
                    }

                    customerManager.Delete(currentListCustomer[idxInList]);
                    
                    //Refresh grid view after delete successfully
                    RefreshGridView(new Customer());
                }
            }
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new Customer());
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorCustomer.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorCustomer.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<Customer> searchResult = customerManager.GetCustomerListByParam(searchEntity, searchParam);
            currentListCustomer = searchResult.SearchList;

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetCustomer.Tables["Customer"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtCustomerName.ReadOnly = state;
            txtAddress.ReadOnly = state;
            txtTelNo.ReadOnly = state;
            txtEmail.ReadOnly = state;
            txtIdCardNo.ReadOnly = state;
            txtBirthday.Enabled = !state;
            txtPrivilegePoint.ReadOnly = state;
            radioMan.Enabled = !state;
            radioWoman.Enabled = !state;
            //cbbCountry.Enabled = !state;
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
                txtCustomerID.ResetText();
            }
            
            txtCustomerName.ResetText();
            txtAddress.ResetText();
            txtTelNo.ResetText();
            txtIdCardNo.ResetText();
            txtEmail.ResetText();
            txtPrivilegePoint.ResetText();
            //cbbCountry.ResetText();
        }

        private void RefreshGridView(Customer searchEntity)
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
            SearchResult<Customer> searchResult = customerManager.GetCustomerListByParam(searchEntity, searchParam);
            currentListCustomer = searchResult.SearchList;

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetCustomer.Tables["Customer"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (gvCustomer.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvCustomer.SelectedCells[0].RowIndex;
                BindingCustomerToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingCustomerToForm(int rowIndex)
        {
            txtCustomerID.Text = (int)gvCustomer.Rows[rowIndex].Cells["CustomerId"].Value + "";
            txtCustomerName.Text = (string)gvCustomer.Rows[rowIndex].Cells["CustomerName"].Value;
            if (gvCustomer.Rows[rowIndex].Cells["Address"].Value != DBNull.Value)
            {
                txtAddress.Text = (string)gvCustomer.Rows[rowIndex].Cells["Address"].Value;
            }
            if (gvCustomer.Rows[rowIndex].Cells["TelNo"].Value != DBNull.Value)
            {
                txtTelNo.Text = (string)gvCustomer.Rows[rowIndex].Cells["TelNo"].Value;
            }
            if (gvCustomer.Rows[rowIndex].Cells["PrivilegePoint"].Value != DBNull.Value)
            {
                txtPrivilegePoint.Text = (string)gvCustomer.Rows[rowIndex].Cells["PrivilegePoint"].Value;
            }
            if (gvCustomer.Rows[rowIndex].Cells["Email"].Value != DBNull.Value)
            {
                txtEmail.Text = (string)gvCustomer.Rows[rowIndex].Cells["Email"].Value;
            }
            if (gvCustomer.Rows[rowIndex].Cells["IdCardNo"].Value != DBNull.Value)
            {
                txtIdCardNo.Text = (string)gvCustomer.Rows[rowIndex].Cells["IdCardNo"].Value;
            }
            if (gvCustomer.Rows[rowIndex].Cells["Birthday"].Value != DBNull.Value)
            {
                txtBirthday.Value = (DateTime)gvCustomer.Rows[rowIndex].Cells["Birthday"].Value;
            }
            if (gvCustomer.Rows[rowIndex].Cells["Sex"].Value != DBNull.Value)
            {
                if ((byte)gvCustomer.Rows[rowIndex].Cells["Sex"].Value == 1)
                {
                    radioMan.Checked = true;
                }
                else
                {
                    radioWoman.Checked = true;
                }               
            }            
            //cbbCountry.SelectedValue = (int)gvCustomer.Rows[rowIndex].Cells["CountryId"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearch.Text.Trim();            

            if (chkSearchCustomerID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new Customer(idSearch);
                }
                else
                {
                    searchEntity = new Customer(-1);
                }
            }
            else
            {
                searchEntity = new Customer();
            }

            if (chkSearchCustomerName.Checked)
            {
                searchEntity.CustomerName = strSearch;
            }

            RefreshGridView(searchEntity);
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchCustomerID.Checked = true;
                chkSearchCustomerName.Checked = true;
            }
            else
            {
                chkSearchCustomerID.Checked = false;
                chkSearchCustomerName.Checked = false;
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

        private void chkDispCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvCustomer, chkDispCustomerName, "CustomerName");
        }

        private void chkDispCustomerID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvCustomer, chkDispCustomerID, "CustomerID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispCustomerID.Checked = true;
                chkDispCustomerName.Checked = true;
                //chkDispCustomerDesc.Checked = true;
            }
            else
            {
                //chkDispCustomerID.Checked = false;
                chkDispCustomerName.Checked = false;
                //chkDispCustomerDesc.Checked = false;
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