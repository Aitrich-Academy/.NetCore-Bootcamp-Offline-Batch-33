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
const menuOptions = [
    '1. Show Applicant List',
    '2. Schedule Interview',
    '3. Show Scheduled InterviewList',
    '0. Exit'
];
let exitProgram = false;
var obj;
let interviewList = [];
var localStorage = "";
class JobProvider {
    constructor() { }
    showMenu() {
        console.log("******************************************************* Welcome To Job Portal********************************************************");
        menuOptions.forEach(option => console.log(option));
        rl.question('Enter your choice: ', (input) => {
            this.selectOption(input);
            if (exitProgram) {
                rl.close();
            }
            else {
                this.showMenu();
            }
        });
    }
    selectOption(input) {
        switch (input) {
            case '1':
                this.applicantList();
                break;
            case '2':
                this.scheduleInterview();
                break;
            case '3':
                interviewList.forEach(list => {
                    console.log("Job Title:" + list.jobTitle +
                        " Date Of Interview: " + list.dateOfInterview +
                        " Mode Of Interview: " + list.modeOfInterview +
                        " Interview Time : " + list.time + "\n");
                });
                break;
            case '0':
                exitProgram = true;
                break;
            default:
                console.log('Invalid option');
                break;
        }
    }
    applicantList() {
        var applicantsList = [
            {
                name: "Akash .A. ",
                jobTitle: "Java Developer",
                qualification: "Bca",
                experience: "2 Year"
            },
            {
                name: "Pakash P Babu",
                jobTitle: "Asp .Net Developer",
                qualification: "Mca",
                experience: "4 Year"
            },
            {
                name: "Baviya C Menon",
                jobTitle: "Asp .Net Developer",
                qualification: "Mca",
                experience: "1 Year",
            },
            {
                name: "Hrishika P Harish",
                jobTitle: "Front End Developer Angular",
                qualification: "Btech",
                experience: "3 Year"
            }
        ];
        console.log("\n--------------------------------------------------Applicants List-----------------------------------------------\n");
        applicantsList.forEach(list => {
            console.log("Name:" + list.name + " JobTitle: " + list.jobTitle + " Qualification: " + list.qualification + " Experience: " + list.experience + "\n");
        });
        console.log("\n------------------------------------------------------------------------------------------------------------\n");
    }
    scheduleInterview() {
        var result = this.auth();
        if (result) {
            console.log("-------------------------Interview Schedule------------------");
            rl.question('Enter job title: ', (jobTitle) => {
                rl.question('Enter interview date(yyyy-mm-dd): ', (interviewDate) => {
                    const dateOfInterview = new Date(interviewDate);
                    rl.question('Enter interview time: ', (time) => {
                        rl.question('Enter interview mode: ', (modeOfInterview) => {
                            const interviewData = {
                                jobTitle,
                                dateOfInterview,
                                time,
                                modeOfInterview
                            };
                            interviewList.push(interviewData);
                            this.showMenu();
                        });
                    });
                });
            });
        }
        else {
            this.login();
        }
    }
    login() {
        console.log("please login");
        rl.question('Enter your username: ', (username) => {
            rl.question('Enter your password: ', (password) => {
                if (username == "admin" && password == "admin123") {
                    console.log('Login successful.');
                    localStorage = "admin";
                    this.scheduleInterview();
                    return true;
                }
                else {
                    console.log('Invalid username or password. Please try again.!!!!!!!!!!!\n');
                    console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'Error: Something went wrong!');
                    this.login();
                }
            });
        });
    }
    auth() {
        if (localStorage) {
            return true;
        }
        else {
            return this.login();
        }
    }
}
var jobProviderRef = new JobProvider();
jobProviderRef.showMenu();
