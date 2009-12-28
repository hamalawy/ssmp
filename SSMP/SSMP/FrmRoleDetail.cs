using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SSMP.Core.Domain;
using SSMP.Data.Manager;

namespace SSMP
{
    public partial class FrmRoleDetail : Form
    {
        private int userRoleID;
        private DataSet dataSetRoleDetail;
        private List<RoleDetail> listRoleDetail;

        private RoleDetailManager roleDetailManager;
        private UserRoleManager userRoleManager;
        private MenuManager menuManager;

        public FrmRoleDetail()
        {
            InitializeComponent();

            //
            roleDetailManager = new RoleDetailManager();
            userRoleManager = new UserRoleManager();
            menuManager = new MenuManager();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (RoleDetail obj in listRoleDetail)
                {
                    roleDetailManager.SaveOrUpdate(obj);
                }
                MessageBox.Show("Phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi trong quá trình xử lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void FrmRoleDetail_Load(object sender, EventArgs e)
        {
            UserRole entity = userRoleManager.GetById(this.userRoleID, false);
            txtRoleName.Text = entity.UserRoleName;

            this.listRoleDetail = roleDetailManager.GetListByRole(this.userRoleID);
            ContructGridViewColumn();
            IList2DataTable(listRoleDetail, dataSetRoleDetail.Tables["RoleDetail"]);
        }

        public DialogResult ShowDialog(IWin32Window owner, int userRoleID)
        {
            if (userRoleID == 0)
            {
                return DialogResult.None;
            }
            else
            {                
                this.userRoleID = userRoleID;
                return this.ShowDialog(owner);
            }
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of RoleDetail
            DataTable dataTableRoleDetail = new DataTable("RoleDetail");
            dataTableRoleDetail.Columns.Add("RoleID", typeof(int));
            dataTableRoleDetail.Columns.Add("MenuID", typeof(int));
            dataTableRoleDetail.Columns.Add("RoleName", typeof(string));
            dataTableRoleDetail.Columns.Add("MenuName", typeof(string));
            dataTableRoleDetail.Columns.Add("Enable", typeof(bool));

            //Create DataSet of RoleDetail
            dataSetRoleDetail = new DataSet();
            dataSetRoleDetail.Tables.Add(dataTableRoleDetail);

            //Config detail of column in grid view
            gvRoleDetail.DataSource = dataSetRoleDetail;
            gvRoleDetail.DataMember = "RoleDetail";
            gvRoleDetail.Columns["RoleName"].HeaderText = "Tên nhóm người dùng";
            gvRoleDetail.Columns["MenuName"].HeaderText = "Danh mục";
            gvRoleDetail.Columns["Enable"].HeaderText = "Được sử dụng";
            gvRoleDetail.Columns["RoleID"].Visible = false;
            gvRoleDetail.Columns["MenuID"].Visible = false;
        }

        private void IList2DataTable(IList<RoleDetail> listRoleDetail, DataTable dataTableRoleDetail)
        {
            if (listRoleDetail != null)
            {
                dataTableRoleDetail.Clear();

                foreach (RoleDetail objRoleDetail in listRoleDetail)
                {
                    DataRow rowTemp = dataTableRoleDetail.NewRow();

                    rowTemp["RoleID"] = objRoleDetail.UserRoleId;
                    rowTemp["MenuID"] = objRoleDetail.MenuId;
                    rowTemp["RoleName"] = userRoleManager.GetById(objRoleDetail.UserRoleId, false).UserRoleName;
                    rowTemp["MenuName"] = menuManager.GetById(objRoleDetail.MenuId, false).MenuName;
                    rowTemp["Enable"] = objRoleDetail.Enable;

                    dataTableRoleDetail.Rows.Add(rowTemp);
                }
            }
        }

        private void gvRoleDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (RoleDetail obj in listRoleDetail)
                {
                    if (obj.MenuId == (int)gvRoleDetail.Rows[e.RowIndex].Cells["MenuID"].Value)
                    {
                        obj.Enable = (bool)gvRoleDetail.Rows[e.RowIndex].Cells["Enable"].Value == true ? (byte)1 : (byte)0;                        
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi trong quá trình xử lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}