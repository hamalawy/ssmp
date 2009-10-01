using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using log4net;
using SSMP.Data.LogUtils;
using SSMP.Data.Dao;
using SSMP.Core.DataInterfaces;

namespace SSMP.Data.Manager
{
    public class CountryManager : IManager<Country, System.Int32>
    {
        private ICountryDao countryDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(CountryManager));

        public CountryManager()
        {
            const string LOCATION = "CountryManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            countryDao = daoFactory.GetCountryDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<Country,int> Members

        public Country GetById(int id, bool shouldLock)
        {
            return countryDao.GetById(id, shouldLock);        
        }

        public List<Country> GetAll()
        {
            return countryDao.GetAll();
        }

        public List<Country> GetByExample(Country exampleInstance, params string[] propertiesToExclude)
        {
            return countryDao.GetByExample(exampleInstance, propertiesToExclude);
        }

        public Country GetUniqueByExample(Country exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Country Save(Country entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Country SaveOrUpdate(Country entity)
        {
            try
            {
                if (entity != null)
                {
                    countryDao.SaveOrUpdate(entity);
                    countryDao.CommitChanges();
                }
                else
                {
                    throw new Exception("Country entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Delete(Country entity)
        {
            try
            {
                if (entity != null)
                {
                    countryDao.Delete(entity);
                    countryDao.CommitChanges();
                }
                else
                {
                    throw new Exception("Country entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SearchResult<Country> GetByExampleAndPaging(Country exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
