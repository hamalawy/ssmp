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
    public class MenuManager : IManager<Menu, System.Int32> 
    {
        private IMenuDao menuDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(MenuManager));

        public MenuManager()
        {
            const string LOCATION = "MenuManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            menuDao = daoFactory.GetMenuDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<Menu,int> Members

        public Menu GetById(int id, bool shouldLock)
        {
            return menuDao.GetById(id, shouldLock);
        }

        public List<Menu> GetAll()
        {
            return menuDao.GetAll();
        }

        public List<Menu> GetByExample(Menu exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Menu GetUniqueByExample(Menu exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Menu Save(Menu entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Menu SaveOrUpdate(Menu entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.ID == 0)
                    {
                        menuDao.SaveOrUpdate(entity);
                    }
                    else
                    {
                        Menu existEntity = menuDao.GetById(entity.ID, false);
                        existEntity.MenuName = entity.MenuName;
                    }
                    
                    menuDao.CommitChanges();
                }
                else
                {
                    throw new Exception("Menu entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Delete(Menu entity)
        {
            try
            {
                if (entity != null)
                {
                    Menu existEntity = menuDao.GetById(entity.ID, false);

                    menuDao.Delete(existEntity);
                    menuDao.CommitChanges();
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

        public SearchResult<Menu> GetByExampleAndPaging(Menu exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<Menu> GetMenuListByParam(Menu entity, SearchParam searchParam)
        {
            SearchResult<Menu> searchResult;

            try
            {
                searchResult = menuDao.GetMenuListByParam(entity, searchParam);
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
