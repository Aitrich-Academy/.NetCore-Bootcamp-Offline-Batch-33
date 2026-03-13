using System.Diagnostics;



Console.WriteLine("Enter a Number :");

try
{
    double a = Convert.ToDouble(Console.ReadLine()); 

   if(a < 0) 
    {
        throw new Exception("The number should be positive");
    }

        Console.WriteLine("The Number " + a + " is positive");

}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

finally 
{
    Console.WriteLine("Thank you");
}

