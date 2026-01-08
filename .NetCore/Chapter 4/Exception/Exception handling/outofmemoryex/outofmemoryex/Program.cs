using System;

class Program
{
    static void Main()
    {
        try
        {
            // Try to allocate a massive array (adjust size based on your system's memory)
            // This is very likely to cause an OutOfMemoryException
            long size = long.MaxValue; // Way too big for most systems
            int[] hugeArray = new int[size];
        }
        catch (OutOfMemoryException ex)
        {
            Console.WriteLine("Caught an OutOfMemoryException!");
            Console.WriteLine("Message: " + ex.Message);
        }
    }
}