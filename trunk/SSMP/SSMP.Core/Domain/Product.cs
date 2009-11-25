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
        private System.Int32? _PurchasePrice;
        private System.Int32? _SalePrice;
        private System.Int32? _Discount;
        private System.Int32 _StatusId;
        private System.Int64 _BillPurchaseId;
        private System.Int64? _BillSaleId;
        private System.Int32 _UnitId;
        private System.String _Description;
        private BillPurchase _BillPurchaseIdLookup;
        private BillSale _BillSaleIdLookup;
        private ProductName _ProductNameIdLookup;
        private ProductStatus _ProductStatusIdLookup;
        private Unit _UnitIdLookup;

        //Search property
        private String _SearchProductName;
        private String _SearchManufacturerName;
        private String _SearchProviderName;
        private System.DateTime? _MfgDateFrom;
        private System.DateTime? _MfgDateTo;
        private System.DateTime? _ExpDateFrom;
        private System.DateTime? _ExpDateTo;
        private Int32? _PurchasePriceFrom;
        private Int32? _PurchasePriceTo;
        private Int32? _PurchasePriceCompare;        
        private Int32? _SalePriceFrom;
        private Int32? _SalePriceTo;
        private Int32? _SalePriceCompare;       
        private Int32? _DiscountFrom;        
        private Int32? _DiscountTo;
        private Int32? _DiscountCompare;        
        private Int32? _SearchCategoryID;        
        private Int32? _SearchManufacturerID;        
        private Int32? _SearchCountryID;                

        public Product()
        {

        }

        public Product(System.Int64 id)
        {
            base.ID = id;
        }

        public virtual System.DateTime? MfgDateFrom
        {
            get { return _MfgDateFrom; }
            set { _MfgDateFrom = value; }
        }

        public virtual System.DateTime? MfgDateTo
        {
            get { return _MfgDateTo; }
            set { _MfgDateTo = value; }
        }

        public virtual System.DateTime? ExpDateFrom
        {
            get { return _ExpDateFrom; }
            set { _ExpDateFrom = value; }
        }

        public virtual System.DateTime? ExpDateTo
        {
            get { return _ExpDateTo; }
            set { _ExpDateTo = value; }
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

        public virtual System.Int32? PurchasePrice
        {
             get { return _PurchasePrice; }
             set { _PurchasePrice = value;}
         }

        public virtual System.Int32? SalePrice
        {
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

        public virtual System.String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public virtual BillPurchase BillPurchaseIdLookup{
            get { return _BillPurchaseIdLookup; }
            set { _BillPurchaseIdLookup = value;}
        }

        public virtual BillSale BillSaleIdLookup{
            get { return _BillSaleIdLookup; }
            set { _BillSaleIdLookup = value;}
        }

        public virtual String SearchProviderName
        {
            get { return _SearchProviderName; }
            set { _SearchProviderName = value; }
        }
        public virtual String SearchProductName
        {
            get { return _SearchProductName; }
            set { _SearchProductName = value; }
        }
        public virtual String SearchManufacturerName
        {
            get { return _SearchManufacturerName; }
            set { _SearchManufacturerName = value; }
        }

        public virtual Int32? PurchasePriceFrom
        {
            get { return _PurchasePriceFrom; }
            set { _PurchasePriceFrom = value; }
        }

        public virtual Int32? PurchasePriceTo
        {
            get { return _PurchasePriceTo; }
            set { _PurchasePriceTo = value; }
        }

        public virtual Int32? SalePriceFrom
        {
            get { return _SalePriceFrom; }
            set { _SalePriceFrom = value; }
        }

        public virtual Int32? SalePriceTo
        {
            get { return _SalePriceTo; }
            set { _SalePriceTo = value; }
        }

        public virtual Int32? SearchManufacturerID
        {
            get { return _SearchManufacturerID; }
            set { _SearchManufacturerID = value; }
        }

        public virtual Int32? SearchCountryID
        {
            get { return _SearchCountryID; }
            set { _SearchCountryID = value; }
        }

        public virtual Int32? SearchCategoryID
        {
            get { return _SearchCategoryID; }
            set { _SearchCategoryID = value; }
        }

        public virtual Int32? DiscountFrom
        {
            get { return _DiscountFrom; }
            set { _DiscountFrom = value; }
        }

        public virtual Int32? DiscountTo
        {
            get { return _DiscountTo; }
            set { _DiscountTo = value; }
        }

        public virtual Int32? PurchasePriceCompare
        {
            get { return _PurchasePriceCompare; }
            set { _PurchasePriceCompare = value; }
        }

        public virtual Int32? SalePriceCompare
        {
            get { return _SalePriceCompare; }
            set { _SalePriceCompare = value; }
        }

        public virtual Int32? DiscountCompare
        {
            get { return _DiscountCompare; }
            set { _DiscountCompare = value; }
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
