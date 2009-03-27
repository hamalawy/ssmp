using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// Unit object for NHibernate mapped table Units.
    /// </summary>
    [Serializable]
    public class Unit : DomainObject<System.Int32>
    {


        private System.String _UnitName;
        private System.String _UnitDesc;
        private IList<ProductName> _ProductNames = new List<ProductName>();

        public Unit()
        {
        }

        public Unit(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String UnitName {
             get { return _UnitName; }
             set { _UnitName = value;}
         }

         public virtual System.String UnitDesc {
             get { return _UnitDesc; }
             set { _UnitDesc = value;}
         }

         public virtual IList<ProductName> ProductNames{
             get { return _ProductNames; }
             set { _ProductNames = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
