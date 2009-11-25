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
    public partial class FrmActionDetail : Form
    {
        //Manager object
        private ActionDetailManager actionDetailManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmActionDetail));
        private ActionDetail searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetActionDetail;
        private List<Int32> listPages;
        private bool isAdd;

        public FrmActionDetail()
        {
            InitializeComponent();

            //
            actionDetailManager = new ActionDetailManager();
        }

        private void FrmActionDetail_Load(object sender, EventArgs e)
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
            searchEntity = new ActionDetail();

            //
            SearchResult<ActionDetail> searchResult = actionDetailManager.GetActionDetailListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetActionDetail.Tables["ActionDetail"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);

            //
            isAdd = true;
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of ActionDetail
            DataTable dataTableActionDetail = new DataTable("ActionDetail");
            dataTableActionDetail.Columns.Add("UserId", typeof(int));
            dataTableActionDetail.Columns.Add("Username", typeof(string));
            dataTableActionDetail.Columns.Add("ActionId", typeof(int));
            dataTableActionDetail.Columns.Add("ActionName", typeof(string));
            dataTableActionDetail.Columns.Add("ActionDate", typeof(DateTime));

            //Create DataSet of ActionDetail
            dataSetActionDetail = new DataSet();
            dataSetActionDetail.Tables.Add(dataTableActionDetail);

            //Config detail of column in grid view
            gvActionDetail.DataSource = dataSetActionDetail;
            gvActionDetail.DataMember = "ActionDetail";
            gvActionDetail.Columns["UserId"].HeaderText = "Mã người dùng";
            gvActionDetail.Columns["Username"].HeaderText = "Tên người dùng";
            gvActionDetail.Columns["ActionId"].HeaderText = "Mã hành động";
            gvActionDetail.Columns["ActionName"].HeaderText = "Tên hành động";
            gvActionDetail.Columns["ActionDate"].HeaderText = "Ngày thực hiện";            
        }

        private void IList2DataTable(IList<ActionDetail> listActionDetail, DataTable dataTableActionDetail)
        {
            if (listActionDetail != null)
            {
                dataTableActionDetail.Clear();

                foreach (ActionDetail objActionDetail in listActionDetail)
                {
                    DataRow rowTemp = dataTableActionDetail.NewRow();

                    rowTemp["UserId"] = objActionDetail.ID.UserId;
                    rowTemp["Username"] = objActionDetail.UserIdLookup.Username;
                    rowTemp["ActionId"] = objActionDetail.ID.ActionId;
                    rowTemp["ActionName"] = objActionDetail.ActionIdLookup.ActionName;
                    rowTemp["ActionDate"] = objActionDetail.ActionDate;

                    dataTableActionDetail.Rows.Add(rowTemp);
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

            bindingNavigatorActionDetail.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorActionDetail.BindingSource.Position = position;
            bindingNavigatorActionDetail.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số dấu vết: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            if (isAdd)
            {
                ActionDetail entity = new ActionDetail();
                entity.ActionDetailName = txtActionDetailName.Text.Trim();
                entity.ActionDetailDesc = txtActionDetailDesc.Text.Trim();

                actionDetailManager.SaveOrUpdate(entity);
                RefreshGridView(new ActionDetail());
                ResetForm();
                SetFormReadOnly(true);
            }
            else
            {
                ActionDetail entity = new ActionDetail(Int32.Parse(txtActionDetailID.Text));
                entity.ActionDetailName = txtActionDetailName.Text.Trim();
                entity.ActionDetailDesc = txtActionDetailDesc.Text.Trim();

                actionDetailManager.SaveOrUpdate(entity);
                RefreshGridView(new ActionDetail());
                ResetForm();
                SetFormReadOnly(true);
            }
            */
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
            /*
            if (gvActionDetail.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvActionDetail.SelectedCells[0].RowIndex;
                int deleteActionDetailId = (int)gvActionDetail.Rows[selectedRowIndex].Cells["ActionDetailId"].Value;
                string deleteActionDetailName = (string)gvActionDetail.Rows[selectedRowIndex].Cells["ActionDetailName"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dấu vết [" + deleteActionDetailName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    actionDetailManager.Delete(new ActionDetail(deleteActionDetailId));
                    
                    //Refresh grid view after delete successfully
                    RefreshGridView(new ActionDetail());
                }
            }
            */
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new ActionDetail());
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorActionDetail.BindingSource.Position);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorActionDetail.BindingSource.Position);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorActionDetail.BindingSource.Position);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorActionDetail.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorActionDetail.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorActionDetail.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<ActionDetail> searchResult = actionDetailManager.GetActionDetailListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetActionDetail.Tables["ActionDetail"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtActionDetailName.ReadOnly = state;
            txtActionDetailDesc.ReadOnly = state;
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
                txtActionDetailID.ResetText();
            }
            
            txtActionDetailName.ResetText();
            txtActionDetailDesc.ResetText();
        }

        private void RefreshGridView(ActionDetail searchEntity)
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
            SearchResult<ActionDetail> searchResult = actionDetailManager.GetActionDetailListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetActionDetail.Tables["ActionDetail"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvActionDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (gvActionDetail.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvActionDetail.SelectedCells[0].RowIndex;
                BindingActionDetailToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingActionDetailToForm(int rowIndex)
        {
            //txtActionDetailID.Text = (int)gvActionDetail.Rows[rowIndex].Cells["ActionDetailId"].Value + "";
            //txtActionDetailName.Text = (string)gvActionDetail.Rows[rowIndex].Cells["ActionDetailName"].Value;
            //txtActionDetailDesc.Text = (string)gvActionDetail.Rows[rowIndex].Cells["ActionDetailDesc"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*
            string strSearch = txtSearch.Text.Trim();            

            if (chkSearchActionDetailID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new ActionDetail(idSearch);
                }
                else
                {
                    searchEntity = new ActionDetail(-1);
                }
            }
            else
            {
                searchEntity = new ActionDetail();
            }

            if (chkSearchActionDetailName.Checked)
            {
                searchEntity.ActionDetailName = strSearch;
            }

            if (chkSearchActionDetailDesc.Checked)
            {
                searchEntity.ActionDetailDesc = strSearch;   
            }

            RefreshGridView(searchEntity);            
            */
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchActionDetailID.Checked = true;
                chkSearchActionDetailName.Checked = true;
                chkSearchActionDetailDesc.Checked = true;
            }
            else
            {
                chkSearchActionDetailID.Checked = false;
                chkSearchActionDetailName.Checked = false;
                chkSearchActionDetailDesc.Checked = false;
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

        private void chkDispActionDetailName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvActionDetail, chkDispActionDetailName, "ActionDetailName");
        }

        private void chkDispActionDetailDesc_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvActionDetail, chkDispActionDetailDesc, "ActionDetailDesc");
        }

        private void chkDispActionDetailID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvActionDetail, chkDispActionDetailID, "ActionDetailID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispActionDetailID.Checked = true;
                chkDispActionDetailName.Checked = true;
                chkDispActionDetailDesc.Checked = true;
            }
            else
            {
                //chkDispActionDetailID.Checked = false;
                chkDispActionDetailName.Checked = false;
                chkDispActionDetailDesc.Checked = false;
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
            searchEntity = new ActionDetail();

            //
            SearchResult<ActionDetail> searchResult = actionDetailManager.GetActionDetailListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetActionDetail.Tables["ActionDetail"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }
    }
}