using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsFibo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long k = Convert.ToInt64(Console.ReadLine());
                allFib(k);
            }
            Console.ReadKey();
        }
        public static void allFib(long n)
        {
            //int[] memo = new int[n + 2];
            List<long> r = new List<long>();
            if (n == 0)
            {
                Console.WriteLine("IsFibo");
            }
            else if (n == 1)
            {
                Console.WriteLine("IsFibo");
            }
            else
            {
                long s = 0;
              //  r.Add(s);
                for (int i = 0; i < n; i++)
                {
                     s = fib(i,r);
                  r.Add(s);
                }
                if (r.Contains(n))
                {
                    Console.WriteLine("IsFibo");
                }
                else
                {
                    Console.WriteLine("IsNotFibo");
                }
            }
        }

        static long fib(int n)
        {
             if (n <= 0) return 0;
             else if (n == 1) return 1;
             return fib(n - 1) + fib(n - 2);
          }

        private static long fib(int i, List<long> memo)
        {
            if (i <= 0)
            {
                return 0;
            }
            else if (i == 1) return 1;
            else if (memo[i] > 0) return  memo[i];
            memo[i] = fib(i - 1, memo) + fib(i - 2, memo);

            return memo[i];
        }
    }
}
