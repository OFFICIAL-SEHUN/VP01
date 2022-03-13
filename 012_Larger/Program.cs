using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Larger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Larger(int a, int b, int c)
            {
                int bigger;
                bigger = (a > b) ? a : b;
                bigger = bigger > c ? bigger : c;
                return bigger;
            }
            Console.Write("3개의 정수를 입력하세요 : ");
            string str_num = Console.ReadLine();
            string[] result = str_num.Split(new char[] { ' ' });  // new char[] {} 로 해도 공백으로 나눈다는 의미 
            for (int i = 0; i < result.Length; i++)               // char 인 이유: split 함수는 '문자'를 입력 받음. 문자열을 문자로 바꿈
            {
                Console.Write(result[i]);
            }
            Console.WriteLine(Larger(result[0],result[1],result[2])); <int로 변환
        }
    }
}
