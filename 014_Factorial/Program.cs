using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수 하나를 입력하세요 : ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(N));
        }
        private static int Factorial(int n)
        {
            if (n == 1) return 1;
            else return n * Factorial(n - 1);
        }    
    }   
}
