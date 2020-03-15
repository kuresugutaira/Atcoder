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
            var line = Console.ReadLine().Split(' ');
            int per8 = int.Parse(line[0]);
            int per10 = int.Parse(line[1]);
            int standard = per10 * 10;
            bool flag = false;
            for (int i = standard - 50; i < standard + 50; i++)
            {
                if (Math.Floor(i * 0.08) == per8 && Math.Floor(i * 0.1) == per10)
                {
                    Console.WriteLine(i);
                    flag = true;
                    break;
                }
            }
            if(flag == false)
            {
                Console.WriteLine("-1");
            }
            //Console.ReadKey();
        }
    }
}
