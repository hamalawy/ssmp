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
    public class RoleDetailManager : IManager<RoleDetail, System.Int32>
    {
        private IRoleDetailDao roleDetailDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(RoleDetailManager));

        public RoleDetailManager()
        {
            const string LOCATION = "UserRoleDetailManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            roleDetailDao = daoFactory.GetRoleDetailDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<RoleDetail,int> Members

        public RoleDetail GetById(int id, bool shouldLock)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<RoleDetail> GetAll()
        {
            return roleDetailDao.GetAll();
        }

        public List<RoleDetail> GetByExample(RoleDetail exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public RoleDetail GetUniqueByExample(RoleDetail exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public RoleDetail Save(RoleDetail entity)
        {
            return roleDetailDao.Save(entity);
        }

        public RoleDetail SaveOrUpdate(RoleDetail entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.ID.UserRoleId == 0 && entity.ID.MenuId == 0)
                    {
                        entity.Enable = 0;
                        roleDetailDao.Save(entity);
                    }
                    else
                    {
                        RoleDetail existEntity = roleDetailDao.GetById(entity.ID, false);
                        //Chỗ này là copy all property của object update cho object exist, nhưng vì chưa code nên copy thủ công                       
                        existEntity.Enable = entity.Enable;
                    }

                    roleDetailDao.CommitChanges();
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

        public void Delete(RoleDetail entity)
        {
            try
            {
                if (entity != null)
                {
                    RoleDetail existEntity = roleDetailDao.GetById(entity.ID, false);

                    roleDetailDao.Delete(existEntity);
                    roleDetailDao.CommitChanges();
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

        public SearchResult<RoleDetail> GetByExampleAndPaging(RoleDetail exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<Menu> GetListMenuByRole(int roleID)
        {
            try
            {
                return roleDetailDao.GetListMenuByRole(roleID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<RoleDetail> GetListByRole(int roleID)
        {
            try
            {
                return roleDetailDao.GetListByRole(roleID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
