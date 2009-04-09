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
    public class UserRoleManager : IManager<UserRole, System.Int32> 
    {
        private IUserRoleDao userRoleDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(UserRoleManager));

        public UserRoleManager()
        {
            const string LOCATION = "UserRoleManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            userRoleDao = daoFactory.GetUserRoleDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<UserRole,int> Members

        public UserRole GetById(int id, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<UserRole> GetAll()
        {
            return userRoleDao.GetAll();
        }

        public List<UserRole> GetByExample(UserRole exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserRole GetUniqueByExample(UserRole exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserRole Save(UserRole entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserRole SaveOrUpdate(UserRole entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Delete(UserRole entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<UserRole> GetByExampleAndPaging(UserRole exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
