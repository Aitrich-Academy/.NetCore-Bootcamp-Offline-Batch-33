

using Exception_Activity__Negative_number_;

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

try
{
    if(number < 0) 
    {
        throw new NegativeNumber("The number should be positive");
    }

    Console.WriteLine("The number is : " + number);
}

catch(NegativeNumber e)
{
    Console.WriteLine(e.Message);
}


