
using DalApi;
using Do;
using System.Xml.Serialization;

namespace Dal;


internal class CustImplementation : ICustomer
{

   static string filePath = @"../xml/customers.xml";
    public int Create(Customer t)
    {
       

        List<Customer> list;

        if (File.Exists(filePath))
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
                list = (List<Customer>)serializer.Deserialize(fs);
            }
        }
        else
        {
            list = new List<Customer>();
        }

        if (list.Any(c => c.Tz == t.Tz))
            throw new Exception("Customer already exists");

        list.Add(t);

        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            serializer.Serialize(fs, list);
        }

        return 1;
    }


    public void Delete(int id)
    {
        

        List<Customer> list;

        if (File.Exists(filePath))
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
                list = (List<Customer>)serializer.Deserialize(fs);
            }
        }
        else
        {
            throw new Exception("File not found");
        }

        Customer toDelete = list.FirstOrDefault(c => c.Tz == id);

        if (toDelete == null)
            throw new Exception("Customer not found");

        list.Remove(toDelete);

        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            serializer.Serialize(fs, list);
        }
    }


    public Customer? Read(int id)
    {

        if (!File.Exists(filePath))
            throw new FileNotFoundException("Customer file not found");

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            List<Customer> list = (List<Customer>)serializer.Deserialize(fs);

            return list.FirstOrDefault(c => c.Tz == id);
        }
    }


    public Customer? Read(Func<Customer, bool>? filter)
    {
        if (filter == null)
            throw new ArgumentNullException(nameof(filter));


        if (!File.Exists(filePath))
            throw new FileNotFoundException("Customer file not found");

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            List<Customer> list = (List<Customer>)serializer.Deserialize(fs);

            return list.FirstOrDefault(filter);
        }
    }


    public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    {
        

        if (!File.Exists(filePath))
            throw new FileNotFoundException("Customer file not found");

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            List<Customer> list = (List<Customer>)serializer.Deserialize(fs);

            return filter == null ? list : list.Where(filter).ToList();
        }
    }


    public void Update(Customer t)
    {

        if (!File.Exists(filePath))
            throw new FileNotFoundException("Customer file not found");

        List<Customer> list;

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            list = (List<Customer>)serializer.Deserialize(fs);
        }

        Customer? existing = list.FirstOrDefault(c => c.Tz == t.Tz);
        if (existing == null)
            throw new Exception("Customer not found");

        list.Remove(existing);

        list.Add(t);

        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            serializer.Serialize(fs, list);
        }
    }

}
