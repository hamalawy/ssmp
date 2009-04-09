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
    public class UserStatusManager : IManager<UserStatus, System.Int32> 
    {
        private IUserStatusDao userStatusDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(UserStatusManager));

        public UserStatusManager()
        {
            const string LOCATION = "UserStatusManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            userStatusDao = daoFactory.GetUserStatusDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<UserStatus,int> Members

        public UserStatus GetById(int id, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<UserStatus> GetAll()
        {
            return userStatusDao.GetAll();
        }

        public List<UserStatus> GetByExample(UserStatus exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserStatus GetUniqueByExample(UserStatus exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserStatus Save(UserStatus entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserStatus SaveOrUpdate(UserStatus entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Delete(UserStatus entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<UserStatus> GetByExampleAndPaging(UserStatus exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
