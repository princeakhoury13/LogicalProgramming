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
        public static void ReverseNumbers()
        {

            int n, reverse = 0, rem;
            Console.WriteLine("Enter the number you want to reverse: ");
            n=Convert.ToInt32(Console.ReadLine());

            while(n!=0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n= n / 10;
            }
            Console.WriteLine("Here is the reversed number: "+reverse);
        }
    }
}
