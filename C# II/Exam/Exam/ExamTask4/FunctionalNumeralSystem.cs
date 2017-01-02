using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ExamTask4
{
    class FunctionalNumeralSystem
    {
        static void Main(string[] args)
        {
            string[] sample = ConvertWordsToDigits(Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries));

            //foreach (string item in sample)
            //{
            //    Console.Write("{0} ", item);
            //}
            int nInDecimal = ConvertBaseToBase(sample[0]);
            Console.WriteLine(nInDecimal);

        }

        static string[] ConvertWordsToDigits(string[] words)
        {

            string[] wordsToConvert = new string[] { "ocaml", "haskell", "scala", "f#", "lisp", "rust", " ml", "clojure", "erlang", "standardml", "racket", "elm", "mercury", "commonlisp", "scheme", "curry" };
            string[] representiveNumbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Replace(wordsToConvert[0], representiveNumbers[0]);
                words[i] = words[i].Replace(wordsToConvert[1], representiveNumbers
                    [1]);
                words[i] = words[i].Replace(wordsToConvert[2], representiveNumbers
                    [2]);
                words[i] = words[i].Replace(wordsToConvert[3], representiveNumbers
                    [3]);
                words[i] = words[i].Replace(wordsToConvert[4], representiveNumbers
                    [4]);
                words[i] = words[i].Replace(wordsToConvert[5], representiveNumbers
                    [5]);
                words[i] = words[i].Replace(wordsToConvert[6], representiveNumbers
                    [6]);
                words[i] = words[i].Replace(wordsToConvert[7], representiveNumbers
                    [7]);
                words[i] = words[i].Replace(wordsToConvert[8], representiveNumbers
                    [8]);
                words[i] = words[i].Replace(wordsToConvert[9], representiveNumbers
                    [9]);
                words[i] = words[i].Replace(wordsToConvert[10], representiveNumbers
                    [10]);
                words[i] = words[i].Replace(wordsToConvert[11], representiveNumbers
                    [11]);
                words[i] = words[i].Replace(wordsToConvert[12], representiveNumbers
                    [12]);
                words[i] = words[i].Replace(wordsToConvert[13], representiveNumbers
                    [13]);
                words[i] = words[i].Replace(wordsToConvert[14], representiveNumbers
                    [14]);
                words[i] = words[i].Replace(wordsToConvert[15], representiveNumbers
                    [15]);

            }
            return words;
        }

        static int ConvertBaseToBase(string input, byte baseInput = 16, byte baseOutput = 10)
        {
            string result = null;

            //convert to base10

            ulong inputDec = 0;
            byte hexValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 65)
                {
                    hexValue = (byte)(input[i] - 55);
                    inputDec = inputDec * baseInput + hexValue;
                }
                else
                {
                    inputDec = inputDec * baseInput + ((ulong)input[i] - 48);
                }
            }

            //convert to baseoutput

            ulong remainder = 0;
            byte outputNum = 0;

            while (inputDec != 0)
            {
                remainder = inputDec / baseOutput;
                outputNum = (byte)(inputDec % baseOutput);
                inputDec = remainder;

                if (outputNum > 9)
                {
                    outputNum += 55;
                    result = (char)outputNum + result; // I added this later
                    //result += (char)outputNum; this is the original way
                }
                else
                {
                    result = outputNum + result; // I added this later
                    //result += outputNum; this is the original way
                }
            }

            //for (int i = (result.Length - 1); i >= 0; i--)
            //{
            //    Console.Write(result[i]);
            //} this is the original way

            return int.Parse(result);
        }
    }
    //How many digits does this numeral sysetm have? Is there an appropriate built-in functionality?
    //String.Replace can simplify things a lot, just be careful in what order you replace
    //Think about the data types of the three numbers and the result - how much is 2^60 * 2^60 * 2^60?
}