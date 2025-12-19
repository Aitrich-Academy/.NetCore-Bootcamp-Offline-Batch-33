namespace encapsulation
{
    internal class Program
    {
        public class Bankacccount
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
            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited :{amount}");
                }
                else
                {
                    Console.WriteLine("Invalid deposit");
                }
            }
            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= Balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdraw :{amount}");
                }
                else
                {
                    Console.WriteLine("insufficient balance");
                }
            }
        }
            static void Main(string[] args)
            {
                Bankacccount myaccount = new Bankacccount();
            myaccount.Deposit(1000);
            myaccount.Withdraw(50);
            }
        }
    }

