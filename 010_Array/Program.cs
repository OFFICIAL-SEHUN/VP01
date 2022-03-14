using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); //랜덤 객체 생성
            int[] a = new int[10]; //정수배열 a는 정수10개를 할당한다.
            Console.Write("a[] :");
            for (int i = 0; i < 10; i++) //랜덤값 배열에 저장
            {
                a[i] = r.Next(0,32767);
                Console.Write(" {0}",a[i]);
            }
            Console.WriteLine();
            double sum = 0; //double 인 이유 : 오버플로우 때문에 음수 출력됨
            for(int i = 0; i < a.Length; i++) sum += a[i]; //average
            double average = sum / a.Length;

            int max = a[0];
            for(int i = 1; i<a.Length; i++)
            {
                if (max < a[i]) max = a[i];
            }

            int min= a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i]) min = a[i];
            }

            Console.WriteLine("평균 : {0}", average);
            Console.WriteLine("최소값 : {0}", min);
            Console.WriteLine("최대값 : {0}", max);
        }
    }
}
