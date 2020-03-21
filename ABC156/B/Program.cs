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
            var line = Console.ReadLine().Split(' ');
            var n = int.Parse(line[0]);
            var k = int.Parse(line[1]);
            int result = 0;
            /*
            for (int i = 0; i < 30; i++)
            {
                if(n < Math.Pow(k, i))
                {
                    result = i;
                    break;
                }
            }
           */

           //解説のやり方
            while(n > 0)
            {
                n = n / k;
                result++;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
