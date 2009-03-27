using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class UserRoleDao : AbstractNHibernateDao<UserRole, System.Int32>, IUserRoleDao
    {
    }
}
