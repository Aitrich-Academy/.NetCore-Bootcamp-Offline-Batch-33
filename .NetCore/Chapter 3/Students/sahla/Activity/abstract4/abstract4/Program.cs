namespace abstract4
{
    interface Ivehicle
    {
        void Drive();
        void Stop();
    }
    class Car : Ivehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
        public void Stop()
        {
            Console.WriteLine("car has stopped");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.Drive();
            mycar.Stop();
        }
    }
}
