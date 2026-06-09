import * as readline from "readline";

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

interface Book {
    id: number;
    title: string;
    author: string;
    available: boolean;
}

let library: Book[] = [];

function showMenu(): void {
    console.log("======== Menu ========");
    console.log("1.Add Book");
    console.log("2.View Books");
    console.log("3.Search Book by Id");
    console.log("4.Issue book");
    console.log("5.Return Book");
    console.log("0.Exit");

    rl.question("Enter Option: ", (option: string) => {
        switch (option) {
            case "1":
                addBooks();
                break;

            case "2":
                viewBooks();
                showMenu();
                break;

            case "3":
                rl.question("Enter Book id: ", (id: string) => {
                    searchBookById(id);
                    showMenu();
                });
                break;

            case "4":
                rl.question("Enter Book title: ", (title: string) => {
                    console.log(issueBook(title));
                    showMenu();
                });
                break;

            case "5":
                rl.question("Enter Book title: ", (title: string) => {
                    console.log(returnBook(title));
                    showMenu();
                });
                break;

            case "0":
                console.log("You have exited.");
                rl.close();
                break;

            default:
                console.log("Invalid Option");
                showMenu();
                break;
        }
    });
}

function addBooks(): void {
    rl.question("Enter Book Id: ", (id: string) => {
        const bookId = parseInt(id);

        rl.question("Enter Book title: ", (title: string) => {
            rl.question("Enter author: ", (author: string) => {
                const bookData: Book = {
                    id: bookId,
                    title,
                    author,
                    available: true
                };

                library.push(bookData);

                console.log("Book added successfully");
                showMenu();
            });
        });
    });
}

function viewBooks(): void {
    if (library.length === 0) {
        console.log("No books available.");
        return;
    }

    library.forEach((lib) => {
        console.log(
            "Id: " + lib.id +
            " Book Title: " + lib.title +
            " Author: " + lib.author +
            " Available: " + lib.available
        );
    });
}

function searchBookById(id: string): void {
    const bookId = parseInt(id);
    let found = true;
    library.forEach((lib) => {
        if (lib.id === bookId) {
            found = true;
            console.log(
                "Id: " + lib.id +
                " Book Title: " + lib.title +
                " Author: " + lib.author +
                " Available: " + lib.available
            );
        }
    });

    if (!found) {
        console.log("Book not found.");
    }
}

function issueBook(title: string): string {
    
    library.forEach((lib) => {
        if (lib.title === title) {
            lib.available = false;
            
        }else{
            return "Book not found";
        }
    });

    return  "Issued Successfully" ;
}

function returnBook(title: string): string {
    

    library.forEach((lib) => {
        if (lib.title === title) {
            lib.available = true;
            
        }else {
          return "Book not found";
        }
    });

    return  "Returned Successfully" ;
}

showMenu();