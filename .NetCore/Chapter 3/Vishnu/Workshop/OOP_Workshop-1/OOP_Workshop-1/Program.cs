using OOP_Workshop_1.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        Admin admin = new Admin();

        Console.WriteLine("=======================================");
        Console.WriteLine("Welcome to the job portal admin module!");
        Console.WriteLine("---------------------------------------");

        while (true)
        {
            Console.WriteLine("=========Please Select a option========");
            Console.WriteLine(" 1. Register ");
            Console.WriteLine(" 2. Login");
            Console.WriteLine(" 3. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter username : ");
                    string RegUsername = Console.ReadLine();

                    Console.WriteLine("Enter password : ");
                    string RegPassword = Console.ReadLine();

                    admin.Register(RegUsername, RegPassword);
                    break;

                case "2":
                    Console.WriteLine("Enter username : ");
                    string Username = Console.ReadLine();

                    Console.WriteLine("Enter password : ");
                    string Password = Console.ReadLine();

                    admin.Login(Username, Password);
                    break;

                case "3":
                    Console.WriteLine("Goodbye");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;

            }
        }
    }
    
}