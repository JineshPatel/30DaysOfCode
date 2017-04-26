using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5__Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=10 ; i++)
            {
                int result = 2 * i;
                Console.WriteLine($"{n} x {i} = {result}");
            }
        }
    }
}
