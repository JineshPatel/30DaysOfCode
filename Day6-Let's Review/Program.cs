using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[n];

            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }

            foreach (var item in str)
            {
                char[] c = item.ToCharArray();
                char[] even = new char[(item.Length / 2) +1];
                char[] odd = new char[(item.Length / 2)];
                int e=0, o =0;
                for (int i = 0; i < item.Length; i++)
                {
                    if (i == 0 || i % 2 == 0)
                    {
                        even[e] = c[i];
                        e++;
                    }
                    else
                    {
                        odd[o] = c[i];
                        o++;
                    }
                }
                Console.WriteLine($"{new string(even).Replace('\0',' ').TrimEnd()} {new string (odd).Replace('\0', ' ').TrimEnd()}");
            }
        }
    }
}
