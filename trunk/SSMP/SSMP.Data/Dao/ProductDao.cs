using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class ProductDao : AbstractNHibernateDao<Product, System.Int64>, IProductDao
    {
    }
}
