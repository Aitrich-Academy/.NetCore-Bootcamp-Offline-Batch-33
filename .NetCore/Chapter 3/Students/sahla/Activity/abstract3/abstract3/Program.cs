namespace abstract3
{
    internal class Program
    {
        abstract class Animal
        {
            public abstract void makesound();

        }
        class Dog:Animal
        {
            public override void makesound()
            {
                Console.WriteLine($"Dog : bark.");
            }
        }
        class Cat : Animal
        {
            public override void makesound()
            {
                Console.WriteLine("cat: meow");
            }
        }
        static void Main(string[] args)
        {
            Dog mydog = new Dog();
            mydog.makesound();
            Cat cat = new Cat();
            cat.makesound();
        }
    }
}
