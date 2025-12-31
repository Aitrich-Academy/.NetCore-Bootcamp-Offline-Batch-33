
namespace Oops_Machinetest
{
    abstract class LibraryMember
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public abstract double CalculateFine(int overdueDays);
    }
}