
using BankingManagementSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        CurrentAccount currentAccount = new CurrentAccount();
        currentAccount.AccountHolder = "Rahul";
        currentAccount.Balance = 5000;
        currentAccount.AccountInfo();
        currentAccount.CalculateInterest();
        currentAccount.ApplyMaintenanceFee(15);




        SavingsAccount savingsAccount = new SavingsAccount();
        savingsAccount.AccountHolder = "Ayesha";
        savingsAccount.Balance = 8000;
        savingsAccount.AccountInfo();
        savingsAccount.CalculateInterest();

    }
}