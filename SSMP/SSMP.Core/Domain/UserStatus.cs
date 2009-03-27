using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// UserStatus object for NHibernate mapped table UserStatus.
    /// </summary>
    [Serializable]
    public class UserStatus : DomainObject<System.Int32>
    {


        private System.String _UserStatusName;
        private System.String _UserStatusDesc;
        private IList<User> _Userses = new List<User>();

        public UserStatus()
        {
        }

        public UserStatus(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String UserStatusName {
             get { return _UserStatusName; }
             set { _UserStatusName = value;}
         }

         public virtual System.String UserStatusDesc {
             get { return _UserStatusDesc; }
             set { _UserStatusDesc = value;}
         }

         public virtual IList<User> Userses{
             get { return _Userses; }
             set { _Userses = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
