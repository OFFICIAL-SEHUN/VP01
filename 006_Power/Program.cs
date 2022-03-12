using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            Console.Write("밑을 입력하세요 : ");
            int under = int.Parse(Console.ReadLine());
            Console.Write("지수를 입력하세요 : ");
            int exponent= int.Parse(Console.ReadLine());

            for (int i = 1; i <= exponent; i++)
            {
               result *= under; 

            }
            Console.WriteLine("{0} ^ {1} = {2} ",under,exponent,result);
        }
    }
}
