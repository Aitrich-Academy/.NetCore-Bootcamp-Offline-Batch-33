namespace INTERFACE_multiple_interferance
{
    internal class Program
    {
        interface IAnimal
        {
            void Eat();
        }
        interface Ipet
        {
            void Play();
        }
        class Dog : IAnimal, Ipet
        {
            public void Eat()
            {
                Console.WriteLine("Dog is Eating");
            }
            public void play()
            {
                Console.WriteLine("Dog is Playing");
            }
            static void Main(string[] args)
            {
               Dog mydog = new Dog();
                mydog.Eat();
                mydog.play();
            }
        }
    }
}
