using System;
class Program
{
    static void Main()
    {
        double[] array = ConvertInputToDoubleArr(Console.ReadLine().Split(' '));
        int timesN;
        int direction;
        int stepSize;
        double valueAtIndex;
        double count = 0;
        double result = 0;
        int index = 0;

        while (true)
        {
            string[] moves = Console.ReadLine().Split(' ');
            if (moves[0] == "stop")
            {
                break;
            }
            timesN = int.Parse(moves[0]);
            direction = CheckDirection(moves[1]);
            stepSize = int.Parse(moves[2]);
            index = index + ((timesN * stepSize * direction) % array.Length);
            valueAtIndex = (double)array.GetValue(index);
            result = result + valueAtIndex;
            count++;

        }
        result = result / count;
        Console.WriteLine("{0:F1}", result);
    }


    static int CheckDirection(string direction)
    {
        int n = 1;
        if (direction == "left")
        {
            n = -1;
        }
        return n;
    }

    static double[] ConvertInputToDoubleArr(string[] input)
    {
        double[] array = new double[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            array[i] = double.Parse(input[i]);
        }
        return array;
    }


}
//int[] input = new int[3] { 12, 32, 44 };
//int position = 0;

//for (int i = 0; i < 20; i++)
//{
//     position = i % input.Length;
//     Console.WriteLine(input[position]);
//}
//Console.WriteLine("==================");

//for (int i = 20; i >= 0; i--)
//    {
//        position = i % input.Length;
//        if (position < 0)
//        {
//            position += input.Length;
//        }
//        Console.WriteLine(input[position]);
    //}