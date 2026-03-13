Console.WriteLine("Hello, World!");

try
{
    string a = Console.ReadLine();

    if(a.Length == 0) 
    {
        throw new Exception("Shouls type a value");
    }

    Console.WriteLine(a.Length);

}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
