struct Patient
{
    public int id;
    public string name;
    public int age;
}

internal class Program
{
    private static void Main(string[] args)
    {
        Patient[] patients = new Patient[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter the details of patient: " + (i + 1));

            Console.WriteLine("Enter id");
            patients[i].id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name");
            patients[i].name = Console.ReadLine();

            Console.WriteLine("Enter age");
            patients[i].age = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("-----Patients Details-----");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(
                "\nPatient " + (i + 1) +
                "\nId: " + patients[i].id +
                "\nName: " + patients[i].name +
                "\nAge: " + patients[i].age
                );
        }
    }
}