using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// User object for NHibernate mapped table Users.
    /// </summary>
    [Serializable]
    public class User : DomainObject<System.Int32>
    {


        private System.String _Username;
        private System.String _Password;
        private System.String _FullName;
        private System.String _Email;
        private System.DateTime? _Birthday;
        private System.String _IdCardNo;
        private System.Byte? _Sex;
        private System.Int32 _UserStatusId;
        private System.String _Address;
        private System.Int32 _UserRoleId;
        private System.Int32? _UserTitleId;
        private System.String _TelNo;
        private UserRole _UserRoleIdLookup;
        private UserStatus _UserStatusIdLookup;
        private UserTitle _UserTitleIdLookup;
        private IList<ActionDetail> _ActionDetails = new List<ActionDetail>();
        private IList<BillPurchase> _BillPurchases = new List<BillPurchase>();
        private IList<BillSale> _BillSales = new List<BillSale>();

        public User()
        {
        }

        public User(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Username {
             get { return _Username; }
             set { _Username = value;}
         }

         public virtual System.String Password {
             get { return _Password; }
             set { _Password = value;}
         }

         public virtual System.String FullName {
             get { return _FullName; }
             set { _FullName = value;}
         }

         public virtual System.String Email {
             get { return _Email; }
             set { _Email = value;}
         }

         public virtual System.DateTime? Birthday {
             get { return _Birthday; }
             set { _Birthday = value;}
         }

         public virtual System.String IdCardNo {
             get { return _IdCardNo; }
             set { _IdCardNo = value;}
         }

         public virtual System.Byte? Sex {
             get { return _Sex; }
             set { _Sex = value;}
         }

         public virtual System.Int32 UserStatusId {
             get { return _UserStatusId; }
             set { _UserStatusId = value;}
         }

         public virtual System.String Address {
             get { return _Address; }
             set { _Address = value;}
         }

         public virtual System.Int32 UserRoleId {
             get { return _UserRoleId; }
             set { _UserRoleId = value;}
         }

         public virtual System.Int32? UserTitleId {
             get { return _UserTitleId; }
             set { _UserTitleId = value;}
         }

         public virtual System.String TelNo {
             get { return _TelNo; }
             set { _TelNo = value;}
         }

         public virtual UserRole UserRoleIdLookup{
             get { return _UserRoleIdLookup; }
             set { _UserRoleIdLookup = value;}
         }

         public virtual UserStatus UserStatusIdLookup{
             get { return _UserStatusIdLookup; }
             set { _UserStatusIdLookup = value;}
         }

         public virtual UserTitle UserTitleIdLookup{
             get { return _UserTitleIdLookup; }
             set { _UserTitleIdLookup = value;}
         }

         public virtual IList<ActionDetail> ActionDetails{
             get { return _ActionDetails; }
             set { _ActionDetails = value; }
         }

         public virtual IList<BillPurchase> BillPurchases{
             get { return _BillPurchases; }
             set { _BillPurchases = value; }
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
