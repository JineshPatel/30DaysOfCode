using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);
        }

        private static int factorial(int n)
        {
            if (n==1)
            {
                return 1;
            }

            return n * factorial(n - 1);
        }
    }
}
