using System;
using System.Collections.Generic;
using SSMP.Core.DataInterfaces;
using SSMP.Data.Dao;

namespace SSMP.Data
{
    public class NHibernateDaoFactory : IDaoFactory
    {
        public IActionDao GetActionDao()
        {
            return new ActionDao();
        }
        public IActionDetailDao GetActionDetailDao()
        {
            return new ActionDetailDao();
        }
        public IBillPurchaseDao GetBillPurchaseDao()
        {
            return new BillPurchaseDao();
        }
        public IBillSaleDao GetBillSaleDao()
        {
            return new BillSaleDao();
        }
        public ICategoryDao GetCategoryDao()
        {
            return new CategoryDao();
        }
        public ICountryDao GetCountryDao()
        {
            return new CountryDao();
        }
        public ICustomerDao GetCustomerDao()
        {
            return new CustomerDao();
        }
        public IManufacturerDao GetManufacturerDao()
        {
            return new ManufacturerDao();
        }
        public IProductDao GetProductDao()
        {
            return new ProductDao();
        }
        public IProductNameDao GetProductNameDao()
        {
            return new ProductNameDao();
        }
        public IProductStatusDao GetProductStatusDao()
        {
            return new ProductStatusDao();
        }
        public IProviderDao GetProviderDao()
        {
            return new ProviderDao();
        }
        public IReferenceDataDao GetReferenceDataDao()
        {
            return new ReferenceDataDao();
        }
        public IReferenceGroupDao GetReferenceGroupDao()
        {
            return new ReferenceGroupDao();
        }
        public IUnitDao GetUnitDao()
        {
            return new UnitDao();
        }
        public IUserRoleDao GetUserRoleDao()
        {
            return new UserRoleDao();
        }
        public IUserDao GetUserDao()
        {
            return new UserDao();
        }
        public IUserStatusDao GetUserStatusDao()
        {
            return new UserStatusDao();
        }
        public IUserTitleDao GetUserTitleDao()
        {
            return new UserTitleDao();
        }
    }
}
