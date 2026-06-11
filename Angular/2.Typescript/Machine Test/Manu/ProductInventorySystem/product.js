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
let products = [];
const menu = () => {
    console.log('Menu');
    console.log('1. Add Product');
    console.log('2. View Product');
    console.log('3. Search Product by Id');
    console.log('4. Update Quantity');
    console.log('5. Delete Product');
    console.log('6. Exit');
    rl.question('Enter choice:', (choice) => {
        switch (choice) {
            case '1':
                addProduct();
                break;
            case '2':
                viewProducts();
                break;
            case '3':
                searchProduct();
                break;
            case '4':
                updateQuantity();
                break;
            case '5':
                deleteProduct();
                break;
            case '6':
                exit();
                break;
            default:
                console.log('Invalid entry');
                menu();
        }
    });
};
const addProduct = () => {
    rl.question('Enter Id: ', (id) => {
        const productId = Number(id);
        const exist = products.some(p => p.id === productId);
        if (exist) {
            console.log('Product with this id is already exist');
            return menu();
        }
        rl.question('Enter Name: ', (name) => {
            rl.question('Enter Price: ', (price) => {
                const productPrice = Number(price);
                rl.question('Enter Quantity: ', (quantity) => {
                    const productQuantity = Number(quantity);
                    const product = {
                        id: productId,
                        name,
                        price: productPrice,
                        quantity: productQuantity
                    };
                    products.push(product);
                    console.log('Product added successfully');
                    menu();
                });
            });
        });
    });
};
const viewProducts = () => {
    if (products.length === 0) {
        console.log('No products available');
    }
    else {
        console.log('\nProducts:');
        products.forEach(products => {
            console.log(`Id: ${products.id}, Title: ${products.name}, Price: ${products.price}, Quantity: ${products.quantity}`);
        });
    }
    menu();
};
const searchProduct = () => {
    rl.question('Enter product id: ', (input) => {
        const product = products.find(p => p.id === Number(input));
        if (product) {
            console.log('\nProduct found:');
            console.log(product);
        }
        else {
            console.log('No product found with this id');
        }
        menu();
    });
};
const updateQuantity = () => {
    rl.question('Enter product id: ', (input) => {
        const product = products.find(p => p.id === Number(input));
        if (!product) {
            console.log('No product found with this id');
            return menu();
        }
        rl.question('Enter new quantity: ', (quantity) => {
            product.quantity = Number(quantity);
            console.log('Quantity updated successfully');
            return menu();
        });
    });
};
const deleteProduct = () => {
    rl.question('Enter Id: ', (id) => {
        const product = products.find(p => p.id === Number(id));
        if (!product) {
            console.log('Product with this id is not found');
            return menu();
        }
        else {
            products = products.filter(p => p.id !== product.id);
            console.log('Product deleted successfully');
            return menu();
        }
    });
};
const exit = () => {
    console.log('Exiting...');
    rl.close();
};
menu();
