using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Domain;

namespace SSMP.Data
{
    public class BillSaleDao : AbstractNHibernateDao<BillSale, System.String>, IBillSaleDao
    {
    }
}
