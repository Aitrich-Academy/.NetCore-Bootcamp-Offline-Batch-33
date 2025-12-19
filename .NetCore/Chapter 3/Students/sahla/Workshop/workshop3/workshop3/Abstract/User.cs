using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop3.Abstract
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Phone {  get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public User()
        {

        }
        public User(int id,string firstName,string email,string phone,string password,string gender)
        {
            Id = id;
            FirstName = firstName;
            Email = email;
            Phone = phone;
            Password = password;
            Gender = gender;
        }

        public abstract void Register();

    }
}
