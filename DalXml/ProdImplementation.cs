using DalApi;
using Do;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Dal
{
    internal class ProdImplementation : IProduct
    {
        static string filePath = @"../xml/products.xml";

        public int Create(Product t)
        {
            List<Product> list;

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                    list = (List<Product>)serializer.Deserialize(fs);
                }
            }
            else
            {
                list = new List<Product>();
            }
            int code = Config.ProductCode;
            list.Add(t with {Id = code });

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                serializer.Serialize(fs, list);
            }

            return code;
        }

        public void Delete(int id)
        {
            List<Product> list;

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                    list = (List<Product>)serializer.Deserialize(fs);
                }
            }
            else
            {
                throw new Exception("File not found");
            }

            Product toDelete = list.FirstOrDefault(p => p.Id == id);

            if (toDelete == null)
                throw new Exception("Product not found");

            list.Remove(toDelete);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                serializer.Serialize(fs, list);
            }
        }

        public Product? Read(int id)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Product file not found");

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                List<Product> list = (List<Product>)serializer.Deserialize(fs);

                return list.FirstOrDefault(p => p.Id == id);
            }
        }

        public Product? Read(Func<Product, bool>? filter)
        {
            if (filter == null)
                throw new ArgumentNullException(nameof(filter));

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Product file not found");

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                List<Product> list = (List<Product>)serializer.Deserialize(fs);

                return list.FirstOrDefault(filter);
            }
        }

        public List<Product> ReadAll(Func<Product, bool>? filter = null)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Product file not found");

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                List<Product> list = (List<Product>)serializer.Deserialize(fs);

                return filter == null ? list : list.Where(filter).ToList();
            }
        }

        public void Update(Product t)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Product file not found");

            List<Product> list;

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                list = (List<Product>)serializer.Deserialize(fs);
            }

            Product? existing = list.FirstOrDefault(p => p.Id == t.Id);
            if (existing == null)
                throw new Exception("Product not found");

            list.Remove(existing);

            list.Add(t);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                serializer.Serialize(fs, list);
            }
        }
    }
}
