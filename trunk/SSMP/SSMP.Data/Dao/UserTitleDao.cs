using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class UserTitleDao : AbstractNHibernateDao<UserTitle, System.Int32>, IUserTitleDao
    {
    }
}
