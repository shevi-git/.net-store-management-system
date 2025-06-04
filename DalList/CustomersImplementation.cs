

namespace Dal;
using Do;
using DalApi;
using System.Collections.Generic;
using System.Reflection;

public class CustomersImplementation : ICustomer
{
    public int Create(Customer? item)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        bool tz = DataSource.customers.Any(t => t.Tz == item.Tz);
        if (!tz)
        {
            DataSource.customers.Add(item);
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            return item.Tz;
        }
        else
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            throw new DalExist("exist customer");

        }
    }

    public void Delete(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        Customer? customer = Read(id);
        DataSource.customers.Remove(customer);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
    }

    public Customer? Read(int id)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        Customer cust = DataSource.customers.FirstOrDefault(t => t.Tz == id);

        if (cust != null)
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            return cust;
        }

        else
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            throw new DalNotExist("Customer does not exist");

        }

    }
    public Customer? Read(Func<Customer, bool>? filter)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        if (filter != null)
        {
            var customer = DataSource.customers.FirstOrDefault(c => filter(c));
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            return customer;
        }
        else
        {
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
            throw new DalExist("Customer does not exist");

        }


    }

    public List<Customer?> ReadAll()
    {
        return new List<Customer?>(DataSource.customers);
    }

    public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        throw new NotImplementedException();
    }

    public void Update(Customer? item)
    {
        Delete(item.Tz);
        DataSource.customers.Add(item);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
    }
}
