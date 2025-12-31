using Oops_Machinetest;
class Program
{
    static void Main()
    {
        LibraryMember[] members = new LibraryMember[2];

        members[0] = new StudentMember(1, "Alice");
        members[1] = new FacultyMember(2, "Ann");

        int overdueDays = 10;

        for (int i = 0; i < members.Length; i++)
        {
            Console.WriteLine( "\nId: " +members[i].MemberId + "\n Name: " + members[i].Name + "\n Fine: Rs " + members[i].CalculateFine(overdueDays));
        }
    }
}
