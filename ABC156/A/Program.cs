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
            var time = int.Parse(line[0]);
            var rate = int.Parse(line[1]);
            if(time < 10)
            {
                rate += 100 * (10 - time);
            }
            Console.WriteLine(rate);
            Console.ReadKey();
        }
    }
}
