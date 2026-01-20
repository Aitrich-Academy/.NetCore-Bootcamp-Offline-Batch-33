internal class Program
{
    private static void Main(string[] args)
    {
 
            int choice;
            int quantity;
            double totalBill = 0;
            string again;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Coffee Menu ===");
                Console.WriteLine("1. Espresso (100)");
                Console.WriteLine("2. Latte (150)");
                Console.WriteLine("3. Cappuccino (130)");
                Console.WriteLine("4. Americano (90)");
                Console.Write("Choose a coffee (1-4): ");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.Write("Invalid choice. Please choose 1-4: ");
                }

                double coffeePrice = 0;

                switch (choice)
                {
                    case 1:
                        coffeePrice = 100;
                        break;
                    case 2:
                        coffeePrice = 150;
                        break;
                    case 3:
                        coffeePrice = 130;
                        break;
                    case 4:
                        coffeePrice = 90;
                        break;
                }

                Console.Write("Enter quantity: ");
                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.Write("Invalid quantity. Enter a positive number: ");
                }

                double itemTotal = coffeePrice * quantity;

                Console.WriteLine("\nWould you like to add toppings?");
                Console.WriteLine("1. Milk (20)");
                Console.WriteLine("2. Sugar (10)");
                Console.WriteLine("3. Whipped Cream (25)");
                Console.WriteLine("4. No toppings");
                Console.Write("Choose a topping (1-4): ");

                int toppingChoice;
                while (!int.TryParse(Console.ReadLine(), out toppingChoice) || toppingChoice < 1 || toppingChoice > 4)
                {
                    Console.Write("Invalid choice. Please choose 1-4: ");
                }

                double toppingPrice = 0;

                switch (toppingChoice)
                {
                    case 1:
                        toppingPrice = 20;
                        break;
                    case 2:
                        toppingPrice = 10;
                        break;
                    case 3:
                        toppingPrice = 25;
                        break;
                    case 4:
                        toppingPrice = 0;
                        break;
                }

                // Toppings cost also multiplied by quantity
                itemTotal += toppingPrice * quantity;

                Console.WriteLine($"\nSubtotal for this order: {itemTotal}.");
                totalBill += itemTotal;

                Console.Write("\nWould you like to order another coffee? (Y/N): ");
                again = Console.ReadLine().Trim().ToUpper();

            } while (again == "Y");

            Console.Clear();
            Console.WriteLine("=== Final Bill ===");
            Console.WriteLine($"Total amount to pay: {totalBill}");
            Console.WriteLine("Thank you for your order! Have a great day.");
            Console.ReadLine();
        }
    }


    
