using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class ActionDao : AbstractNHibernateDao<Action, System.Int32>, IActionDao
    {       
        #region IActionDao Members

        public SearchResult<Action> GetActionListByParam(Action entity, SearchParam searchParam)
        {
            SearchResult<Action> searchResult = new SearchResult<Action>();

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

            searchResult.SearchList = criteria.List<Action>() as List<Action>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(Action entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(Action));

            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.ActionName != null)
                    {
                        if (entity.ActionDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Or(
                                        Restrictions.Like("ActionName", entity.ActionName, MatchMode.Anywhere),
                                        Restrictions.Like("ActionDesc", entity.ActionDesc, MatchMode.Anywhere))));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("ActionName", entity.ActionName, MatchMode.Anywhere)));
                        }
                    }
                    else
                    {
                        if (entity.ActionDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("ActionDesc", entity.ActionDesc, MatchMode.Anywhere)));
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
                    if (entity.ActionName != null)
                    {
                        if (entity.ActionDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("ActionName", entity.ActionName, MatchMode.Anywhere),
                                    Restrictions.Like("ActionDesc", entity.ActionDesc, MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Like("ActionName", entity.ActionName, MatchMode.Anywhere));
                        }
                    }
                    else
                    {
                        if (entity.ActionDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Like("ActionDesc", entity.ActionDesc, MatchMode.Anywhere));
                        }
                    }
                }
            }

            return criteria;
        }

        #endregion
    }
}
