internal class Program
{
    private static void Main(string[] args)
    {
        

        int[] votes = new int[4];
        int totalVotes = 0;
        int maxVotes = 0;
        int winner = 0;


        for (int  i = 0;  i < 4;  i++)
        {
            Console.Write($"Enter votes for candidate {i + 1} ==> ");

            votes[i] = Convert.ToInt32(Console.ReadLine());  
        }


        for (int i = 0; i < 4; i++)
        {
            totalVotes += votes[i];

            if (votes[i] > maxVotes)
            {
                maxVotes = votes[i];
                winner = i + 1;
            }
        }

        Console.WriteLine("\n \tElection Result");
        Console.WriteLine("\t---------------");

        Console.WriteLine($"\nTotal votes ==>   { totalVotes}");

        Console.WriteLine($"\nCandidate {winner}  has the highest vote with {maxVotes} votes.");

    }
}

    
