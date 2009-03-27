using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class UserDao : AbstractNHibernateDao<User, System.Int32>, IUserDao
    {
        #region IUserDao Members

        public SearchResult<User> GetUserListByParam(User entity, SearchParam searchParam)
        {
            SearchResult<User> searchResult = new SearchResult<User>();

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

            searchResult.SearchList = criteria.List<User>() as List<User>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);
            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(User entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(User));

            if (entity != null)
            {
                if (entity.Username != null)
                {
                    criteria.Add(Restrictions.Like("Username", entity.Username, MatchMode.Anywhere));
                }
            }

            return criteria;
        }

        #endregion
    }
}
