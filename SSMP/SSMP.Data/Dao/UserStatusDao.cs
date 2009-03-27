using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class UserStatusDao : AbstractNHibernateDao<UserStatus, System.Int32>, IUserStatusDao
    {
    }
}
