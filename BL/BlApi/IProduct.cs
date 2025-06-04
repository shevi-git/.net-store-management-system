using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IProduct
    {
        int Create(Product product);
        Product? Read(int id);
        Product? Read(Func<Product, bool>? filter);
        List<Product> ReadAll(Func<Product, bool>? filter = null);
        void Update(Product product);
        void Delete(int id);
        List<SaleInPrduct> GetActiveSales(BO.PrductInOrder product, bool priority);
    }
}
