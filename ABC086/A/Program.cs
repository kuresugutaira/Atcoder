using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var num = int.Parse(input[0]) * int.Parse(input[1]);
            if (num % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");
            Console.ReadKey();
        }
    }
}
