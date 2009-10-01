using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class ProviderDao : AbstractNHibernateDao<Provider, System.Int32>, IProviderDao
    {
        #region IProviderDao Members

        public SearchResult<Provider> GetProviderListByParam(Provider entity, SearchParam searchParam)
        {
            SearchResult<Provider> searchResult = new SearchResult<Provider>();

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

            searchResult.SearchList = criteria.List<Provider>() as List<Provider>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(Provider entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(Provider));

            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.ProviderName != null)
                    {
                        criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("ProviderName", entity.ProviderName, MatchMode.Anywhere)));
                    }
                    else
                    {
                        criteria.Add(
                                Restrictions.Eq("ID", entity.ID));
                    }

                }
                else
                {
                    if (entity.ProviderName != null)
                    {
                        criteria.Add(
                                Restrictions.Like("ProviderName", entity.ProviderName, MatchMode.Anywhere));
                    }
                }
            }

            return criteria;
        }

        #endregion
    }
}
