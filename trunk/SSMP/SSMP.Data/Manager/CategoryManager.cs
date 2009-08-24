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
    public class CategoryManager : IManager<Category, System.Int32>
    {
        private ICategoryDao categoryDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(CategoryManager));

        public CategoryManager()
        {
            const string LOCATION = "CategoryManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            categoryDao = daoFactory.GetCategoryDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<Category,int> Members

        public Category GetById(int id, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<Category> GetAll()
        {
            return categoryDao.GetAll();
        }

        public List<Category> GetByExample(Category exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Category GetUniqueByExample(Category exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Category Save(Category entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Category SaveOrUpdate(Category entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.ID == 0)
                    {
                        categoryDao.SaveOrUpdate(entity);
                    }
                    else
                    {
                        Category existEntity = categoryDao.GetById(entity.ID, false);
                        existEntity.CategoryName = entity.CategoryName;
                        existEntity.CategoryDesc = entity.CategoryDesc;
                    }

                    categoryDao.CommitChanges();
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

        public void Delete(Category entity)
        {
            try
            {
                if (entity != null)
                {
                    Category existEntity = categoryDao.GetById(entity.ID, false);

                    categoryDao.Delete(existEntity);
                    categoryDao.CommitChanges();
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

        public SearchResult<Category> GetByExampleAndPaging(Category exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<Category> GetCategoryListByParam(Category entity, SearchParam searchParam)
        {
            SearchResult<Category> searchResult;

            try
            {
                searchResult = categoryDao.GetCategoryListByParam(entity, searchParam);
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
