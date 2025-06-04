using DalApi;
using Dal;
using DalTest;
using Do;
using System.Diagnostics;
using System.Xml.Linq;
using Tools;

namespace DalTest;
public class Program
{

    static readonly IDal s_dal = DalApi.Factory.Get;


    public static int printMainMenu()
    {
        int select;
        Console.WriteLine("Press customers - 1");
        Console.WriteLine("Press sales - 2");
        Console.WriteLine("Press product - 3");
        Console.WriteLine("To end the program press - 0");
        Console.WriteLine("To clear the log folder press - 4");

        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }


    public static void ProductSubMenu()
    {

        int select = PrintSubMenu("Product");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    CreateProduct();
                    break;
                case 2:
                    Delete(s_dal.product);
                    break;
                case 3:
                    Read(s_dal.product);
                    break;
                case 4:
                    UpdateProduct();
                    break;
                case 5:
                    ReadAll(s_dal.product);
                    break;
                default:
                    Console.WriteLine("Wrong choose");
                    break;
            }
            select = PrintSubMenu("Product");
        }

    }


    private static void CustomerSubMenu()
    {
        int select = PrintSubMenu("Customer");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    CreateCustomer();
                    break;
                case 2:
                    Delete(s_dal.customer);
                    break;
                case 3:
                    Read(s_dal.customer);
                    break;
                case 4:
                    UpdateCustomer();
                    break;
                case 5:
                    ReadAll(s_dal.customer);
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
            select = PrintSubMenu("Customer");
        }
    }

    private static void SaleSubMenu()
    {
        int select = PrintSubMenu("Sale");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    CreateSale();
                    break;
                case 2:
                    Delete(s_dal.sale);
                    break;
                case 3:
                    Read(s_dal.sale);
                    break;
                case 4:
                    UpdateSale();
                    break;
                case 5:
                    ReadAll(s_dal.sale);
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
            select = PrintSubMenu("Sale");
        }
    }
    private static int PrintSubMenu(string item)
    {
        Console.WriteLine($"to add {item} press - 1");
        Console.WriteLine($"to delete {item} press - 2");
        Console.WriteLine($"to read {item} press - 3");
        Console.WriteLine($"to update {item} press - 4");
        Console.WriteLine($"to read all {item} press - 5");
        Console.WriteLine($"To end the program press - 0");

        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }

    public static void Delete<T>(ICrud<T> crud)
    {
        try
        {
            Console.WriteLine("Insert ID");
            int id = int.Parse(Console.ReadLine());
            crud.Delete(id);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
    public static void Read<T>(ICrud<T> crud)
    {
        try
        {
            Console.WriteLine("Insert ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(crud.Read(id));
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }
    public static void ReadAll<T>(ICrud<T> crud)
    {
        Console.WriteLine(string.Join('\n', crud.ReadAll()));
    }

    //product
    public static void CreateProduct()
    {
        try
        {
            Product p = AskProduct();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    public static void UpdateProduct()
    {
        try
        {
            Console.WriteLine("Enter product code");
            int id = int.Parse(Console.ReadLine());
            Product p = AskProduct(id);
            p = p with { Id = id };
            Product p1 = AskProduct(id);
            ProductImplementation pr = new ProductImplementation();
            pr.Update(p1);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static Product AskProduct(int id = 0)
    {
        Category category = 0;
        Console.WriteLine("Enter product code");
        Console.WriteLine("Enter product name");
        Console.WriteLine("Enter product category number between 1-4");
        Console.WriteLine("Enter product price");
        Console.WriteLine("Enter quantity in stock");
        int code = int.Parse(Console.ReadLine());
        string name = Console.ReadLine();
        int cat;
        if (!int.TryParse(Console.ReadLine(), out cat))
            category = 0;
        else
            category = (Category)cat;
        double price = int.Parse(Console.ReadLine());
        int stock = int.Parse(Console.ReadLine());

        return new Product(id, name, category, price, stock);

    }
    //sale
    public static void CreateSale()
    {
        try
        {
            Sale s = AskSale();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void UpdateSale()
    {
        try
        {
            Console.WriteLine("Enter sale code");
            int numIdentify = int.Parse(Console.ReadLine());
            Sale s = AskSale(numIdentify);
            s = s with { NumIdentify = numIdentify };
            Sale s1 = AskSale(numIdentify);
            SaleImplementation sa = new SaleImplementation();
            sa.Update(s1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static Sale AskSale(int id = 0)
    {
        DateTime DateStart = DateTime.Now;
        DateTime DateEnd = DateTime.Now;
        bool allCust = false;

        Console.WriteLine("Enter num identify product");
        Console.WriteLine("Enter count for sale");
        Console.WriteLine("Enter price for sale");
        Console.WriteLine("Enter if the sale for all the customer");
        Console.WriteLine("Enter day start sale");
        Console.WriteLine("Enter day end sale");

        int NumIdentifyProduct = int.Parse(Console.ReadLine());
        int CountForSale = int.Parse(Console.ReadLine());
        int PriceInSale = int.Parse(Console.ReadLine());

        if (!bool.TryParse(Console.ReadLine(), out allCust))
            Console.WriteLine("error");

        int dayStart = int.Parse(Console.ReadLine());
        int dayEnd = int.Parse(Console.ReadLine());
        DateStart.AddDays(dayStart);
        DateEnd.AddDays(dayEnd);
        //DateTime DateStartSale;
        //if (!DateTime.TryParse(Console.ReadLine(), out DateStartSale))
        //    Console.WriteLine("error");
        //else
        //    DateStart = DateStartSale;
        //DateTime DateEndSale;
        //if (!DateTime.TryParse(Console.ReadLine(), out DateEndSale))
        //    Console.WriteLine("error");
        //else
        //    DateEnd = DateEndSale;

        return new Sale(id, NumIdentifyProduct, CountForSale,
            PriceInSale, allCust, DateStart, DateEnd);

    }
    //customer
    public static void CreateCustomer()
    {
        try
        {
            Customer c = AskCustomer();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static void UpdateCustomer()
    {
        try
        {
            Console.WriteLine("Enter t.z");
            int tz = int.Parse(Console.ReadLine());
            Customer c = AskCustomer(tz);
            c = c with { Tz = tz };
            Customer c1 = AskCustomer(tz);
            CustomersImplementation cu = new CustomersImplementation();
            cu.Update(c1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static Customer AskCustomer(int id = 0)
    {


        Console.WriteLine("Enter t.z");
        Console.WriteLine("Enter customer name");
        Console.WriteLine("Enter customer address");
        Console.WriteLine("Enter customer phone number");
        int tz = int.Parse(Console.ReadLine());
        string name = Console.ReadLine();
        string address = Console.ReadLine();
        int phone = int.Parse(Console.ReadLine());
        return new Customer(tz, name, address, phone);

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("insert 1 if you want start 0 if no");
        int ifStart = int.Parse(Console.ReadLine());
        if (ifStart != 0)
            Initialization.Initialize();
        try
        {

            int select = printMainMenu();
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        CustomerSubMenu();
                        break;
                    case 2:
                        SaleSubMenu();
                        break;
                    case 3:
                        ProductSubMenu();
                        break;
                        //case 4:


                }
                select = printMainMenu();
            }

        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}