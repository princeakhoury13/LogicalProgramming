using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class LogicalPrograms
    {
        public static void PrimeNumbers()
        {
            int start, end;
            Console.WriteLine("Enter the starting range: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ending range: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers between " + start + " and " + end + ":");
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
