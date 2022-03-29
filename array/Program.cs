using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] array = new int[10];
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
                    array[i] = r.Next(1,32768);
            Console.Write("a [] : ");
            for (int i = 0; i < array.Length; i++) Console.Write("{0} ",array[i]);
            for (int i = 0; i < array.Length; i++) sum += array[i];
            double average = sum / array.Length;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i]) max = array[i];
            }

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i]) min = array[i];
            }
            Console.WriteLine(average);
            Console.WriteLine(max);
            Console.WriteLine(min);


        }
    }
}