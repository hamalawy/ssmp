using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class ProductDao : AbstractNHibernateDao<Product, System.Int32>, IProductDao
    {
        #region IProductDao Members

        public SearchResult<Product> GetProductListByParam(Product entity, SearchParam searchParam)
        {
            SearchResult<Product> searchResult = new SearchResult<Product>();

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

            searchResult.SearchList = criteria.List<Product>() as List<Product>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(Product entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(Product));
            /*
            if (entity != null)
            {
                if (entity.ID != 0)
                {
                    if (entity.Productname == null && entity.FullName == null && entity.Email == null)
                    {
                        criteria.Add(Restrictions.Eq("ID", entity.ID));
                    }
                    else if (entity.Productname != null && entity.FullName == null && entity.Email == null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                Restrictions.Eq("ID", entity.ID),
                                Restrictions.Like("Productname", entity.Productname, MatchMode.Anywhere)));
                    }
                    else if (entity.Productname != null && entity.FullName != null && entity.Email == null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID)
                                    , Restrictions.Like("Productname", entity.Productname, MatchMode.Anywhere))
                                        , Restrictions.Like("FullName", entity.FullName, MatchMode.Anywhere)));
                    }
                    else if (entity.Productname != null && entity.FullName != null && entity.Email != null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                Restrictions.Or(
                                    Restrictions.Or(
                                        Restrictions.Eq("ID", entity.ID)
                                        , Restrictions.Like("Productname", entity.Productname, MatchMode.Anywhere))
                                            , Restrictions.Like("FullName", entity.FullName, MatchMode.Anywhere))
                                                , Restrictions.Like("Email", entity.Email, MatchMode.Anywhere)));
                    }
                    else if (entity.Productname == null && entity.FullName != null && entity.Email == null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                Restrictions.Eq("ID", entity.ID)
                                    , Restrictions.Like("FullName", entity.FullName, MatchMode.Anywhere)));
                    }
                    else if (entity.Productname == null && entity.FullName != null && entity.Email != null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID)
                                        , Restrictions.Like("FullName", entity.FullName, MatchMode.Anywhere))
                                            , Restrictions.Like("Email", entity.Email, MatchMode.Anywhere)));
                    }
                    else if (entity.Productname == null && entity.FullName == null && entity.Email != null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                Restrictions.Eq("ID", entity.ID)
                                , Restrictions.Like("Email", entity.Email, MatchMode.Anywhere)));
                    }
                }
                else
                {
                    if (entity.Productname != null && entity.FullName == null && entity.Email == null)
                    {
                        criteria.Add(
                            Restrictions.Like("Productname", entity.Productname, MatchMode.Anywhere));
                    }
                    else if (entity.Productname != null && entity.FullName != null && entity.Email == null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                 Restrictions.Like("Productname", entity.Productname, MatchMode.Anywhere)
                                 , Restrictions.Like("FullName", entity.FullName, MatchMode.Anywhere)));
                    }
                    else if (entity.Productname != null && entity.FullName != null && entity.Email != null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                Restrictions.Or(
                                    Restrictions.Like("Productname", entity.Productname, MatchMode.Anywhere)
                                        , Restrictions.Like("FullName", entity.FullName, MatchMode.Anywhere))
                                            , Restrictions.Like("Email", entity.Email, MatchMode.Anywhere)));
                    }
                    else if (entity.Productname == null && entity.FullName != null && entity.Email == null)
                    {
                        criteria.Add(
                            Restrictions.Like("FullName", entity.FullName, MatchMode.Anywhere));
                    }
                    else if (entity.Productname == null && entity.FullName != null && entity.Email != null)
                    {
                        criteria.Add(
                            Restrictions.Or(
                                   Restrictions.Like("FullName", entity.FullName, MatchMode.Anywhere)
                                    , Restrictions.Like("Email", entity.Email, MatchMode.Anywhere)));
                    }
                    else if (entity.Productname == null && entity.FullName == null && entity.Email != null)
                    {
                        criteria.Add(
                            Restrictions.Like("Email", entity.Email, MatchMode.Anywhere));
                    }
                }
            } */

            return criteria;
        }

        #endregion
    }
}

