using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// UserRole object for NHibernate mapped table UserRole.
    /// </summary>
    [Serializable]
    public class UserRole : DomainObject<System.Int32>
    {


        private System.String _UserRoleDesc;
        private System.String _UserRoleName;
        private IList<User> _Userses = new List<User>();

        public UserRole()
        {
        }

        public UserRole(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String UserRoleDesc {
             get { return _UserRoleDesc; }
             set { _UserRoleDesc = value;}
         }

         public virtual System.String UserRoleName {
             get { return _UserRoleName; }
             set { _UserRoleName = value;}
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
