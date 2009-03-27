using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data.Dao
{
    public class CustomerDao : AbstractNHibernateDao<Customer, System.Int32>, ICustomerDao
    {
    }
}
