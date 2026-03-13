

using Exception_Activity__Age_Validation_;



Console.WriteLine("Enter your Age : ");
int age = Convert.ToInt32(Console.ReadLine());


try 
{
    if (age < 18)
    {
        throw new InvalidAge("Under age !! Age should be 18 or greater");
    }

}

catch(InvalidAge e)
{
    Console.WriteLine(e.Message);
}

