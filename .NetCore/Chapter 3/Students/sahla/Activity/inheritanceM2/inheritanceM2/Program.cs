using System.Security.Cryptography.X509Certificates;

namespace inheritanceM2
{
    interface IVehicle
    {
        void start();
    }
    class Vehicle:IVehicle
    {
        public void start()
        {
            Console.WriteLine("vehicle is starting...");
        }
    }
    class Car:Vehicle
    {
        public int NumberofDoors { get; set; }
        public Car(int numberofDoors)
        {
            NumberofDoors = numberofDoors;
        }
        public void start()
        {
            Console.WriteLine($"Car with {NumberofDoors} doors is starting..");
        }
    }
    class SportsCar:Car
    {
        public SportsCar(int numberofDoors) : base(numberofDoors) { }
        public void Turboboost()
        {
            Console.WriteLine("Sports Car activated Turbo boost");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.start();

            Car car = new Car(4);
            car.start();

            SportsCar sportsCar = new SportsCar(2);
            sportsCar.start();
            sportsCar.Turboboost();
        }
    }
}
