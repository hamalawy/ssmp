using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class CountryDao : AbstractNHibernateDao<Country, System.Int32>, ICountryDao
    {
    }
}
