using OOP_Exercise__3;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("======new======");

        Book book = new Book("amal",120);

        book.BookDetails();
    }
}