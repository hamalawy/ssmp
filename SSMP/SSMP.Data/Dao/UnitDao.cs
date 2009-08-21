using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class UnitDao : AbstractNHibernateDao<Unit, System.Int32>, IUnitDao
    {
        #region IUnitDao Members

        public SearchResult<Unit> GetUnitListByParam(Unit entity, SearchParam searchParam)
        {
            SearchResult<Unit> searchResult = new SearchResult<Unit>();

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

            searchResult.SearchList = criteria.List<Unit>() as List<Unit>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(Unit entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(Unit));

            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.UnitName != null)
                    {
                        if (entity.UnitDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Or(
                                        Restrictions.Like("UnitName", entity.UnitName, MatchMode.Anywhere),
                                        Restrictions.Like("UnitDesc", entity.UnitDesc, MatchMode.Anywhere))));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("UnitName", entity.UnitName, MatchMode.Anywhere)));
                        }
                    }
                    else
                    {
                        if (entity.UnitDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("UnitDesc", entity.UnitDesc, MatchMode.Anywhere)));
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
                    if (entity.UnitName != null)
                    {
                        if (entity.UnitDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("UnitName", entity.UnitName, MatchMode.Anywhere),
                                    Restrictions.Like("UnitDesc", entity.UnitDesc, MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Like("UnitName", entity.UnitName, MatchMode.Anywhere));
                        }
                    }
                    else
                    {
                        if (entity.UnitDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Like("UnitDesc", entity.UnitDesc, MatchMode.Anywhere));
                        }
                    }
                }
            }

            return criteria;
        }

        #endregion
    }
}
