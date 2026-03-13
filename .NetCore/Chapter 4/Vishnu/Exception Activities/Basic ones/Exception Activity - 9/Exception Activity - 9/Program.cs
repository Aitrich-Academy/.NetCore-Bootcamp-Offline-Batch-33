
try
{
    int[] numbers = { 10, 200, 3000, 40000, 500000, 60000000 };

    Console.WriteLine("Enter a indux value for the array");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("ENter a number as divident");
    int b = Convert.ToInt32(Console.ReadLine());

    int result = numbers[a] / b;

    Console.WriteLine("this is the result : " + result);


}

catch(DivideByZeroException)
{
    Console.WriteLine("THE NUmber can't be divided by zero !!!");
}

catch(FormatException)
{
    Console.WriteLine("The input should be numbers only !!! ");
}

catch(IndexOutOfRangeException)
{
    Console.WriteLine("the number has excceded than the array range !!!");
}
