using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// ActionDetail object for NHibernate mapped table ActionDetail.
    /// </summary>
    [Serializable]
    public class ActionDetail : DomainObject<ActionDetail.DomainObjectID>
    {

        [Serializable]
        public class DomainObjectID
        {
            public DomainObjectID() {}

            private System.Int32 _UserId;
            private System.Int32 _ActionId;

            public DomainObjectID(System.Int32 userId, System.Int32 actionId)
            {
                _UserId = userId;
                _ActionId = actionId;
            }

         public System.Int32 UserId {
             get { return _UserId; }
             protected set { _UserId = value;}
         }

         public System.Int32 ActionId {
             get { return _ActionId; }
             protected set { _ActionId = value;}
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
                    if (this.UserId != that.UserId) return false;
                    if (this.ActionId != that.ActionId) return false;

                    return true;
                }

            }

            public override int GetHashCode()
            {
                return UserId.GetHashCode() ^ ActionId.GetHashCode();
            }

        }

        private System.DateTime _ActionDate;
        private Action _ActionIdLookup;
        private User _UserIdLookup;

        public ActionDetail()
        {
        }

        public ActionDetail(DomainObjectID id)
        {
            base.ID = id;
        }

         public virtual System.Int32 UserId {
             get { return base.id.UserId; }
         }

         public virtual System.Int32 ActionId {
             get { return base.id.ActionId; }
         }

         public virtual System.DateTime ActionDate {
             get { return _ActionDate; }
             set { _ActionDate = value;}
         }

         public virtual Action ActionIdLookup{
             get { return _ActionIdLookup; }
             set { _ActionIdLookup = value;}
         }

         public virtual User UserIdLookup{
             get { return _UserIdLookup; }
             set { _UserIdLookup = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
