namespace Oops_Machinetest
{
    class StudentMember : LibraryMember
    {
        public StudentMember(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }

        public override double CalculateFine(int overdueDays)
        {
            
            return overdueDays * 1.0;
        }
    }
}