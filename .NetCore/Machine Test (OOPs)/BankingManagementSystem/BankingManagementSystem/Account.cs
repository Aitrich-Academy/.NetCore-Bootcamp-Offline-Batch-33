using System;
using System.Collections.Generic;
using System.Text;

namespace BankingManagementSystem
{
    internal abstract class Account
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; } = 0;

        public abstract void CalculateInterest();
        public abstract void AccountInfo();
    }
}
