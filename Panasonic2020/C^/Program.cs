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
            var abc = Console.ReadLine().Split(' ');
            var nums = new long[3];
            for (int i = 0; i < 3; i++)
            {
                nums[i] = long.Parse(abc[i]);
            }
            long tmp = nums[2] - nums[0] - nums[1];
            if (tmp * tmp > 4 * nums[0] * nums[1] && tmp > 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
