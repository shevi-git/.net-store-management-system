using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;
using DalApi;
using Do;

namespace BlImplementation
{
    internal class OrderImplametation : IOrder
    {
        private DalApi.IDal Customers_dal = DalApi.Factory.Get;

        public List<SaleInPrduct> AddProductToOrder(Order order, int id, int count)
        {
            Do.Product product = Customers_dal.product.Read(id);
            if (product == null)
                throw new BL_NoExistException("המוצר לא קיים");

            var existing = order.productlist.FirstOrDefault(x => x.id == id);
            if (existing != null)
            {
                existing.count += count;
                SearchSaleForProduct(existing, order.priority);
                CalcTotalPriceForProduct(existing);
                CalcTotalPrice(order);
                return existing.salelist;
            }
            else
            {
                if (product.CountStock < count)
                    throw new BL_NoExistException("אין מספיק מלאי");

                var newProductInOrder = new BO.PrductInOrder(
                id,
                    product.Name,
                    product.Price,
                    count,
                    new List<SaleInPrduct>(),
                    0
                );

                order.productlist.Add(newProductInOrder);
                SearchSaleForProduct(newProductInOrder, order.priority);
                CalcTotalPriceForProduct(newProductInOrder);
                CalcTotalPrice(order);
                return newProductInOrder.salelist;
            }
        }


        public void CalcTotalPrice(BO.Order order)
        {
            order.price = order.productlist.Sum(p => p.price);
        }



        public void CalcTotalPriceForProduct(PrductInOrder prductInOrder)
        {
            int remainingCount = prductInOrder.count;
            double totalPrice = 0;
            var applicableSales = new List<SaleInPrduct>();

            foreach (var sale in prductInOrder.salelist.OrderBy(s => s.count))
            {
                while (remainingCount >= sale.count)
                {
                    totalPrice += sale.price;
                    remainingCount -= sale.count;
                    applicableSales.Add(sale);
                }

                if (remainingCount == 0)
                    break;
            }

            if (remainingCount > 0)
            {
                totalPrice += remainingCount * prductInOrder.price; 
            }

            prductInOrder.salelist = applicableSales;
            prductInOrder.finalPrice = totalPrice; 
        }


        public void DoOrder(Order order)
        {
            Do.Product product;
            foreach (PrductInOrder item in order.productlist)
            {
                product = Customers_dal.product.Read(item.id);
                Customers_dal.product.Update(product with { CountStock = product.CountStock - item.count });
            }
        }

        public void SearchSaleForProduct(PrductInOrder productInOrder, bool priority)
        {
            productInOrder.salelist = Customers_dal.sale.ReadAll(s => s.NumIdentifyProduct == productInOrder.id && s.DateStartSale <= DateTime.Now && s.DateEndSale >= DateTime.Now
            && s.CountForSale >= productInOrder.count && (priority || s.AllCustomers)).Select(s => new SaleInPrduct(s.NumIdentifyProduct, s.CountForSale, s.PriceInSale, s.AllCustomers)).ToList();
        }

    }
}
