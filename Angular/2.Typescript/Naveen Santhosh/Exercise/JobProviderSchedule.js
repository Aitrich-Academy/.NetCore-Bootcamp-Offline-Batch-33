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
const readline = __importStar(require("readline-sync"));
class Dashboard {
    constructor() {
        this.jobProviders = [
            "Tcs",
            "Infosys",
            "Wipro",
            "Accenture",
            "Cognizant",
            "Deloite"
        ];
        this.registrations = [{},
            { name: "Naveen", status: "pending" },
            { name: "Abijith", status: "on-hold" },
            { name: "Edwin", status: "candidate" },
            { name: "Aswin", status: "on-hold" },
            { name: "Akshay", status: "pending" }
        ];
    }
    showDashboard() {
        console.log("============= DASHBOARD =============");
        console.log("1. Job Providers List");
        console.log("2. New Registrations");
        console.log("0. Exit");
    }
    ;
    showRegistrationMenu() {
        console.log("============= Registration Menu =============");
        console.log("1. All Registrations");
        console.log("3. Pending");
        console.log("4. On-hold");
        console.log("5. Candidate");
        console.log("6. back To Dashboard");
    }
    selectOption() {
        let exit = false;
        while (!exit) {
            this.showDashboard();
            const option = readline.question("Enter Option: ");
            switch (option) {
                case "1":
                    console.log("Job Providers List");
                    this.jobProviders.forEach(provider => {
                        console.log(provider);
                    });
                    break;
                case "2":
                    this.registrationMenu();
                    break;
                case "0":
                    console.log("Program Exited");
                    exit = true;
                    break;
                default:
                    console.log("Invalid Option");
            }
        }
    }
    registrationMenu() {
        let back = false;
        while (!back) {
            this.showRegistrationMenu();
            const option = readline.question("Enter Option: ");
            switch (option) {
                case "1":
                    console.log("All Registrations");
                    this.registrations.forEach(reg => {
                        console.log("Name : " + reg.name +
                            " Status : " + reg.status);
                    });
                    break;
                case "2":
                    console.log("Pending Registrations");
                    this.registrations.forEach(reg => {
                        if (reg.status === "pending") {
                            console.log(reg.name);
                        }
                    });
                    break;
                case "3":
                    console.log("On-Hold Registrations");
                    this.registrations.forEach(reg => {
                        if (reg.status === "on-hold") {
                            console.log(reg.name);
                        }
                    });
                    break;
                case "4":
                    console.log("Candidate Registrations");
                    this.registrations.forEach(reg => {
                        if (reg.status === "candidate") {
                            console.log(reg.name);
                        }
                    });
                    break;
                case "0":
                    back = true;
                    console.log("Returning To Dashboard...");
                    break;
                default:
                    console.log("Invalid Option");
            }
        }
    }
}
const dashboard = new Dashboard();
dashboard.selectOption();
