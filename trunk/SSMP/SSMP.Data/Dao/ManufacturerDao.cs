using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class ManufacturerDao : AbstractNHibernateDao<Manufacturer, System.Int32>, IManufacturerDao
    {
        #region IManufacturerDao Members

        public SearchResult<Manufacturer> GetManufacturerListByParam(Manufacturer entity, SearchParam searchParam)
        {
            SearchResult<Manufacturer> searchResult = new SearchResult<Manufacturer>();

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

            searchResult.SearchList = criteria.List<Manufacturer>() as List<Manufacturer>;

            //Criteria for query totalsize
            ICriteria criteriaSize = CreateCriteriaByParam(entity);

            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));
            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        private ICriteria CreateCriteriaByParam(Manufacturer entity)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(Manufacturer));

            if (entity != null)
            {
                /*
                if (entity.ID != 0)
                {
                    if (entity.ManufacturerName != null)
                    {
                        if (entity.ManufacturerDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Or(
                                        Restrictions.Like("ManufacturerName", entity.ManufacturerName, MatchMode.Anywhere),
                                        Restrictions.Like("ManufacturerDesc", entity.ManufacturerDesc, MatchMode.Anywhere))));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("ManufacturerName", entity.ManufacturerName, MatchMode.Anywhere)));
                        }
                    }
                    else
                    {
                        if (entity.ManufacturerDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Eq("ID", entity.ID),
                                    Restrictions.Like("ManufacturerDesc", entity.ManufacturerDesc, MatchMode.Anywhere)));
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
                    if (entity.ManufacturerName != null)
                    {
                        if (entity.ManufacturerDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Or(
                                    Restrictions.Like("ManufacturerName", entity.ManufacturerName, MatchMode.Anywhere),
                                    Restrictions.Like("ManufacturerDesc", entity.ManufacturerDesc, MatchMode.Anywhere)));
                        }
                        else
                        {
                            criteria.Add(
                                Restrictions.Like("ManufacturerName", entity.ManufacturerName, MatchMode.Anywhere));
                        }
                    }
                    else
                    {
                        if (entity.ManufacturerDesc != null)
                        {
                            criteria.Add(
                                Restrictions.Like("ManufacturerDesc", entity.ManufacturerDesc, MatchMode.Anywhere));
                        }
                    }
                }
                */
            }

            return criteria;
        }

        #endregion
    }
}
