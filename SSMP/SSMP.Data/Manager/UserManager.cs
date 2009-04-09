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
    public class UserManager : IManager<User, System.String>
    {
        private IUserDao userDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(UserManager));

        public UserManager()
        {
            const string LOCATION = "UserManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            userDao = daoFactory.GetUserDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        public User GetById(System.String IdT, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<User> GetAll()
        {
            return userDao.GetAll();
        }

        public List<User> GetByExample(User exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public User GetUniqueByExample(User exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public User Save(User entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public User SaveOrUpdate(User entity)
        {
            try
            {
                if (entity != null)
                {
                    userDao.SaveOrUpdate(entity);
                    userDao.CommitChanges();
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

            return entity;
        }

        public void Delete(User entity)
        {
            try
            {
                if (entity != null)
                {
                    //entity.UserTitleIdLookup = null;
                    entity.UserTitleId = null;
                    //userDao.CommitChanges();
                    userDao.Delete(entity);
                    userDao.CommitChanges();
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

        public bool IsExist(User entity)
        {
            User userObj = userDao.GetById(entity.ID, false);

            if (userObj != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SearchResult<User> GetByExampleAndPaging(User exampleInstance, SearchParam searchParam)
        {
            SearchResult<User> searchResult;

            try
            {
                searchResult = userDao.GetByExampleAndPaging(exampleInstance, searchParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchResult;
        }

        public SearchResult<User> GetUserListByParam(User entity, SearchParam searcParam)
        {
            SearchResult<User> searchResult;

            try
            {
                searchResult = userDao.GetUserListByParam(entity, searcParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchResult;
        }
    }
}
