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
    public partial class FrmCategory : Form
    {
        //Manager object
        private CategoryManager categoryManager;

        //Constant variable
        private const string DEFAULT_SORT_BY = "ID";
        private const string DEFAULT_SORT_DIR = "ASC";
        private const int DEFAULT_START = 0;
        private const int DEFAULT_LIMIT = 10;

        //
        private static readonly ILog logger = LogManager.GetLogger(typeof(FrmCategory));
        private Category searchEntity;
        private SearchParam searchParam;
        private DataSet dataSetCategory;
        private List<Int32> listPages;
        private bool isAdd;

        public FrmCategory()
        {
            InitializeComponent();

            //
            categoryManager = new CategoryManager();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
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
            searchEntity = new Category();

            //
            SearchResult<Category> searchResult = categoryManager.GetCategoryListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetCategory.Tables["Category"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);

            //
            isAdd = true;
        }

        private void ContructGridViewColumn()
        {
            //Create DataTable of Category
            DataTable dataTableCategory = new DataTable("Category");
            dataTableCategory.Columns.Add("CategoryId", typeof(int));
            dataTableCategory.Columns.Add("CategoryName", typeof(string));
            dataTableCategory.Columns.Add("CategoryDesc", typeof(string));

            //Create DataSet of Category
            dataSetCategory = new DataSet();
            dataSetCategory.Tables.Add(dataTableCategory);

            //Config detail of column in grid view
            gvCategory.DataSource = dataSetCategory;
            gvCategory.DataMember = "Category";
            gvCategory.Columns["CategoryId"].HeaderText = "Mã loại sản phẩm";
            gvCategory.Columns["CategoryName"].HeaderText = "Tên loại sản phẩm";
            gvCategory.Columns["CategoryDesc"].HeaderText = "Mô tả";
        }

        private void IList2DataTable(IList<Category> listCategory, DataTable dataTableCategory)
        {
            if (listCategory != null)
            {
                dataTableCategory.Clear();

                foreach (Category objCategory in listCategory)
                {
                    DataRow rowTemp = dataTableCategory.NewRow();

                    rowTemp["CategoryId"] = objCategory.ID;
                    rowTemp["CategoryName"] = objCategory.CategoryName;
                    rowTemp["CategoryDesc"] = objCategory.CategoryDesc;

                    dataTableCategory.Rows.Add(rowTemp);
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

            bindingNavigatorCategory.BindingSource = new BindingSource(listPages, "");
            bindingNavigatorCategory.BindingSource.Position = position;
            bindingNavigatorCategory.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            //Set total of number user in bindingNavigator
            toolStripLblTotal.Text = "Tổng số loại sản phẩm: " + sizeOfList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Category entity = new Category();
                entity.CategoryName = txtCategoryName.Text.Trim();
                entity.CategoryDesc = txtCategoryDesc.Text.Trim();

                categoryManager.SaveOrUpdate(entity);
                RefreshGridView(new Category());
                ResetForm();
                SetFormReadOnly(true);
            }
            else
            {
                Category entity = new Category(Int32.Parse(txtCategoryID.Text));
                entity.CategoryName = txtCategoryName.Text.Trim();
                entity.CategoryDesc = txtCategoryDesc.Text.Trim();

                categoryManager.SaveOrUpdate(entity);
                RefreshGridView(new Category());
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
            if (gvCategory.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvCategory.SelectedCells[0].RowIndex;
                int deleteCategoryId = (int)gvCategory.Rows[selectedRowIndex].Cells["CategoryId"].Value;
                string deleteCategoryName = (string)gvCategory.Rows[selectedRowIndex].Cells["CategoryName"].Value;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm [" + deleteCategoryName + "] ?", Constants.INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    categoryManager.Delete(new Category(deleteCategoryId));

                    //Refresh grid view after delete successfully
                    RefreshGridView(new Category());
                }
            }
        }


        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            RefreshGridView(new Category());
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorCategory.BindingSource.Position);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorCategory.BindingSource.Position);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorCategory.BindingSource.Position);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorCategory.BindingSource.Position);
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            MoveItem(bindingNavigatorCategory.BindingSource.Position);
        }

        private void MoveItem(int position)
        {
            SearchParam searchParam = new SearchParam();
            searchParam.Start = bindingNavigatorCategory.BindingSource.Position * DEFAULT_LIMIT;
            searchParam.Limit = DEFAULT_LIMIT;
            searchParam.SortBy = DEFAULT_SORT_BY;
            searchParam.SortDir = DEFAULT_SORT_DIR;

            //this.BindingDataToForm(searchEntity, searchParam, position);

            SearchResult<Category> searchResult = categoryManager.GetCategoryListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetCategory.Tables["Category"]);

            //
            BindingDataToBindingNagivator(searchResult.SearchSize, position);
        }

        #endregion

        private void SetFormReadOnly(bool state)
        {
            txtCategoryName.ReadOnly = state;
            txtCategoryDesc.ReadOnly = state;
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
                txtCategoryID.ResetText();
            }

            txtCategoryName.ResetText();
            txtCategoryDesc.ResetText();
        }

        private void RefreshGridView(Category searchEntity)
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
            SearchResult<Category> searchResult = categoryManager.GetCategoryListByParam(searchEntity, searchParam);

            //Binding list userrole to gridview
            IList2DataTable(searchResult.SearchList, dataSetCategory.Tables["Category"]);

            //Binding list to navigator
            listPages = new List<Int32>();
            BindingDataToBindingNagivator(searchResult.SearchSize, 0);
        }

        private void gvCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (gvCategory.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvCategory.SelectedCells[0].RowIndex;
                BindingCategoryToForm(selectedRowIndex);

                SetFormReadOnly(true);
            }
        }

        private void BindingCategoryToForm(int rowIndex)
        {
            txtCategoryID.Text = (int)gvCategory.Rows[rowIndex].Cells["CategoryId"].Value + "";
            txtCategoryName.Text = (string)gvCategory.Rows[rowIndex].Cells["CategoryName"].Value;
            txtCategoryDesc.Text = (string)gvCategory.Rows[rowIndex].Cells["CategoryDesc"].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearch.Text.Trim();

            if (chkSearchCategoryID.Checked)
            {
                int idSearch = 0;

                if (Int32.TryParse(strSearch, out idSearch))
                {
                    searchEntity = new Category(idSearch);
                }
                else
                {
                    searchEntity = new Category(-1);
                }
            }
            else
            {
                searchEntity = new Category();
            }

            if (chkSearchCategoryName.Checked)
            {
                searchEntity.CategoryName = strSearch;
            }

            if (chkSearchCategoryDesc.Checked)
            {
                searchEntity.CategoryDesc = strSearch;
            }

            RefreshGridView(searchEntity);
        }

        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                chkSearchCategoryID.Checked = true;
                chkSearchCategoryName.Checked = true;
                chkSearchCategoryDesc.Checked = true;
            }
            else
            {
                chkSearchCategoryID.Checked = false;
                chkSearchCategoryName.Checked = false;
                chkSearchCategoryDesc.Checked = false;
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

        private void chkDispCategoryName_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvCategory, chkDispCategoryName, "CategoryName");
        }

        private void chkDispCategoryDesc_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvCategory, chkDispCategoryDesc, "CategoryDesc");
        }

        private void chkDispCategoryID_CheckedChanged(object sender, EventArgs e)
        {
            DisplayColumn(gvCategory, chkDispCategoryID, "CategoryID");
        }

        private void DisplayAllColumn(bool state)
        {
            if (state)
            {
                //chkDispCategoryID.Checked = true;
                chkDispCategoryName.Checked = true;
                chkDispCategoryDesc.Checked = true;
            }
            else
            {
                //chkDispCategoryID.Checked = false;
                chkDispCategoryName.Checked = false;
                chkDispCategoryDesc.Checked = false;
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