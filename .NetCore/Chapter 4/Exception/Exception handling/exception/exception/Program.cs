//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int[] nums = { 1, 2, 3, 4, 5, };
//        Console.WriteLine(nums[10]);
//    }
//}

//using try and catch
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            Console.WriteLine(nums[2]);
        }

        catch (Exception ex)
        {

            Console.WriteLine("ex is: " + ex);
            Console.WriteLine("oops!!!!!some thing went wrong");
        }

        finally
        {
            Console.WriteLine("thank you");
        }

    }
}