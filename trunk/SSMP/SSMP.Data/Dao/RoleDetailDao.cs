using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;
using SSMP.Core.Utils;
using NHibernate;
using NHibernate.Criterion;

namespace SSMP.Data.Dao
{
    public class RoleDetailDao : AbstractNHibernateDao<RoleDetail, System.Int32>, IRoleDetailDao
    {
        #region IUserRoleDetailDao Members

        public List<Menu> GetListMenuByRole(int roleID)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(RoleDetail));
            criteria.Add(Restrictions.Eq("ID.UserRoleId", roleID));
            List<RoleDetail> list = criteria.List<RoleDetail>() as List<RoleDetail>;
            List<Menu> listMenu = new List<Menu>();

            foreach (RoleDetail obj in list)
            {
                ICriteria criteriaMenu = NHibernateSession.CreateCriteria(typeof(Menu));
                criteriaMenu.Add(Restrictions.Eq("ID", obj.MenuId));

                List<Menu> tmp = criteriaMenu.List<Menu>() as List<Menu>;
                listMenu.Add(tmp[0]);
            }

            return listMenu;
        }

        public List<RoleDetail> GetListByRole(int roleID)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(RoleDetail));
            criteria.Add(Restrictions.Eq("ID.UserRoleId", roleID));
            List<RoleDetail> list = criteria.List<RoleDetail>() as List<RoleDetail>;

            return list;
        }

        #endregion     
   
        #region IDao<RoleDetail,DomainObjectID> Members

        public RoleDetail GetById(RoleDetail.DomainObjectID id, bool shouldLock)
        {
            RoleDetail entity;

            if (shouldLock)
            {
                entity = (RoleDetail)NHibernateSession.Load(typeof(RoleDetail), id, LockMode.Upgrade);
            }
            else
            {
                entity = (RoleDetail)NHibernateSession.Load(typeof(RoleDetail), id);
            }

            return entity;
        }

        #endregion
    }
}
