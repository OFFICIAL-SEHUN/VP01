using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int even_sum = 0;
            int odd_sum = 0;
            double reverse_sum = 0;
            for(int i=1; i<=100; i++)
            {
                sum += i;
                reverse_sum += 1.0 / i;
                if (i % 2 == 0) even_sum += i;
                else odd_sum += i;
            }

            Console.WriteLine("1~100의 합 : {0}",sum);
            Console.WriteLine("1~100의 짝수의 합 : {0}",even_sum);
            Console.WriteLine("1~100의 홀수의 합 : {0}",odd_sum);
            Console.WriteLine("1~100의 역수의 합 : {0:G6}",reverse_sum); //형식지정자를 이용한 포메팅
        }
    }
}
