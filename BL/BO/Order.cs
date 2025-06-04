using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool priority { get; set; }
        public List<BO.PrductInOrder> productlist { get; set; }
        public double price { get; set; }

        public Order(bool existClient,List<BO.PrductInOrder>alistPIO,double x) 
        {
            priority = existClient;
            productlist = alistPIO;
            price = x;
        }
        public Order() { }
    }
}
