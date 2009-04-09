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
    public partial class FrmUser : Form
    {
        //Manager object
        private UserManager userManager;
        private UserTitleManager userTitleManager;
        private UserRoleManager userRoleManager;
        private UserStatusManager userStatusManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private User userEntity;
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmUser));
        private IList<User> currentListUser;
        private DataSet dataSetUser;
        private int MODE;
        private int updateUserId;

        public FrmUser()
        {
            InitializeComponent();

            //Create Manager which will use in form
            userManager = new UserManager();
            userTitleManager = new UserTitleManager();
            userRoleManager = new UserRoleManager();
            userStatusManager = new UserStatusManager();

            //
            MODE = Constants.MODE.ADD;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshGridViewUsers();
                cbbUserTitle.DataSource = userTitleManager.GetAll();
                cbbUserTitle.DisplayMember = "UserTitleName";
                cbbUserTitle.ValueMember = "ID";

                cbbUserRole.DataSource = userRoleManager.GetAll();
                cbbUserRole.DisplayMember = "UserRoleName";
                cbbUserRole.ValueMember = "ID";

                cbbUserStatus.DataSource = userStatusManager.GetAll();
                cbbUserStatus.DisplayMember = "UserStatusName";
                cbbUserStatus.ValueMember = "ID";

                //Display all column in gridview
                DisplayAll();
            }
            catch (Exception ex)
            {
                logger.Debug(ex.Message);
                logger.Debug(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }

        #region Binding Data

        private void BindingDataToForm(User entity, SearchParam searchParam, int position)
        {
            SearchResult<User> searchResult = userManager.GetUserListByParam(entity, searchParam);

            if (searchResult != null)
            {
                DataTable dataTableUser = new DataTable("User");
                dataTableUser.Columns.Add("UserId", typeof(int));
                dataTableUser.Columns.Add("Username", typeof(string));
                dataTableUser.Columns.Add("FullName", typeof(string));
                dataTableUser.Columns.Add("Email", typeof(string));
                dataTableUser.Columns.Add("Birthday", typeof(DateTime));
                dataTableUser.Columns.Add("IdCardNo", typeof(string));
                dataTableUser.Columns.Add("Sex", typeof(byte));
                dataTableUser.Columns.Add("TelNo", typeof(string));
                dataTableUser.Columns.Add("Address", typeof(string));
                dataTableUser.Columns.Add("UserTitleId", typeof(int));
                dataTableUser.Columns.Add("UserTitle", typeof(string));
                dataTableUser.Columns.Add("UserRoleId", typeof(int));
                dataTableUser.Columns.Add("UserRole", typeof(string));
                dataTableUser.Columns.Add("UserStatusId", typeof(int));
                dataTableUser.Columns.Add("UserStatus", typeof(string));

                foreach(User objUser in searchResult.SearchList) 
                {
                    DataRow rowTemp = dataTableUser.NewRow();
                    rowTemp["UserId"] = objUser.ID;
                    rowTemp["Username"] = objUser.Username;
                    rowTemp["FullName"] = objUser.FullName;
                    rowTemp["Email"] = objUser.Email;
                    rowTemp["Birthday"] = objUser.Birthday;
                    rowTemp["IdCardNo"] = objUser.IdCardNo;
                    rowTemp["Sex"] = objUser.Sex;
                    rowTemp["TelNo"] = objUser.TelNo;
                    rowTemp["Address"] = objUser.Address;
                    rowTemp["UserTitleId"] = objUser.UserTitleIdLookup.ID;
                    rowTemp["UserTitle"] = objUser.UserTitleIdLookup.UserTitleName;
                    rowTemp["UserRoleId"] = objUser.UserRoleIdLookup.ID;
                    rowTemp["UserRole"] = objUser.UserRoleIdLookup.UserRoleName;
                    rowTemp["UserStatusId"] = objUser.UserStatusIdLookup.ID;
                    rowTemp["UserStatus"] = objUser.UserStatusIdLookup.UserStatusName;
                        
                    dataTableUser.Rows.Add(rowTemp);
                }

                dataSetUser = new DataSet();
                dataSetUser.Tables.Add(dataTableUser);
                gvUser.DataSource = dataSetUser;
                gvUser.DataMember = "User";
                gvUser.Columns["UserId"].HeaderText = "Mã người dùng";
                gvUser.Columns["Username"].HeaderText = "Tên đăng nhập";
                gvUser.Columns["FullName"].HeaderText = "Họ và tên";
                gvUser.Columns["Email"].HeaderText = "Email";
                gvUser.Columns["Birthday"].HeaderText = "Ngày sinh";
                gvUser.Columns["IdCardNo"].HeaderText = "Số CMT/Passport";
                gvUser.Columns["Sex"].HeaderText = "Giới tính";
                gvUser.Columns["TelNo"].HeaderText = "Điện thoại";
                gvUser.Columns["Address"].HeaderText = "Địa chỉ";
                gvUser.Columns["UserTitleId"].Visible = false;
                gvUser.Columns["UserTitle"].HeaderText = "Chức vụ";
                gvUser.Columns["UserRoleId"].Visible = false;
                gvUser.Columns["UserRole"].HeaderText = "Nhóm người dùng";
                gvUser.Columns["UserStatusId"].Visible = false;
                gvUser.Columns["UserStatus"].HeaderText = "Trạng thái";

                //
                currentListUser = searchResult.SearchList;

                //
                logger.Debug("searchList size = " + searchResult.SearchList.Count);

                List<Int32> listPages = new List<Int32>();
                int totalPage = 0;

                if (searchResult.SearchSize % DEFAULT_LIMIT > 0)
                {
                    totalPage = (int)searchResult.SearchSize / DEFAULT_LIMIT + 1;
                }
                else
                {
                    totalPage = (int)searchResult.SearchSize / DEFAULT_LIMIT;
                }

                logger.Debug("searchSize = " + searchResult.SearchSize);
                logger.Debug("totalPage = " + totalPage);

                for (int i = 0; i < totalPage; i++)
                {
                    listPages.Add(i);
                }

                bindingNavigatorUser.BindingSource = new BindingSource(listPages, "");
                bindingNavigatorUser.BindingSource.Position = position;
                bindingNavigatorUser.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

                //Set total of number user in bindingNavigator
                toolStripLblTotal.Text = "Tổng số người dùng: " + searchResult.SearchSize;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUser.BindingSource.Position);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUser.BindingSource.Position);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUser.BindingSource.Position);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUser.BindingSource.Position);
        }

        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUser.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUser.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorUser.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            this.BindingDataToForm(userEntity, searchParam, position);
        }

        public void RefreshGridViewUsers()
        {
            User entity = new User();

            SearchParam searchParam = new SearchParam();
            searchParam.Start = DEFAULT_START;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            this.BindingDataToForm(entity, searchParam, 0);

            bindingNavigatorUser.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);
        }



        #endregion

        #region Set DOB
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            FrmCalendar frmCalendar = new FrmCalendar(this);
            frmCalendar.ShowDialog(this);
        }

        public void setDOB(string dob)
        {
            txtDOB.Text = dob;
        }
        #endregion

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                User userEntity;

                if (MODE == Constants.MODE.ADD)
                {
                    userEntity = new User();
                }
                else if (MODE == Constants.MODE.UPDATE)
                {
                    int idxInList = -1;

                    foreach (User objUser in currentListUser)
                    {
                        if (objUser.ID == updateUserId)
                        {
                            idxInList = currentListUser.IndexOf(objUser);
                        }
                    }

                    userEntity = currentListUser[idxInList];
                }
                else
                {
                    userEntity = new User();
                }

                string strFullname = txtFullname.Text.Trim();
                string strUsername = txtUsername.Text.Trim();
                string strPassword = txtPassword.Text.Trim();
                string strPasswordConfirm = txtPasswordConfirm.Text.Trim();
                int valueTitle = (int)cbbUserTitle.SelectedValue;
                int valueRole = (int)cbbUserRole.SelectedValue;
                byte valueSex = rdMale.Checked == true ? (byte)1 : (byte)0;
                DateTime dateDOB = DateTime.Parse(txtDOB.Text.Trim());
                string strIdCardNo = txtIdCardNo.Text.Trim();
                string strTelNo = txtTelNo.Text.Trim();
                string strEmail = txtEmail.Text.Trim();
                string strAddress = txtAddress.Text.Trim();

                if (strPassword != strPasswordConfirm)
                {
                    MessageBox.Show("Mật khẩu không trùng nhau. Vui lòng nhập lại", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    userEntity.FullName = strFullname;
                    userEntity.Username = strUsername;
                    userEntity.Password = new HoTro().DoiSangMaMD5(strPassword);
                    userEntity.UserTitleId = valueTitle;
                    userEntity.UserRoleId = valueRole;
                    userEntity.UserStatusId = DBConstants.User.ACTIVE;
                    userEntity.Sex = valueSex;
                    userEntity.Birthday = dateDOB;
                    userEntity.IdCardNo = strIdCardNo;
                    userEntity.TelNo = strTelNo;
                    userEntity.Email = strEmail;
                    userEntity.Address = strAddress;

                    //Do save new entity
                    userManager.SaveOrUpdate(userEntity);

                    //Show message success
                    if (MODE == Constants.MODE.ADD)
                    {
                        MessageBox.Show("Tạo mới người dùng [" + userEntity.ID + " ] thành công", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (MODE == Constants.MODE.UPDATE)
                    {
                        MessageBox.Show("Cập nhật người dùng [" + userEntity.ID + " ] thành công", Constants.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MODE = Constants.MODE.ADD;
                        btnAddUpdate.Text = "Thêm";
                        this.ResetForm();
                    }

                    //Refresh grid view after insert successfully
                    this.RefreshGridViewUsers();
                }
            }
            catch (Exception ex)
            {
                logger.Debug(ex.Message);
                logger.Debug(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripBtnUpdate_Click(object sender, EventArgs e)
        {
            if (gvUser.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvUser.SelectedCells[0].RowIndex;

                BindingUserToForm(selectedRowIndex);

                btnAddUpdate.Text = "Update";
                MODE = Constants.MODE.UPDATE;
                updateUserId = (int)gvUser.Rows[selectedRowIndex].Cells["UserId"].Value;
            }
            
        }

        private void toolStripBtnDelete_Click(object sender, EventArgs e)
        {
            if (gvUser.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvUser.SelectedCells[0].RowIndex;
                int deleteUserId = (int)gvUser.Rows[selectedRowIndex].Cells["UserId"].Value;
                string deleteUsername = (string)gvUser.Rows[selectedRowIndex].Cells["Username"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng [" + deleteUsername + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idxInList = -1;

                    foreach (User objUser in currentListUser)
                    {
                        if (objUser.ID == deleteUserId)
                        {
                            idxInList = currentListUser.IndexOf(objUser);
                        }
                    }

                    userManager.Delete(currentListUser[idxInList]);

                    //Refresh grid view after delete successfully
                    this.RefreshGridViewUsers();
                }
            }
        }

        private void chkDispAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDispAll.Checked == true)
            {
                DisplayAll();
            }
            else
            {
                chkDispAddress.Checked = false;
                chkDispDOB.Checked = false;
                chkDispEmail.Checked = false;
                chkDispFullname.Checked = false;
                chkDispIdCardNo.Checked = false;
                chkDispSex.Checked = false;
                chkDispTelNo.Checked = false;
                chkDispUsername.Checked = false;
                chkDispUserRole.Checked = false;
                chkDispUserStatus.Checked = false;
                chkDispUserTitle.Checked = false;
            }
        }

        private void chkDispFullname_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispFullname, "Fullname");
        }

        private void chkDispUsername_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispUsername, "Username");
        }

        private void chkDispUserTitle_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispUserTitle, "UserTitle");
        }

        private void chkDispUserStatus_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispUserStatus, "UserStatus");
        }

        private void chkDispUserRole_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispUserRole, "UserRole");
        }

        private void chkDispSex_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispSex, "Sex");
        }

        private void chkDispDOB_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispDOB, "Birthday");
        }

        private void chkDispIdCardNo_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispIdCardNo, "IdCardNo");
        }

        private void chkDispTelNo_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispTelNo, "TelNo");
        }

        private void chkDispEmail_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispEmail, "Email");
        }

        private void chkDispAddress_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUser, chkDispAddress, "Address");
        }

        private void DisplayColumn(DataGridView gridView, CheckBox chk, string columnName)
        {
            if (chk.Checked)
            {
                gridView.Columns["" + columnName + ""].Visible = true;
            }
            else
            {
                gridView.Columns["" + columnName + ""].Visible = false;
            }
        }

        private void DisplayAll()
        {
            chkDispAddress.Checked = true;
            chkDispDOB.Checked = true;
            chkDispEmail.Checked = true;
            chkDispFullname.Checked = true;
            chkDispIdCardNo.Checked = true;
            chkDispSex.Checked = true;
            chkDispTelNo.Checked = true;
            chkDispUsername.Checked = true;
            chkDispUserRole.Checked = true;
            chkDispUserStatus.Checked = true;
            chkDispUserTitle.Checked = true;
        }

        private void BindingUserToForm(int rowIndex)
        {
            txtAddress.Text = (string)gvUser.Rows[rowIndex].Cells["Address"].Value;
            txtDOB.Text = ((DateTime)gvUser.Rows[rowIndex].Cells["Birthday"].Value).ToString(Constants.DATETIME_FORMAT);
            txtEmail.Text = (string)gvUser.Rows[rowIndex].Cells["Email"].Value;
            txtFullname.Text = (string)gvUser.Rows[rowIndex].Cells["Fullname"].Value;
            txtIdCardNo.Text = (string)gvUser.Rows[rowIndex].Cells["IdCardNo"].Value;
            txtTelNo.Text = (string)gvUser.Rows[rowIndex].Cells["TelNo"].Value;
            txtUserId.Text = (int)gvUser.Rows[rowIndex].Cells["UserId"].Value + "";
            txtUsername.Text = (string)gvUser.Rows[rowIndex].Cells["Username"].Value;
            cbbUserRole.SelectedValue = gvUser.Rows[rowIndex].Cells["UserRoleId"].Value;
            cbbUserStatus.SelectedValue = gvUser.Rows[rowIndex].Cells["UserStatusId"].Value;
            cbbUserTitle.SelectedValue = gvUser.Rows[rowIndex].Cells["UserTitleId"].Value;
            rdMale.Checked = (byte)gvUser.Rows[rowIndex].Cells["Sex"].Value == 1 ? true : false;
            rdFemale.Checked = (byte)gvUser.Rows[rowIndex].Cells["Sex"].Value == 0 ? true : false;
        }

        private void ResetForm()
        {
            txtAddress.ResetText();
            txtDOB.ResetText();
            txtEmail.ResetText();
            txtFullname.ResetText();
            txtIdCardNo.ResetText();
            txtTelNo.ResetText();
            txtUserId.ResetText();
            txtUsername.ResetText();
            cbbUserRole.ResetText();
            cbbUserStatus.ResetText();
            cbbUserTitle.ResetText();
            rdMale.ResetText();
            rdFemale.ResetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }
    }
}