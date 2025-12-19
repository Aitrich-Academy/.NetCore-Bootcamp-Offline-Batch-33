namespace encapsulation2
{
    internal class Program
    {
        public class Temperature
        {
            private double _celsius;

            public double Celsius
            {
                get { return _celsius; }
                 set
                {
                    if (value <= 100 && value >= -100)
                    {
                        _celsius = value;
                    }
                }
            }
            public double Fahrenheit
            {
                get { return (_celsius * 9 / 5) + 32; }
            }
        }
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            temp.Celsius =25;
            Console.WriteLine($"Celsius:{temp.Celsius}C");
            Console.WriteLine($"Fahrenheit :{temp.Fahrenheit}");
        }
    }
}
