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
            var kn = Console.ReadLine().Split();
            var around = int.Parse(kn[0]);
            var time = int.Parse(kn[1]);
            var data = Console.ReadLine().Split(' ');
            var nums = new int[time];
            var max = 0;
            for(int i = 0; i < time; i++)
            {
                nums[i] = int.Parse(data[i]);
            }
            for(int i = 0; i < time - 1; i++)
            {
                max = Math.Max(max, nums[i + 1] - nums[i]);
            }
            max = Math.Max(max, around - nums[time - 1] + nums[0]);
            Console.WriteLine(around - max);
            Console.ReadKey();
        }
    }
}
