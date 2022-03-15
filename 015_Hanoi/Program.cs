using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Hanoi(int N, char start, char mid, char to)
            {
                if (N == 1)
                {
                    Console.WriteLine("{0} -> {1}",start,to);
                    return ;
                }
                    // A -> C로 옮긴다고 가정할 떄,
                    // STEP 1 : N-1개를 A에서 B로 이동 (= start 지점의 N-1개의 원판을 mid 지점으로 옮긴다.)
                Hanoi(N - 1, start, to, mid);

                // STEP 2 : 1개를 A에서 C로 이동 (= start 지점의 N번째 원판을 to지점으로 옮긴다.)
                Console.WriteLine("{0} -> {1}",start,to);

                // STEP 3 : N-1개를 B에서 C로 이동 (= mid 지점의 N-1개의 원판을 to 지점으로 옮긴다.)
                Hanoi(N - 1, mid, start, to);

            }
            Hanoi(4, 'A', 'B', 'C');
        } 
    }
}
