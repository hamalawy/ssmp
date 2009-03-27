using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class ManufacturerDao : AbstractNHibernateDao<Manufacturer, System.Int32>, IManufacturerDao
    {
    }
}
