using System;
using System.Text;
class ExtractSente
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int lengthOfWord = word.Length;
        string[] sentences = Console.ReadLine().Split('.');
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < sentences.Length - 1; i++)
        {
            int indexOfWord = sentences[i].IndexOf(word);
            if (sentences[i].Contains(word) && indexOfWord == 0 && word.Length == sentences[i].Length)
            {
                result.Append(sentences[i]);
                result.Append(".");
            }

            else if (sentences[i].Contains(word) == true && indexOfWord == 0)
            {
                
                indexOfWord = sentences[i].IndexOf(word);
                char charAfter = sentences[i][indexOfWord + lengthOfWord];
                if (char.IsLetter(charAfter) == false)
                {
                    result.Append(sentences[i]);
                    result.Append(".");
                }
            }
            else if (sentences[i].Contains(word) == true && indexOfWord == sentences[i].Length - lengthOfWord)
            {
                char charBefore = sentences[i][indexOfWord - 1];
                if (char.IsLetter(charBefore) == false)
                {
                    result.Append(sentences[i]);
                    result.Append(".");
                }
            }
            else if (sentences[i].Contains(word) == true)
            {
                int currentIndex = 0;
                while (currentIndex != -1)
                {
                    currentIndex = sentences[i].IndexOf(word, currentIndex);
                    char charBefore = sentences[i][currentIndex - 1];
                    char charAfter = sentences[i][currentIndex + lengthOfWord];
                    if (char.IsLetter(charBefore) == false && char.IsLetter(charAfter) == false)
                    {
                        result.Append(sentences[i]);
                        result.Append(".");
                        break;
                    }
                    currentIndex = sentences[i].IndexOf(word, currentIndex + 1);
                }
            }
        }
        Console.WriteLine(result);

        //We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
    }
}
