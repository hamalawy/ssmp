using System;
using System.Collections.Generic;
using System.Text;
using SSMP.Core.Domain;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Utils;
using log4net;
using SSMP.Data.LogUtils;

namespace SSMP.Data.Manager
{
    public class ProviderManager : IManager<Provider, System.Int32>
    {
        private IProviderDao manufacturerDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(ProviderManager));

        public ProviderManager()
        {
            const string LOCATION = "ProviderManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            manufacturerDao = daoFactory.GetProviderDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        public Provider GetById(System.Int32 Id, bool shouldLock)
        {
            return manufacturerDao.GetById(Id, shouldLock);
        }

        public List<Provider> GetAll()
        {
            return manufacturerDao.GetAll();
        }

        public List<Provider> GetByExample(Provider exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Provider GetUniqueByExample(Provider exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Provider Save(Provider entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Provider SaveOrUpdate(Provider entity)
        {
            try
            {
                if (entity != null)
                {
                    manufacturerDao.SaveOrUpdate(entity);
                    manufacturerDao.CommitChanges();
                }
                else
                {
                    throw new Exception("Provider entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Delete(Provider entity)
        {
            try
            {
                if (entity != null)
                {
                    //entity.ProviderTitleIdLookup = null;
                    // entity.ProviderTitleId = null;
                    //manufacturerDao.CommitChanges();
                    entity.CountryIdLookup = null;
                    manufacturerDao.Delete(entity);
                    manufacturerDao.CommitChanges();
                }
                else
                {
                    throw new Exception("Provider entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsExist(Provider entity)
        {
            Provider userObj = manufacturerDao.GetById(entity.ID, false);

            if (userObj != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SearchResult<Provider> GetByExampleAndPaging(Provider exampleInstance, SearchParam searchParam)
        {
            SearchResult<Provider> searchResult;

            try
            {
                searchResult = manufacturerDao.GetByExampleAndPaging(exampleInstance, searchParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchResult;
        }

        public SearchResult<Provider> GetProviderListByParam(Provider entity, SearchParam searcParam)
        {
            SearchResult<Provider> searchResult = null;

            try
            {
                searchResult = manufacturerDao.GetProviderListByParam(entity, searcParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchResult;
        }
    }
}
