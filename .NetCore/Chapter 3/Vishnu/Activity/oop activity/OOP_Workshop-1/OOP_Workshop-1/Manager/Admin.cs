using OOP_Workshop_1.Interface;
using OOP_Workshop_1.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace OOP_Workshop_1.Manager
{
    internal class Admin
    {
        private User[] users = new User[2];

        JobManager job = new JobManager();

        private int user_numb = 0;
        bool Islogged = false;

        public void Register(string username, string password)
        {
            if (user_numb == users.Length)
            {
                Console.WriteLine("Maximum number of users reached. Please try again later");
                return;
            }

            User newUser = new User(username, password);

            users[user_numb] = newUser;
            user_numb++;

            Console.WriteLine("Registration Successful !");
        }
        public bool Login(string username, string password)
        {
            for (int i = 0; i < user_numb; i++)

                if (users[i].Username == username && users[i].Password ==password)
            {
                Console.WriteLine("Login Successful");
                Islogged = true;

                string ch = "0";

                if (Islogged)

                    Console.WriteLine("1. past job");
                    Console.WriteLine("2. list job");
                    Console.WriteLine("3. back to main menu");

                    ch = Console.ReadLine();


                    while (ch != "3")
                    {
                        if (ch == "1")
                        {
                            job.addjob();
                        }

                        if (ch == "2")
                        {
                            job.listjob();
                        }
                        if (ch == "3")
                        {
                            Console.WriteLine("Exit");
                        }
                    }
                return true;
            }

            Console.WriteLine("Invalid username or password");
            return false;
        }
    }
}





       

          