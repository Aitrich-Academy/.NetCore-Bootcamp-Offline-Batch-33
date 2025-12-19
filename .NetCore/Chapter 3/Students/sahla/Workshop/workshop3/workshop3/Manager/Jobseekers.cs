using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop3.Abstract;
using workshop3.Models;

namespace workshop3.Manager
{
    public class Jobseekers: User
    {
        private const int Max_Jobseeker = 10;
        private const int Max_jobs = 100;
        public Jobseekers[] user=new Jobseekers[Max_Jobseeker];
        private int numSeeker = 0;

        private Job[] jobs=new Job[Max_jobs];
        private int numJobs = 0;

        int id = 1;

        public override void Register()
        {
            id++;
            Console.Write("Enter firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter lastname: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Enter designation: ");
            string designation = Console.ReadLine();


            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var seeker = new Jobseekers(id,
                firstname,
                lastname,
                email,
                designation,
                password);
            user[numSeeker] = seeker;
            numSeeker = numSeeker + 1;

            Console.WriteLine("Registration successful. Please log in to continue.");
        }
        public Jobseekers()
        {

        }
        public Jobseekers(int id, string firstName, string email, string phone, string password, string gender) : base(id, firstName, email, phone, password, gender)
        {
            Id = id;
            FirstName = firstName;
            Email = email;
            Phone = phone;
            Password = password;
            Gender = gender;

        }
    }
}
