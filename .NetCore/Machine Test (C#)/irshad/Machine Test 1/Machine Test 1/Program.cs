
internal class Program
{
    private static void Main(string[] args)
    {
        //Console.Write("Enter the current temperature: ");
        //string temper = Console.ReadLine();


        double[] Temperature = new double[7];
        double sum = 0;
        int i = 0;
        for (i = 0; i < Temperature.Length; i++)
        {
            Console.Write($"Day {i+1}: ");
            Temperature[i] = Convert.ToDouble(Console.ReadLine());
            sum += Temperature[i];
        }

        double Average = sum / Temperature.Length;

        double max = Temperature[0];
        double min = Temperature[0];

        for (i = 1;i < Temperature.Length; i++)
        {
            if (Temperature[i] > max)
            {
                max = Temperature[i];
            }
            else if (Temperature[i] < min)
            {
                min = Temperature[i];
            }
        }




        Console.WriteLine("---------Result----------\n\n");

        Console.WriteLine($"Average Temperature: {Average}");
        Console.WriteLine($"Maximum Temperature in a Week: {max}");
        Console.WriteLine($"Minimum Temperature in a Week: {min}");


        
    }
}