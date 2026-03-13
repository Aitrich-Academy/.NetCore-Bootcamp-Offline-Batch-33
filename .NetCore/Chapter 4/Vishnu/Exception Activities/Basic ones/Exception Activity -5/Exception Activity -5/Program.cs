using NCalc;

Console.WriteLine("Hello, World!");

try
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    Console.WriteLine("Enter a indux value for the array in btw 0-4 : ");

    int indux = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("THe number at indux " + indux + " is equal to " + numbers[indux]);


}

catch (IndexOutOfRangeException) 
{
    Console.WriteLine("the number is out of range of the current array");
}