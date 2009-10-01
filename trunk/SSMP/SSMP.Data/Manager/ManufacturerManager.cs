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
    public class ManufacturerManager : IManager<Manufacturer, System.Int32>
    {
        private IManufacturerDao manufacturerDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(ManufacturerManager));

        public ManufacturerManager()
        {
            const string LOCATION = "ManufacturerManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            manufacturerDao = daoFactory.GetManufacturerDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        public Manufacturer GetById(System.Int32 Id, bool shouldLock)
        {
            return manufacturerDao.GetById(Id, shouldLock);
        }

        public List<Manufacturer> GetAll()
        {
            return manufacturerDao.GetAll();
        }

        public List<Manufacturer> GetByExample(Manufacturer exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Manufacturer GetUniqueByExample(Manufacturer exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Manufacturer Save(Manufacturer entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Manufacturer SaveOrUpdate(Manufacturer entity)
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
                    throw new Exception("Manufacturer entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Delete(Manufacturer entity)
        {
            try
            {
                if (entity != null)
                {
                    //entity.ManufacturerTitleIdLookup = null;
                    // entity.ManufacturerTitleId = null;
                    //manufacturerDao.CommitChanges();
                    entity.CountryIdLookup = null;
                    manufacturerDao.Delete(entity);
                    manufacturerDao.CommitChanges();
                }
                else
                {
                    throw new Exception("Manufacturer entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsExist(Manufacturer entity)
        {
            Manufacturer userObj = manufacturerDao.GetById(entity.ID, false);

            if (userObj != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SearchResult<Manufacturer> GetByExampleAndPaging(Manufacturer exampleInstance, SearchParam searchParam)
        {
            SearchResult<Manufacturer> searchResult;

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

        public SearchResult<Manufacturer> GetManufacturerListByParam(Manufacturer entity, SearchParam searcParam)
        {
            SearchResult<Manufacturer> searchResult = null;
            
            try
            {
                searchResult = manufacturerDao.GetManufacturerListByParam(entity, searcParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return searchResult;
        }
    }
}
