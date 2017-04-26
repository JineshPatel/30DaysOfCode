using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Jars
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] arr_temp = Console.ReadLine().Split(' ');
            long numberOfJars = 4000;// Convert.ToInt64(arr_temp[0]);
            long numberOfOprations = 30000;// Convert.ToInt64(arr_temp[1]);
            int[] candies = new int[numberOfJars];
            long sumtotal = 0;
            //for (long i = 0; i < numberOfOprations; i++)
            //{
            //string[] operation = Console.ReadLine().Split(' ');
            string[] operations = readfile(numberOfOprations);
            int k = 0;
            foreach (var o in operations)
            {
                
                if (o != null)
                {

                    string[] operation = o.Split(' ');
                    sumtotal = sumtotal + (Convert.ToInt64(operation[1]) - Convert.ToInt64(operation[0]) + 1) * (Convert.ToInt64(operation[2]));
                }
                else
                {
                    Console.WriteLine(k);
                }
                k++;
            }
            //  sumtotal = sumtotal + (Convert.ToInt32(operation[1]) - Convert.ToInt32(operation[0]) + 1) * (Convert.ToInt32(operation[2])); 
            //candies.Skip(Convert.ToInt32(operation[0])).Take(Convert.ToInt32(operation[1])).

            //for (int j = Convert.ToInt32(operation[0]); j <= Convert.ToInt32(operation[1]); j++)
            //{
            //    candies[j-1] = candies[j-1] + Convert.ToInt32(operation[2]);
            //}
            //  }
            Console.WriteLine(Math.Floor((double)(sumtotal / numberOfJars)));
        }

        private static string[] readfile(long numberOfOprations)
        {
            var fileStream = new FileStream(@"file.txt", FileMode.Open, FileAccess.Read);
            List<string> lines = new List<string>();
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines.ToArray();
        }



    }
}
