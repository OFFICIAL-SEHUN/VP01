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
            string[] token;
            Console.Write("밑과 지수를 입력하세요 : ");
            string power = Console.ReadLine();
            token = power.Split(' ');
            int under = int.Parse(token[0]);
            int exponent = int.Parse(token[1]);

            for (int i = 1; i <= exponent; i++)
            {
               result *= under; 

            }
            Console.WriteLine("{0} ^ {1} = {2} ",under,exponent,result);
        }
    }
}
