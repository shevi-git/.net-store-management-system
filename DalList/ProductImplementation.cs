

namespace Dal;
using Do;
using DalApi;
using System.Collections.Generic;
using System.Reflection;

public class ProductImplementation : IProduct
{
    public int Create(Product? item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        try
        {
            Product? p = item with { Id = DataSource.Config.productCode };
            DataSource.products.Add(p);
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            return p.Id;

        }
        catch
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            throw new DalExist("exist product");
        }


    }

    public void Delete(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        Product? product = Read(id);
        DataSource.products.Remove(product);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
    }
    public Product? Read(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());

        Product? prod = DataSource.products.FirstOrDefault(t => t.Id == id);
        if (prod != null)
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            return prod;
        }
        else
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            throw new DalNotExist("Product does not exist.");
        }

    }

    public Product? Read(Func<Product, bool>? filter)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        throw new NotImplementedException();
    }

    public List<Product> ReadAll()
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        return new List<Product?>(DataSource.products);
    }

    public List<Product> ReadAll(Func<Product, bool>? filter = null)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        throw new NotImplementedException();
    }



    public void Update(Product item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        Delete(item.Id);
        DataSource.products.Add(item);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
    }
}
