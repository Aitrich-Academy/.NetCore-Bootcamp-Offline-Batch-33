namespace polymorphism1
{
    internal class Program
    {
        class mathOperation
        {
            public int add(int x, int y)
            {
                return x + y;
            }
            public int add(int x, int y, int z)
            {
                return x + y + z;
            }
            public double add(double x, double y)
            {
                return x + y;
            }
        }
        static void Main(string[] args)
        {
            mathOperation math=new mathOperation();
            Console.WriteLine(math.add(30,10));
            Console.WriteLine(math.add(10,20,30));
            Console.WriteLine(math.add(10.5,20.5));
        }
    }
}
