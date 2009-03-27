using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class ActionDao : AbstractNHibernateDao<Action, System.Int32>, IActionDao
    {
    }
}
