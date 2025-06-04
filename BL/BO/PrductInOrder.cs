using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class PrductInOrder
    {
        private List<SaleInPrduct> saleInPrducts;
        private int v;

        public PrductInOrder(int id, string name, double price, int count, List<SaleInPrduct> saleInPrducts, int v)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.count = count;
            this.saleInPrducts = saleInPrducts;
            this.v = v;
        }

        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public List<BO.SaleInPrduct> salelist { get; set; }
        public double finalPrice { get; set; }



    }
}
