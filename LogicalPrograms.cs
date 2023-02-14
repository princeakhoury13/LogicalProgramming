using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class LogicalPrograms
    {
        public static void FibonacciSeries()
        {
            Console.WriteLine("Enter number of terms for Fibonacci Series: ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int first_term = 0;
            int second_term = 1;
            int next_term;
            Console.WriteLine("Here is the Fibonacci Series:");
            Console.WriteLine(first_term);
            Console.WriteLine(second_term);

            for (int i = 2; i < terms; i++)
            {
                next_term = first_term + second_term;
                Console.WriteLine(next_term);
                first_term = second_term;
                second_term = next_term;
            }
        }
    }
}
