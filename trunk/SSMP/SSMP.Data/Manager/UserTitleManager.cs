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
    public class UserTitleManager : IManager<UserTitle, System.Int32> 
    {
        private IUserTitleDao userTitleDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(UserTitleManager));

        public UserTitleManager()
        {
            const string LOCATION = "UserTitleManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            userTitleDao = daoFactory.GetUserTitleDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<UserTitle,int> Members

        public UserTitle GetById(int id, bool shouldLock)
        {
            return userTitleDao.GetById(id, shouldLock);
        }

        public List<UserTitle> GetAll()
        {
            return userTitleDao.GetAll();
        }

        public List<UserTitle> GetByExample(UserTitle exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserTitle GetUniqueByExample(UserTitle exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserTitle Save(UserTitle entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserTitle SaveOrUpdate(UserTitle entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.ID == 0)
                    {
                        userTitleDao.SaveOrUpdate(entity);
                    }
                    else
                    {
                        UserTitle existEntity = userTitleDao.GetById(entity.ID, false);
                        existEntity.UserTitleName = entity.UserTitleName;
                        existEntity.UserTitleDesc = entity.UserTitleDesc;
                    }
                    
                    userTitleDao.CommitChanges();
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

        public void Delete(UserTitle entity)
        {
            try
            {
                if (entity != null)
                {
                    UserTitle existEntity = userTitleDao.GetById(entity.ID, false);

                    userTitleDao.Delete(existEntity);
                    userTitleDao.CommitChanges();
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

        public SearchResult<UserTitle> GetByExampleAndPaging(UserTitle exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<UserTitle> GetUserTitleListByParam(UserTitle entity, SearchParam searchParam)
        {
            SearchResult<UserTitle> searchResult;

            try
            {
                searchResult = userTitleDao.GetUserTitleListByParam(entity, searchParam);
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
