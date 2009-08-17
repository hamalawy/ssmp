using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// ProductName object for NHibernate mapped table ProductName.
    /// </summary>
    [Serializable]
    public class ProductName : DomainObject<System.Int32>
    {
        private System.String _ProdName;
        private System.String _ProdDesc;
        private System.Int32 _CategoryId;
        private System.Int32 _ManId;
        private Category _CategoryIdLookup;
        private Manufacturer _ManIdLookup;
        //private Unit _UnitIdLookup;
        private IList<Product> _Products = new List<Product>();

        public ProductName()
        {

        }

        public ProductName(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String ProdName 
         {
             get { return _ProdName; }
             set { _ProdName = value;}
         }

         public virtual System.String ProdDesc 
         {
             get { return _ProdDesc; }
             set { _ProdDesc = value;}
         }

         public virtual System.Int32 CategoryId 
         {
             get { return _CategoryId; }
             set { _CategoryId = value;}
         }

         public virtual System.Int32 ManId 
         {
             get { return _ManId; }
             set { _ManId = value;}
         }

         public virtual Category CategoryIdLookup
         {
             get { return _CategoryIdLookup; }
             set { _CategoryIdLookup = value;}
         }

         public virtual Manufacturer ManIdLookup
         {
             get { return _ManIdLookup; }
             set { _ManIdLookup = value;}
         }

         //public virtual Unit UnitIdLookup
         //{
         //    get { return _UnitIdLookup; }
         //    set { _UnitIdLookup = value;}
         //}

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
