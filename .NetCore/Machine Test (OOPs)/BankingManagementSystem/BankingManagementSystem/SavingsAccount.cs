using System;
using System.Collections.Generic;
using System.Text;

namespace BankingManagementSystem
{
    internal class SavingsAccount : Account
    {
        public override void AccountInfo()
        {
            Console.WriteLine("Savings Account Information:");
            Console.WriteLine("----------------------------");

            Console.WriteLine($"Savings Account Holder: {AccountHolder}\nBalance: {Balance}rs");
            Console.WriteLine();
        }
        public override void CalculateInterest()
        {
            
            decimal interestRate = 0.05m;
            decimal interest = Balance * interestRate;
            Balance += interest;
            Console.WriteLine($"Interest of {interest}rs applied. New balance: {Balance}rs");
        }

    }
}
