using DalApi;
using Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalXml : IDal
    {
       
        public IProduct product => new ProdImplementation();

        public ISale sale =>  new SaleImplementation();

        public ICustomer customer =>  new CustImplementation();
        private DalXml() { }
        private static readonly DalXml instance =new DalXml();
        public static DalXml Instance => instance;


    }
}
