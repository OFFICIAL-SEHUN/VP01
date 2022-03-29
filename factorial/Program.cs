using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int recursive(int n)
            {
                if (n == 1) return 1;
                else return recursive(n - 1)*n; 
            }
            int n = int.Parse(Console.ReadLine());
            for (int i=1;i<n;i++){
                Console.WriteLine(recursive(i));
            }
        }   
    }
}