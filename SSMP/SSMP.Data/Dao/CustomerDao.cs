using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class CustomerDao : AbstractNHibernateDao<Customer, System.Int32>, ICustomerDao
    {
        #region ICustomerDao Members

        public SearchResult<Customer> GetCustomerListByParam(Customer entity, SearchParam searchParam)
        {
            SearchResult<Customer> searchResult = new SearchResult<Customer>();

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

            searchResult.SearchList = criteria.List<Customer>() as List<Customer>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(Customer entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(Customer));

            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.CustomerName != null)
                    {
                        criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("CustomerName", entity.CustomerName, MatchMode.Anywhere)));
                    }
                    else
                    {
                        criteria.Add(
                                Restrictions.Eq("ID", entity.ID));
                    }

                }
                else
                {
                    if (entity.CustomerName != null)
                    {
                        criteria.Add(
                                Restrictions.Like("CustomerName", entity.CustomerName, MatchMode.Anywhere));
                    }
                }
            }

            return criteria;
        }

        #endregion
    }
}
