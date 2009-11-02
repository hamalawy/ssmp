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
    public partial class FrmUnit : Form
    {
        //Manager object
        private UnitManager unitManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmUnit));
        private Unit searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetUnit;
        private List<Int32> listPages;
        private bool isAdd;

        public FrmUnit()
        {
            InitializeComponent();

            //
            unitManager = new UnitManager();
        }

        private void FrmUnit_Load(object sender, EventArgs e)
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
            searchEntity = new Unit();

            //
            SearchResult<Unit> searchResult = unitManager.GetUnitListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUnit.Tables["Unit"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);

            //
            isAdd = true;
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of Unit
            DataTable dataTableUnit = new DataTable("Unit");
            dataTableUnit.Columns.Add("UnitId", typeof(int));
            dataTableUnit.Columns.Add("UnitName", typeof(string));
            dataTableUnit.Columns.Add("UnitDesc", typeof(string));

            //Create DataSet of Unit
            dataSetUnit = new DataSet();
            dataSetUnit.Tables.Add(dataTableUnit);

            //Config detail of column in grid view
            gvUnit.DataSource = dataSetUnit;
            gvUnit.DataMember = "Unit";
            gvUnit.Columns["UnitId"].HeaderText = "Mã đơn vị";
            gvUnit.Columns["UnitName"].HeaderText = "Tên đơn vị";
            gvUnit.Columns["UnitDesc"].HeaderText = "Mô tả";
        }

        private void IList2DataTable(IList<Unit> listUnit, DataTable dataTableUnit)
        {
            if (listUnit != null)
            {
                dataTableUnit.Clear();

                foreach (Unit objUnit in listUnit)
                {
                    DataRow rowTemp = dataTableUnit.NewRow();

                    rowTemp["UnitId"] = objUnit.ID;
                    rowTemp["UnitName"] = objUnit.UnitName;
                    rowTemp["UnitDesc"] = objUnit.UnitDesc;

                    dataTableUnit.Rows.Add(rowTemp);
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

            bindingNavigatorUnit.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorUnit.BindingSource.Position = position;
            bindingNavigatorUnit.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số đơn vị: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUnitName.Text.Trim().Length == 0)
            {
                HoTro.baoLoi("Điền tên đơn vị");
                return;
            }
            if (isAdd)
            {
                Unit entity = new Unit();
                entity.UnitName = txtUnitName.Text.Trim();
                entity.UnitDesc = txtUnitDesc.Text.Trim();

                unitManager.SaveOrUpdate(entity);
                RefreshGridView(new Unit());
                ResetForm();
                SetFormReadOnly(true);
            }
            else
            {
                Unit entity = new Unit(Int32.Parse(txtUnitID.Text));
                entity.UnitName = txtUnitName.Text.Trim();
                entity.UnitDesc = txtUnitDesc.Text.Trim();

                unitManager.SaveOrUpdate(entity);
                RefreshGridView(new Unit());
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
            if (gvUnit.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvUnit.SelectedCells[0].RowIndex;
                int deleteUnitId = (int)gvUnit.Rows[selectedRowIndex].Cells["UnitId"].Value;
                string deleteUnitName = (string)gvUnit.Rows[selectedRowIndex].Cells["UnitName"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn vị [" + deleteUnitName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    unitManager.Delete(new Unit(deleteUnitId));

                    //Refresh grid view after delete successfully
                    RefreshGridView(new Unit());
                }
            }
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new Unit());
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUnit.BindingSource.Position);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUnit.BindingSource.Position);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUnit.BindingSource.Position);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUnit.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorUnit.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorUnit.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<Unit> searchResult = unitManager.GetUnitListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUnit.Tables["Unit"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtUnitName.ReadOnly = state;
            txtUnitDesc.ReadOnly = state;
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
                txtUnitID.ResetText();
            }

            txtUnitName.ResetText();
            txtUnitDesc.ResetText();
        }

        private void RefreshGridView(Unit searchEntity)
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
            SearchResult<Unit> searchResult = unitManager.GetUnitListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetUnit.Tables["Unit"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvUnit_SelectionChanged(object sender, EventArgs e)
        {
            if (gvUnit.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvUnit.SelectedCells[0].RowIndex;
                BindingUnitToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingUnitToForm(int rowIndex)
        {
            txtUnitID.Text = (int)gvUnit.Rows[rowIndex].Cells["UnitId"].Value + "";
            txtUnitName.Text = (string)gvUnit.Rows[rowIndex].Cells["UnitName"].Value;
            txtUnitDesc.Text = (string)gvUnit.Rows[rowIndex].Cells["UnitDesc"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearch.Text.Trim();

            if (chkSearchUnitID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new Unit(idSearch);
                }
                else
                {
                    searchEntity = new Unit(-1);
                }
            }
            else
            {
                searchEntity = new Unit();
            }

            if (chkSearchUnitName.Checked)
            {
                searchEntity.UnitName = strSearch;
            }

            if (chkSearchUnitDesc.Checked)
            {
                searchEntity.UnitDesc = strSearch;
            }

            RefreshGridView(searchEntity);
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchUnitID.Checked = true;
                chkSearchUnitName.Checked = true;
                chkSearchUnitDesc.Checked = true;
            }
            else
            {
                chkSearchUnitID.Checked = false;
                chkSearchUnitName.Checked = false;
                chkSearchUnitDesc.Checked = false;
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

        private void chkDispUnitName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUnit, chkDispUnitName, "UnitName");
        }

        private void chkDispUnitDesc_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUnit, chkDispUnitDesc, "UnitDesc");
        }

        private void chkDispUnitID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvUnit, chkDispUnitID, "UnitID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispUnitID.Checked = true;
                chkDispUnitName.Checked = true;
                chkDispUnitDesc.Checked = true;
            }
            else
            {
                //chkDispUnitID.Checked = false;
                chkDispUnitName.Checked = false;
                chkDispUnitDesc.Checked = false;
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