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
            string str_id = Console.ReadLine();
            int int_id = int.Parse(str_id);

            Console.Write("이름을 입력하세요 : ");
            string str_name = Console.ReadLine(); //int로 변환할 필요없음

            Console.WriteLine("[학번] : {0}",int_id);
            Console.WriteLine("[이름] : {0}",str_name);

        }
    }
}
