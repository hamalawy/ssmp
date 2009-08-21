using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class UserRoleDao : AbstractNHibernateDao<UserRole, System.Int32>, IUserRoleDao
    {
        #region IUserRoleDao Members

        public SearchResult<UserRole> GetUserRoleListByParam(UserRole entity, SearchParam searchParam)
        {
            SearchResult<UserRole> searchResult = new SearchResult<UserRole>();

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

            searchResult.SearchList = criteria.List<UserRole>() as List<UserRole>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(UserRole entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(UserRole));

            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.UserRoleName != null)
                    {
                        if (entity.UserRoleDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Or(
                                        Restrictions.Like("UserRoleName", entity.UserRoleName, MatchMode.Anywhere),
                                        Restrictions.Like("UserRoleDesc", entity.UserRoleDesc, MatchMode.Anywhere))));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("UserRoleName", entity.UserRoleName, MatchMode.Anywhere)));
                        }
                    }
                    else
                    {
                        if (entity.UserRoleDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("UserRoleDesc", entity.UserRoleDesc, MatchMode.Anywhere)));
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
                    if (entity.UserRoleName != null)
                    {
                        if (entity.UserRoleDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("UserRoleName", entity.UserRoleName, MatchMode.Anywhere),
                                    Restrictions.Like("UserRoleDesc", entity.UserRoleDesc, MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Like("UserRoleName", entity.UserRoleName, MatchMode.Anywhere));
                        }
                    }
                    else
                    {
                        if (entity.UserRoleDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Like("UserRoleDesc", entity.UserRoleDesc, MatchMode.Anywhere));
                        }
                    }
                }
            }

            return criteria;
        }

        #endregion 
    }
}
