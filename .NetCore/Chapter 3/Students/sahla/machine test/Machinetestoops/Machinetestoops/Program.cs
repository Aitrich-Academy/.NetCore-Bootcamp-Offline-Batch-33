using Machinetestoops.Interface;
using Machinetestoops.manager;

namespace Machinetestoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal orderAmount = 1000m;
            IDiscounts discounts = new CustomerDiscounts.RegularCustDiscount();
            Order order=new Order(discounts);

            decimal finalAmount=order.CalculateTotal(orderAmount);
            Console.WriteLine($"Final price after discount:{finalAmount}");
        }
    }
}
