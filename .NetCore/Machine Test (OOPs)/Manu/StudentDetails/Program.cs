//1.Create a class Student with properties Name, Age, Marks1, Marks2, Marks3, Marks4,
//Marks5, and Marks6.
//2. Create a method to find CGPA

//If CGPA is between 9-10 give A grade
//If CGPA is between 8-9 give B grade
//If CGPA is between 7-8 give C grade
//If CGPA is between 6-7 give D grade
//If CGPA is between 5-6 give E grade

//If CGPA is below 5, failed

//3. Make sure Age is restricted to between 18 and 25
//4. Create Department class that inherit Student Class.
//5. Create a method to find topper from each Department

using StudentDetails;
internal class Program
{
    private static void Main(string[] args)
    {
        //Computer Science Department

        var csMark1 = new List<int> { 66, 75, 68, 72, 74, 71 };
        Department css1 = new Department("Rahul", 20, csMark1, "computer science");

        var csMark2 = new List<int> { 59, 55, 68, 44, 60, 61 };
        Department css2 = new Department("Pranav", 21, csMark2, "computer science");

        var csMark3 = new List<int> { 71, 75, 77, 76, 69, 80 };
        Department css3 = new Department("Roshan", 20, csMark3, "computer science");

        List<Student> CsStudents = new List<Student> { css1, css2, css3 };

        Department csTopper = (Department)Department.FindTopper(CsStudents);
        Console.WriteLine($"The top student in {csTopper.DepName} is {csTopper.Name}");


        //Mathematics Department

        var mathMark1 = new List<int> { 86, 75, 68, 88, 79, 76 };
        Department maths1 = new Department("Freddy", 21, mathMark1, "mathematics");

        var mathMark2 = new List<int> { 79, 66, 68, 74, 70, 61 };
        Department maths2 = new Department("Thomas", 21, mathMark2, "mathematics");

        var mathMark3 = new List<int> { 74, 75, 80, 79, 65, 82 };
        Department maths3 = new Department("Jackson", 20, mathMark3, "mathematics");

        List<Student> MathStudents = new List<Student> { maths1, maths2, maths3 };

        Department mathTopper = (Department)Department.FindTopper(MathStudents);
        Console.WriteLine($"The top student in {mathTopper.DepName} is {mathTopper.Name}");
    }
}