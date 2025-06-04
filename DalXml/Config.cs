using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    static internal class Config
    {
        static private string nameFile = @"../xml/data-config.xml";
        const string PRODUCTCODE = "productCode";
        const string SALECODE = "saleCode";
        public static int ProductCode
        {
            get
            {
                XElement file = XElement.Load(nameFile);
                string productCodes = file.Element(PRODUCTCODE).Value;
                int product = int.Parse(productCodes);
                product++;

                file.Element(PRODUCTCODE).SetValue(product.ToString());
                file.Save(nameFile);

                return product;
            }
        }


        public static int SaleCode
        {
            get
            {
                XElement file = XElement.Load(nameFile);
                string saleCodeString = file.Element(SALECODE).Value;
                int saleCode = int.Parse(saleCodeString);
                saleCode++;

                file.Element(SALECODE).SetValue(saleCode.ToString());
                file.Save(nameFile);

                return saleCode;
            }
        }


    }
}
