

using Exception_Activity__Student_Marks_;

Console.WriteLine("Enter your Marks");
double marks = Convert.ToDouble(Console.ReadLine());

try
{
    if (marks < 0 || marks > 100) 
    {
        throw new InvalidMarks("The marks should be in btw 0 & 100");
    }
    Console.WriteLine("you have entered " + marks + " marks");
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}
