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
    public partial class FrmProductStatus : Form
    {
        //Manager object
        private ProductStatusManager productStatusManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmProductStatus));
        private ProductStatus searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetProductStatus;
        private List<Int32> listPages;
        private bool isAdd;

        public FrmProductStatus()
        {
            InitializeComponent();

            //
            productStatusManager = new ProductStatusManager();
        }

        private void FrmProductStatus_Load(object sender, EventArgs e)
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
            searchEntity = new ProductStatus();

            //
            SearchResult<ProductStatus> searchResult = productStatusManager.GetProductStatusListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetProductStatus.Tables["ProductStatus"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);

            //
            isAdd = true;
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of ProductStatus
            DataTable dataTableProductStatus = new DataTable("ProductStatus");
            dataTableProductStatus.Columns.Add("ProductStatusId", typeof(int));
            dataTableProductStatus.Columns.Add("ProductStatusName", typeof(string));
            dataTableProductStatus.Columns.Add("ProductStatusDesc", typeof(string));

            //Create DataSet of ProductStatus
            dataSetProductStatus = new DataSet();
            dataSetProductStatus.Tables.Add(dataTableProductStatus);

            //Config detail of column in grid view
            gvProductStatus.DataSource = dataSetProductStatus;
            gvProductStatus.DataMember = "ProductStatus";
            gvProductStatus.Columns["ProductStatusId"].HeaderText = "Mã trạng thái sản phẩm";
            gvProductStatus.Columns["ProductStatusName"].HeaderText = "Tên trạng thái sản phẩm";
            gvProductStatus.Columns["ProductStatusDesc"].HeaderText = "Mô tả";            
        }

        private void IList2DataTable(IList<ProductStatus> listProductStatus, DataTable dataTableProductStatus)
        {
            if (listProductStatus != null)
            {
                dataTableProductStatus.Clear();

                foreach (ProductStatus objProductStatus in listProductStatus)
                {
                    DataRow rowTemp = dataTableProductStatus.NewRow();

                    rowTemp["ProductStatusId"] = objProductStatus.ID;
                    rowTemp["ProductStatusName"] = objProductStatus.StatusName;
                    rowTemp["ProductStatusDesc"] = objProductStatus.Description;

                    dataTableProductStatus.Rows.Add(rowTemp);
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

            bindingNavigatorProductStatus.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorProductStatus.BindingSource.Position = position;
            bindingNavigatorProductStatus.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số trạng thái sản phẩm: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductStatusName.Text.Trim().Length == 0)
            {
                HoTro.baoLoi("Điền tên trạng thái");
                return;
            }
            if (isAdd)
            {
                ProductStatus entity = new ProductStatus();
                entity.StatusName = txtProductStatusName.Text.Trim();
                entity.Description = txtProductStatusDesc.Text.Trim();

                productStatusManager.SaveOrUpdate(entity);
                RefreshGridView(new ProductStatus());
                ResetForm();
                SetFormReadOnly(true);
            }
            else
            {
                ProductStatus entity = new ProductStatus(Int32.Parse(txtProductStatusID.Text));
                entity.StatusName = txtProductStatusName.Text.Trim();
                entity.Description = txtProductStatusDesc.Text.Trim();

                productStatusManager.SaveOrUpdate(entity);
                RefreshGridView(new ProductStatus());
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
            if (gvProductStatus.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvProductStatus.SelectedCells[0].RowIndex;
                int deleteProductStatusId = (int)gvProductStatus.Rows[selectedRowIndex].Cells["ProductStatusId"].Value;
                string deleteProductStatusName = (string)gvProductStatus.Rows[selectedRowIndex].Cells["ProductStatusName"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa trạng thái sản phẩm [" + deleteProductStatusName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productStatusManager.Delete(new ProductStatus(deleteProductStatusId));
                    
                    //Refresh grid view after delete successfully
                    RefreshGridView(new ProductStatus());
                }
            }
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new ProductStatus());
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProductStatus.BindingSource.Position);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProductStatus.BindingSource.Position);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProductStatus.BindingSource.Position);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProductStatus.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorProductStatus.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorProductStatus.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<ProductStatus> searchResult = productStatusManager.GetProductStatusListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetProductStatus.Tables["ProductStatus"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtProductStatusName.ReadOnly = state;
            txtProductStatusDesc.ReadOnly = state;
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
                txtProductStatusID.ResetText();
            }
            
            txtProductStatusName.ResetText();
            txtProductStatusDesc.ResetText();
        }

        private void RefreshGridView(ProductStatus searchEntity)
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
            SearchResult<ProductStatus> searchResult = productStatusManager.GetProductStatusListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetProductStatus.Tables["ProductStatus"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvProductStatus_SelectionChanged(object sender, EventArgs e)
        {
            if (gvProductStatus.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvProductStatus.SelectedCells[0].RowIndex;
                BindingProductStatusToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingProductStatusToForm(int rowIndex)
        {
            txtProductStatusID.Text = (int)gvProductStatus.Rows[rowIndex].Cells["ProductStatusId"].Value + "";
            txtProductStatusName.Text = (string)gvProductStatus.Rows[rowIndex].Cells["ProductStatusName"].Value;
            txtProductStatusDesc.Text = (string)gvProductStatus.Rows[rowIndex].Cells["ProductStatusDesc"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearch.Text.Trim();            

            if (chkSearchProductStatusID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new ProductStatus(idSearch);
                }
                else
                {
                    searchEntity = new ProductStatus(-1);
                }
            }
            else
            {
                searchEntity = new ProductStatus();
            }

            if (chkSearchProductStatusName.Checked)
            {
                searchEntity.StatusName = strSearch;
            }

            if (chkSearchProductStatusDesc.Checked)
            {
                searchEntity.Description = strSearch;   
            }

            RefreshGridView(searchEntity);
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchProductStatusID.Checked = true;
                chkSearchProductStatusName.Checked = true;
                chkSearchProductStatusDesc.Checked = true;
            }
            else
            {
                chkSearchProductStatusID.Checked = false;
                chkSearchProductStatusName.Checked = false;
                chkSearchProductStatusDesc.Checked = false;
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

        private void chkDispProductStatusName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvProductStatus, chkDispProductStatusName, "ProductStatusName");
        }

        private void chkDispProductStatusDesc_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvProductStatus, chkDispProductStatusDesc, "ProductStatusDesc");
        }

        private void chkDispProductStatusID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvProductStatus, chkDispProductStatusID, "ProductStatusID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispProductStatusID.Checked = true;
                chkDispProductStatusName.Checked = true;
                chkDispProductStatusDesc.Checked = true;
            }
            else
            {
                //chkDispProductStatusID.Checked = false;
                chkDispProductStatusName.Checked = false;
                chkDispProductStatusDesc.Checked = false;
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
            searchEntity = new ProductStatus();

            //
            SearchResult<ProductStatus> searchResult = productStatusManager.GetProductStatusListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetProductStatus.Tables["ProductStatus"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }
    }
}