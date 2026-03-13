Console.WriteLine("Enter the marks : ");

try
{
    int a = Convert.ToInt32(Console.ReadLine());

    if (a > 100) 
    {
        throw new Exception("The marks should be lesser than 100");
    }

    Console.WriteLine("your mark is : ");
}

catch(Exception e)
{
    Console.WriteLine(e.Message); 
}
