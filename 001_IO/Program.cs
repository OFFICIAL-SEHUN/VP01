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
            int id = int.Parse(Console.ReadLine());
            

            Console.Write("이름을 입력하세요 : ");
            string str_name = Console.ReadLine(); //int로 변환할 필요없음

            Console.WriteLine("[학번] : {0}",id);
            Console.WriteLine("[이름] : {0}",str_name);

        }
    }
}
