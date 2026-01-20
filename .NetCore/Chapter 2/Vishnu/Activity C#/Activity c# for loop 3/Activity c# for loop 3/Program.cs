internal class Program
{
    private static void Main(string[] args)
    {
        //print multiplication table of a number
        int number;
        Console.WriteLine("Enter a number:");
        number = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($" ({i}*{number})= {number*i}");
        }
        //print numbers from 1 to 10
        Console.WriteLine("\nnumber from 1 to 10");

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //print sum of all even numbers upto 50

        int sum = 0;
        for (int i = 2; i <= 50; i += 2)
        {
            sum += i;
        }
        Console.WriteLine($"Sum of even numbers upto 50 is: {sum}");

        //print numbers from 100 to 50
        Console.WriteLine("Write numbers from 100 to 50");

        for (int i =100; i>=50; i--)
        {
            Console.WriteLine(i);
        }


        //FizzBuzz from 1 to 50

        Console.WriteLine();

        for (int i =1; i <= 50; i++) 
        {
            if (i % 3 == 0  && i % 5 == 0) 
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0) 
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0) 
            {
                Console.WriteLine("Buzz");
            }
            else 
            {
                Console.WriteLine(i);
            }
        }
    }
}