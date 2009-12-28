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
    public partial class FrmUserRole : Form
    {
        //Manager object
        private UserRoleManager userRoleManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmUserRole));
        private UserRole searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetUserRole;
        private List<Int32> listPages;
        private bool isAdd;

        public FrmUserRole()
        {
            InitializeComponent();

            //
            userRoleManager = new UserRoleManager();
        }

        private void FrmUserRole_Load(object sender, EventArgs e)
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
            searchEntity = new UserRole();

            //
            SearchResult<UserRole> searchResult = userRoleManager.GetUserRoleListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserRole.Tables["UserRole"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);

            //
            isAdd = true;
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of UserRole
            DataTable dataTableUserRole = new DataTable("UserRole");
            dataTableUserRole.Columns.Add("UserRoleId", typeof(int));
            dataTableUserRole.Columns.Add("UserRoleName", typeof(string));
            dataTableUserRole.Columns.Add("UserRoleDesc", typeof(string));

            //Create DataSet of UserRole
            dataSetUserRole = new DataSet();
            dataSetUserRole.Tables.Add(dataTableUserRole);

            //Config detail of column in grid view
            gvUserRole.DataSource = dataSetUserRole;
            gvUserRole.DataMember = "UserRole";
            gvUserRole.Columns["UserRoleId"].HeaderText = "Mã nhóm người dùng";
            gvUserRole.Columns["UserRoleName"].HeaderText = "Tên nhóm người dùng";
            gvUserRole.Columns["UserRoleDesc"].HeaderText = "Mô tả";            
        }

        private void IList2DataTable(IList<UserRole> listUserRole, DataTable dataTableUserRole)
        {
            if (listUserRole != null)
            {
                dataTableUserRole.Clear();

                foreach (UserRole objUserRole in listUserRole)
                {
                    DataRow rowTemp = dataTableUserRole.NewRow();

                    rowTemp["UserRoleId"] = objUserRole.ID;
                    rowTemp["UserRoleName"] = objUserRole.UserRoleName;
                    rowTemp["UserRoleDesc"] = objUserRole.UserRoleDesc;

                    dataTableUserRole.Rows.Add(rowTemp);
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

            bindingNavigatorUserRole.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorUserRole.BindingSource.Position = position;
            bindingNavigatorUserRole.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số nhóm người dùng: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserRoleName.Text.Trim().Length == 0)
                {
                    HoTro.baoLoi("Điền tên nhóm người dùng");
                    return;
                }
                if (isAdd)
                {
                    UserRole entity = new UserRole();
                    entity.UserRoleName = txtUserRoleName.Text.Trim();
                    entity.UserRoleDesc = txtUserRoleDesc.Text.Trim();

                    userRoleManager.SaveOrUpdate(entity);
                    RefreshGridView(new UserRole());
                    ResetForm();
                    SetFormReadOnly(true);
                }
                else
                {
                    UserRole entity = new UserRole(Int32.Parse(txtUserRoleID.Text));
                    entity.UserRoleName = txtUserRoleName.Text.Trim();
                    entity.UserRoleDesc = txtUserRoleDesc.Text.Trim();

                    userRoleManager.SaveOrUpdate(entity);
                    RefreshGridView(new UserRole());
                    ResetForm();
                    SetFormReadOnly(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi trong quá trình xử lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int selectedUserRoleId = (int)gvUserRole.SelectedRows[0].Cells[0].Value;
            if (selectedUserRoleId == 1)
            {
                MessageBox.Show("Nhóm quản trị hệ thống là nhóm người dùng mặc định, không sửa được!", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isAdd = false;
                SetFormReadOnly(false);  
            }                      
        }

        private void toolStripBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvUserRole.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = gvUserRole.SelectedCells[0].RowIndex;
                    int deleteUserRoleId = (int)gvUserRole.Rows[selectedRowIndex].Cells["UserRoleId"].Value;
                    string deleteUserRoleName = (string)gvUserRole.Rows[selectedRowIndex].Cells["UserRoleName"].Value;

                    if (deleteUserRoleId == 1)
                    {
                        MessageBox.Show("Nhóm quản trị hệ thống là nhóm người dùng mặc định, không xóa được!", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhóm người dùng [" + deleteUserRoleName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            userRoleManager.Delete(new UserRole(deleteUserRoleId));

                            //Refresh grid view after delete successfully
                            RefreshGridView(new UserRole());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi trong quá trình xử lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new UserRole());
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserRole.BindingSource.Position);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserRole.BindingSource.Position);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserRole.BindingSource.Position);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserRole.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUserRole.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorUserRole.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<UserRole> searchResult = userRoleManager.GetUserRoleListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserRole.Tables["UserRole"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtUserRoleName.ReadOnly = state;
            txtUserRoleDesc.ReadOnly = state;
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
                txtUserRoleID.ResetText();
            }
            
            txtUserRoleName.ResetText();
            txtUserRoleDesc.ResetText();
        }

        private void RefreshGridView(UserRole searchEntity)
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
            SearchResult<UserRole> searchResult = userRoleManager.GetUserRoleListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserRole.Tables["UserRole"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvUserRole_SelectionChanged(object sender, EventArgs e)
        {
            if (gvUserRole.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvUserRole.SelectedCells[0].RowIndex;
                BindingUserRoleToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingUserRoleToForm(int rowIndex)
        {
            txtUserRoleID.Text = (int)gvUserRole.Rows[rowIndex].Cells["UserRoleId"].Value + "";
            txtUserRoleName.Text = (string)gvUserRole.Rows[rowIndex].Cells["UserRoleName"].Value;
            txtUserRoleDesc.Text = (string)gvUserRole.Rows[rowIndex].Cells["UserRoleDesc"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearch.Text.Trim();            

            if (chkSearchUserRoleID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new UserRole(idSearch);
                }
                else
                {
                    searchEntity = new UserRole(-1);
                }
            }
            else
            {
                searchEntity = new UserRole();
            }

            if (chkSearchUserRoleName.Checked)
            {
                searchEntity.UserRoleName = strSearch;
            }

            if (chkSearchUserRoleDesc.Checked)
            {
                searchEntity.UserRoleDesc = strSearch;   
            }

            RefreshGridView(searchEntity);
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchUserRoleID.Checked = true;
                chkSearchUserRoleName.Checked = true;
                chkSearchUserRoleDesc.Checked = true;
            }
            else
            {
                chkSearchUserRoleID.Checked = false;
                chkSearchUserRoleName.Checked = false;
                chkSearchUserRoleDesc.Checked = false;
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

        private void chkDispUserRoleName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUserRole, chkDispUserRoleName, "UserRoleName");
        }

        private void chkDispUserDesc_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUserRole, chkDispUserRoleDesc, "UserRoleDesc");
        }

        private void chkDispUserRoleID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUserRole, chkDispUserRoleID, "UserRoleID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispUserRoleID.Checked = true;
                chkDispUserRoleName.Checked = true;
                chkDispUserRoleDesc.Checked = true;
            }
            else
            {
                //chkDispUserRoleID.Checked = false;
                chkDispUserRoleName.Checked = false;
                chkDispUserRoleDesc.Checked = false;
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
            searchEntity = new UserRole();

            //
            SearchResult<UserRole> searchResult = userRoleManager.GetUserRoleListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUserRole.Tables["UserRole"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void toolStripBtnRoleDetail_Click(object sender, EventArgs e)
        {
            int selectedUserRoleId = (int)gvUserRole.SelectedRows[0].Cells[0].Value;
            if (selectedUserRoleId == 1)
            {
                MessageBox.Show("Nhóm quản trị hệ thống là nhóm người dùng mặc định, không sửa được!", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmRoleDetail frmRoleDetail = new FrmRoleDetail();
                frmRoleDetail.ShowDialog(this, selectedUserRoleId);
            }
        }
    }
}