using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Interfaces
{
    internal interface IUser
    {
        public void Register(User user);
        public User Login(string username, string password);
    }
}
