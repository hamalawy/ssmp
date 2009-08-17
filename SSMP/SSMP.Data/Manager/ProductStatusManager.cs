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
    public class ProductStatusManager : IManager<ProductStatus, System.Int32>
    {
        private IProductStatusDao productStatusDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(UserTitleManager));

        public ProductStatusManager()
        {
            const string LOCATION = "ProductStatusManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            productStatusDao = daoFactory.GetProductStatusDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<ProductStatus,int> Members

        public ProductStatus GetById(int id, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<ProductStatus> GetAll()
        {
            return productStatusDao.GetAll();
        }

        public List<ProductStatus> GetByExample(ProductStatus exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ProductStatus GetUniqueByExample(ProductStatus exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ProductStatus Save(ProductStatus entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ProductStatus SaveOrUpdate(ProductStatus entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Delete(ProductStatus entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<ProductStatus> GetByExampleAndPaging(ProductStatus exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
