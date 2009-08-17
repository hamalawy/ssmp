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
    public class ProductNameManager : IManager<SSMP.Core.Domain.ProductName, System.Int32>
    {
        private SSMP.Core.DataInterfaces.IProductNameDao productNameDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(ProductNameManager));

        public ProductNameManager()
        {
            const string LOCATION = "ProductNameManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            productNameDao = daoFactory.GetProductNameDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        public ProductName GetById(System.Int32 id, bool shouldLock)
        {
            return productNameDao.GetById(id, false);
        }

        public List<ProductName> GetAll()
        {
            return productNameDao.GetAll();
        }

        public List<ProductName> GetByExample(ProductName exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ProductName GetUniqueByExample(ProductName exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ProductName Save(ProductName entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ProductName SaveOrUpdate(ProductName entity)
        {
            try
            {
                if (entity != null)
                {
                    productNameDao.SaveOrUpdate(entity);
                    productNameDao.CommitChanges();
                }
                else
                {
                    throw new Exception("ProductName entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Delete(ProductName entity)
        {
            try
            {
                if (entity != null)
                {
                    //entity.ProductNameTitleIdLookup = null;
                    // entity.ProductNameTitleId = null;
                    //productNameDao.CommitChanges();
                    productNameDao.Delete(entity);
                    productNameDao.CommitChanges();
                }
                else
                {
                    throw new Exception("ProductName entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsExist(ProductName entity)
        {
            /*
            ProductName productNameObj = productNameDao.GetById(entity.ID, false);

            if (productNameObj != null)
            {
                return true;
            }
            else
            {
                return false;
            }
             */
            return false;
        }

        public SearchResult<ProductName> GetByExampleAndPaging(ProductName exampleInstance, SearchParam searchParam)
        {
            SearchResult<ProductName> searchResult;

            try
            {
                searchResult = productNameDao.GetByExampleAndPaging(exampleInstance, searchParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchResult;
        }

        public SearchResult<ProductName> GetProductNameListByParam(ProductName entity, SearchParam searcParam)
        {
            SearchResult<ProductName> searchResult;

            try
            {
                searchResult = productNameDao.GetProductNameListByParam(entity, searcParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchResult;
        }
    }
}
