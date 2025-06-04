

namespace Dal;

using DalApi;
using Do;

internal static class DataSource
{
    static internal List<Customer?> customers = new List<Customer?>();
    static internal List<Product?> products = new List<Product?>();
    static internal List<Sale?> sales = new List<Sale?>();

    static internal class Config
    {
        internal const int productMinCode = 0;
        internal const int saleMinCode = 0;

        private static int producIndex = productMinCode;
        private static int saleIndex = saleMinCode;


        public static int productCode
        {
            get { return producIndex++; }
        }

        public static int saleCode
        {
            get { return saleIndex++; }
        }

    }


}






