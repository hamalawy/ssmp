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
    public class UserRoleManager : IManager<UserRole, System.Int32> 
    {
        private IUserRoleDao userRoleDao;
        private IRoleDetailDao roleDetailDao;
        private IMenuDao menuDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(UserRoleManager));

        public UserRoleManager()
        {
            const string LOCATION = "UserRoleManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            userRoleDao = daoFactory.GetUserRoleDao();
            roleDetailDao = daoFactory.GetRoleDetailDao();
            menuDao = daoFactory.GetMenuDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        #region IManager<UserRole,int> Members

        public UserRole GetById(int id, bool shouldLock)
        {
            return userRoleDao.GetById(id, shouldLock);
        }

        public List<UserRole> GetAll()
        {
            return userRoleDao.GetAll();
        }

        public List<UserRole> GetByExample(UserRole exampleInstance, params string[] propertiesToExclude)
        {
            return userRoleDao.GetByExample(exampleInstance, propertiesToExclude);
        }

        public UserRole GetUniqueByExample(UserRole exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserRole Save(UserRole entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UserRole SaveOrUpdate(UserRole entity)
        {
            try
            {
                if (entity != null)
                {
                    userRoleDao.OpenTransaction();
                    bool isSave = false;
                    if (entity.ID == 0)
                    {
                        userRoleDao.SaveOrUpdate(entity);
                        isSave = true;
                    }
                    else
                    {
                        UserRole existEntity = userRoleDao.GetById(entity.ID, false);
                        existEntity.UserRoleName = entity.UserRoleName;
                        existEntity.UserRoleDesc = entity.UserRoleDesc;
                    }

                    if (isSave)
                    {
                        for (int i = 1; i <= 5; i++)
                        {
                            RoleDetail roleDetail = new RoleDetail(new RoleDetail.DomainObjectID(i, entity.ID));
                            roleDetail.Enable = 0;
                            //roleDetail.MenuIdLookup = menuDao.GetById(i, false);
                            //roleDetail.UserRoleIdLookup = userRoleDao.GetById(entity.ID, false);
                            roleDetailDao.Save(roleDetail);                                 
                        }                        
                    }

                    userRoleDao.CommitChanges();
                }
                else
                {
                    throw new Exception("User role entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                userRoleDao.RollbackTransaction();
                throw ex;                
            }

            return entity;
        }

        public void Delete(UserRole entity)
        {
            try
            {
                if (entity != null)
                {
                    userRoleDao.OpenTransaction();
                    for (int i = 1; i <= 5; i++)
                    {
                        RoleDetail roleDetail = roleDetailDao.GetById(new RoleDetail.DomainObjectID(i, entity.ID), false);

                        bool entityExist = true;
                        try
                        {
                            byte tmp = roleDetail.Enable.Value;                            
                        }
                        catch(NHibernate.ObjectNotFoundException ex)
                        {
                            entityExist = false;
                        }
                        if (entityExist) //De tranh truong hop null
                        {
                            roleDetailDao.Delete(roleDetail);
                        }
                    }

                    UserRole existEntity = userRoleDao.GetById(entity.ID, false);

                    userRoleDao.Delete(existEntity);
                    userRoleDao.CommitChanges();
                }
                else
                {
                    userRoleDao.RollbackTransaction();
                    throw new Exception("User entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                userRoleDao.RollbackTransaction();
                throw ex;                
            }
        }

        public SearchResult<UserRole> GetByExampleAndPaging(UserRole exampleInstance, SearchParam searchParam)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public SearchResult<UserRole> GetUserRoleListByParam(UserRole entity, SearchParam searchParam)
        {
            SearchResult<UserRole> searchResult;

            try
            {
                searchResult = userRoleDao.GetUserRoleListByParam(entity, searchParam);
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
