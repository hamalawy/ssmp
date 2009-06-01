using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using SSMP.Data;
using SSMP.Core.Utils;
using SSMP.Core.DataInterfaces;

namespace SSMP.Data
{
    public abstract class AbstractNHibernateDao<T, IdT> : IDao<T, IdT>
    {
        private Type persitentType = typeof(T);

        /// <summary>
        /// Loads an instance of type TypeOfListItem from the DB based on its ID.
        /// </summary>
        public virtual T GetById(IdT id, bool shouldLock)
        {
            T entity;

            if (shouldLock)
            {
                entity = (T)NHibernateSession.Load(persitentType, id, LockMode.Upgrade);
            }
            else
            {
                entity = (T)NHibernateSession.Load(persitentType, id);
            }

            return entity;
        }

        /// <summary>
        /// Loads every instance of the requested type with no filtering.
        /// </summary>
        public List<T> GetAll()
        {
            return GetByCriteria();
        }

        /// <summary>
        /// Loads every instance of the requested type using the supplied <see cref="ICriterion" />.
        /// If no <see cref="ICriterion" /> is supplied, this behaves like <see cref="GetAll" />.
        /// </summary>
        public List<T> GetByCriteria(params ICriterion[] criterion)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(persitentType);

            foreach (ICriterion criterium in criterion)
            {
                criteria.Add(criterium);
            }

            return criteria.List<T>() as List<T>;
        }

        public List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(persitentType);
            Example example = Example.Create(exampleInstance);

            foreach (string propertyToExclude in propertiesToExclude)
            {
                example.ExcludeProperty(propertyToExclude);
            }

            criteria.Add(example);
            example.EnableLike(MatchMode.Anywhere);

            return criteria.List<T>() as List<T>;
        }

        /// <summary>
        /// Get list of instance and by start, limit
        /// VietLH2@fsoft.com.vn added on 23 Mar 2009
        /// </summary>
        public SearchResult<T> GetByExampleAndPaging(T exampleInstance, SearchParam searchParam)
        {
            SearchResult<T> searchResult = new SearchResult<T>();

            //Example object
            Example example = Example.Create(exampleInstance);
            example.EnableLike(MatchMode.Anywhere);

            //Criteria for query list
            ICriteria criteria = NHibernateSession.CreateCriteria(persitentType);

            criteria.Add(example);
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
            searchResult.SearchList = criteria.List<T>() as List<T>;

            //Criteria for query totalsize
            ICriteria criteriaSize = NHibernateSession.CreateCriteria(persitentType);

            criteriaSize.Add(example);
            criteriaSize.SetProjection(Projections.Count(DBConstants.ID));

            searchResult.SearchSize = criteriaSize.UniqueResult<System.Int32>();

            return searchResult;
        }

        /// <summary>
        /// Looks for a single instance using the example provided.
        /// </summary>
        /// <exception cref="NonUniqueResultException" />
        public T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude)
        {
            List<T> foundList = GetByExample(exampleInstance, propertiesToExclude);

            if (foundList.Count > 1)
            {
                throw new NonUniqueResultException(foundList.Count);
            }

            if (foundList.Count > 0)
            {
                return foundList[0];
            }
            else
            {
                return default(T);
            }
        }

        /// <summary>
        /// For entities that have assigned ID's, you must explicitly call Save to add a new one.
        /// See http://www.hibernate.org/hib_docs/reference/en/html/mapping.html#mapping-declaration-id-assigned.
        /// </summary>
        public T Save(T entity)
        {
            NHibernateSession.Save(entity);
            return entity;
        }

        /// <summary>
        /// For entities with automatatically generated IDs, such as identity, SaveOrUpdate may 
        /// be called when saving a new entity.  SaveOrUpdate can also be called to update any 
        /// entity, even if its ID is assigned.
        /// </summary>
        public T SaveOrUpdate(T entity)
        {
            NHibernateSession.SaveOrUpdate(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            NHibernateSession.Delete(entity);
        }

        /// <summary>
        /// Commits changes regardless of whether there's an open transaction or not
        /// </summary>
        public void CommitChanges()
        {
            if (NHibernateSessionManager.Instance.HasOpenTransaction())
            {
                NHibernateSessionManager.Instance.CommitTransaction();
            }
            else
            {
                // If there's no transaction, just flush the changes
                NHibernateSessionManager.Instance.GetSession().Flush();
            }
        }

        /// <summary>
        /// Exposes the ISession used within the DAO.
        /// VietLH2@fsoft.com.vn changed access from private to protected on 26, Mar 2009
        /// </summary>
        protected ISession NHibernateSession
        {
            get
            {
                return NHibernateSessionManager.Instance.GetSession();
            }
        }
    }
}
