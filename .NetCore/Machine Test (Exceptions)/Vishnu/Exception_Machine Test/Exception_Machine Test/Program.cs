using Exception_Machine_Test.Exceptions;
using Exception_Machine_Test.Models;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("======Student Management Menu======");

        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alison", Age = 19, Marks = 79 },
            new Student { Id = 2, Name = "Drake", Age = 23, Marks = 89 },
            new Student { Id = 3, Name = "Winston", Age = 20, Marks = 73 },
            new Student { Id = 4, Name = "Lee", Age = 19, Marks = 82 },
            new Student { Id = 5, Name = "Tom", Age = 21, Marks = 71 }

        };

        Student highMarksStudent = null;

        foreach (Student s in students)
        {
            if (s.Marks > 80)
            {
                highMarksStudent = s;
                break;
            }
        }


        if (highMarksStudent != null)
        {
            Console.WriteLine("\nFirst student with marks Greater than 80: " + highMarksStudent.Name);
        }
        else
        {
            Console.WriteLine("First student with marks Greater than 80: Not found");
        }

        Console.WriteLine("");

        //
        Student studentById = null;

        foreach (Student s in students)
        {
            if (s.Id == 1)
            {
                studentById = s;
                break;
            }
        }
        if (studentById != null)
        {
            Console.WriteLine("Student with ID 1: " + studentById.Name);
        }
        else
        {
            Console.WriteLine("Student with ID 1: Not found");
        }

        Console.WriteLine("");

        //

        Student ArunStudent = null;

        foreach (Student s in students)
        {
            if (s.Name.Equals("Arun", StringComparison.OrdinalIgnoreCase))
            {
                ArunStudent = s;
                break;
            }
        }
        if (ArunStudent != null)
        {
            Console.WriteLine("Student named Arun " + ArunStudent.Name);
        }
        else
        {
            Console.WriteLine("Student named Arun: Not found");
        }

        Console.WriteLine("");

        //

        bool anyAbove22 = false;

        foreach (Student s in students)
        {
            if (s.Age > 22)
            {
                anyAbove22 = true;
                break;
            }
        }
        Console.WriteLine("Any student age lesser than 22: " + anyAbove22);

        Console.WriteLine("");

        //

        Console.WriteLine("Students with marks lesser than 80:");
        foreach (Student s in students)
        {
            if (s.Marks < 80)
            {
                Console.WriteLine($"{s.Id} | {s.Name} -> {s.Marks}");
            }
        }

        Console.WriteLine("");




        try
        {
            bool again = true;
            Console.WriteLine("================Menu================");
            Console.WriteLine("\n1. See the marks of students");
            Console.WriteLine("2. Exit");
            Console.WriteLine("\n====================================");
            Console.WriteLine("Enter a option (1 or 2)");

            while (again)
            {
                Console.WriteLine(" \nTo Continue listing marks, enter 1");
                
                int option = int.Parse(Console.ReadLine());
                switch (option)
                    {
                    case 1:
                        if(option  == 1) 
                        {
                            Console.Write("\nEnter Student Id: ");
                            string input = Console.ReadLine();

                            if (int.TryParse(input, out var inputId) == false)

                            {
                                Console.WriteLine("Invalid input!");
                                return;
                            }

                            Student result = null;
                            foreach (var s in students)
                            {
                                if (s.Id == inputId)
                                {
                                    result = s;
                                    break;
                                }
                            }

                            if (result == null)
                            {
                                throw new StudentNotFoundException("Student not found");
                            }

                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine($"Found: {result.Name}, Age: {result.Age}, Marks: {result.Marks}");
                            Console.WriteLine("---------------------------------------");
                        }
                        break;

                        case 2:
                        if (option == 2) { again = false; Console.WriteLine("Exiting from the menu..........."); }
                        break;

                        default:
                        Console.WriteLine("invalid input !!");
                        break;
                }

                
            }
        }
        catch (StudentNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    

    }
}