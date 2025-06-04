using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{

    public class Sale
    {
        public int NumIdentify { get; set; }
        public int NumIdentifyProduct { get; set; }
        public int CountForSale { get; set; }
        public int PriceInSale { get; set; }
        public bool AllCustomers { get; set; }
        public DateTime DateStartSale { get; set; }
        public DateTime DateEndSale { get; set; }



        public Sale(int NumIdentify, int NumIdentifyProduct, int CountForSale, int PriceInSale, bool AllCustomers, DateTime DateStartSale, DateTime DateEndSale)
        {
            this.NumIdentify = NumIdentify;
            this.NumIdentifyProduct = NumIdentifyProduct;
            this.CountForSale = CountForSale;
            this.PriceInSale = PriceInSale;
            this.AllCustomers = AllCustomers;
            this.DateStartSale = DateStartSale;
            this.DateEndSale = DateEndSale;

        }
        public Sale() { }
    }



}

