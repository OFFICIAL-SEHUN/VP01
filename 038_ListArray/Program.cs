using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            int[] arr = new int[10];
            double[] arrd = new double[10];

            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {   
                arrd[i] = r.NextDouble(); //0~1미만
                arr[i] = r.Next(100);
                lst.Add(arr[i]);
            }
            Console.WriteLine("Before Sort : ");
            Print(arr);
            Print(arrd);
            PrintList(lst);


            Console.WriteLine("After Sort : ");
            lst.Sort();
            Array.Sort(arr);
            Array.Sort(arrd);
            Print(arr);
            Print(arrd);
            PrintList(lst);


            void Print<T>(T[] a)
            {
                foreach (var item in a)
                    Console.Write(item+" ");
                Console.WriteLine();
            }
        }

        private static void PrintList(List<int> lst)
        {
            foreach (var item in lst)
                Console.Write("{0:F3} ", item);
            Console.WriteLine();
        }
    }
}