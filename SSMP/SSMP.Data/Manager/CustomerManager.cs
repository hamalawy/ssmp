using System;
using System.Collections.Generic;
using System.Text;
using SSMP.Core.Domain;
using SSMP.Core.DataInterfaces;
using SSMP.Core.Utils;
using log4net;
using SSMP.Data.LogUtils;

namespace SSMP.Data.Manager
{
    public class CustomerManager : IManager<Customer, System.Int32>
    {
        private ICustomerDao customerDao;
        private static readonly ILog logger = LogManager.GetLogger(typeof(CustomerManager));

        public CustomerManager()
        {
            const string LOCATION = "CustomerManager()";
            logger.Debug(LOCATION + LogConstants.BEGIN);

            IDaoFactory daoFactory = new NHibernateDaoFactory();
            customerDao = daoFactory.GetCustomerDao();

            logger.Debug(LOCATION + LogConstants.SEPARATOR + "DaoFactory create successfully");
            logger.Debug(LOCATION + LogConstants.END);
        }

        public Customer GetById(System.Int32 Id, bool shouldLock)
        {
            return customerDao.GetById(Id, shouldLock);
        }

        public List<Customer> GetAll()
        {
            return customerDao.GetAll();
        }

        public List<Customer> GetByExample(Customer exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Customer GetUniqueByExample(Customer exampleInstance, params string[] propertiesToExclude)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Customer Save(Customer entity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Customer SaveOrUpdate(Customer entity)
        {
            try
            {
                if (entity != null)
                {
                    customerDao.SaveOrUpdate(entity);
                    customerDao.CommitChanges();
                }
                else
                {
                    throw new Exception("Customer entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Delete(Customer entity)
        {
            try
            {
                if (entity != null)
                {
                    //entity.CustomerTitleIdLookup = null;
                    //entity.CustomerTitleId = null;
                    //customerDao.CommitChanges();
                    //entity.CountryIdLookup = null;
                    customerDao.Delete(entity);
                    customerDao.CommitChanges();
                }
                else
                {
                    throw new Exception("Customer entity cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsExist(Customer entity)
        {
            Customer userObj = customerDao.GetById(entity.ID, false);

            if (userObj != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SearchResult<Customer> GetByExampleAndPaging(Customer exampleInstance, SearchParam searchParam)
        {
            SearchResult<Customer> searchResult;

            try
            {
                searchResult = customerDao.GetByExampleAndPaging(exampleInstance, searchParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchResult;
        }

        public SearchResult<Customer> GetCustomerListByParam(Customer entity, SearchParam searcParam)
        {
            SearchResult<Customer> searchResult = null;
            
            try
            {
                searchResult = customerDao.GetCustomerListByParam(entity, searcParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return searchResult;
        }
    }
}
