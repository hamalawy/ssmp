using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// BillSale object for NHibernate mapped table BillSale.
    /// </summary>
    [Serializable]
    public class BillSale : DomainObject<System.String>
    {


        private System.DateTime _CreateDate;
        private System.Int32 _CustomersId;
        private System.Int32 _UserId;
        private Customer _CustomersIdLookup;
        private User _UserIdLookup;
        private IList<Product> _Products = new List<Product>();

        public BillSale()
        {
        }

        public BillSale(System.String id)
        {
            base.ID = id;
        }

         public virtual System.DateTime CreateDate {
             get { return _CreateDate; }
             set { _CreateDate = value;}
         }

         public virtual System.Int32 CustomersId {
             get { return _CustomersId; }
             set { _CustomersId = value;}
         }

         public virtual System.Int32 UserId {
             get { return _UserId; }
             set { _UserId = value;}
         }

         public virtual Customer CustomersIdLookup{
             get { return _CustomersIdLookup; }
             set { _CustomersIdLookup = value;}
         }

         public virtual User UserIdLookup{
             get { return _UserIdLookup; }
             set { _UserIdLookup = value;}
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
