using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// ProductStatus object for NHibernate mapped table ProductStatus.
    /// </summary>
    [Serializable]
    public class ProductStatus : DomainObject<System.Int32>
    {


        private System.String _StatusName;
        private System.String _Description;
        private IList<Product> _Products = new List<Product>();

        public ProductStatus()
        {
        }

        public ProductStatus(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String StatusName {
             get { return _StatusName; }
             set { _StatusName = value;}
         }

         public virtual System.String Description {
             get { return _Description; }
             set { _Description = value;}
         }

         public virtual IList<Product> Products{
             get { return _Products; }
             set { _Products = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
