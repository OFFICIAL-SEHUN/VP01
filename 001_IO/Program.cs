using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("학번을 입력하세요 : ");
            string id = Console.ReadLine();
            int result = int.Parse(id);

            Console.WriteLine(result);
        }
    }
}
