struct Student
{
    public int RollNumber;
    public string Name;
    public int[] Grades;
    public class Program
    {
        private static void Main(string[] args)
        {
            Student[] students = new Student[3];

            
            for (int i = 0; i < 3; i++)
            {
                students[i].Grades = new int[5];

                Console.WriteLine("\nEnter details for Student " + (i + 1));

                Console.Write("\nRoll Number: ");
                students[i].RollNumber = int.Parse(Console.ReadLine());

                Console.Write("\nName: ");
                students[i].Name = Console.ReadLine();

                Console.WriteLine("\nEnter Marks Of 5 subjects:");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("\nEnter Mark " + (j + 1) + ": ");
                    students[i].Grades[j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n\n Student Details :");
            Console.WriteLine("R.No\tName\tSub1\tSub2\tSub3\tSub4\tSub5\tAverage");

            for (int i = 0; i < 3; i++)
            {
                int total = 0;

                for (int j = 0; j < 5; j++)
                {
                    total += students[i].Grades[j];
                }

                double average = total / 5.0;
                Console.WriteLine($"{students[i].RollNumber}\t{students[i].Name}\t{students[i].Grades[0]}\t{students[i].Grades[1]}\t{students[i].Grades[2]}\t{students[i].Grades[3]}\t{students[i].Grades[4]}\t{average:F2}");
               
            }
        }
    }
}