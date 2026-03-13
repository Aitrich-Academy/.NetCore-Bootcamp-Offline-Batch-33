Console.WriteLine("Enter Two numbers");

try 
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

    int result = a / b;

    Console.WriteLine("Value : " + result);
}

catch(DivideByZeroException) 
{
    Console.WriteLine("Can't be divided by zero");
}

catch(FormatException)
{
    Console.WriteLine("Should provide Numbers only !!");
}
