namespace encapsulation
{
    internal class Program
    {
        class Bankaccount
        {
            private double balance;


            public double Balance
            {
                get { return balance; }

                private set
                {
                    if (value >= 0)
                    {
                        balance = value;
                    }

                }
            }

            public void Deposite(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposite:{amount}");
                }
                else
                {
                    Console.WriteLine("Invalid deposite");
                }
            }
            public void widraw(double amount)
            {
                if (amount > 0 && amount <= Balance)
                {
                    balance -= amount;
                    Console.WriteLine($"withdraw:{amount}");
                }
                else
                {
                    Console.WriteLine("insuffient balance");
                }

            }
        }
        static void Main(string[] args)
        {
            Bankaccount myAccount=new Bankaccount();
            myAccount.Deposite(500);
            myAccount.widraw(50);
            Console.WriteLine($"final Balance:{myAccount.Balance}");
        }
    }
}
