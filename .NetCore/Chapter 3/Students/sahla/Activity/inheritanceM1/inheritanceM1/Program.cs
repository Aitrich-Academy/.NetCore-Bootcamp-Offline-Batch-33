namespace inheritanceM1
{
    interface IAnimal
    {
        void makeSound();
    }
    class Animal:IAnimal
    {
      public void makeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
 
    }
    class Mammal : Animal
    {
        public void makeSound()
        {
            Console.WriteLine("Mammal make sound.");
        }
    }
    class dog : Mammal
    {
        public void makeSound()
        {
            Console.WriteLine("Dog makes a sound.");
        }
        public void bark()
        {
            Console.WriteLine("Dog barks");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Animal();
            animal.makeSound();

            Mammal animal2 = new Mammal();
            animal2.makeSound();

            dog mydog=new dog();
            mydog.bark();
            mydog.makeSound();
           
        }
    }
}
