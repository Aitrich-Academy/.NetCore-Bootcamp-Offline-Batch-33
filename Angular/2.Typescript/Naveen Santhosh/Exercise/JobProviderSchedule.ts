import * as readline from "readline-sync";

class Dashboard{

    jobProviders = [
        "Tcs",
        "Infosys",
        "Wipro",
        "Accenture",
        "Cognizant",
        "Deloite"
    ];

    registrations = [ 
    {name : "Benlin", status : "candidate"},
    {name : "Naveen", status : "pending"},
    {name : "Abijith", status : "on-hold"},
    {name : "Edwin", status : "candidate"},
    {name : "Aswin", status : "on-hold"},
    {name : "Akshay", status : "pending"}
];

showDashboard(): void {
    console.log("============= DASHBOARD =============");
    console.log("1. Job Providers List");
    console.log("2. New Registrations");
    console.log("0. Exit");
};

showRegistrationMenu(): void{

    console.log("============= Registration Menu =============");
    console.log("1. All Registrations");
    console.log("2. Pending");
    console.log("3. On-hold");
    console.log("4. Candidate");
    console.log("0. back To Dashboard");
}

selectOption() : void {
let exit = false;
while(!exit){

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

    registrationMenu(): void {
        let back = false;

        while (!back) {
            this.showRegistrationMenu();
            const option = readline.question("Enter Option: ");
            switch (option) {
                case "1":

                    console.log("All Registrations");
                    this.registrations.forEach(reg => {
                        console.log("Name : "+reg.name +
                            " Status : " + reg.status
                        );
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




