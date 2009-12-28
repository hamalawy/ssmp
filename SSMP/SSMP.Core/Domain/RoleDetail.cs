using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// UserRoleDetail object for NHibernate mapped table UserRoleDetail.
    /// </summary>
    [Serializable]
    public class RoleDetail : DomainObject<RoleDetail.DomainObjectID>
    {

        [Serializable]
        public class DomainObjectID
        {
            public DomainObjectID() {}

            private System.Int32 _MenuId;
            private System.Int32 _UserRoleId;

            public DomainObjectID(System.Int32 menuId, System.Int32 userRoleId)
            {
                _MenuId = menuId;
                _UserRoleId = userRoleId;
            }

            public System.Int32 MenuId {
                get { return _MenuId; }
                protected set { _MenuId = value;}
         }

         public System.Int32 UserRoleId {
             get { return _UserRoleId; }
             protected set { _UserRoleId = value;}
         }

            public override bool Equals(object obj)
            {
                if (obj == this) return true;
                if (obj == null) return false;

                DomainObjectID that = obj as DomainObjectID;
                if (that == null)
                {
                    return false;
                }
                else
                {
                    if (this.MenuId != that.MenuId) return false;
                    if (this.UserRoleId != that.UserRoleId) return false;

                    return true;
                }

            }

            public override int GetHashCode()
            {
                return MenuId.GetHashCode() ^ UserRoleId.GetHashCode();
            }

        }

        private UserRole _UserRoleIdLookup;
        private Menu _MenuIdLookup;
        private System.Byte? _Enable;

        public RoleDetail()
        {
        }

        public RoleDetail(DomainObjectID id)
        {
            base.ID = id;
        }

         public virtual System.Int32 MenuId {
             get { return base.id.MenuId; }
         }

         public virtual System.Int32 UserRoleId {
             get { return base.id.UserRoleId; }
         }

         public virtual UserRole UserRoleIdLookup{
             get { return _UserRoleIdLookup; }
             set { _UserRoleIdLookup = value;}
         }

         public virtual Menu MenuIdLookup{
             get { return _MenuIdLookup; }
             set { _MenuIdLookup = value;}
         }

        public virtual System.Byte? Enable
        {
            get { return _Enable; }
            set { _Enable = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
