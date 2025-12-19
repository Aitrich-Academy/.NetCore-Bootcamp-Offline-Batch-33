using mechinetestoop.model;

namespace mechinetestoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee ("sahana", "manager", 5000);
            Console.WriteLine($"Employee{emp.Name},position{emp.Position},Salary{emp.Salary}");
            emp.Incresesalary(15);
            //emp.Incresesalary(25);
        }
    }
}
                
    