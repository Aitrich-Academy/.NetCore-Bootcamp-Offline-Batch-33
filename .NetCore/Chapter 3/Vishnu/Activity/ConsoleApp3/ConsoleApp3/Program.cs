using System.Security.Cryptography.X509Certificates;



public  class stud
{
    public string name;

    public int age;

    public stud (string name, int age)

    {
        this.name = name;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        stud s = new stud("kart", 2);
        Console.WriteLine(s.name);

    }
}
