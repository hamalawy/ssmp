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
    public class ProductManager : IManager<SSMP.Core.Domain.Product, System.String>
    {
        private SSMP.Core.DataInterfaces.IProductDao productDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(ProductManager));

        public ProductManager()
        {
            const string LOCATION = "ProductManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            productDao = daoFactory.GetProductDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        public Product GetById(System.String IdT, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<Product> GetAll()
        {
            return productDao.GetAll();
        }

        public List<Product> GetByExample(Product exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Product GetUniqueByExample(Product exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Product Save(Product entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Product SaveOrUpdate(Product entity)
        {
            try
            {
                if (entity != null)
                {
                    productDao.SaveOrUpdate(entity);
                    productDao.CommitChanges();
                }
                else
                {
                    throw new Exception("Product entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Delete(Product entity)
        {
            try
            {
                if (entity != null)
                {
                    //entity.ProductTitleIdLookup = null;
                    // entity.ProductTitleId = null;
                    //productDao.CommitChanges();
                    productDao.Delete(entity);
                    productDao.CommitChanges();
                }
                else
                {
                    throw new Exception("Product entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsExist(Product entity)
        {
            /*
            Product productObj = productDao.GetById(entity.ID, false);

            if (productObj != null)
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

        public SearchResult<Product> GetByExampleAndPaging(Product exampleInstance, SearchParam searchParam)
        {
            SearchResult<Product> searchResult;

            try
            {
                searchResult = productDao.GetByExampleAndPaging(exampleInstance, searchParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchResult;
        }

        public SearchResult<Product> GetProductListByParam(Product entity, SearchParam searcParam)
        {
            SearchResult<Product> searchResult;

            try
            {
                searchResult = productDao.GetProductListByParam(entity, searcParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchResult;
        }
    }
}
