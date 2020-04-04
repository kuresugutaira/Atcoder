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
            Console.WriteLine("{0} {1} {2}", input[2], input[0], input[1]);
            Console.ReadKey();
        }
    }
}
