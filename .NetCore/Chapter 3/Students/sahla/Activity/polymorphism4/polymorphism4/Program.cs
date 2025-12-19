namespace polymorphism4
{
    internal class Program
    {
        class Employee
        {
            protected string Name;
            protected double BaseSalary;

            public Employee(string name, double baseSalary)
            {
                Name = name;
                BaseSalary = baseSalary;
            }

            public virtual double CalculateSalary()
            {
                return BaseSalary;
            }

            public virtual void DisplaySalary()
            {
                Console.WriteLine($"{Name}'s Salary: {CalculateSalary():C}");
            }
        }
        class Manager:Employee
        {
            private double Bonus;

            public Manager(string name, double baseSalary, double bonus)
                : base(name, baseSalary)
            {
                Bonus = bonus;
            }

            public override double CalculateSalary()
            {
                return BaseSalary + Bonus;
            }

        }
        class Developer : Employee
        {
            private double OvertimeHours;
            private double OvertimeRate;

            public Developer(string name, double baseSalary, double overtimeHours, double overtimeRate)
                : base(name, baseSalary)
            {
                OvertimeHours = overtimeHours;
                OvertimeRate = overtimeRate;
            }

            public override double CalculateSalary()
            {
                return BaseSalary + (OvertimeHours * OvertimeRate);
            }
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Manager("Alice", 5000, 1000);
            Employee emp2 = new Developer("Bob", 4000, 10, 50);

            emp1.DisplaySalary();
            emp2.DisplaySalary();
        }
    }
}
