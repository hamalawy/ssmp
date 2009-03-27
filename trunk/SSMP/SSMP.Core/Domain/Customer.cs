using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// Customer object for NHibernate mapped table Customer.
    /// </summary>
    [Serializable]
    public class Customer : DomainObject<System.Int32>
    {


        private System.String _CustomersName;
        private System.String _Address;
        private System.Byte? _Sex;
        private System.String _Email;
        private System.String _IdCardNo;
        private System.DateTime? _Birthday;
        private System.Int32? _PrivilegePoint;
        private System.String _TelNo;
        private IList<BillSale> _BillSales = new List<BillSale>();

        public Customer()
        {
        }

        public Customer(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String CustomersName {
             get { return _CustomersName; }
             set { _CustomersName = value;}
         }

         public virtual System.String Address {
             get { return _Address; }
             set { _Address = value;}
         }

         public virtual System.Byte? Sex {
             get { return _Sex; }
             set { _Sex = value;}
         }

         public virtual System.String Email {
             get { return _Email; }
             set { _Email = value;}
         }

         public virtual System.String IdCardNo {
             get { return _IdCardNo; }
             set { _IdCardNo = value;}
         }

         public virtual System.DateTime? Birthday {
             get { return _Birthday; }
             set { _Birthday = value;}
         }

         public virtual System.Int32? PrivilegePoint {
             get { return _PrivilegePoint; }
             set { _PrivilegePoint = value;}
         }

         public virtual System.String TelNo {
             get { return _TelNo; }
             set { _TelNo = value;}
         }

         public virtual IList<BillSale> BillSales{
             get { return _BillSales; }
             set { _BillSales = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
