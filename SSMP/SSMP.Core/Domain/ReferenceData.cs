using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// ReferenceData object for NHibernate mapped table ReferenceData.
    /// </summary>
    [Serializable]
    public class ReferenceData : DomainObject<System.String>
    {


        private System.Int32? _RefNumber;
        private System.String _RefString;
        private System.DateTime? _RefDate;
        private System.String _RefGroup;
        private ReferenceGroup _RefGroupLookup;

        public ReferenceData()
        {
        }

        public ReferenceData(System.String id)
        {
            base.ID = id;
        }

         public virtual System.Int32? RefNumber {
             get { return _RefNumber; }
             set { _RefNumber = value;}
         }

         public virtual System.String RefString {
             get { return _RefString; }
             set { _RefString = value;}
         }

         public virtual System.DateTime? RefDate {
             get { return _RefDate; }
             set { _RefDate = value;}
         }

         public virtual System.String RefGroup {
             get { return _RefGroup; }
             set { _RefGroup = value;}
         }

         public virtual ReferenceGroup RefGroupLookup{
             get { return _RefGroupLookup; }
             set { _RefGroupLookup = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
