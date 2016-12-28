using System;
using System.Numerics;
using System.Text;
class Messages
{
    static void Main()
    {
        string firstText = Console.ReadLine();
        string operationSign = Console.ReadLine();
        string secondText = Console.ReadLine();
        string[] firstAsArray = DivideText(firstText);
        string[] secondAsArray = DivideText(secondText);
        string firstAsDigits = GetDigitValue(firstAsArray);
        string secondAsDigits = GetDigitValue(secondAsArray);
        BigInteger firstAsNumber = BigInteger.Parse(firstAsDigits);
        BigInteger secondAsNumber = BigInteger.Parse(secondAsDigits);
        BigInteger resultAsNumber = GetOperationResult(operationSign, firstAsNumber, secondAsNumber);
        string result = GetValueDigit(resultAsNumber);
        Console.WriteLine(result);

    }



    static string[] DivideText(string text)
    {
        string[] textAsArray = new string[text.Length / 3];
        int j = 0;
        for (int i = 0; i < text.Length; i += 3)
        {
            textAsArray[j] = string.Format("{0}{1}{2}", text[i], text[i + 1], text[i + 2]);
            j++;
        }
        return textAsArray;
    }

    static string GetDigitValue(string[] textToDigits)
    {
        for (int i = 0; i < textToDigits.Length; i++)
        {
            switch (textToDigits[i])
            {
                case "cad":
                    textToDigits[i] = textToDigits[i].Replace("cad", "0");
                    break;
                case "xoz":
                    textToDigits[i] = textToDigits[i].Replace("xoz", "1");
                    break;
                case "nop":
                    textToDigits[i] = textToDigits[i].Replace("nop", "2");
                    break;
                case "cyk":
                    textToDigits[i] = textToDigits[i].Replace("cyk", "3");
                    break;
                case "min":
                    textToDigits[i] = textToDigits[i].Replace("min", "4");
                    break;
                case "mar":
                    textToDigits[i] = textToDigits[i].Replace("mar", "5");
                    break;
                case "kon":
                    textToDigits[i] = textToDigits[i].Replace("kon", "6");
                    break;
                case "iva":
                    textToDigits[i] = textToDigits[i].Replace("iva", "7");
                    break;
                case "ogi":
                    textToDigits[i] = textToDigits[i].Replace("ogi", "8");
                    break;
                case "yan":
                    textToDigits[i] = textToDigits[i].Replace("yan", "9");
                    break;
            };
        }
        return string.Join("", textToDigits);
    }

    static BigInteger GetOperationResult(string operation, BigInteger operand1, BigInteger operand2)
    {
        BigInteger result = 0;
        switch (operation)
        {
            case "+":
                result = operand1 + operand2;
                return result;
            case "-":
                result = operand1 - operand2;
                return result;
            default:
                return result;
        }
    }

    static string GetValueDigit(BigInteger number)
    {
        string result = number.ToString();
        for (int i = 0; i < result.Length; i++)
        {
            switch (result[i])
            {
                case '0':
                    result = result.Replace('0'.ToString(), "cad");
                    break;
                case '1':
                    result = result.Replace('1'.ToString(), "xoz");
                    break;
                case '2':
                    result = result.Replace('2'.ToString(), "nop");
                    break;
                case '3':
                    result = result.Replace('3'.ToString(), "cyk");
                    break;
                case '4':
                    result = result.Replace('4'.ToString(), "min");
                    break;
                case '5':
                    result = result.Replace('5'.ToString(), "mar");
                    break;
                case '6':
                    result = result.Replace('6'.ToString(), "kon");
                    break;
                case '7':
                    result = result.Replace('7'.ToString(), "iva");
                    break;
                case '8':
                    result = result.Replace('8'.ToString(), "ogi");
                    break;
                case '9':
                    result = result.Replace('9'.ToString(), "yan");
                    break;
            }
        }
        return result;
    }
}
