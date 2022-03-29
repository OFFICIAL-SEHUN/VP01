using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void pyramid(int n)
            {
                for (int line = 1; line <= n; line++)
                {
                    for(int space = 1; space <= n - line; space++)
                    {
                        Console.Write(" ");
                    }
                    for(int star = 1; star <= 2*line-1;star++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            pyramid(100);
        }
    }
}