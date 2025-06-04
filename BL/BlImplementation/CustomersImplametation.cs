using BlApi;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;

namespace BlImplementation
{
    internal class CustomersImplametation : ICustomers
    {

        private DalApi.IDal Customers_dal = DalApi.Factory.Get;

       public bool ifexist(int id)
        {
            try
            {
                Read(id);
                return true;
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("not exsist", ex);
            }
        }
        public int Create(BO.Customer customer)
        {
            try
            {
                return Customers_dal.customer.Create(ConvertCustomerDo(customer));
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_ExistException("coustomer exsist", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                Customers_dal.customer.Delete(id);
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("customer not exist", ex);
            }
        }
        public BO.Customer? Read(int id)
        {
            try
            {
                return BO.Tools.ConvertCustomerBO(Customers_dal.customer.Read(id));
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("customer not exist", ex);
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool>? filter)
        {
            try
            {
                return BO.Tools.ConvertCustomerBO(Customers_dal.customer.Read(doCustomer => filter(BO.Tools.ConvertCustomerBO(doCustomer))));
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("customer not exsist", ex);
            }
        }

        public List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {
                if (filter != null)
                    return Customers_dal.customer.ReadAll(doSale => filter(BO.Tools.ConvertCustomerBO(doSale))).Select(s => BO.Tools.ConvertCustomerBO(s)).ToList();
                else
                    return Customers_dal.customer.ReadAll().Select(s => BO.Tools.ConvertCustomerBO(s)).ToList();
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("customer not exsist", ex);
            }
        }

        public void Update(BO.Customer customer)
        {
            try
            {
                Customers_dal.customer.Update(BO.Tools.ConvertCustomerDo(customer));
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("customer not exsist", ex);
            }
        }
        public bool IfCustomerExist(int id)
        {
            try
            {
               Customers_dal.customer.Read(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
