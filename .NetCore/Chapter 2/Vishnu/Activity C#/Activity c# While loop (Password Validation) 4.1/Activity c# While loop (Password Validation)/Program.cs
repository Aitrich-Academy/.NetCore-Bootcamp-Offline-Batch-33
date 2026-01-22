internal class Program
{
    private static void Main(string[] args)
    {
        string Password = "darkness";
        int Maximumattempts = 3;
        int attempts = 0;



        while (Maximumattempts > attempts)
        {

            Console.WriteLine("Enter the password:");
            string input = Console.ReadLine();

            if (input == Password)
            {
                Console.WriteLine("Access granted.");
                break;
            }
            else if (Maximumattempts - 1 == attempts)
            {
                Console.WriteLine("your locked. No more attempts left.");
                break;
            }

            else if (input.Length <= 8)
            {
                Console.WriteLine("Password must be 8 characters long . Try again.");
            }
            else
            {
                attempts++;
                Console.WriteLine("Access denied. Try again.");
            }


        }



    }
}