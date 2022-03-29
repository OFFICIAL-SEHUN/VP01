using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] sort = new int[10];
            for (int i = 0; i < 10; i++) sort[i] = r.Next(1,101); //랜덤값 저장
            Console.Write("Before Sorting : ");
            for (int i = 0; i < 10; i++) Console.Write("{0} ",sort[i]);
            Console.WriteLine();

            int n = 10; //배열의 길이
            int tmp;
            for (int i = 0; i < n; i++) // i회전
            {
                for (int j = 0; j < n - (i + 1); j++) //순회할 원소의 개수만큼 loop
                                                              /*조건이 [ j < n - i ) ]인 이유:
                                                              버블정렬 특성상 1회전마다 가장 큰 수는 정렬이 되어있게 된다.*/
                                                              /* 1회전마다 탐색할 원소의 개수 n(배열 개수) - i(회전 수) 이다.
                                                                 위 코드에서 i + 1 인 이유는 j = 0 부터 시작하기 때문이다. */
                {
                    if (sort[j] > sort[j + 1])
                    {
                        tmp = sort[j + 1];
                        sort[j + 1] = sort[j];
                        sort[j] = tmp;
                    }
                }
            }
            Console.Write("After Sorting : ");
            for (int i = 0; i < sort.Length; i++) Console.Write("{0} ", sort[i]);
            Console.WriteLine();        
        }
    }
}
