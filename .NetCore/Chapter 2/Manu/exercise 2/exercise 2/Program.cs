using System;

internal class Program
{
    struct CompanyMember
    {
        public int UserId;
        public string Name;
        public string Designation;
        public string Email;
        public string Phone;
    }

    static void Main(string[] args)
    {
        string providerEmail = "jobprovider@gmail.com";
        string providerPassword = "123";

        CompanyMember[] members = new CompanyMember[10];
        int memberCount = 0;

        Console.WriteLine("Welcome to the Job Portal");
        Console.WriteLine("\n1. Login");

        Console.ReadLine();

        Console.Write("Please enter your email: ");
        string email = Console.ReadLine();

        Console.Write("Please enter your password: ");
        string password = Console.ReadLine();

        if (email != providerEmail || password != providerPassword)
        {
            Console.WriteLine("Invalid login credentials!");
            return;
        }

        Console.WriteLine("Login successful!\n");

        bool isLoggedIn = true;

        while (isLoggedIn)
        {
            Console.WriteLine("1. List all company members");
            Console.WriteLine("2. Add company members");
            Console.WriteLine("3. Logout");
            Console.Write("Choose an option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nCompany Members:");

                    if (memberCount == 0)
                    {
                        Console.WriteLine("No company members found.");
                    }
                    else
                    {
                        for (int i = 0; i < memberCount; i++)
                        {
                            Console.WriteLine(
                                "\nUser ID: " + members[i].UserId +
                                "\nName: " + members[i].Name +
                                "\nDesignation: " + members[i].Designation +
                                "\nEmail: " + members[i].Email +
                                "\nPhone: " + members[i].Phone
                            );
                        }
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    if (memberCount >= members.Length)
                    {
                        Console.WriteLine("Member limit reached!");
                        break;
                    }

                    CompanyMember member = new CompanyMember();

                    member.UserId = memberCount + 1;

                    Console.Write("Enter company member name: ");
                    member.Name = Console.ReadLine();

                    Console.Write("Enter email: ");
                    member.Email = Console.ReadLine();

                    Console.Write("Enter designation: ");
                    member.Designation = Console.ReadLine();

                    Console.Write("Enter phone number: ");
                    member.Phone = Console.ReadLine();

                    members[memberCount] = member;
                    memberCount++;

                    Console.WriteLine("Registration successful!\n");
                    break;

                case 3:
                    isLoggedIn = false;
                    Console.WriteLine("Logged out successfully.");
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}
