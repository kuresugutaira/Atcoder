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
            var s = int.Parse(input[0]);
            var l = int.Parse(input[1]);
            var r = int.Parse(input[2]);
            if (s <= l) Console.WriteLine(l);
            else if (r <= s) Console.WriteLine(r);
            else Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
