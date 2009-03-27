using System;
using System.Collections.Generic;

namespace SSMP.Core.DataInterfaces
{
    public interface IDaoFactory
    {
        IActionDao GetActionDao();
        IActionDetailDao GetActionDetailDao();
        IBillPurchaseDao GetBillPurchaseDao();
        IBillSaleDao GetBillSaleDao();
        ICategoryDao GetCategoryDao();
        ICountryDao GetCountryDao();
        ICustomerDao GetCustomerDao();
        IManufacturerDao GetManufacturerDao();
        IProductDao GetProductDao();
        IProductNameDao GetProductNameDao();
        IProductStatusDao GetProductStatusDao();
        IProviderDao GetProviderDao();
        IReferenceDataDao GetReferenceDataDao();
        IReferenceGroupDao GetReferenceGroupDao();
        IUnitDao GetUnitDao();
        IUserRoleDao GetUserRoleDao();
        IUserDao GetUserDao();
        IUserStatusDao GetUserStatusDao();
        IUserTitleDao GetUserTitleDao();
    }
}
