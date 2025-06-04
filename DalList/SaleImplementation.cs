
namespace Dal;
using Do;
using DalApi;
using System.Collections.Generic;
using System.Reflection;

public class SaleImplementation : ISale
{
    public int Create(Sale? item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        bool sale = DataSource.sales.Any(t => t.NumIdentify == item.NumIdentify);
        if (!sale)
        {
            DataSource.sales.Add(item);
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            return item.NumIdentify;
        }
        else
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            throw new DalExist("exist sale");

        }

    }

    public void Delete(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        Sale? sale = Read(id);
        DataSource.sales.Remove(sale);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());

    }
    public Sale? Read(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        Sale? sale = DataSource.sales.FirstOrDefault(t => t.NumIdentify == id);
        if (sale != null)
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            return sale;
        }
        else
        {
            throw new DalNotExist("Product does not exist");
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        }

    }
    public Sale? Read(Func<Sale, bool>? filter)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        return DataSource.sales.FirstOrDefault(filter);
    }

    public List<Sale?> ReadAll()
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        return new List<Sale?>(DataSource.sales);
    }
    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        if (filter == null)
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            return DataSource.sales;
        }
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        return DataSource.sales.Where((item) => filter(item)).ToList();
    }

    public void Update(Sale? item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        Delete(item.NumIdentify);
        DataSource.sales.Add(item);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
    }
}
