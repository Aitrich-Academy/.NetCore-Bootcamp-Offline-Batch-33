using Gym_Membership_Calculator_OOP_Machine_Test_.Gym_Member;
using Gym_Membership_Calculator_OOP_Machine_Test_.Members;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        GymMember[] gymMembers = new GymMember[6];

        gymMembers[0] = new RegularMember(12, "Jack");
        gymMembers[1] = new RegularMember(13, "Alice");
        gymMembers[2] = new RegularMember(14, "Winston");
        gymMembers[3] = new PremiumMember(02, "Trump");
        gymMembers[4] = new PremiumMember(01, "Putin");
        gymMembers[5] = new PremiumMember(03, "Modi");


        Console.WriteLine("======Gym MemberShip Menu======");

        Console.Write("\nEnter the number of months: ");
        int months = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter 1 to view all member details for " + months + " months:");
        string Input = Console.ReadLine();

        if (Input == "1")
        {
            for (int i = 0; i < gymMembers.Length; i++)
            {
                int cost = gymMembers[i].CalculateFeeCost(months);

                Console.WriteLine("__________________________________");
                Console.WriteLine("\nMember ID : " + gymMembers[i].MemberId);
                Console.WriteLine("Member Name : " + gymMembers[i].MemberName);
                Console.WriteLine("Membrship Type : " + gymMembers[i].GetType().Name);
                Console.WriteLine("Membership Cost : $" + cost);
                Console.WriteLine("__________________________________");
                Console.WriteLine("\nTo continue Viewing next member's info PLease enter 'Enter' key !!");
                Console.ReadLine();
                
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting the program...");
        }


    }
}

