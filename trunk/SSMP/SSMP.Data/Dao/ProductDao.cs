using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class ProductDao : AbstractNHibernateDao<Product, System.Int32>, IProductDao
    {
        #region IProductDao Members

        public SearchResult<Product> GetProductListByParam(Product entity, SearchParam searchParam)
        {
            SearchResult<Product> searchResult = new SearchResult<Product>();

            string sqlWhere = string.Empty;

            if (entity.SearchProductName != null)
            {
                sqlWhere = "manpn.prodname like '%" + entity.SearchProductName + "%' ";
            }
            if (entity.SearchManufacturerName != null)
            {
                if (string.IsNullOrEmpty(sqlWhere))
                {
                    sqlWhere += "manpn.manname like '%" + entity.SearchManufacturerName + "%' ";
                }
                else
                {
                    sqlWhere += "or manpn.manname like '%" + entity.SearchManufacturerName + "%' ";
                }
            }
            if (entity.SearchProviderName != null)
            {
                if (string.IsNullOrEmpty(sqlWhere))
                {
                    sqlWhere += "billpv.providername like '%" + entity.SearchProviderName + "%' ";
                }
                else
                {
                    sqlWhere += "or billpv.providername like '%" + entity.SearchProviderName + "%' ";
                }
            }

            if (string.IsNullOrEmpty(sqlWhere))
            {
                sqlWhere = "1 = 1";
            }

            string sqlSelect = "select p.ProductId,p.MfgDate,p.ExpDate,p.ProductNameId,p.PurchasePrice,p.SalePrice," +
                                "p.Discount,p.StatusId,p.BillPurchaseId,p.BillSaleId,p.UnitId,p.Description " +
                                //",manpn.prodname, manpn.manname,billpv.providername " + 
                                "from product as p " +
                                "join " + 
	                                "(select billpurchaseid, providername from billpurchase as b join provider as pv on b.providerid = pv.providerid) as billpv " + 
                                    "on p.billpurchaseid = billpv.billpurchaseid " + 
                                "join " + 
                                    "(select prodname, manname, productnameid from manufacturer as man join productname as pn on man.manid = pn.manid) as manpn " + 
                                    "on p.productnameid = manpn.productnameid " +
                                "where " + sqlWhere;

            string sqlSelectCount = "select count(p.ProductId) " +
                                "from product as p " +
                                "join " +
                                    "(select billpurchaseid, providername from billpurchase as b join provider as pv on b.providerid = pv.providerid) as billpv " +
                                    "on p.billpurchaseid = billpv.billpurchaseid " +
                                "join " +
                                    "(select prodname, manname, productnameid from manufacturer as man join productname as pn on man.manid = pn.manid) as manpn " +
                                    "on p.productnameid = manpn.productnameid " +
                                "where " + sqlWhere;

            List<Object> result = NHibernateSession.CreateSQLQuery(sqlSelect)
                .SetFirstResult(searchParam.Start)
                .SetMaxResults(searchParam.Limit)
                .List<Object>() as List<Object>;

            List<Product> searchList = new List<Product>();

            for (int i = 0; i < result.Count; i++)
            {
                Array obj = (Array)result[i];
                Product tempPd = new Product((long)obj.GetValue(0));
                tempPd.MfgDate = (DateTime)obj.GetValue(1);
                tempPd.ExpDate = (DateTime)obj.GetValue(2);
                tempPd.ProductNameId = (int)obj.GetValue(3);
                tempPd.PurchasePrice = obj.GetValue(4) != null ? (string)obj.GetValue(4) : "";
                tempPd.SalePrice = obj.GetValue(5) != null ? (string)obj.GetValue(5) : "";
                tempPd.Discount = obj.GetValue(6) != null ? (int)obj.GetValue(6) : 0;
                tempPd.StatusId = obj.GetValue(7) != null ? (int)obj.GetValue(7) : 0;
                tempPd.BillPurchaseId = obj.GetValue(8) != null ? (long)obj.GetValue(8) : 0;
                tempPd.BillSaleId = obj.GetValue(9) != null ? (long)obj.GetValue(9) : 0;
                tempPd.UnitId = obj.GetValue(10) != null ? (int)obj.GetValue(10) : 0;
                tempPd.Description = obj.GetValue(11) != null ? (string)obj.GetValue(11) : "";

                searchList.Add(tempPd);
            }

            //searchResult.SearchList = NHibernateSession.CreateSQLQuery(sqlSelect)
            //    .SetFirstResult(searchParam.Start)
            //    .SetMaxResults(searchParam.Limit)
            //    .List<Product>() as List<Product>;

            searchResult.SearchList = searchList;

            //Criteria for query totalsize
            searchResult.SearchSize = NHibernateSession.CreateSQLQuery(sqlSelectCount).UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(Product entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(Product));
            
            return criteria;
        }

        #endregion
    }
}

