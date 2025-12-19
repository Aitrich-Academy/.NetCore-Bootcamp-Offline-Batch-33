namespace inheritance5
{
    internal class Program
    {
        class bankAccount
        {
            public virtual double GetInterestRate()
            {
                return 0.0;
            }
        }
        class SavingsAccount:bankAccount
        {
            public override double GetInterestRate()
            {
                return 3.5;
            }
        }
        class CurrentAccount:bankAccount
        {
            public override double GetInterestRate()
            {
                return 1.0;
            }
        }
        static void Main(string[] args)
        {
            bankAccount account1=new SavingsAccount();  
            Console.WriteLine($"Savings Account Interest rate:{account1.GetInterestRate()}%");

            bankAccount account2=new CurrentAccount();
            Console.WriteLine($"Current account interest rate:{account2.GetInterestRate()}%");

            SavingsAccount savings=new SavingsAccount();
            Console.WriteLine($"Savings account interest rate(direct call):{savings.GetInterestRate()}%");

            CurrentAccount current=new CurrentAccount();
            Console.WriteLine($"Current account interest rate (direct call):{current.GetInterestRate()}%");
        }
    }
}
