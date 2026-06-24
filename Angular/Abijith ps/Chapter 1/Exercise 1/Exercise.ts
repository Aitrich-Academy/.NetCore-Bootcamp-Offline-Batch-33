import * as readline from "readline";

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

const username: string = "admin";
const pass: string = "pass";

let jobs: string[] = [
    "Java Developer",
    ".NET Developer",
    "Angular Developer",
    "Spring Boot Developer",
    "DevOps",
    "Digital Marketing",
    "HR",
    "Receptionist"
];

let applications: string[] = [
    "Java Developer",
    "Spring Boot Developer",
    "Angular Developer"
];

function showMenu(): void {
    console.log("===== JOB PORTAL MENU =====");
    console.log("1. All Jobs");
    console.log("2. My Applications");
    console.log("3. Logout");

    rl.question("Enter your choice: ", (choice: string) => {

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

rl.question("Enter your username: ", (name: string) => {

    rl.question("Enter your password: ", (password: string) => {

        if (name === username && password === pass) {
            console.log("Login successful!");
            showMenu();
        } else {
            console.log("Invalid username or password.");
            rl.close();
        }

    });

});