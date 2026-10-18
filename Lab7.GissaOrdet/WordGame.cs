
namespace Lab7.GissaOrdet;

public class WordGame
{
    // List of words that the player can guess
    private List<string> words = new List<string> {
        "katt", "hund", "hus", "dator", "sträng", "gata"
    };

    // Create a Random object to generate random numbers
    Random random = new Random();

    // Store the correct word
    public string AnswerWord = "";

    public string GetMixedWord()
    {
        // Select a random word from the list
        string answerword = words[random.Next(words.Count)];

        // Save the correct word
        AnswerWord = answerword;

        // Convert the word into an array of characters
        char[] letters = answerword.ToCharArray();

        // I got this idea from AI
        // Shuffle the letters in the word
        for (int i = letters.Length - 1; i > 0; i--)
        {
            // Generate a random index
            int j = random.Next(i + 1);

            // Swap two letters using a temporary variable
            char temp = letters[i];
            letters[i] = letters[j];
            letters[j] = temp;
        }

        // Convert the shuffled letters back into a string
        return new string(letters);
    }
}
