using System;
using System.Collections.Generic;
using System.Text;

namespace BankingManagementSystem
{
    internal class CurrentAccount : Account
    {
        public override void AccountInfo()
        {
            Console.WriteLine("Current Account Information:");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Current Account Holder: {AccountHolder}\nBalance: {Balance}rs");
            Console.WriteLine();
        }
        public override void CalculateInterest()
        {
            // Current accounts typically do not earn interest
            Console.WriteLine("Current accounts do not earn interest.");
        }

        public void ApplyMaintenanceFee(decimal fee)
        {
            Balance -= fee;
            Console.WriteLine($"Maintenance fee of {fee}rs applied. New balance: {Balance}rs\n\n");
        }
    }
}
