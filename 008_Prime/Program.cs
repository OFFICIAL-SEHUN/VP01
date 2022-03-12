using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            for (int i = 2; i <= 1000; i++) //나
            {
                int j;
                for (j = 2; j < i; j++) //나누는 수
                {
                    if (i % j == 0) break;

                }
                if (j == i)
                {
                    Console.Write("{0}\t", i);
                    cnt++;
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("소수의 개수 : {0}", cnt);
        }
    }
}
