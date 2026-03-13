

using Exception_Activity__Minimum__Balence_;

double balence = 100;

Console.WriteLine("Enter your withdrawal amount : ");
double amount = Convert.ToDouble(Console.ReadLine());

try 
{
    if(amount > balence)
    {
        throw new InsufficientBalence("Amount insufficient");
    }
    Console.WriteLine("You have withdrawn " + amount + " Yen");
}

catch(InsufficientBalence e)
{
    Console.WriteLine(e.Message);
}
