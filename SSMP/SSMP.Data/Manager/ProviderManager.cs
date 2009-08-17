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
    public class ProviderManager : IManager<Provider, System.Int32>
    {
        private IProviderDao userRoleDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(ProviderManager));

        public ProviderManager()
        {
            const string LOCATION = "ProviderManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            userRoleDao = daoFactory.GetProviderDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<Provider,int> Members

        public Provider GetById(int id, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<Provider> GetAll()
        {
            return userRoleDao.GetAll();
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
            throw new Exception("The method or operation is not implemented.");
        }

        public void Delete(Provider entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<Provider> GetByExampleAndPaging(Provider exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
