"use strict";
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || (function () {
    var ownKeys = function(o) {
        ownKeys = Object.getOwnPropertyNames || function (o) {
            var ar = [];
            for (var k in o) if (Object.prototype.hasOwnProperty.call(o, k)) ar[ar.length] = k;
            return ar;
        };
        return ownKeys(o);
    };
    return function (mod) {
        if (mod && mod.__esModule) return mod;
        var result = {};
        if (mod != null) for (var k = ownKeys(mod), i = 0; i < k.length; i++) if (k[i] !== "default") __createBinding(result, mod, k[i]);
        __setModuleDefault(result, mod);
        return result;
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
const readLine = __importStar(require("readline"));
let rl = readLine.createInterface({
    input: process.stdin,
    output: process.stdout
});
;
let accounts = [];
function findAccountByNumber(accNo) {
    for (let account of accounts) {
        if (account.accountNumber === accNo) {
            return account;
        }
    }
}
function findAllAccounts() {
    return accounts;
}
function showMenu() {
    console.log("1.Create Account");
    console.log("2.Deposit");
    console.log("3.Withdraw");
    console.log("4.Check Balance");
    console.log("5.View All Accounts");
    console.log("6.Exit");
    rl.question("Enter your choice: ", (choice) => {
        switch (choice) {
            case "1": {
                let account = { accountNumber: 0, name: "", balance: 0 };
                rl.question("Enter account number:", (accNo) => {
                    account.accountNumber = parseInt(accNo);
                    rl.question("Enter your name:", (accountName) => {
                        account.name = accountName;
                        rl.question("Enter a amount: ", (amount) => {
                            account.balance = parseInt(amount);
                            console.log("Account created:", account);
                            accounts.push(account);
                            showMenu();
                        });
                    });
                });
                break;
            }
            case "2": {
                rl.question("Enter account number", (accNo) => {
                    const account = findAccountByNumber(parseInt(accNo));
                    if (account) {
                        rl.question("Enter amount:", (amount) => {
                            account.balance += parseInt(amount);
                            console.log(account.balance);
                            accounts.push(account);
                            showMenu();
                        });
                    }
                    else {
                        showMenu();
                    }
                });
                break;
            }
            case "3": {
                rl.question("Enter account number", (accNo) => {
                    const account = findAccountByNumber(parseInt(accNo));
                    if (account) {
                        rl.question("Enter amount:", (amount) => {
                            account.balance -= parseInt(amount);
                            console.log(account.balance);
                            accounts.push(account);
                            showMenu();
                        });
                    }
                    else {
                        showMenu();
                    }
                });
                break;
            }
            case "4": {
                rl.question("Enter account number", (accNo) => {
                    const account = findAccountByNumber(parseInt(accNo));
                    if (account) {
                        console.log(account.balance);
                    }
                    showMenu();
                });
                break;
            }
            case "5": {
                console.log(findAllAccounts());
                showMenu();
                break;
            }
            case "6": {
                console.log("Exiting");
                break;
            }
        }
    });
}
showMenu();
