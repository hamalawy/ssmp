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
    public class ActionManager : IManager<Action, System.Int32> 
    {
        private IActionDao actionDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(ActionManager));

        public ActionManager()
        {
            const string LOCATION = "ActionManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            actionDao = daoFactory.GetActionDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<Action,int> Members

        public Action GetById(int id, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<Action> GetAll()
        {
            return actionDao.GetAll();
        }

        public List<Action> GetByExample(Action exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Action GetUniqueByExample(Action exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Action Save(Action entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Action SaveOrUpdate(Action entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.ID == 0)
                    {
                        actionDao.SaveOrUpdate(entity);
                    }
                    else
                    {
                        Action existEntity = actionDao.GetById(entity.ID, false);
                        existEntity.ActionName = entity.ActionName;
                        existEntity.ActionDesc = entity.ActionDesc;
                    }
                    
                    actionDao.CommitChanges();
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

        public void Delete(Action entity)
        {
            try
            {
                if (entity != null)
                {
                    Action existEntity = actionDao.GetById(entity.ID, false);

                    actionDao.Delete(existEntity);
                    actionDao.CommitChanges();
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

        public SearchResult<Action> GetByExampleAndPaging(Action exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<Action> GetActionListByParam(Action entity, SearchParam searchParam)
        {
            SearchResult<Action> searchResult;

            try
            {
                searchResult = actionDao.GetActionListByParam(entity, searchParam);
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
