using oop_Exercise;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("======Book Object======");


        IssuedBook issuedBook = new IssuedBook();
        
        issuedBook.title = "Ikigai";
        issuedBook.Author = "Test";
        issuedBook.IssueDate = 22;

        issuedBook.DisplayBookDetails();
        issuedBook.IssueDateDetail();

        
    }


}