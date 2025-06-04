
using BO;

internal class Program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
    private static void Main(string[] args)
    {
        int finish = 0;
        bool flug = false;
        while (finish!=0)
        {
            Console.WriteLine("Enter to customerId or 0 to end");
            int customerId = int.Parse(Console.ReadLine());

            bool existcustomer = s_bl.Customers.IfCustomerExist(customerId);
            Console.WriteLine("Enter to products");
            Order order = new Order(existcustomer, new List<PrductInOrder>(), 0);
            bool flug1 = false;
            while (!flug)
            {
                Console.WriteLine("Enter to productId or 0 to end");
                int productID = int.Parse(Console.ReadLine());
                if (productID == 0)
                    flug = true;
                else
                {
                    Console.WriteLine("Enter quantity");
                    int quantity = int.Parse(Console.ReadLine());
                    List<SaleInPrduct> sales = s_bl.Order.AddProductToOrder(order, productID, quantity);
                    //להדפיס מבצעים
                    foreach (var item in sales)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            s_bl.Order.DoOrder(order);
            order.ToString();
        
            Console.WriteLine($"the total price{order.price}");
            Console.WriteLine("Enter 0 to finish the order");
            finish=int.Parse(Console.ReadLine()) ;
        }
    }
}