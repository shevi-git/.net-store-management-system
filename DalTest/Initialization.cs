

namespace DalTest;
using Do;
using DalApi;
using System.Reflection;

public static class Initialization
{
    private static IDal s_dal = DalApi.Factory.Get;


    public static void creatSale()
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        s_dal.sale.Create(new Sale(100,200,5,0,true,new DateTime(1/11/2024),new DateTime(1/1/2025)));
        s_dal.sale.Create(new Sale(101,200,5,0,false,new DateTime(1/3/2025),new DateTime(1/4/2025)));
        s_dal.sale.Create(new Sale(102,200,5,0,false,new DateTime(1/5/2025),new DateTime(1/7/2025)));
        s_dal.sale.Create(new Sale(103,200,5,0,true,new DateTime(1/2/2025),new DateTime(1/4/2025)));
        s_dal.sale.Create(new Sale(104,200,5,0,true,new DateTime(1/11/2024),new DateTime(1/12/2024)));
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
    }
    public static void creatProduct()
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());

        s_dal.product.Create(new Product(100,"חלב", Category.מוצרי_חלב, 5.9, 50));
        s_dal.product.Create(new Product(101, "גבינה", Category.מוצרי_חלב, 5.9, 50));
        s_dal.product.Create(new Product(102, "לבן", Category.מוצרי_חלב, 5.9, 50));
        s_dal.product.Create(new Product(103, "תירס", Category.שימורים, 5.9, 50));
        s_dal.product.Create(new Product(104, "תפוחים", Category.פירות, 5.9, 50));
        s_dal.product.Create(new Product(105, "עגבניה", Category.ירקות, 5.9, 50));
        s_dal.product.Create(new Product(106, "תפוזים", Category.פירות, 5.9, 50));
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());

    }


    public static void creatCustomers()
    {
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
        s_dal.customer.Create(new Customer(035454223,"שלמה","שלמה המלך 7",0556787414));
        s_dal.customer.Create(new Customer(234525343, "שבי", "רבי עקיבא 6", 0556791242));
        s_dal.customer.Create(new Customer(034534567, "אפרת", "מסילת יוסף 15", 0556721339));
        s_dal.customer.Create(new Customer(032123443, "דוד", "יהודה הנשיא 34", 0587474125));
        s_dal.customer.Create(new Customer(034545343, "מיכל", "המסגר 52", 0527145874));
        s_dal.customer.Create(new Customer(037655343, "יוסי", "קהילות יעקב 2", 0583258745));
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().ToString());
    }

    public static void Initialize()
    {
        creatCustomers();
        creatProduct();
        creatSale();
    }
}
