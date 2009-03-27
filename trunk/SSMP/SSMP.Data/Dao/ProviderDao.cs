using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class ProviderDao : AbstractNHibernateDao<Provider, System.Int32>, IProviderDao
    {
    }
}
