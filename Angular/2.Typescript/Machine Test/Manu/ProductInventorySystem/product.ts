import * as readline from 'readline';

const rl = readline.createInterface(
    {
        input: process.stdin,
        output: process.stdout
    }
);

interface Product {
    id: number;
    name: string;
    price: number;
    quantity: number;
}

let products: Product[] = [];

const menu = (): void => {
    console.log('Menu');
    console.log('1. Add Product');
    console.log('2. View Product');
    console.log('3. Search Product by Id');
    console.log('4. Update Quantity');
    console.log('5. Delete Product');
    console.log('6. Exit');

rl.question('Enter choice:' , (choice) => {
    switch (choice) {
        case '1': addProduct(); break;
        case '2': viewProducts(); break;
        case '3': searchProduct(); break;
        case '4': updateQuantity(); break;
        case '5': deleteProduct(); break;
        case '6': exit(); break;
        default:
            console.log('Invalid entry');
            menu();
    }
});
};


const addProduct = (): void => {
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

                    const product: Product = {
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


const viewProducts = (): void => {
    if (products.length === 0) {
        console.log('No products available')
    } else {
        console.log('\nProducts:');
        products.forEach(products => {

            console.log(`Id: ${products.id}, Title: ${products.name}, Price: ${products.price}, Quantity: ${products.quantity}`);
        });
    }

    menu();
};


const searchProduct = (): void => {
    rl.question('Enter product id: ', (input) => {
        const product = products.find(p => p.id === Number(input));

    if (product) {
        console.log('\nProduct found:')
        console.log(product);
    } else {
        console.log('No product found with this id');
    }

    menu();
});
};

const updateQuantity = (): void => {
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


const deleteProduct = (): void => {
    rl.question('Enter Id: ', (id) => {

        const product = products.find(p => p.id === Number(id));

        if (!product) {
            console.log('Product with this id is not found');
            return menu();
        } else {
            products = products.filter(p => p.id !== product.id);
            console.log('Product deleted successfully');
            return menu();
        }
    });
};


const exit = (): void => {
    console.log('Exiting...');
    rl.close();
};

menu();