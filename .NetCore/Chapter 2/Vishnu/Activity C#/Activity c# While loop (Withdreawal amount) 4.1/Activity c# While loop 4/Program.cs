internal class Program
{
    private static void Main(string[] args)
    {
        int cashBalance = 1000;
        int cash;
        Console.WriteLine("your current balance is $1000");

        

        while (cashBalance > 0)
        {
            Console.WriteLine("\nEnter the withdrawal amount:");
            cash = int.Parse(Console.ReadLine());

            if (cash == 0) 
            {
                Console.WriteLine("Thank you for banking with us. Goodbye!");
                break;
            }
            if(cash > cashBalance )
            {
                Console.WriteLine($"Insufficient funds. Your balance is {cashBalance}.");
                break;
            }

            else if (cash < cashBalance)
            {
                cashBalance -= cash;
                Console.WriteLine("Withdrawal successful. Your new balance is $" + cashBalance);
            }
            else {
                Console.WriteLine("Thank you for banking with us. Goodbye!");
                break;
            }
        }

       
    }
}