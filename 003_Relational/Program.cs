using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Relational
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            Console.Write("정수 두 개를 입력하세요 : ");
            string numbers = Console.ReadLine();
            token = numbers.Split(' ');
            int num1 = int.Parse(token[0]);
            int num2 = int.Parse(token[1]);

            Console.WriteLine("{0} > {1} = {2}", num1, num2, num1 > num2);
            Console.WriteLine("{0} >= {1} = {2}", num1, num2, num1 >= num2);
            Console.WriteLine("{0} < {1} = {2}", num1, num2, num1 < num2);
            Console.WriteLine("{0} <= {1} = {2}", num1, num2, num1 <= num2);
            Console.WriteLine("{0} == {1} = {2}", num1, num2, num1 == num2);
            Console.WriteLine("{0} != {1} = {2}", num1, num2, num1 != num2);

        }
    }
}
