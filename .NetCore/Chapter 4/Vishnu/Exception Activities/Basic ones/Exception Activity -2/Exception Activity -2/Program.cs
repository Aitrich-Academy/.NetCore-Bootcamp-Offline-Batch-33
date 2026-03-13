
    try
    {
        Console.WriteLine("enter ur age");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
        {
            throw new Exception("ur not eligible");
        }
        Console.WriteLine("jyfhvgufu");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

