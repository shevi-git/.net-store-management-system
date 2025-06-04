using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalList : IDal
    {
        public DalList Instance { get; }=new DalList();
        public IProduct product => new ProductImplementation();

        public ISale sale => new SaleImplementation();

        public ICustomer customer => new CustomersImplementation();

        private DalList() { }
    }
   
}
