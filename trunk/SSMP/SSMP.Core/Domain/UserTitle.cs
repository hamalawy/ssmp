using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// UserTitle object for NHibernate mapped table UserTitle.
    /// </summary>
    [Serializable]
    public class UserTitle : DomainObject<System.Int32>
    {


        private System.String _UserTitleDesc;
        private System.String _UserTitleName;
        private IList<User> _Userses = new List<User>();

        public UserTitle()
        {
        }

        public UserTitle(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String UserTitleDesc {
             get { return _UserTitleDesc; }
             set { _UserTitleDesc = value;}
         }

         public virtual System.String UserTitleName {
             get { return _UserTitleName; }
             set { _UserTitleName = value;}
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
