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
            var input = Console.ReadLine();
            var chArr = input.ToCharArray();
            int count = 0;
            foreach(char c in chArr)
            {
                if (c == '1') count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}
