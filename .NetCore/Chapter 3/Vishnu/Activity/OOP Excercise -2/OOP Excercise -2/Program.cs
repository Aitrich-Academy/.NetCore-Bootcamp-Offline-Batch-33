using OOP_Excercise__2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("======Library Object======");

        LibraryBook library = new LibraryBook();

        library.BookID = 12;
        library.Author = "test1";
        library.Title = "test2";
        library.AvailabilityStatus = true;

        library.BookInfo();
        library.Availability();

    }
}