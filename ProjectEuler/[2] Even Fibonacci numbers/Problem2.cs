using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__Even_Fibonacci_numbers
{
    class Problem2
    {
        static void Main(string[] args)
        {
            int sum = 2;
            int prev_1 = 2;
            int prev_2 = 1;
            int now = 3;
            while (now<4000000)
            {
                if (now % 2 == 0) sum += now;
                prev_2 = prev_1;
                prev_1 = now;
                now = prev_1 + prev_2;   
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
