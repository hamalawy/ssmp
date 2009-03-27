using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// Action object for NHibernate mapped table Action.
    /// </summary>
    [Serializable]
    public class Action : DomainObject<System.Int32>
    {


        private System.String _ActionName;
        private System.String _ActionDesc;
        private IList<ActionDetail> _ActionDetails = new List<ActionDetail>();

        public Action()
        {
        }

        public Action(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String ActionName {
             get { return _ActionName; }
             set { _ActionName = value;}
         }

         public virtual System.String ActionDesc {
             get { return _ActionDesc; }
             set { _ActionDesc = value;}
         }

         public virtual IList<ActionDetail> ActionDetails{
             get { return _ActionDetails; }
             set { _ActionDetails = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
