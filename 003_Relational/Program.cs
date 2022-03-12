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
            int num1, num2;
            Console.Write("첫번째 정수를 입력하세요 :");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수를 입력하세요 :");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} > {1} = {2}", num1, num2, num1 > num2);
            Console.WriteLine("{0} >= {1} = {2}", num1, num2, num1 >= num2);
            Console.WriteLine("{0} < {1} = {2}", num1, num2, num1 < num2);
            Console.WriteLine("{0} <= {1} = {2}", num1, num2, num1 <= num2);
            Console.WriteLine("{0} == {1} = {2}", num1, num2, num1 == num2);
            Console.WriteLine("{0} != {1} = {2}", num1, num2, num1 != num2);

        }
    }
}
