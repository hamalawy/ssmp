using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class CategoryDao : AbstractNHibernateDao<Category, System.Int32>, ICategoryDao
    {
        #region ICategoryDao Members

        public SearchResult<Category> GetCategoryListByParam(Category entity, SearchParam searchParam)
        {
            SearchResult<Category> searchResult = new SearchResult<Category>();

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

            searchResult.SearchList = criteria.List<Category>() as List<Category>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(Category entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(Category));

            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.CategoryName != null)
                    {
                        if (entity.CategoryDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Or(
                                        Restrictions.Like("CategoryName", entity.CategoryName, MatchMode.Anywhere),
                                        Restrictions.Like("CategoryDesc", entity.CategoryDesc, MatchMode.Anywhere))));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("CategoryName", entity.CategoryName, MatchMode.Anywhere)));
                        }
                    }
                    else
                    {
                        if (entity.CategoryDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("CategoryDesc", entity.CategoryDesc, MatchMode.Anywhere)));
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
                    if (entity.CategoryName != null)
                    {
                        if (entity.CategoryDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("CategoryName", entity.CategoryName, MatchMode.Anywhere),
                                    Restrictions.Like("CategoryDesc", entity.CategoryDesc, MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Like("CategoryName", entity.CategoryName, MatchMode.Anywhere));
                        }
                    }
                    else
                    {
                        if (entity.CategoryDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Like("CategoryDesc", entity.CategoryDesc, MatchMode.Anywhere));
                        }
                    }
                }
            }

            return criteria;
        }

        #endregion
    }
}
