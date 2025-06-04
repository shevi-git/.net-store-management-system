using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class ProductImplametation : IProduct
    {
        private DalApi.IDal Product_dal = DalApi.Factory.Get;
        public List<BO.SaleInPrduct> GetActiveSales(BO.PrductInOrder product, bool priority)
        {
            return Product_dal.sale.ReadAll(s => s.NumIdentifyProduct == product.id && s.DateStartSale <= DateTime.Now && s.DateEndSale >= DateTime.Now
            && s.CountForSale >= product.count && (priority || s.AllCustomers)).Select(s => new SaleInPrduct(s.NumIdentifyProduct, s.CountForSale, s.PriceInSale, s.AllCustomers)).ToList();
        }

        public int Create(BO.Product product)
        {
            try
            {
                return Product_dal.product.Create(BO.Tools.ConvertProductDo(product));
            }
            catch (Do.DalExist ex) 
            { 
                throw new BO.BL_ExistException("product exsist", ex); 
            }
        }

        public void Delete(int id)
        {
            try
            {
                Product_dal.product.Delete(id);
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("product not exist", ex);
            }
        }

        public BO.Product? Read(int id)
        {
            try
            {
                return BO.Tools.ConvertProductBO(Product_dal.product.Read(id));
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("product not exsist", ex);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool>? filter)
        {
            try
            {
                return BO.Tools.ConvertProductBO(Product_dal.product.Read(doProduct => filter(BO.Tools.ConvertProductBO(doProduct))));
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("product not exsist", ex);
            }
        }



        public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                if (filter != null)
                    return Product_dal.product.ReadAll(doProduct => filter(BO.Tools.ConvertProductBO(doProduct))).Select(s => BO.Tools.ConvertProductBO(s)).ToList();
                else
                    return Product_dal.product.ReadAll().Select(s => BO.Tools.ConvertProductBO(s)).ToList();
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("product not exsist", ex);
            }
        }

        public void Update(BO.Product product)
        {
            try
            {
                Product_dal.product.Update(BO.Tools.ConvertProductDo(product));
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("product not exsist", ex);
            }
        }
    }
}
