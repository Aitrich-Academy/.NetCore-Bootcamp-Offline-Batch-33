namespace encapsulation4
{
    internal class Program
    {
        public class Person
        {
            private int _age;
            public int Age
            {
                get { return _age; }
                set 
                { 
                    if (value > 0)
                    {
                        _age = value;
                    }
                    else
                    {
                        Console.WriteLine("Age must be greater than 0");
                    }
                }
            }
            public int showAge()
            {
                return Age;
            }

        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 18;
            Console.WriteLine($"Age :{person.showAge()}");
        }
    }
}
