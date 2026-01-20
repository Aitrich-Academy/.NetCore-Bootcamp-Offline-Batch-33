for (int i = 1; i <= 6; i++)
{
    for (int j = 1; j <= i; j++)
    {

        Console.Write("*");
    }
    Console.WriteLine();
}

for(int i = 6; i >=1; i--)
{
    for(int j=1; j<=i; j++)
    {
        Console.Write("*"); 
    }
    Console.WriteLine();

}

int n = 5; 

for (int i = 1; i <= n; i++)
{

    for (int j = 1; j <= n - i; j++)
    {
        Console.Write(" ");
    }


    for (int k = 1; k <= i; k++)
    {
        Console.Write(k + " ");
    }

    Console.WriteLine();
} 
Console.WriteLine();


for (int i = 1; i <= 6; i++)
{
    for (int j = 1; j <= 6 - i; j++)
    {
        Console.Write(" ");
    }


    for (int k = 1; k <= i; k++)
    { 
        Console.Write("* ");
    }
    Console.WriteLine();
}

for (int  i = 5;   i>=1;  i--)
{
    for (int j = 1; j <= 6-i; j++)
    {
        Console.Write(" ");

    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();

}








