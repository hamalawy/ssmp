using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// BillSale object for NHibernate mapped table BillSale.
    /// </summary>
    [Serializable]
    public class BillSale : DomainObject<System.Int64>
    {


        private System.DateTime _CreateDate;
        private System.Int32 _CustomerId;
        private System.Int32 _UserId;
        private IList<Product> _Products = new List<Product>();

        public BillSale()
        {
        }

        public BillSale(System.Int64 id)
        {
            base.ID = id;
        }

         public virtual System.DateTime CreateDate {
             get { return _CreateDate; }
             set { _CreateDate = value;}
         }

         public virtual System.Int32 CustomerId {
             get { return _CustomerId; }
             set { _CustomerId = value;}
         }

         public virtual System.Int32 UserId {
             get { return _UserId; }
             set { _UserId = value;}
         }

         public virtual IList<Product> Products{
             get { return _Products; }
             set { _Products = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
