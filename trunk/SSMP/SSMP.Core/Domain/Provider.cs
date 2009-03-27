using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// Provider object for NHibernate mapped table Provider.
    /// </summary>
    [Serializable]
    public class Provider : DomainObject<System.Int32>
    {


        private System.String _ProviderName;
        private System.String _Address;
        private System.String _TelNo;
        private System.String _FaxNo;
        private System.String _Email;
        private System.String _Website;
        private System.Int32 _CountryId;
        private Country _CountryIdLookup;
        private IList<BillPurchase> _BillPurchases = new List<BillPurchase>();

        public Provider()
        {
        }

        public Provider(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String ProviderName {
             get { return _ProviderName; }
             set { _ProviderName = value;}
         }

         public virtual System.String Address {
             get { return _Address; }
             set { _Address = value;}
         }

         public virtual System.String TelNo {
             get { return _TelNo; }
             set { _TelNo = value;}
         }

         public virtual System.String FaxNo {
             get { return _FaxNo; }
             set { _FaxNo = value;}
         }

         public virtual System.String Email {
             get { return _Email; }
             set { _Email = value;}
         }

         public virtual System.String Website {
             get { return _Website; }
             set { _Website = value;}
         }

         public virtual System.Int32 CountryId {
             get { return _CountryId; }
             set { _CountryId = value;}
         }

         public virtual Country CountryIdLookup{
             get { return _CountryIdLookup; }
             set { _CountryIdLookup = value;}
         }

         public virtual IList<BillPurchase> BillPurchases{
             get { return _BillPurchases; }
             set { _BillPurchases = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
