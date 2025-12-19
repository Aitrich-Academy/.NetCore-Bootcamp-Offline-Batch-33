

namespace singleinheri_ex1

{
    internal class Program
    {
        class Employee
        {
            public string name;
            public double salary;

            public void Name()
            {
                Console.WriteLine($"employee name is {name}");
            }
            public void Salary()
            {
                Console.WriteLine($"employee salary is {Salary}");
            }

            class Manager : Employee
            {
                public double bonous;

                public void Bonus()
                {
                    Console.WriteLine($"bounus of employee {bonous}");
                }
            }
        }
    
    
       
        
        static void Main(string[] args)
        {

          
            

           
        }
    }
}
