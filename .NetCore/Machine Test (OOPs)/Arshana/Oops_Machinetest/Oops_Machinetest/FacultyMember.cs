namespace Oops_Machinetest
{
    class FacultyMember : LibraryMember
    {
        public FacultyMember(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }

        public override double CalculateFine(int overdueDays)
        {
            
            return overdueDays * 0.5;
        }
    }
}