using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface ICustomers
    {
       
        public bool IfCustomerExist(int id);
        int Create(Customer customer);
        Customer? Read(int id);
        Customer? Read(Func<Customer, bool>? filter);
        List<Customer> ReadAll(Func<Customer, bool>? filter = null);
        void Update(Customer customer);
        void Delete(int id);
        bool ifexist(int id);
    }
}
