using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int line = 1; line <= 5; line++)
            {
                for (int space = 0; space < 5 - line; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < 2*line-1; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
