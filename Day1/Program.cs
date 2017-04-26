using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double meal = Convert.ToDouble(Console.ReadLine());
            //int tip = Convert.ToInt32(Console.ReadLine());
            //int tax = Convert.ToInt32(Console.ReadLine());

            //int totalCost = Convert.ToInt32(meal+( Convert.ToDouble(((decimal)meal * ((decimal)tip / 100))) + Convert.ToDouble(((decimal)meal * ((decimal)tax / 100)))));
            //Console.WriteLine($"The total meal cost is {totalCost} dollars ");
            int r = div(10, 5);

            int limit = 1000;
            for (int a = 1; a < limit; a++)
            {
                for (int b = 1; b < limit; b++)
                {
                    for (int c = 1; c < limit; c++)
                    {
                        for (int d = 1; d < limit; d++)
                        {
                            if (Math.Pow((double)a, 3) + Math.Pow((double)b, 3) == Math.Pow((double)c, 3) + Math.Pow((double)d, 3))
                            {
                                Console.WriteLine($"{a},{b},{c},{d}");
                                break;
                            }
                        }

                    }
                }

            }
            Console.ReadKey();
        }
       static int div(int a, int b)
        {
            int count = 0;

            int sum = b;
            while (sum <= a)
            {
                sum = sum+ b;
                count++;
            }

            return count;
        }
        }
    }
