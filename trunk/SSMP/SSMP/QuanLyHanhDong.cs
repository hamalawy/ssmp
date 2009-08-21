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
    public partial class FrmAction : Form
    {
        //Manager object
        private ActionManager actionManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmAction));
        private Action searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetAction;
        private List<Int32> listPages;
        private bool isAdd;

        public FrmAction()
        {
            InitializeComponent();

            //
            actionManager = new ActionManager();
        }

        private void FrmAction_Load(object sender, EventArgs e)
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
            searchEntity = new Action();

            //
            SearchResult<Action> searchResult = actionManager.GetActionListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetAction.Tables["Action"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);

            //
            isAdd = true;
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of Action
            DataTable dataTableAction = new DataTable("Action");
            dataTableAction.Columns.Add("ActionId", typeof(int));
            dataTableAction.Columns.Add("ActionName", typeof(string));
            dataTableAction.Columns.Add("ActionDesc", typeof(string));

            //Create DataSet of Action
            dataSetAction = new DataSet();
            dataSetAction.Tables.Add(dataTableAction);

            //Config detail of column in grid view
            gvAction.DataSource = dataSetAction;
            gvAction.DataMember = "Action";
            gvAction.Columns["ActionId"].HeaderText = "Mã chức vụ";
            gvAction.Columns["ActionName"].HeaderText = "Tên chức vụ";
            gvAction.Columns["ActionDesc"].HeaderText = "Mô tả";
        }

        private void IList2DataTable(IList<Action> listAction, DataTable dataTableAction)
        {
            if (listAction != null)
            {
                dataTableAction.Clear();

                foreach (Action objAction in listAction)
                {
                    DataRow rowTemp = dataTableAction.NewRow();

                    rowTemp["ActionId"] = objAction.ID;
                    rowTemp["ActionName"] = objAction.ActionName;
                    rowTemp["ActionDesc"] = objAction.ActionDesc;

                    dataTableAction.Rows.Add(rowTemp);
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

            bindingNavigatorAction.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorAction.BindingSource.Position = position;
            bindingNavigatorAction.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số chức vụ: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Action entity = new Action();
                entity.ActionName = txtActionName.Text.Trim();
                entity.ActionDesc = txtActionDesc.Text.Trim();

                actionManager.SaveOrUpdate(entity);
                RefreshGridView(new Action());
                ResetForm();
                SetFormReadOnly(true);
            }
            else
            {
                Action entity = new Action(Int32.Parse(txtActionID.Text));
                entity.ActionName = txtActionName.Text.Trim();
                entity.ActionDesc = txtActionDesc.Text.Trim();

                actionManager.SaveOrUpdate(entity);
                RefreshGridView(new Action());
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
            if (gvAction.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvAction.SelectedCells[0].RowIndex;
                int deleteActionId = (int)gvAction.Rows[selectedRowIndex].Cells["ActionId"].Value;
                string deleteActionName = (string)gvAction.Rows[selectedRowIndex].Cells["ActionName"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ [" + deleteActionName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    actionManager.Delete(new Action(deleteActionId));

                    //Refresh grid view after delete successfully
                    RefreshGridView(new Action());
                }
            }
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new Action());
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorAction.BindingSource.Position);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorAction.BindingSource.Position);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorAction.BindingSource.Position);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorAction.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorAction.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorAction.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<Action> searchResult = actionManager.GetActionListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetAction.Tables["Action"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtActionName.ReadOnly = state;
            txtActionDesc.ReadOnly = state;
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
                txtActionID.ResetText();
            }

            txtActionName.ResetText();
            txtActionDesc.ResetText();
        }

        private void RefreshGridView(Action searchEntity)
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
            SearchResult<Action> searchResult = actionManager.GetActionListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetAction.Tables["Action"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvAction_SelectionChanged(object sender, EventArgs e)
        {
            if (gvAction.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvAction.SelectedCells[0].RowIndex;
                BindingActionToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingActionToForm(int rowIndex)
        {
            txtActionID.Text = (int)gvAction.Rows[rowIndex].Cells["ActionId"].Value + "";
            txtActionName.Text = (string)gvAction.Rows[rowIndex].Cells["ActionName"].Value;
            txtActionDesc.Text = (string)gvAction.Rows[rowIndex].Cells["ActionDesc"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearch.Text.Trim();

            if (chkSearchActionID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new Action(idSearch);
                }
                else
                {
                    searchEntity = new Action(-1);
                }
            }
            else
            {
                searchEntity = new Action();
            }

            if (chkSearchActionName.Checked)
            {
                searchEntity.ActionName = strSearch;
            }

            if (chkSearchActionDesc.Checked)
            {
                searchEntity.ActionDesc = strSearch;
            }

            RefreshGridView(searchEntity);
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchActionID.Checked = true;
                chkSearchActionName.Checked = true;
                chkSearchActionDesc.Checked = true;
            }
            else
            {
                chkSearchActionID.Checked = false;
                chkSearchActionName.Checked = false;
                chkSearchActionDesc.Checked = false;
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

        private void chkDispActionName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvAction, chkDispActionName, "ActionName");
        }

        private void chkDispActionDesc_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvAction, chkDispActionDesc, "ActionDesc");
        }

        private void chkDispActionID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvAction, chkDispActionID, "ActionID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispActionID.Checked = true;
                chkDispActionName.Checked = true;
                chkDispActionDesc.Checked = true;
            }
            else
            {
                //chkDispActionID.Checked = false;
                chkDispActionName.Checked = false;
                chkDispActionDesc.Checked = false;
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