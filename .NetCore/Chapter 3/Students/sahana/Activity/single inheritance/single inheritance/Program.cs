namespace single_inheritance
{
    internal class Program
    {
        class Animal
        {
            public void eat()
            {
                Console.WriteLine("Animal");
            }
        }
       class Dog : Animal
        {
            public void bark()
            {
                Console.WriteLine("dog is barking");
            }
        }
        static void Main(string[] args)
        {
            Dog mydog=new Dog();
            mydog.bark();
            mydog.eat();
        }
    }
}
