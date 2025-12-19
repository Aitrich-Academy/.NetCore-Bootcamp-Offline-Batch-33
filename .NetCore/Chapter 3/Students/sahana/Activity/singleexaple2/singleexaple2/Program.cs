namespace singleexaple2
{
   
    internal class Program
    {
        class shape
        {
            public void Display()
            {
                Console.WriteLine("display"); 
            }
            class circle:shape
            {
                public double radius;

                public void calculateArea()
                {
                    Console.WriteLine("calculatearea");
                }
            }
        }
        static void Main(string[] args)
        {
            circle myCircle = new circle(5.0);
            myCircle.calculateArea();
            myCircle.Display();

        }
    }
}
