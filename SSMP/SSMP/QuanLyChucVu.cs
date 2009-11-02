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
    public partial class FrmUserTitle : Form
    {
        //Manager object
        private UserTitleManager userTitleManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmUserTitle));
        private UserTitle searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetUserTitle;
        private List<Int32> listPages;
        private bool isAdd;

        public FrmUserTitle()
        {
            InitializeComponent();

            //
            userTitleManager = new UserTitleManager();
        }

        private void FrmUserTitle_Load(object sender, EventArgs e)
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
            searchEntity = new UserTitle();

            //
            SearchResult<UserTitle> searchResult = userTitleManager.GetUserTitleListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserTitle.Tables["UserTitle"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);

            //
            isAdd = true;
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of UserTitle
            DataTable dataTableUserTitle = new DataTable("UserTitle");
            dataTableUserTitle.Columns.Add("UserTitleId", typeof(int));
            dataTableUserTitle.Columns.Add("UserTitleName", typeof(string));
            dataTableUserTitle.Columns.Add("UserTitleDesc", typeof(string));

            //Create DataSet of UserTitle
            dataSetUserTitle = new DataSet();
            dataSetUserTitle.Tables.Add(dataTableUserTitle);

            //Config detail of column in grid view
            gvUserTitle.DataSource = dataSetUserTitle;
            gvUserTitle.DataMember = "UserTitle";
            gvUserTitle.Columns["UserTitleId"].HeaderText = "Mã chức vụ";
            gvUserTitle.Columns["UserTitleName"].HeaderText = "Tên chức vụ";
            gvUserTitle.Columns["UserTitleDesc"].HeaderText = "Mô tả";            
        }

        private void IList2DataTable(IList<UserTitle> listUserTitle, DataTable dataTableUserTitle)
        {
            if (listUserTitle != null)
            {
                dataTableUserTitle.Clear();

                foreach (UserTitle objUserTitle in listUserTitle)
                {
                    DataRow rowTemp = dataTableUserTitle.NewRow();

                    rowTemp["UserTitleId"] = objUserTitle.ID;
                    rowTemp["UserTitleName"] = objUserTitle.UserTitleName;
                    rowTemp["UserTitleDesc"] = objUserTitle.UserTitleDesc;

                    dataTableUserTitle.Rows.Add(rowTemp);
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

            bindingNavigatorUserTitle.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorUserTitle.BindingSource.Position = position;
            bindingNavigatorUserTitle.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số chức vụ: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserTitleName.Text.Trim().Length == 0)
            {
                HoTro.baoLoi("Điền tên chức vụ");
                return;
            }
            if (isAdd)
            {
                UserTitle entity = new UserTitle();
                entity.UserTitleName = txtUserTitleName.Text.Trim();
                entity.UserTitleDesc = txtUserTitleDesc.Text.Trim();

                userTitleManager.SaveOrUpdate(entity);
                RefreshGridView(new UserTitle());
                ResetForm();
                SetFormReadOnly(true);
            }
            else
            {
                UserTitle entity = new UserTitle(Int32.Parse(txtUserTitleID.Text));
                entity.UserTitleName = txtUserTitleName.Text.Trim();
                entity.UserTitleDesc = txtUserTitleDesc.Text.Trim();

                userTitleManager.SaveOrUpdate(entity);
                RefreshGridView(new UserTitle());
                ResetForm();
                SetFormReadOnly(true);
            }
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
            if (gvUserTitle.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvUserTitle.SelectedCells[0].RowIndex;
                int deleteUserTitleId = (int)gvUserTitle.Rows[selectedRowIndex].Cells["UserTitleId"].Value;
                string deleteUserTitleName = (string)gvUserTitle.Rows[selectedRowIndex].Cells["UserTitleName"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ [" + deleteUserTitleName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userTitleManager.Delete(new UserTitle(deleteUserTitleId));
                    
                    //Refresh grid view after delete successfully
                    RefreshGridView(new UserTitle());
                }
            }
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new UserTitle());
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserTitle.BindingSource.Position);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserTitle.BindingSource.Position);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserTitle.BindingSource.Position);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserTitle.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserTitle.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorUserTitle.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<UserTitle> searchResult = userTitleManager.GetUserTitleListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserTitle.Tables["UserTitle"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtUserTitleName.ReadOnly = state;
            txtUserTitleDesc.ReadOnly = state;
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
                txtUserTitleID.ResetText();
            }
            
            txtUserTitleName.ResetText();
            txtUserTitleDesc.ResetText();
        }

        private void RefreshGridView(UserTitle searchEntity)
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
            SearchResult<UserTitle> searchResult = userTitleManager.GetUserTitleListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserTitle.Tables["UserTitle"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvUserTitle_SelectionChanged(object sender, EventArgs e)
        {
            if (gvUserTitle.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvUserTitle.SelectedCells[0].RowIndex;
                BindingUserTitleToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingUserTitleToForm(int rowIndex)
        {
            txtUserTitleID.Text = (int)gvUserTitle.Rows[rowIndex].Cells["UserTitleId"].Value + "";
            txtUserTitleName.Text = (string)gvUserTitle.Rows[rowIndex].Cells["UserTitleName"].Value;
            txtUserTitleDesc.Text = (string)gvUserTitle.Rows[rowIndex].Cells["UserTitleDesc"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearch.Text.Trim();            

            if (chkSearchUserTitleID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new UserTitle(idSearch);
                }
                else
                {
                    searchEntity = new UserTitle(-1);
                }
            }
            else
            {
                searchEntity = new UserTitle();
            }

            if (chkSearchUserTitleName.Checked)
            {
                searchEntity.UserTitleName = strSearch;
            }

            if (chkSearchUserTitleDesc.Checked)
            {
                searchEntity.UserTitleDesc = strSearch;   
            }

            RefreshGridView(searchEntity);
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchUserTitleID.Checked = true;
                chkSearchUserTitleName.Checked = true;
                chkSearchUserTitleDesc.Checked = true;
            }
            else
            {
                chkSearchUserTitleID.Checked = false;
                chkSearchUserTitleName.Checked = false;
                chkSearchUserTitleDesc.Checked = false;
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

        private void chkDispUserTitleName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUserTitle, chkDispUserTitleName, "UserTitleName");
        }

        private void chkDispUserTitleDesc_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUserTitle, chkDispUserTitleDesc, "UserTitleDesc");
        }

        private void chkDispUserTitleID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUserTitle, chkDispUserTitleID, "UserTitleID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispUserTitleID.Checked = true;
                chkDispUserTitleName.Checked = true;
                chkDispUserTitleDesc.Checked = true;
            }
            else
            {
                //chkDispUserTitleID.Checked = false;
                chkDispUserTitleName.Checked = false;
                chkDispUserTitleDesc.Checked = false;
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