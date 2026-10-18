
using System.Reflection;

namespace Lab7.GissaOrdet;

internal class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the WordGame class
        WordGame game = new WordGame();

        // Get a word with shuffled letters
        string mixedWord = game.GetMixedWord();

        // Store the player's guess
        string guess = "";

        // Count the number of incorrect attempts
        int failedAttempt = 0;

        // Set the maximum number of incorrect attempts
        int maxAttempt = 3;

        // Continue the game until the player guesses correctly or runs out of attempts
        while (guess != game.AnswerWord && failedAttempt < maxAttempt)
        {
            // Display the shuffled word
            Console.WriteLine("Gissa ordet: " + mixedWord);

            // Read the player's input
            guess = Console.ReadLine() ?? "";

            // Check if the player's guess is incorrect
            if (guess != game.AnswerWord)
            {
                // Increase the number of failed attempts by one
                failedAttempt++;

                // Display a message for an incorrect guess
                Console.WriteLine("Fel, Försök igen!");
            }
        }

        // Check if the player guessed the correct word
        if (guess == game.AnswerWord)
        {
            // Display a winning message
            Console.WriteLine("Rätt! Ordet var " + game.AnswerWord);
        }
        else
        {
            // Display a losing message
            Console.WriteLine("Du Förlorade! Ordet var " + game.AnswerWord);
        }
    }
}
