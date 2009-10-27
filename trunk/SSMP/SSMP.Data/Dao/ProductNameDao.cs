using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class ProductNameDao : AbstractNHibernateDao<ProductName, System.Int32>, IProductNameDao
    {
        #region IProductNameDao Members

        public SearchResult<ProductName> GetProductNameListByParam(ProductName entity, SearchParam searchParam)
        {
            SearchResult<ProductName> searchResult = new SearchResult<ProductName>();

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

            searchResult.SearchList = criteria.List<ProductName>() as List<ProductName>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(ProductName entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(ProductName));
            
            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.ProdName == null)
                    {
                        criteria.Add(Restrictions.Eq("ID", entity.ID));
                    }
                    else if (entity.ProdName != null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                Restrictions.Eq("ID", entity.ID),
                                Restrictions.Like("ProdName", entity.ProdName, MatchMode.Anywhere)));
                    }                    
                }
                else
                {
                    if (entity.ProdName != null)
                    {
                        criteria.Add(
                            Restrictions.Like("ProdName", entity.ProdName, MatchMode.Anywhere));
                    }                    
                }
            } 

            return criteria;
        }

        #endregion
    }
}

