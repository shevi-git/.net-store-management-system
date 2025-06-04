using DalApi;
using Do;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        const string NUMIDENTIFY = "NumIdentify";
        const string NUMIDENTIFYPRODUCT = "NumIdentifyProduct";
        const string COUNTFORSALE = "CountForSale";
        const string PRICEINSALE = "PriceInSale";
        const string ALLCUSTOMERS = "AllCustomers";
        const string DATESTARTSALE = "DateStartSale";
        const string DATEENDSALE = "DateEndSale";

        static string filePath = @"../xml/sale.xml";

        public int Create(Sale t)
        {
            XElement root;

            if (File.Exists(filePath))
                root = XElement.Load(filePath);
            else
                root = new XElement("Sales");

            int code = Config.SaleCode;

            XElement saleElement = new XElement("Sale",
                new XElement(NUMIDENTIFY, code),
                new XElement(NUMIDENTIFYPRODUCT, t.NumIdentifyProduct),
                new XElement(COUNTFORSALE, t.CountForSale),
                new XElement(PRICEINSALE, t.PriceInSale),
                new XElement(ALLCUSTOMERS, t.AllCustomers),
                new XElement(DATESTARTSALE, t.DateStartSale),
                new XElement(DATEENDSALE, t.DateEndSale)
            );

            root.Add(saleElement);
            root.Save(filePath);

            return code;
        }

        public void Delete(int id)
        {
            XElement root = XElement.Load(filePath);

            XElement saleToDelete = root.Elements("Sale")
                                        .FirstOrDefault(e => (int)e.Element(NUMIDENTIFY) == id);

            if (saleToDelete == null)
                throw new Exception("Sale not found");

            saleToDelete.Remove();
            root.Save(filePath);
        }

        public Sale? Read(int id)
        {
            XElement root = XElement.Load(filePath);

            XElement saleElement = root.Elements("Sale")
                                       .FirstOrDefault(e => (int)e.Element(NUMIDENTIFY) == id);

            if (saleElement == null)
                return null;

            return XElementToSale(saleElement);
        }

        public Sale? Read(Func<Sale, bool>? filter)
        {
            if (filter == null)
                throw new ArgumentNullException(nameof(filter));

            XElement root = XElement.Load(filePath);

            return root.Elements("Sale")
                       .Select(XElementToSale)
                       .FirstOrDefault(filter);
        }

        public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            XElement root = XElement.Load(filePath);

            var sales = root.Elements("Sale")
                            .Select(XElementToSale)
                            .ToList();

            return filter == null ? sales : sales.Where(filter).ToList();
        }

        public void Update(Sale t)
        {
            XElement root = XElement.Load(filePath);

            XElement saleToUpdate = root.Elements("Sale")
                                        .FirstOrDefault(e => (int)e.Element(NUMIDENTIFY) == t.NumIdentify);

            if (saleToUpdate == null)
                throw new Exception("Sale not found");

            saleToUpdate.Element(NUMIDENTIFYPRODUCT)?.SetValue(t.NumIdentifyProduct);
            saleToUpdate.Element(COUNTFORSALE)?.SetValue(t.CountForSale);
            saleToUpdate.Element(PRICEINSALE)?.SetValue(t.PriceInSale);
            saleToUpdate.Element(ALLCUSTOMERS)?.SetValue(t.AllCustomers);
            saleToUpdate.Element(DATESTARTSALE)?.SetValue(t.DateStartSale);
            saleToUpdate.Element(DATEENDSALE)?.SetValue(t.DateEndSale);

            root.Save(filePath);
        }

        private Sale XElementToSale(XElement e)
        {
            return new Sale
            {
                NumIdentify = (int)e.Element(NUMIDENTIFY),
                NumIdentifyProduct = (int)e.Element(NUMIDENTIFYPRODUCT),
                CountForSale = (int)e.Element(COUNTFORSALE),
                PriceInSale = (int)e.Element(PRICEINSALE),
                AllCustomers = (bool)e.Element(ALLCUSTOMERS),
                DateStartSale = (DateTime)e.Element(DATESTARTSALE),
                DateEndSale = (DateTime)e.Element(DATEENDSALE)
            };
        }

        private static void CreateFile()
        {
            XElement salesXml = new XElement("Sales");

            salesXml.Add(new XElement("Sale",
                new XElement(NUMIDENTIFY, 1),
                new XElement(NUMIDENTIFYPRODUCT, 101),
                new XElement(COUNTFORSALE, 2),
                new XElement(PRICEINSALE, 100),
                new XElement(ALLCUSTOMERS, true),
                new XElement(DATESTARTSALE, DateTime.Now),
                new XElement(DATEENDSALE, DateTime.Now.AddMonths(1))
            ));

            salesXml.Add(new XElement("Sale",
                new XElement(NUMIDENTIFY, 2),
                new XElement(NUMIDENTIFYPRODUCT, 102),
                new XElement(COUNTFORSALE, 3),
                new XElement(PRICEINSALE, 200),
                new XElement(ALLCUSTOMERS, false),
                new XElement(DATESTARTSALE, DateTime.Now.AddMonths(1)),
                new XElement(DATEENDSALE, DateTime.Now.AddMonths(2))
            ));

            salesXml.Save(filePath);
        }
    }
}
