using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// Category object for NHibernate mapped table Category.
    /// </summary>
    [Serializable]
    public class Category : DomainObject<System.Int32>
    {


        private System.String _CategoryName;
        private System.String _CategoryDesc;
        private IList<ProductName> _ProductNames = new List<ProductName>();

        public Category()
        {
        }

        public Category(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String CategoryName {
             get { return _CategoryName; }
             set { _CategoryName = value;}
         }

         public virtual System.String CategoryDesc {
             get { return _CategoryDesc; }
             set { _CategoryDesc = value;}
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
