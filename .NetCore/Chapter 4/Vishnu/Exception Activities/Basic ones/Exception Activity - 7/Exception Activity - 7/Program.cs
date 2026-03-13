Console.WriteLine("Enter your password : ");

try
{
    string password = Console.ReadLine();

    if (password.Length > 6)
    {
        throw new Exception("Pass word must have less than 6 letters");
    }

    Console.WriteLine("Your password is : " + password);
}

catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
