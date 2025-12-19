namespace polymorphism2
{
    internal class Program
    {
        class Shape
        {
            public int area(int s)
            {
                return s*s;
            }
            public int area(int l, int b)
            {
                return l * b;
            }
            public double area(double r)
            {
                return Math.PI * r*r;
            }

        }
        static void Main(string[] args)
        {
            Shape shapes = new Shape();
            Console.WriteLine(shapes.area(5));
            Console.WriteLine(shapes.area(10,5));
            Console.WriteLine(shapes.area(4));
        }
    }
}
