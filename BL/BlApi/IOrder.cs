using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IOrder
    {
        public List<BO.SaleInPrduct> AddProductToOrder(Order order, int id, int count);
        public void CalcTotalPriceForProduct(BO.PrductInOrder prductInOrder);
        public void CalcTotalPrice(BO.Order order);
        public void DoOrder(BO.Order order);
        public void SearchSaleForProduct(BO.PrductInOrder productInOrder, bool priority);

    }
}
