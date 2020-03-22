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
            var line = Console.ReadLine().Split(' ');
            var n = int.Parse(line[0]);
            var m = int.Parse(line[1]);
            Console.WriteLine((n * (n - 1)) / 2 + (m * (m - 1) )/ 2);
            Console.ReadKey();
        }
    }
}
