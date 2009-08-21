using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class UserStatusDao : AbstractNHibernateDao<UserStatus, System.Int32>, IUserStatusDao
    {
        #region IUserStatusDao Members

        public SearchResult<UserStatus> GetUserStatusListByParam(UserStatus entity, SearchParam searchParam)
        {
            SearchResult<UserStatus> searchResult = new SearchResult<UserStatus>();

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

            searchResult.SearchList = criteria.List<UserStatus>() as List<UserStatus>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(UserStatus entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(UserStatus));

            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.UserStatusName != null)
                    {
                        if (entity.UserStatusDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Or(
                                        Restrictions.Like("UserStatusName", entity.UserStatusName, MatchMode.Anywhere),
                                        Restrictions.Like("UserStatusDesc", entity.UserStatusDesc, MatchMode.Anywhere))));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("UserStatusName", entity.UserStatusName, MatchMode.Anywhere)));
                        }
                    }
                    else
                    {
                        if (entity.UserStatusDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("UserStatusDesc", entity.UserStatusDesc, MatchMode.Anywhere)));
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
                    if (entity.UserStatusName != null)
                    {
                        if (entity.UserStatusDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("UserStatusName", entity.UserStatusName, MatchMode.Anywhere),
                                    Restrictions.Like("UserStatusDesc", entity.UserStatusDesc, MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Like("UserStatusName", entity.UserStatusName, MatchMode.Anywhere));
                        }
                    }
                    else
                    {
                        if (entity.UserStatusDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Like("UserStatusDesc", entity.UserStatusDesc, MatchMode.Anywhere));
                        }
                    }
                }
            }

            return criteria;
        }

        #endregion
    }
}
