using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInPrduct
    {
        public int id { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public bool ifAllToSale { get; set; }

        public SaleInPrduct(int id, int count, double price , bool ifAllToSale)
        { 
            this.id = id;
            this.count = count;
            this.price = price;
            this.ifAllToSale= ifAllToSale;
        }

    }
}
