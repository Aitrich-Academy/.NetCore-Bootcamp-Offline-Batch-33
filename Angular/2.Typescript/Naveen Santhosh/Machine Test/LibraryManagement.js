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
let library = [];
function showMenu() {
    console.log("======== Menu ========");
    console.log("1.Add Book");
    console.log("2.View Books");
    console.log("3.Search Book by Id");
    console.log("4.Issue book");
    console.log("5.Return Book");
    console.log("0.Exit");
    rl.question("Enter Option: ", (option) => {
        switch (option) {
            case "1":
                addBooks();
                break;
            case "2":
                viewBooks();
                showMenu();
                break;
            case "3":
                rl.question("Enter Book id: ", (id) => {
                    searchBookById(id);
                    showMenu();
                });
                break;
            case "4":
                rl.question("Enter Book title: ", (title) => {
                    console.log(issueBook(title));
                    showMenu();
                });
                break;
            case "5":
                rl.question("Enter Book title: ", (title) => {
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
function addBooks() {
    rl.question("Enter Book Id: ", (id) => {
        const bookId = parseInt(id);
        rl.question("Enter Book title: ", (title) => {
            rl.question("Enter author: ", (author) => {
                const bookData = {
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
function viewBooks() {
    if (library.length === 0) {
        console.log("No books available.");
        return;
    }
    library.forEach((lib) => {
        console.log("Id: " + lib.id +
            " Book Title: " + lib.title +
            " Author: " + lib.author +
            " Available: " + lib.available);
    });
}
function searchBookById(id) {
    const bookId = parseInt(id);
    let found = true;
    library.forEach((lib) => {
        if (lib.id === bookId) {
            found = true;
            console.log("Id: " + lib.id +
                " Book Title: " + lib.title +
                " Author: " + lib.author +
                " Available: " + lib.available);
        }
    });
    if (!found) {
        console.log("Book not found.");
    }
}
function issueBook(title) {
    library.forEach((lib) => {
        if (lib.title === title) {
            lib.available = false;
        }
        else {
            return "Book not found";
        }
    });
    return "Issued Successfully";
}
function returnBook(title) {
    library.forEach((lib) => {
        if (lib.title === title) {
            lib.available = true;
        }
        else {
            return "Book not found";
        }
    });
    return "Returned Successfully";
}
showMenu();
