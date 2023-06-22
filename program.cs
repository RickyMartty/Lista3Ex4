using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p;
            int d;
            p = Console.ReadLine();

            for(int i = 1; i< 11; i++)
            {
                d = 5 * i;
                Console.WriteLine($"5 x {i} = {d}");
            }
        }
    }
}
