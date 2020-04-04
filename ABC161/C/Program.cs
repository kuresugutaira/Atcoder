using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(' ');
            var n = Int64.Parse(nm[0]);
            var m = Int64.Parse(nm[1]);
            Console.WriteLine(Math.Min(n % m, Math.Abs(m - (n % m))));
            Console.ReadKey();
        }
    }
}
