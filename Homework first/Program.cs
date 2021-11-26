using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10; int i = 2; int count = 0;
            if (n <= 1)
            {
                Console.WriteLine("invalid number");
             }
            else
            {
                for (i = 2; i <= n/2; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("{0} is not a prime number",n);
                        count++;
                        break;
                    }
                }
                if (count == 0) 
                {
                    Console.WriteLine("{0} is a prime number",n);
                        }
            }
        }
    }
}
