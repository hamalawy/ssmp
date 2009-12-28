using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class MenuDao : AbstractNHibernateDao<Menu, System.Int32>, IMenuDao
    {       
        #region IMenuDao Members

        public SearchResult<Menu> GetMenuListByParam(Menu entity, SearchParam searchParam)
        {
            SearchResult<Menu> searchResult = new SearchResult<Menu>();

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

            searchResult.SearchList = criteria.List<Menu>() as List<Menu>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(Menu entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(Menu));

            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.MenuName != null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                Restrictions.Eq("ID", entity.ID),
                                Restrictions.Like("MenuName", entity.MenuName, MatchMode.Anywhere)));
                    }
                    else
                    {
                        criteria.Add(
                            Restrictions.Eq("ID", entity.ID));
                    }

                }
                else
                {
                    if (entity.MenuName != null)
                    {
                        criteria.Add(
                            Restrictions.Like("MenuName", entity.MenuName, MatchMode.Anywhere));
                    }
                }
            }

            return criteria;
        }

        #endregion
    }
}
