using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_PyramidMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PyramidMethod(int n)
            {
                for (int line = 1; line <= n; line++)
                {
                    for (int space = 1; space <= n - line; space++)
                    {
                        Console.Write(" ");
                    }
                    for (int star = 1; star <= 2 * line - 1; star++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            for(int n = 3;n <= 7; n+=2)
                PyramidMethod(n);
        }
    }
}
