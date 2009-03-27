using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// ReferenceGroup object for NHibernate mapped table ReferenceGroup.
    /// </summary>
    [Serializable]
    public class ReferenceGroup : DomainObject<System.String>
    {


        private System.String _RefDesc;
        private IList<ReferenceData> _ReferenceDatas = new List<ReferenceData>();

        public ReferenceGroup()
        {
        }

        public ReferenceGroup(System.String id)
        {
            base.ID = id;
        }

         public virtual System.String RefDesc {
             get { return _RefDesc; }
             set { _RefDesc = value;}
         }

         public virtual IList<ReferenceData> ReferenceDatas{
             get { return _ReferenceDatas; }
             set { _ReferenceDatas = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
