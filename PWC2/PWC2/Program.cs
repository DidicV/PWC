class Program
{
    static void Main()
    {
        Console.Write("Insert sentence: ");
        string text = Console.ReadLine();
        string[] words = SplitStringIntoWords(text);

        foreach (string word in words)
        {
            Console.WriteLine($"First letter of '{word}' is '{word[0]}'");
            Console.WriteLine($"Last letter of '{word}' is '{word[^1]}' \n");
        }
    }

    // split string into words
    public static string[] SplitStringIntoWords(string input)
    {
        int wordCount = 0;
        int wordStartIndex = -1;
        bool insideWord = false;

        // Count the number of words in the input
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            if (char.IsWhiteSpace(currentChar))
            {
                if (insideWord)
                {
                    insideWord = false;
                }
            }
            else if (!insideWord)
            {
                wordStartIndex = i;
                insideWord = true;
                wordCount++;
            }
        }

        // Create an array to store the words
        string[] words = new string[wordCount];

        // Populate the array with words
        wordCount = 0;
        insideWord = false;
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            if (char.IsWhiteSpace(currentChar))
            {
                if (insideWord)
                {
                    words[wordCount++] = input.Substring(wordStartIndex, i - wordStartIndex);
                    insideWord = false;
                }
            }
            else if (!insideWord)
            {
                wordStartIndex = i;
                insideWord = true;
            }
        }

        // Add the last word if it exists
        if (insideWord)
        {
            words[wordCount++] = input.Substring(wordStartIndex);
        }

        return words;
    }
}
