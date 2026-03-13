Console.WriteLine("Enter a number : ");

try
{
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(a);
}

catch(FormatException)
{
    Console.WriteLine("the input should be numbers");
}
