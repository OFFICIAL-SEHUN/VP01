using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Gugu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 9; x++)
            {
                for(int y = 2; y <= 9; y++)
                {
                    Console.Write("{0}*{1}={2}\t", y, x, x * y);
                }
                Console.WriteLine();
            }
        }
    }
}
