using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class BL : IBl
    {
        public ICustomers Customers => new CustomersImplametation();

        public ISale Sale => new SaleImplametation();

        public IProduct Product => new ProductImplametation();

        public IOrder Order { get => new OrderImplametation(); set => new OrderImplametation(); }
    }
}
