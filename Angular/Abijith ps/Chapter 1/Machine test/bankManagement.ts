import * as readLine from 'readline';

let rl = readLine.createInterface({
    input:process.stdin,
    output:process.stdout
});

interface Account{
    accountNumber:number,
    name:string,
    balance:number
};

let accounts:Account[]=[];

function findAccountByNumber(accNo:number): Account | undefined {
    for(let account of accounts){
        if(account.accountNumber === accNo){
            return account;
        }
    }
}

function findAllAccounts(){
    return accounts;
}

function showMenu(){
    console.log("1.Create Account");
    console.log("2.Deposit");
    console.log("3.Withdraw");
    console.log("4.Check Balance");
    console.log("5.View All Accounts");
    console.log("6.Exit");
    rl.question("Enter your choice: ",(choice:string)=>{
        switch(choice){
            case "1":{
                let account: Account = { accountNumber: 0, name: "", balance: 0 };
                rl.question("Enter account number:", (accNo: string) => {
                    account.accountNumber = parseInt(accNo);
                    rl.question("Enter your name:", (accountName: string) => {
                        account.name = accountName;
                        rl.question("Enter a amount: ", (amount: string) => {
                            account.balance = parseInt(amount);
                            console.log("Account created:", account);
                            accounts.push(account);
                            showMenu();
                        });
                    });
                });
                break;
            }

            case "2":{
                rl.question("Enter account number",(accNo:string)=>{
                     const account = findAccountByNumber(parseInt(accNo));
                    if(account){
                        rl.question("Enter amount:",(amount:string)=>{
                            account.balance+=parseInt(amount);
                            console.log(account.balance)
                            showMenu();
                        })
                    } else {
                        showMenu();
                    }
                });
                break;
            }
            case "3":{
                
               rl.question("Enter account number",(accNo:string)=>{
                     const account = findAccountByNumber(parseInt(accNo));
                    if(account){
                        rl.question("Enter amount:",(amount:string)=>{
                            account.balance-=parseInt(amount);
                            console.log(account.balance);
                            showMenu();
                        })
                    } else {
                        showMenu();
                    }
                });
                break;
            }
            case "4":{
                
               rl.question("Enter account number",(accNo:string)=>{
                     const account = findAccountByNumber(parseInt(accNo));
                    if(account){
                        console.log(account.balance);
                    }
                    showMenu();
                });
                break;
            }
            case "5":{
                console.log(findAllAccounts());
                showMenu();
                break;
            }
            case "6":{
                console.log("Exiting");
                break;
            }
        }

    });

}
showMenu();