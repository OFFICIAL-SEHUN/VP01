using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Larger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Larger(int a, int b)
            {
                int bigger;
                return bigger = (a > b) ? a : b;
            }
            string[] token;
            Console.Write("정수 세개를 입력하세요 : ");
            string numbers = Console.ReadLine();
            token = numbers.Split(' ');
            int num1 = int.Parse(token[0]);
            int num2 = int.Parse(token[1]);
            int num3 = int.Parse(token[2]);


            Console.WriteLine(Larger(Larger(num1,num2),num3));
        }
    }
}
