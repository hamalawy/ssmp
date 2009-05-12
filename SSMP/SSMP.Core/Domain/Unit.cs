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
        private IList<Product> _Products = new List<Product>();

        public Unit()
        {
        }

        public Unit(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String UnitName 
         {
             get { return _UnitName; }
             set { _UnitName = value;}
         }

         public virtual System.String UnitDesc 
         {
             get { return _UnitDesc; }
             set { _UnitDesc = value;}
         }

         public virtual IList<Product> Products
         {
             get { return _Products; }
             set { _Products = value; }
         }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
     }
}
