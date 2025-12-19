namespace inheritance1
{
    internal class Program
    {
        class shape
        {
            public  void display()
            {
                Console.WriteLine("This is a shape.");
            }
        }
        class Circle : shape
        {
            public double Radius { get; set; }
            public Circle(double radius)
            {
                Radius = radius;
            }
            public double calculateArea()
            {
                return Math.PI * Radius * Radius;
            }
            public  void display()
            {
                Console.WriteLine($"This is a circle with radius{Radius}.");
            }
        }
        static void Main(string[] args)
        {
            shape shape= new shape();
            shape.display();

            Circle circle = new Circle(5);
            circle.display() ;
            Console.WriteLine($"Area of the circle :{circle.calculateArea()}");
        }
    }
}
