using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace encapsulation2
{
    internal class Program
    {
        class temperature
        {
            private double _celcies;

            public double Celsues
            {
                get { return _celcies; }

                set
                {
                    if (value <= 100 && value >= -100)
                    {
                        _celcies = value;
                    }
                    else
                    {
                        Console.WriteLine("invalid");
                    }

                }
            }
            public double Fahrenheit
            {
                get { return (_celcies * 9 / 5) + 32; }
            }


            }
        static void Main(string[] args)
        {
            temperature Temperature=new temperature();
            Temperature.Celsues = 25;

            Console.WriteLine("Celsius: " + Temperature.Celsues + "°C");
            Console.WriteLine("Fahrenheit: " + Temperature.Fahrenheit + "°F");
        }
    }
}
