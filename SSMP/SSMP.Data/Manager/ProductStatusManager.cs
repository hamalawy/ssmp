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
        private static readonly ILog logger = LogManager.GetLogger(typeof(ProductStatusManager));

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
            try
            {
                if (entity != null)
                {
                    if (entity.ID == 0)
                    {
                        productStatusDao.SaveOrUpdate(entity);
                    }
                    else
                    {
                        ProductStatus existEntity = productStatusDao.GetById(entity.ID, false);
                        existEntity.StatusName = entity.StatusName;
                        existEntity.Description = entity.Description;
                    }

                    productStatusDao.CommitChanges();
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

        public void Delete(ProductStatus entity)
        {
            try
            {
                if (entity != null)
                {
                    ProductStatus existEntity = productStatusDao.GetById(entity.ID, false);

                    productStatusDao.Delete(existEntity);
                    productStatusDao.CommitChanges();
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

        public SearchResult<ProductStatus> GetByExampleAndPaging(ProductStatus exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<ProductStatus> GetProductStatusListByParam(ProductStatus entity, SearchParam searchParam)
        {
            SearchResult<ProductStatus> searchResult;

            try
            {
                searchResult = productStatusDao.GetProductStatusListByParam(entity, searchParam);
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
