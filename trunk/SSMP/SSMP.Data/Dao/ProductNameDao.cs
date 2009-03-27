using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class ProductNameDao : AbstractNHibernateDao<ProductName, System.Int32>, IProductNameDao
    {
    }
}
