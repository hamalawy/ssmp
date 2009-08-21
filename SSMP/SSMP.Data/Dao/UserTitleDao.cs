using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class UserTitleDao : AbstractNHibernateDao<UserTitle, System.Int32>, IUserTitleDao
    {
        #region IUserTitleDao Members

        public SearchResult<UserTitle> GetUserTitleListByParam(UserTitle entity, SearchParam searchParam)
        {
            SearchResult<UserTitle> searchResult = new SearchResult<UserTitle>();

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

            searchResult.SearchList = criteria.List<UserTitle>() as List<UserTitle>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(UserTitle entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(UserTitle));

            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.UserTitleName != null)
                    {
                        if (entity.UserTitleDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Or(
                                        Restrictions.Like("UserTitleName", entity.UserTitleName, MatchMode.Anywhere),
                                        Restrictions.Like("UserTitleDesc", entity.UserTitleDesc, MatchMode.Anywhere))));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("UserTitleName", entity.UserTitleName, MatchMode.Anywhere)));
                        }
                    }
                    else
                    {
                        if (entity.UserTitleDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("UserTitleDesc", entity.UserTitleDesc, MatchMode.Anywhere)));
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
                    if (entity.UserTitleName != null)
                    {
                        if (entity.UserTitleDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("UserTitleName", entity.UserTitleName, MatchMode.Anywhere),
                                    Restrictions.Like("UserTitleDesc", entity.UserTitleDesc, MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Like("UserTitleName", entity.UserTitleName, MatchMode.Anywhere));
                        }
                    }
                    else
                    {
                        if (entity.UserTitleDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Like("UserTitleDesc", entity.UserTitleDesc, MatchMode.Anywhere));
                        }
                    }
                }
            }

            return criteria;
        }

        #endregion
    }
}
