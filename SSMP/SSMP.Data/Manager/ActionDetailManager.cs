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
    public class ActionDetailManager : IManager<ActionDetail, System.Int32>
    {
        private IActionDetailDao actionDetailDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(ActionDetailManager));

        public ActionDetailManager()
        {
            const string LOCATION = "ActionDetailManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            actionDetailDao = daoFactory.GetActionDetailDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<ActionDetail,int> Members

        public ActionDetail GetById(int id, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<ActionDetail> GetAll()
        {
            return actionDetailDao.GetAll();
        }

        public List<ActionDetail> GetByExample(ActionDetail exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ActionDetail GetUniqueByExample(ActionDetail exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ActionDetail Save(ActionDetail entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ActionDetail SaveOrUpdate(ActionDetail entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.ID.ActionId == 0 && entity.ID.UserId == 0)
                    {
                        actionDetailDao.SaveOrUpdate(entity);
                    }
                    else
                    {
                        ActionDetail existEntity = actionDetailDao.GetById(entity.ID, false);
                        //Chỗ này là copy all property của object update cho object exist, nhưng vì chưa code nên copy thủ công
                        existEntity.ActionDate = entity.ActionDate;
                        //existEntity.ActionId = entity.ActionId;
                        //existEntity.UserId = entity.UserId;
                    }

                    actionDetailDao.CommitChanges();
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

        public void Delete(ActionDetail entity)
        {
            try
            {
                if (entity != null)
                {
                    ActionDetail existEntity = actionDetailDao.GetById(entity.ID, false);

                    actionDetailDao.Delete(existEntity);
                    actionDetailDao.CommitChanges();
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

        public SearchResult<ActionDetail> GetByExampleAndPaging(ActionDetail exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<ActionDetail> GetActionDetailListByParam(ActionDetail entity, SearchParam searchParam)
        {
            SearchResult<ActionDetail> searchResult;

            try
            {
                searchResult = actionDetailDao.GetActionDetailListByParam(entity, searchParam);
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
