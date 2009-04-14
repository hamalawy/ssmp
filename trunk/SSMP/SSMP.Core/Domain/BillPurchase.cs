using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// BillPurchase object for NHibernate mapped table BillPurchase.
    /// </summary>
    [Serializable]
    public class BillPurchase : DomainObject<System.Int64>
    {


        private System.DateTime _CreateDate;
        private System.String _DeliveryStaff;
        private System.Int32 _ProviderId;
        private System.Int32 _UserId;
        private IList<Product> _Products = new List<Product>();

        public BillPurchase()
        {
        }

        public BillPurchase(System.Int64 id)
        {
            base.ID = id;
        }

         public virtual System.DateTime CreateDate {
             get { return _CreateDate; }
             set { _CreateDate = value;}
         }

         public virtual System.String DeliveryStaff {
             get { return _DeliveryStaff; }
             set { _DeliveryStaff = value;}
         }

         public virtual System.Int32 ProviderId {
             get { return _ProviderId; }
             set { _ProviderId = value;}
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
