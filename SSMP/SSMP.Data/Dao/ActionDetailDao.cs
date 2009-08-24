using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class ActionDetailDao : AbstractNHibernateDao<ActionDetail, System.Int32>, IActionDetailDao
    {
        #region IActionDetailDao Members

        public SearchResult<ActionDetail> GetActionDetailListByParam(ActionDetail entity, SearchParam searchParam)
        {
            SearchResult<ActionDetail> searchResult = new SearchResult<ActionDetail>();

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

            searchResult.SearchList = criteria.List<ActionDetail>() as List<ActionDetail>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            //criteriaSize.SetProjection(Projections.Count("UserId"));
            //searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();
            searchResult.SearchSize = 100;

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(ActionDetail entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(ActionDetail));

            if (entity != null)
            {
                if (entity.UserIdLookup != null && entity.UserIdLookup.Username != null)
                {
                    if (entity.ActionIdLookup.ActionName != null)
                    {
                        if (entity.ActionDate != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("Username", entity.UserIdLookup.Username, MatchMode.Anywhere),
                                    Restrictions.Or(
                                        Restrictions.Like("ActionName", entity.ActionIdLookup.ActionName, MatchMode.Anywhere),
                                        Restrictions.Like("ActionDate", entity.ActionDate))));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("Username", entity.UserIdLookup.Username, MatchMode.Anywhere),
                                    Restrictions.Like("ActionName", entity.ActionIdLookup.ActionName, MatchMode.Anywhere)));
                        }
                    }
                    else
                    {
                        if (entity.ActionDate != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("Username", entity.UserIdLookup.Username, MatchMode.Anywhere),
                                    Restrictions.Like("ActionDate", entity.ActionDate.ToString(), MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Like("Username", entity.UserIdLookup.Username, MatchMode.Anywhere));
                        }
                    }

                }
                else
                {
                    if (entity.ActionIdLookup != null && entity.ActionIdLookup.ActionName != null)
                    {
                        if (entity.ActionDate != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("ActionName", entity.ActionIdLookup.ActionName, MatchMode.Anywhere),
                                    Restrictions.Like("ActionDate", entity.ActionDate.ToString(), MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Like("ActionName", entity.ActionIdLookup.ActionName, MatchMode.Anywhere));
                        }
                    }
                    else
                    {
                        if (entity.ActionDate != null && entity.ActionDate.CompareTo(DateTime.MinValue) > 0)
                        {
                            criteria.Add(
                                Restrictions.Eq("ActionDate", entity.ActionDate));
                        }
                    }
                }
            }

            return criteria;
        }

        #endregion

        #region IDao<ActionDetail,DomainObjectID> Members

        public ActionDetail GetById(ActionDetail.DomainObjectID id, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
