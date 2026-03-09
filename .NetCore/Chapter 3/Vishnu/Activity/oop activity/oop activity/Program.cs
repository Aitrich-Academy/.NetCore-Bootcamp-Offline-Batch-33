using oop_activity;

class Program
{
    static void Main()
    {
        Console.WriteLine("======STUDENT OBJECT======");

        Student student = new Student();

        student.name = "Karthik";
        student.age = 21;
        student.SetMarks(82);

        student.ShowBasicInfo();

        student.ShowRole();

        Console.WriteLine("Marks :" + student.GetMarks());
        Console.WriteLine("Grade :" + student.CalculateGrade());


        Console.WriteLine("======TEACHER OBJECT======");

        Teacher teacher = new Teacher();

        teacher.name = "Anita";
        teacher.age = 35;    
        teacher.Subject = "MATHS"; 

        teacher.ShowBasicInfo() ;

        teacher.ShowRole() ;

        Console.WriteLine("Subject : " + teacher.Subject);

    }
}

