using System;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        SortedList<int,string> BookTitle = new SortedList<int,string> ();

        BookTitle.Add(121, "Dear Debbie");
        BookTitle.Add(143, "My Husband's Wife");
        BookTitle.Add(147, "The Astral Library");
        BookTitle.Add(150, "Vigil");
        BookTitle.Add(168, "The Things We Never Say");

        foreach (KeyValuePair<int, string> Title in BookTitle) 
        {
            Console.WriteLine($"ISBN : {Title.Key}, Books Title : {Title.Value}");
        }


        Console.WriteLine("\n======================================");


        Dictionary<int,string> Members = new Dictionary<int,string> ();

        Members.Add(101, "Alice");
        Members.Add(102, "Nami");
        Members.Add(103, "Drake");
        Members.Add(104, "Jack");
        Members.Add(105, "Michaele");

        foreach (KeyValuePair<int, string> Member in Members)
        {
            Console.WriteLine($"Member Id : {Member.Key} , Member Name : {Member.Value}");
        }


        Console.WriteLine("\n======================================");


        Queue<string> borrowedBook = new Queue<string> ();

        borrowedBook.Enqueue("Lessons in Chemistry");
        borrowedBook.Enqueue("Tomorrow, and Tomorrow, and Tomorrow ");
        borrowedBook.Enqueue("The Women");
        borrowedBook.Enqueue("Fourth Wing");
        borrowedBook.Enqueue("Atomic Habits");

        foreach (string b in borrowedBook)
        {
            Console.WriteLine($"Borrowed Book : {b}");
        }

        Console.WriteLine("\n======================================");

        Stack<string> OverDueMembers = new Stack<string>();

        OverDueMembers.Push("Tom Hardey");
        OverDueMembers.Push("Tony Stark");
        OverDueMembers.Push("Tom Hiddleston");
        OverDueMembers.Push("Mark Yamaguchi");
        OverDueMembers.Push("Ash");

        foreach (string DueMember in OverDueMembers)
        {
            Console.WriteLine("Overdue Member : " + DueMember);

        }

        Console.WriteLine("\n======================================");

        List <string> Announcements = new List<string> ();

        Announcements.Add("New arrivals: 50+ fiction books from 2026 bestsellers now available!");
        Announcements.Add("Special event: Author Kate Quinn book reading on March 20th, 4 PM");
        Announcements.Add("Library closure: Maintenance on March 15th, 10 AM - 2 PM");
        Announcements.Add("Late fee waiver: Return overdue books by March 25th, no fines!");
        Announcements.Add("Join our book club: First meeting March 18th, all genres welcome");

        Console.WriteLine("\n\n-------------Announcements------------");

        foreach (string a in Announcements)
        {
            Console.WriteLine("\n- " + a);
        }



    }
}