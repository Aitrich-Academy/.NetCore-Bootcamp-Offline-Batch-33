declare var require : any;
const readlineSync = require("readline-sync");
class Account{
    public AccountNumber : number;
    public HolderName : string;
    public Balance : number;

    constructor(AccountNumber: number, HolderName : string, Balance : number)
    {
        this.AccountNumber = AccountNumber;
        this.HolderName = HolderName;
        this.Balance = Balance;
    }

    deposit(amount : number) : void{
        if(amount <= this.Balance)
        {
            this.Balance += amount;
            console.log("₹",amount,"deposited successfull.");
        }
    }

    withdraw(amount : number) : void{
        if(amount <= this.Balance)
        {
            this.Balance -= amount;
            console.log("₹",amount,"withdrawn successfull.");
        }
        else
        {
            console.log("Insufficient Balance.");
        }
    }

    checkbalance() : void{
        console.log("Balance: ₹"+this.Balance);
    }

    display() : void{
        console.log("\n ------------------------0");
        console.log('Account Number :',this.AccountNumber);
        console.log('Holder Name :',this.HolderName);
        console.log('Balance :',this.Balance);
    }
}

class Manager{
    private accounts : Account[] = [];

    createAccount() : void{

        const AccountNumber =Number(readlineSync.question("Enter Account Number: "));
        const HolderName = readlineSync.question("Enter Holder Name: ");
        const Balance = Number(readlineSync.question("Enter Initial Balance: "));

        const account = new Account(
            AccountNumber,
            HolderName,
            Balance
        )

        this.accounts.push(account);
        console.log("Account Created Successfully.");
    }

    findAccount(AccountNumber: number) : Account | undefined{
        return this.accounts.find(
            account => account.AccountNumber === AccountNumber
        );
    }

    deposit() : void{
        const AccountNumber = Number(readlineSync.question("Enter Your Account Number: "));

        const account = this.findAccount(AccountNumber);
        if (!account) {
            console.log("Account Not Found.");
            return;
        }

        const amount = Number(readlineSync.question("Enter Amount to Deposit: "));

        account.deposit(amount);
    }

    withdraw() : void{
        const AccountNumber = Number(readlineSync.question("Enter Your Account Number: "));

        const account = this.findAccount(AccountNumber);
        if (!account) {
            console.log("Account Not Found.");
            return;
        }

        const amount = Number(readlineSync.question("Enter Amount to Withdraw: "));

        account.withdraw(amount);
    }

    checkBalance() : void{
        const AccountNumber = Number(readlineSync.question("Enter Your Account Number: "));

        const account = this.findAccount(AccountNumber);
        if (!account) {
            console.log("Account Not Found.");
            return;
        }

        account.checkbalance();
    }

    ViewAllAccounts() : void{
        if (this.accounts.length===0) {
            console.log("No Accounts Available!");
            return ;
        }

        console.log("All Accounts");
        this.accounts.forEach(
            account => account.display()
        );
    }
}








const Bank = new Manager();



while(true){
    console.log("\n-----Bank Account Management-----");
    console.log("1. Create Account");
    console.log("2. Deposit");
    console.log("3. Withdraw");
    console.log("4. Check Balance");
    console.log("5. View All Accounts");
    console.log("6. Exit");


    const choice = Number(readlineSync.question("Enter Your choice: "));

    switch (choice) {
        case 1:
            Bank.createAccount();
            break;
        case 2:
            Bank.deposit();
            break;
        case 3:
            Bank.withdraw();
            break;
        case 4:
            Bank.checkBalance();
            break;
        case 5:
            Bank.ViewAllAccounts();
            break;
        case 6:
            console.log("ThankYou For Using Our Service.");
            break;
    
        default:
            console.log("Invalid Input!...  Please try again.");
            break;
    }
}