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
            var num = int.Parse(Console.ReadLine());
            int happy = 0;
            happy += num / 500 * 1000;
            happy += num % 500 / 5 * 5;
            Console.WriteLine(happy);
            Console.ReadKey();
        }
    }
}
