using System;
using System.Collections.Generic;
using System.Text;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using log4net;
using SSMP.Data.LogUtils;
using SSMP.Data.Dao;
using SSMP.Core.DataInterfaces;

namespace SSMP.Data.Manager
{
    public class UnitManager : IManager<Unit, System.Int32>
    {
        private IUnitDao unitDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(UnitManager));

        public UnitManager()
        {
            const string LOCATION = "UnitManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            unitDao = daoFactory.GetUnitDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<Unit,int> Members

        public Unit GetById(int id, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<Unit> GetAll()
        {
            return unitDao.GetAll();
        }

        public List<Unit> GetByExample(Unit exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Unit GetUniqueByExample(Unit exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Unit Save(Unit entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Unit SaveOrUpdate(Unit entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.ID == 0)
                    {
                        unitDao.SaveOrUpdate(entity);
                    }
                    else
                    {
                        Unit existEntity = unitDao.GetById(entity.ID, false);
                        existEntity.UnitName = entity.UnitName;
                        existEntity.UnitDesc = entity.UnitDesc;
                    }

                    unitDao.CommitChanges();
                }
                else
                {
                    throw new Exception("User role entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Delete(Unit entity)
        {
            try
            {
                if (entity != null)
                {
                    Unit existEntity = unitDao.GetById(entity.ID, false);

                    unitDao.Delete(existEntity);
                    unitDao.CommitChanges();
                }
                else
                {
                    throw new Exception("User entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SearchResult<Unit> GetByExampleAndPaging(Unit exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<Unit> GetUnitListByParam(Unit entity, SearchParam searchParam)
        {
            SearchResult<Unit> searchResult;

            try
            {
                searchResult = unitDao.GetUnitListByParam(entity, searchParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchResult;
        }

        #endregion
    }
}
