using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int Larger(int n1,int n2)
            {
                return n1 > n2 ? n1 : n2;
            }
            Console.Write("숫자 입력 :");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("숫자 입력 :");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("숫자 입력 :");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Larger(Larger(n1,n2),n3));

        }
    }
}