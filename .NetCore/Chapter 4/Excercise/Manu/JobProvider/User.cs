using System;

namespace JobProvider
{
    internal enum UserRole
    {
        JobSeeker,
        JobProvider
    }

    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; } 
        public string Password { get; set; }
        public UserRole Role { get; set; }

        public User(string firstName, string lastName, string email, string phone, string password, UserRole role)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new InvalidInputException("Email cannot be empty");
            }
            else if (!email.Contains("@"))
            {
                throw new InvalidInputException("Invalid email format");
            }

            FirstName = firstName;
            LastName = lastName;
            Email = email.ToLower();
            Phone = phone;
            Password = password;
            Role = role;
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }

        public string GetProfile()
        {
            return $"Name: {FirstName} {LastName}\nEmail: {Email}\nPhone: {Phone}\nRole: {Role}";
        }
    }
}