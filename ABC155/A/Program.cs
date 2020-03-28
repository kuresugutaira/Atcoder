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
            int count = 0;
            if (line[0] == line[1]) count++;
            if (line[1] == line[2]) count++;
            if (line[2] == line[0]) count++;
            if (count == 1) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
