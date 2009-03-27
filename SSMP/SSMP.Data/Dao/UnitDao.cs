using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class UnitDao : AbstractNHibernateDao<Unit, System.Int32>, IUnitDao
    {
    }
}
