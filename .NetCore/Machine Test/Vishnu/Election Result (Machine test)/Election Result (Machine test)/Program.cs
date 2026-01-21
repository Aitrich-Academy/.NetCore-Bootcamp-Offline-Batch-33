internal class Program
{
    private static void Main(string[] args)
    {
        
        //decalaring number of votes for 4 candidates

        int[] votes = new int[4];
        int totalVotes = 0;
        int maxVotes = 0;
        int winner = 0;

        //Reading votes

        for (int  i = 0;  i < 4;  i++)
        {
            Console.Write($"Enter votes for candidate {i + 1} ==> ");

            votes[i] = Convert.ToInt32(Console.ReadLine());  
        }

        //Calculating total votes

        for (int i = 0; i < 4; i++)
        {
            totalVotes += votes[i];

            if (votes[i] > maxVotes)
            {
                maxVotes = votes[i];
                winner = i + 1;
            }
        }

        //Displaying results

        Console.WriteLine("\n \tElection Result");
        Console.WriteLine("\t---------------");

        Console.WriteLine($"\nTotal votes ==>   { totalVotes}");

        Console.WriteLine($"\nCandidate {winner}  has the highest vote with {maxVotes} votes.");

    }
}

    
