using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ADMIN_JOB.Manager
{
    internal class Admin
    {
        private int numberOfUsers = 0;
        private User[] users = new User[2];

        JobManager job = new JobManager();

        bool isLogged = false;

        public void Register(string username,string password)
        {
            if (numberOfUsers == users.Lenght )
        {
                Console.WriteLine("Maximum number of users reached. Please try again later");
                return
        }

            User newUser =new User(username,password);


    }
}
