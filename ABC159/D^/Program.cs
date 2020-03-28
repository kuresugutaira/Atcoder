using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = long.Parse(Console.ReadLine());
            var tmp = Console.ReadLine().Split(' ');
            var nums = new long[time];
            long all = 0;
            for(var i = 0; i < time; i++)
            {
                nums[i] = long.Parse(tmp[i]);
            }
            var countArr = new long[time];
            for(var i = 0; i < time; i++)
            {
                all += countArr[nums[i] - 1]++;
            }
            for(var k = 0; k < time; k++)
            {
                var ans = all - countArr[nums[k] - 1] + 1;
                Console.WriteLine(ans);
            }
            Console.ReadKey();
        }
    }
}
