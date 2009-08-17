using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// Product object for NHibernate mapped table Product.
    /// </summary>
    [Serializable]
    public class Product : DomainObject<System.Int64>
    {
        private System.DateTime? _MfgDate;
        private System.DateTime? _ExpDate;
        private System.Int32? _ProductNameId;
        private System.String _PurchasePrice;
        private System.String _SalePrice;
        private System.Int32? _Discount;
        private System.Int32 _StatusId;
        private System.Int64 _BillPurchaseId;
        private System.Int64? _BillSaleId;
        private System.Int32 _UnitId;
        private BillPurchase _BillPurchaseIdLookup;
        private BillSale _BillSaleIdLookup;

        private ProductName _ProductNameIdLookup;


        private ProductStatus _ProductStatusIdLookup;

        private Unit _UnitIdLookup;


        public Product()
        {
        }

        public Product(System.Int64 id)
        {
            base.ID = id;
        }

        public virtual ProductName ProductNameIdLookup
        {
            get { return _ProductNameIdLookup; }
            set { _ProductNameIdLookup = value; }
        }
        public virtual ProductStatus ProductStatusIdLookup
        {
            get { return _ProductStatusIdLookup; }
            set { _ProductStatusIdLookup = value; }
        }
        public virtual Unit UnitIdLookup
        {
            get { return _UnitIdLookup; }
            set { _UnitIdLookup = value; }
        }

         public virtual System.DateTime? MfgDate {
             get { return _MfgDate; }
             set { _MfgDate = value;}
         }

         public virtual System.DateTime? ExpDate {
             get { return _ExpDate; }
             set { _ExpDate = value;}
         }

         public virtual System.Int32? ProductNameId {
             get { return _ProductNameId; }
             set { _ProductNameId = value;}
         }

         public virtual System.String PurchasePrice {
             get { return _PurchasePrice; }
             set { _PurchasePrice = value;}
         }

         public virtual System.String SalePrice {
             get { return _SalePrice; }
             set { _SalePrice = value;}
         }

         public virtual System.Int32? Discount {
             get { return _Discount; }
             set { _Discount = value;}
         }

         public virtual System.Int32 StatusId {
             get { return _StatusId; }
             set { _StatusId = value;}
         }

         public virtual System.Int64 BillPurchaseId {
             get { return _BillPurchaseId; }
             set { _BillPurchaseId = value;}
         }

         public virtual System.Int64? BillSaleId {
             get { return _BillSaleId; }
             set { _BillSaleId = value;}
         }

        public virtual System.Int32 UnitId
        {
            get { return _UnitId; }
            set { _UnitId = value; }
        }

         public virtual BillPurchase BillPurchaseIdLookup{
             get { return _BillPurchaseIdLookup; }
             set { _BillPurchaseIdLookup = value;}
         }

         public virtual BillSale BillSaleIdLookup{
             get { return _BillSaleIdLookup; }
             set { _BillSaleIdLookup = value;}
         }
        



        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
