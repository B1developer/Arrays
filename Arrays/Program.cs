namespace Arrays
{
    class Program
    {
        static void Main()
        {

            // 1. Creating and Initializing Arrays
            int[] playerScores = { 10, 20, 30, 40, 50 };

            // 2. Accessing and Modifiying Array Elements
            Console.WriteLine("Player 1 score: " + playerScores[0]); // Output: 10
            Console.WriteLine("Player 2 score: " + playerScores[1]); // Output: 20

            //Modify the score of Player 3
            playerScores[2] = 60;
            Console.WriteLine("Updated Player 3 score: " + playerScores[2]); // Output: 60

            // 3. Looping Through Arrays

            for (int i = 0; i < playerScores.Length; i++)
            {
                Console.WriteLine("Player " + (i + 1) + "score: " + playerScores[i]);
            }

            // 4. Summing Array Elements 

            int totalScore = 0;
            for (int i = 0; i < playerScores.Length; i++)
            {
                totalScore += playerScores[i];
            }
            Console.WriteLine("Total Score of all players: " + totalScore);

            // 5. Working with Multidimensional Arrays

            int[,] multiPlayerScores =
            {
                { 10, 20, 30},
                { 40, 50, 60},
                { 70, 80, 90}

            };

            Console.WriteLine("Player1, Game 2 score: " + multiPlayerScores[0, 1]); // Output = 20

            // 6. Challenge: Find the Highest Score
            int[] playerScores = { 10, 20, 30, 40, 50 };
            int highestScore = playerScores[0];

            for (int i = 1; i < playerScores.Length; i++)
            {
                if (playerScores[i] > highestScore)
                {
                    highestScore = playerScores[i];
                }
            }
            Console.WriteLine("The highest score is: " + highestScore);
        }
    }
}