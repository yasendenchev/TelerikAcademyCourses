using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExamTask1
{
    class PeshoCode
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int wordLength = word.Length;
            string sentence = null;
            int lines = int.Parse(Console.ReadLine());
            string[] text = new string[lines];
            StringBuilder wholeText = new StringBuilder();
            for (int i = 0; i < lines; i++)
            {
                text[i] = Console.ReadLine();
                wholeText.Append(text[i]);
            }
            string[] sentences = Regex.Split(wholeText.ToString(), @"(?<=[.?])");
            string wordSentence = GetSentenceWithWord(sentences, word);
            string allLines = string.Join(".", text);
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            allLines = rgx.Replace(allLines, "");
            string partOfSentence = PartOfSentence(wordSentence, word, wordLength);
            partOfSentence = partOfSentence.ToUpper();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(partOfSentence);
            int result = 0;
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                result += asciiBytes[i];
            }
            Console.WriteLine(result);

            //Software developers like to solve
            //problems. If they are no problems
            //handily available, they will create
            //their own problems.

        }
        static string GetSentenceWithWord(string[] sentences, string word)
        {
            string sentenceWithWord = null;
            foreach (string sentence in sentences)
            {
                if (sentence.Contains(word) == true)
                {
                    sentenceWithWord = sentence;
                    return sentenceWithWord;
                }
            }
            return null;
        }

        static string PartOfSentence(string sentence, string word, int wordLength)
        {
            string sub = null;
            if (sentence.Contains('.') == true)
            {
                sub = sentence.Substring(0, sentence.IndexOf(word));
                sub = sub.Replace(" ", "");
            }
            else
            {
                sub = sentence.Substring(sentence.IndexOf(word) + wordLength, sentence.IndexOf("?") - (sentence.IndexOf(word) + wordLength));
                sub = sub.Replace(" ", "");
            }
            return sub;
        }
    }
}
