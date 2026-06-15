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
const readline = __importStar(require("readline"));
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
const username = "admin";
const pass = "pass";
let jobs = [
    "Java Developer",
    ".NET Developer",
    "Angular Developer",
    "Spring Boot Developer",
    "DevOps",
    "Digital Marketing",
    "HR",
    "Receptionist"
];
let applications = [
    "Java Developer",
    "Spring Boot Developer",
    "Angular Developer"
];
function showMenu() {
    console.log("===== JOB PORTAL MENU =====");
    console.log("1. All Jobs");
    console.log("2. My Applications");
    console.log("3. Logout");
    rl.question("Enter your choice: ", (choice) => {
        switch (choice) {
            case "1":
                console.log("Displaying all jobs...");
                jobs.forEach(job => {
                    console.log(job);
                });
                showMenu();
                break;
            case "2":
                console.log("Displaying applications...");
                applications.forEach(application => {
                    console.log(application);
                });
                showMenu();
                break;
            case "3":
                console.log("Logged out successfully.");
                rl.close();
                break;
            default:
                console.log("Invalid choice. Please try again.");
                showMenu();
        }
    });
}
rl.question("Enter your username: ", (name) => {
    rl.question("Enter your password: ", (password) => {
        if (name === username && password === pass) {
            console.log("Login successful!");
            showMenu();
        }
        else {
            console.log("Invalid username or password.");
            rl.close();
        }
    });
});
//# sourceMappingURL=Exercise.js.map