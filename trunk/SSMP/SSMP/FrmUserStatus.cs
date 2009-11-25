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
    public partial class FrmUserStatus : Form
    {
        //Manager object
        private UserStatusManager userStatusManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmUserStatus));
        private UserStatus searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetUserStatus;
        private List<Int32> listPages;
        private bool isAdd;

        public FrmUserStatus()
        {
            InitializeComponent();

            //
            userStatusManager = new UserStatusManager();
        }

        private void FrmUserStatus_Load(object sender, EventArgs e)
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
            searchEntity = new UserStatus();

            //
            SearchResult<UserStatus> searchResult = userStatusManager.GetUserStatusListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserStatus.Tables["UserStatus"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);

            //
            isAdd = true;
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of UserStatus
            DataTable dataTableUserStatus = new DataTable("UserStatus");
            dataTableUserStatus.Columns.Add("UserStatusId", typeof(int));
            dataTableUserStatus.Columns.Add("UserStatusName", typeof(string));
            dataTableUserStatus.Columns.Add("UserStatusDesc", typeof(string));

            //Create DataSet of UserStatus
            dataSetUserStatus = new DataSet();
            dataSetUserStatus.Tables.Add(dataTableUserStatus);

            //Config detail of column in grid view
            gvUserStatus.DataSource = dataSetUserStatus;
            gvUserStatus.DataMember = "UserStatus";
            gvUserStatus.Columns["UserStatusId"].HeaderText = "Mã trạng thái";
            gvUserStatus.Columns["UserStatusName"].HeaderText = "Tên trạng thái";
            gvUserStatus.Columns["UserStatusDesc"].HeaderText = "Mô tả";            
        }

        private void IList2DataTable(IList<UserStatus> listUserStatus, DataTable dataTableUserStatus)
        {
            if (listUserStatus != null)
            {
                dataTableUserStatus.Clear();

                foreach (UserStatus objUserStatus in listUserStatus)
                {
                    DataRow rowTemp = dataTableUserStatus.NewRow();

                    rowTemp["UserStatusId"] = objUserStatus.ID;
                    rowTemp["UserStatusName"] = objUserStatus.UserStatusName;
                    rowTemp["UserStatusDesc"] = objUserStatus.UserStatusDesc;

                    dataTableUserStatus.Rows.Add(rowTemp);
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

            bindingNavigatorUserStatus.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorUserStatus.BindingSource.Position = position;
            bindingNavigatorUserStatus.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số trạng thái: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserStatusName.Text.Trim().Length == 0)
            {
                HoTro.baoLoi("Điền tên trạng thái");
                return;
            }
            if (isAdd)
            {
                UserStatus entity = new UserStatus();
                entity.UserStatusName = txtUserStatusName.Text.Trim();
                entity.UserStatusDesc = txtUserStatusDesc.Text.Trim();

                userStatusManager.SaveOrUpdate(entity);
                RefreshGridView(new UserStatus());
                ResetForm();
                SetFormReadOnly(true);
            }
            else
            {
                UserStatus entity = new UserStatus(Int32.Parse(txtUserStatusID.Text));
                entity.UserStatusName = txtUserStatusName.Text.Trim();
                entity.UserStatusDesc = txtUserStatusDesc.Text.Trim();

                userStatusManager.SaveOrUpdate(entity);
                RefreshGridView(new UserStatus());
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
            if (gvUserStatus.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvUserStatus.SelectedCells[0].RowIndex;
                int deleteUserStatusId = (int)gvUserStatus.Rows[selectedRowIndex].Cells["UserStatusId"].Value;
                string deleteUserStatusName = (string)gvUserStatus.Rows[selectedRowIndex].Cells["UserStatusName"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa trạng thái [" + deleteUserStatusName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userStatusManager.Delete(new UserStatus(deleteUserStatusId));
                    
                    //Refresh grid view after delete successfully
                    RefreshGridView(new UserStatus());
                }
            }
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new UserStatus());
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserStatus.BindingSource.Position);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserStatus.BindingSource.Position);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserStatus.BindingSource.Position);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserStatus.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserStatus.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorUserStatus.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<UserStatus> searchResult = userStatusManager.GetUserStatusListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserStatus.Tables["UserStatus"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtUserStatusName.ReadOnly = state;
            txtUserStatusDesc.ReadOnly = state;
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
                txtUserStatusID.ResetText();
            }
            
            txtUserStatusName.ResetText();
            txtUserStatusDesc.ResetText();
        }

        private void RefreshGridView(UserStatus searchEntity)
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
            SearchResult<UserStatus> searchResult = userStatusManager.GetUserStatusListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserStatus.Tables["UserStatus"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvUserStatus_SelectionChanged(object sender, EventArgs e)
        {
            if (gvUserStatus.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvUserStatus.SelectedCells[0].RowIndex;
                BindingUserStatusToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingUserStatusToForm(int rowIndex)
        {
            txtUserStatusID.Text = (int)gvUserStatus.Rows[rowIndex].Cells["UserStatusId"].Value + "";
            txtUserStatusName.Text = (string)gvUserStatus.Rows[rowIndex].Cells["UserStatusName"].Value;
            txtUserStatusDesc.Text = (string)gvUserStatus.Rows[rowIndex].Cells["UserStatusDesc"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearch.Text.Trim();            

            if (chkSearchUserStatusID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new UserStatus(idSearch);
                }
                else
                {
                    searchEntity = new UserStatus(-1);
                }
            }
            else
            {
                searchEntity = new UserStatus();
            }

            if (chkSearchUserStatusName.Checked)
            {
                searchEntity.UserStatusName = strSearch;
            }

            if (chkSearchUserStatusDesc.Checked)
            {
                searchEntity.UserStatusDesc = strSearch;   
            }

            RefreshGridView(searchEntity);
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchUserStatusID.Checked = true;
                chkSearchUserStatusName.Checked = true;
                chkSearchUserStatusDesc.Checked = true;
            }
            else
            {
                chkSearchUserStatusID.Checked = false;
                chkSearchUserStatusName.Checked = false;
                chkSearchUserStatusDesc.Checked = false;
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

        private void chkDispUserStatusName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUserStatus, chkDispUserStatusName, "UserStatusName");
        }

        private void chkDispUserStatusDesc_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUserStatus, chkDispUserStatusDesc, "UserStatusDesc");
        }

        private void chkDispUserStatusID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUserStatus, chkDispUserStatusID, "UserStatusID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispUserStatusID.Checked = true;
                chkDispUserStatusName.Checked = true;
                chkDispUserStatusDesc.Checked = true;
            }
            else
            {
                //chkDispUserStatusID.Checked = false;
                chkDispUserStatusName.Checked = false;
                chkDispUserStatusDesc.Checked = false;
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

        private void btnReloadAll_Click(object sender, EventArgs e)
        {
            //Get all user
            searchParam = new SearchParam();
            searchParam.Start = DEFAULT_START;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //
            searchEntity = new UserStatus();

            //
            SearchResult<UserStatus> searchResult = userStatusManager.GetUserStatusListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserStatus.Tables["UserStatus"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }
    }
}