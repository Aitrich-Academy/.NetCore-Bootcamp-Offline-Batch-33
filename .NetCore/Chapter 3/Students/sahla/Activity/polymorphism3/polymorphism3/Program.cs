namespace polymorphism3
{
    internal class Program
    {
        class Vehicle
        {
            public virtual void Speed()
            {
                Console.WriteLine("vehicles have speed limit");
            }
        }
        class Car:Vehicle
        {
            public override void Speed()
            {
                Console.WriteLine("Car have speed 60km/h.");
            }
        }
        class Bike:Vehicle
        {
            public override void Speed()
            {
                Console.WriteLine("bike have speed 80km/h.");
            }
        }
        static void Main(string[] args)
        {
            Vehicle v=new Car();
            v.Speed();
            Vehicle v2= new Bike();
            v2.Speed();
        }
    }
}
