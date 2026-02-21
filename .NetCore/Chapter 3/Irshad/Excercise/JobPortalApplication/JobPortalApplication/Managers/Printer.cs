using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace JobPortalApplication.Managers
{
    internal class Printer
    {
        public void Print(Job[] jobs)
        {
            Console.WriteLine("\n--- Jobs ---");
            foreach (var j in jobs)
                Console.WriteLine($"{j.Id} | {j.Title} | {j.Company}");
        }

        public void Print(JobApplication[] applications)
        {
            Console.WriteLine("\n--- Applications ---");
            foreach (var a in applications)
                Console.WriteLine($"{a.Id} | {a.ApplicantName} | {a.Status}");
        }

        public void Print(Interview[] interviews)
        {
            Console.WriteLine("\n--- Interviews ---");
            foreach (var i in interviews)
                Console.WriteLine($"{i.Id} | {i.Company} | {i.Post}");
        }
    }
}
