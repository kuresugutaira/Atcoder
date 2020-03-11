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
            var info = Console.ReadLine();
            var chr = info.ToCharArray();
            if(chr[0] == chr[1] && chr[1] == chr[2])
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
            //Console.ReadKey();
        }
    }
}
