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
            throw new Exception("The method or operation is not implemented.");
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
            throw new Exception("The method or operation is not implemented.");
        }

        public void Delete(UserTitle entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<UserTitle> GetByExampleAndPaging(UserTitle exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
