using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace abstract1
{
    internal class Program
    {
        abstract class shape
        {
            public abstract double getArea();

            public  void displayArea()
            {
                Console.WriteLine($"Area : {getArea()}");
            }
        }
        class Rectangle : shape
        {
            public double x;
            public double y;
            public Rectangle( double x, double y )
            {
                x = x;
                y = y;
            }
            public override double getArea()
            {
               double area = x * y;
                return area;
            }
        }
        static void Main(string[] args)
        {
            Rectangle rect=new Rectangle(10,5);
            rect.displayArea();
        }
    }
}
