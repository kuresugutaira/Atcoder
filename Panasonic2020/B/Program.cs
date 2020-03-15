using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw = Console.ReadLine().Split(' ');
            UInt64 h = UInt64.Parse(hw[0]);
            UInt64 w = UInt64.Parse(hw[1]);
            if(h == 1 || w == 1)
            {
                Console.WriteLine("1");
            } else
            {
                Console.WriteLine((h * w + 1) / 2);
            }
            Console.ReadKey();
        }
    }
}
