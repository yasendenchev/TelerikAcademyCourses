using System;
using System.Text;
using System.Collections.Generic;
class DeCatCoding
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine().Split(' ');
        string[] result = new string[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            int[] wordAsDigits = ConvertWordToDigits(inputArray[i]);
            int wordAsNumber = ConvertToDecimal(wordAsDigits);
            List<int> decimalToAlphabetical = DecimalToAlphabetical(wordAsNumber);
            string word = GenerateWord(decimalToAlphabetical);

            result[i] = word;
        }
        Console.Write(string.Join(" ", result));

    }
    static string ReverseWord (string reversedWord)
    { 
        StringBuilder word = new StringBuilder();
        int wordLength = reversedWord.Length;
        for (int i = 0; i < reversedWord.Length; i++)
			{
			 word= word.Append(reversedWord[wordLength - 1 - i]);
			}
        return word.ToString();
    }
    static string GenerateWord(List<int> letterPos)
    {
        StringBuilder reversedWord = new StringBuilder();
        for (int i = 0; i < letterPos.Count; i++)
        {
            reversedWord = reversedWord.Append((char)(letterPos[i] + 97));
        }
        string word = ReverseWord(reversedWord.ToString());
        return word;

    }
    static List<int> DecimalToAlphabetical(int decimalNumber)
    {
        int remainder = 0;
        List<int> letterPositions = new List<int>();
        while (decimalNumber > 0)
        {
            remainder = decimalNumber / 26;
            letterPositions.Add(decimalNumber % 26);
            decimalNumber = remainder;
        }
        return letterPositions;
    }

    static int ConvertToDecimal(int[] digits)
    {
        double wordInDecimal = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            wordInDecimal = wordInDecimal + digits[i] * Math.Pow(21, digits.Length - 1 - i);
        }
        return (int)wordInDecimal;
    }

    static int[] ConvertWordToDigits(string word)
    {
        int[] wordValue = new int[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            wordValue[i] = word[i] - 97;
        }
        return wordValue;
    }
}