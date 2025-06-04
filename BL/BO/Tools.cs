using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal static class Tools

    {
        public static BO.Customer ConvertCustomerBO(Do.Customer customer)
        {
            return new BO.Customer(customer.Tz, customer.NameCustomers, customer.Address, customer.Phone);
        }
        public static BO.Product ConvertProductBO(Do.Product product)
        {
            return new BO.Product(product.Id, product.Name, (BO.Category)product.Category, product.Price, product.CountStock);
        }
        public static BO.Sale ConvertSaleBO(Do.Sale sale)
        {
            return new BO.Sale(sale.NumIdentify, sale.NumIdentifyProduct, sale.CountForSale, sale.PriceInSale, sale.AllCustomers, sale.DateStartSale, sale.DateEndSale);
        }
        public static Do.Customer ConvertCustomerDo(BO.Customer customer)
        {
            return new Do.Customer(customer.Tz, customer.NameCustomers, customer.Address, customer.Phone);
        }
        public static Do.Product ConvertProductDo(BO.Product product)
        {
            return new Do.Product(product.Id, product.Name,(Do.Category) product.Category , product.Price, product.CountStock);

        }
        public static Do.Sale ConvertSaleDo(BO.Sale sale)
        {
            return new Do.Sale(sale.NumIdentify, sale.NumIdentifyProduct, sale.CountForSale, sale.PriceInSale, sale.AllCustomers, sale.DateStartSale, sale.DateEndSale);

        }

        public static string ToStringProperty<T>(this T t)
        {
            string str = "";
            Type Ttype = t.GetType();
            PropertyInfo[] info = Ttype.GetProperties();
            foreach (PropertyInfo item in info)
            {
                if (typeof(IEnumerable).IsAssignableFrom(item.PropertyType) && item.PropertyType != typeof(string))
                {
                    IEnumerable collection = item.GetValue(t) as IEnumerable;
                    foreach (var x in collection)
                    {
                        str += x.ToStringProperty();
                    }
                }
                else
                    str += string.Format("{0,-15} {1,-15}\n", item.Name, item.GetValue(t, null));

            }
            return str;
        }
    }
}
