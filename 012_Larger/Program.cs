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
            Console.Write("3개중 첫번째 정수를 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("3개중 두번째 정수를 입력하세요 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("3개중 세번째 정수를 입력하세요 : ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Larger(Larger(num1, num2), num3));
        }
    }
}
