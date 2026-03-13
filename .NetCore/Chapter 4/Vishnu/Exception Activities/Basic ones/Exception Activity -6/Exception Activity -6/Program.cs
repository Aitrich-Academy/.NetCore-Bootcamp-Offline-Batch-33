Console.WriteLine("enter a withdrawal amount :");

try
{
    int balence = 100;
    int withdraw = Convert.ToInt32(Console.ReadLine());


    if(withdraw > balence) 
    {
        throw new Exception("The entered amount is insufficent amout ");
    }

    Console.WriteLine("You have withdrawn " + withdraw + " Ruppees");
}

catch(Exception ex)
{
    Console.WriteLine(ex.Message);

}
