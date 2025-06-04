
using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class SaleImplametation : ISale
    {
        private DalApi.IDal Sale_dal = DalApi.Factory.Get;

        public int Create(BO.Sale sale)
        {
            try
            {
                return Sale_dal.sale.Create(BO.Tools.ConvertSaleDo(sale));
            }
            catch (Do.DalExist ex)
            {
                throw new BO.BL_ExistException("sale not exsist", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                Sale_dal.sale.Delete(id);
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("sale not exsist", ex);
            }

        }

        public BO.Sale? Read(int id)
        {
            try
            {
                return BO.Tools.ConvertSaleBO(Sale_dal.sale.Read(id));
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("k", ex);
            }

        }

        public BO.Sale? Read(Func<BO.Sale, bool>? filter)
        {
            try
            {
                return BO.Tools.ConvertSaleBO(Sale_dal.sale.Read(doSale => filter(BO.Tools.ConvertSaleBO(doSale))));
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("sale not exsist", ex);
            }
        }


        public List<BO.Sale> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                if (filter != null)
                    return Sale_dal.sale.ReadAll(doSale => filter(BO.Tools.ConvertSaleBO(doSale))).Select(s => BO.Tools.ConvertSaleBO(s)).ToList();
                else
                    return Sale_dal.sale.ReadAll().Select(s => BO.Tools.ConvertSaleBO(s)).ToList();
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("sale not exsist", ex);
            }
        }

        public void Update(BO.Sale sale)
        {
            try
            {
                Sale_dal.sale.Update(BO.Tools.ConvertSaleDo(sale));
            }
            catch (Do.DalNotExist ex)
            {
                throw new BO.BL_NoExistException("sale not exsist", ex);
            }
        }
    }
}
