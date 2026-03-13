

using Exception_Activity__Password_Lenght_;

Console.WriteLine("Hello, World!");
string Password = Console.ReadLine();

try 
{
    if(Password.Length < 8) 
    {
        throw new WeakPassword("The password must have more than 8 characters");
    }
    Console.WriteLine("Password created successful");
}

catch(WeakPassword e)
{
    Console.WriteLine(e.Message);
}
