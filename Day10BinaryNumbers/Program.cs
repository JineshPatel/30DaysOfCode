using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            List<int> counter = new List<int>();
            int r = 0;
            //Console.WriteLine(binary);
            foreach (char c in binary)

            {
                if (c=='1')
                {
                    r++;
                }
                else
                {
                    counter.Add(r);
                    r = 0;
                }
            }
            if (r!=0)
            {
                counter.Add(r);
            }
            Console.WriteLine(counter.Max());
            Console.ReadLine();
        }
    }
}
