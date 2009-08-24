using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class ProductStatusDao : AbstractNHibernateDao<ProductStatus, System.Int32>, IProductStatusDao
    {
        #region IProductStatusDao Members

        public SearchResult<ProductStatus> GetProductStatusListByParam(ProductStatus entity, SearchParam searchParam)
        {
            SearchResult<ProductStatus> searchResult = new SearchResult<ProductStatus>();

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

            searchResult.SearchList = criteria.List<ProductStatus>() as List<ProductStatus>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(ProductStatus entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(ProductStatus));

            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.StatusName != null)
                    {
                        if (entity.Description != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Or(
                                        Restrictions.Like("StatusName", entity.StatusName, MatchMode.Anywhere),
                                        Restrictions.Like("Description", entity.Description, MatchMode.Anywhere))));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("StatusName", entity.StatusName, MatchMode.Anywhere)));
                        }
                    }
                    else
                    {
                        if (entity.Description != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("Description", entity.Description, MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Eq("ID", entity.ID));
                        }
                    }

                }
                else
                {
                    if (entity.StatusName != null)
                    {
                        if (entity.Description != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("StatusName", entity.StatusName, MatchMode.Anywhere),
                                    Restrictions.Like("Description", entity.Description, MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Like("StatusName", entity.StatusName, MatchMode.Anywhere));
                        }
                    }
                    else
                    {
                        if (entity.Description != null)
                        {
                            criteria.Add(
                                Restrictions.Like("Description", entity.Description, MatchMode.Anywhere));
                        }
                    }
                }
            }

            return criteria;
        }

        #endregion
    }
}
