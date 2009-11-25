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
                if (obj.GetValue(4) != null)
                {
                    tempPd.PurchasePrice = (int)obj.GetValue(4);
                }
                if (obj.GetValue(5) != null)
                {
                    tempPd.SalePrice = (int)obj.GetValue(5);
                }
                //tempPd.PurchasePrice = obj.GetValue(4) != null ? (int)obj.GetValue(4) : 0;
                //tempPd.SalePrice = obj.GetValue(5) != null ? (int)obj.GetValue(5): 0;
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

            if (entity != null)
            {
                if (entity.ProductNameId.HasValue && entity.ProductNameId != 0) 
                {
                    criteria.Add(Restrictions.Eq("ProductNameId", entity.ProductNameId));
                }

                if (entity.SearchCategoryID.HasValue && entity.SearchCategoryID != 0)
                {
                    criteria
                        .CreateAlias("ProductNameIdLookup", "ProductName")
                        .Add(Restrictions.Eq("ProductName.CategoryId", entity.SearchCategoryID));
                }

                if (entity.UnitId != 0)
                {
                    criteria.Add(Restrictions.Eq("UnitId", entity.UnitId));
                }

                if (entity.SearchCountryID.HasValue && entity.SearchCountryID != 0)
                {
                    if (criteria.GetCriteriaByPath("ProductNameIdLookup") == null)
                    {
                        criteria.CreateAlias("ProductNameIdLookup", "ProductName");
                    }
                    criteria
                        .CreateAlias("ProductName.ManIdLookup", "Manufaturer")                                              
                        .Add(Restrictions.Eq("Manufaturer.CountryId", entity.SearchCountryID));
                }

                if (entity.SearchManufacturerID.HasValue && entity.SearchManufacturerID != 0)
                {
                    if (criteria.GetCriteriaByPath("ProductNameIdLookup") == null)
                    {
                        criteria.CreateAlias("ProductNameIdLookup", "ProductName");
                    }
                    criteria
                        .Add(Restrictions.Eq("ProductName.ManId", entity.SearchManufacturerID));
                }

                if (entity.StatusId != 0)
                {
                    criteria
                        .Add(Restrictions.Eq("StatusId", entity.StatusId));
                }

                if (entity.MfgDateFrom != null && entity.MfgDateTo != null)
                {
                    criteria.Add(Restrictions.Between("MfgDate", entity.MfgDateFrom, entity.MfgDateTo));
                }

                if (entity.ExpDateFrom != null && entity.ExpDateTo != null)
                {
                    criteria.Add(Restrictions.Between("ExpDate", entity.ExpDateFrom, entity.ExpDateTo));
                }

                switch (entity.PurchasePriceCompare)
                {
                    case DBConstants.DieuKienTimKiemValue.Bang:
                        criteria.Add(Restrictions.Eq("PurchasePrice", entity.PurchasePriceFrom));
                        break;
                    case DBConstants.DieuKienTimKiemValue.LonHonHoacBang:
                        criteria.Add(Restrictions.Ge("PurchasePrice", entity.PurchasePriceFrom));
                        break;
                    case DBConstants.DieuKienTimKiemValue.NhoHonHoacBang:
                        criteria.Add(Restrictions.Le("PurchasePrice", entity.PurchasePriceFrom));
                        break;
                    case DBConstants.DieuKienTimKiemValue.TrongKhoang:
                        criteria.Add(Restrictions.Between("PurchasePrice", entity.PurchasePriceFrom, entity.PurchasePriceTo));
                        break;
                }

                switch (entity.SalePriceCompare)
                {
                    case DBConstants.DieuKienTimKiemValue.Bang:
                        criteria.Add(Restrictions.Eq("SalePrice", entity.SalePriceFrom));
                        break;
                    case DBConstants.DieuKienTimKiemValue.LonHonHoacBang:
                        criteria.Add(Restrictions.Eq("SalePrice", entity.SalePriceFrom));
                        break;
                    case DBConstants.DieuKienTimKiemValue.NhoHonHoacBang:
                        criteria.Add(Restrictions.Eq("SalePrice", entity.SalePriceFrom));
                        break;
                    case DBConstants.DieuKienTimKiemValue.TrongKhoang:
                        criteria.Add(Restrictions.Between("SalePrice", entity.SalePriceFrom, entity.SalePriceTo));
                        break;
                }

                switch (entity.DiscountCompare)
                {
                    case DBConstants.DieuKienTimKiemValue.Bang:
                        criteria.Add(Restrictions.Eq("Discount", entity.DiscountFrom));
                        break;
                    case DBConstants.DieuKienTimKiemValue.LonHonHoacBang:
                        criteria.Add(Restrictions.Eq("Discount", entity.DiscountFrom));
                        break;
                    case DBConstants.DieuKienTimKiemValue.NhoHonHoacBang:
                        criteria.Add(Restrictions.Eq("Discount", entity.DiscountFrom));
                        break;
                    case DBConstants.DieuKienTimKiemValue.TrongKhoang:
                        criteria.Add(Restrictions.Between("Discount", entity.DiscountFrom, entity.DiscountTo));
                        break;
                }
            }

            return criteria;
        }

        public SearchResult<Product> GetProductListByAdvanceParam(Product entity, SearchParam searchParam)
        {
            SearchResult<Product> searchResult = new SearchResult<Product>();

            //Criteria for query list
            ICriteria criteria = CreateCriteriaByParam(entity);
            criteria.SetFirstResult(searchParam.Start);
            criteria.SetMaxResults(searchParam.Limit);

            if (searchParam.SortDir.Equals(DBConstants.ASC))
            {
                criteria.AddOrder(Order.Asc(searchParam.SortBy));
            }
            else
            {
                criteria.AddOrder(Order.Desc(searchParam.SortBy));
            }

            searchResult.SearchList = criteria.List<Product>() as List<Product>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();
           
            return searchResult;
        }

        #endregion
    }
}

