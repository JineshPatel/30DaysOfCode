using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> phoneDirectory = new Dictionary<string, int>();
            string[] Names = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                phoneDirectory.Add(arr_temp[0], Convert.ToInt32(arr_temp[1]));
               
            }
            for (int i = 0; i < n; i++)
            {
                Names[i] = Console.ReadLine();
            }
            foreach (var name in Names)
            {
                if (phoneDirectory.ContainsKey(name))
                {
                    Console.WriteLine($"{name}={phoneDirectory[name]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            Console.ReadKey();
        }
    }
}
