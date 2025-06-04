using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{

    public class Customer
    {
        public int Tz { get; set; }
        public string NameCustomers { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
       

        public Customer(int tz, string NameCustomers,string Address,int Phone)
        { 
            this.Tz = tz;
            this.NameCustomers = NameCustomers;
            this.Address = Address;
            this.Phone = Phone;
        }


    }
}
