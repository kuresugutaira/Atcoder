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
            int result = 0;
            var time = int.Parse(Console.ReadLine());
            var data = Console.ReadLine().Split(' ');
            var nums = new int[time];
            for(int i = 0; i < time; i++)
            {
                nums[i] = int.Parse(data[i]);
            }
            var tmp = nums.Average();
            int ave = (int)Math.Round(tmp, MidpointRounding.AwayFromZero);
            for(int i = 0; i < time; i++)
            {
                result += (ave - nums[i]) * (ave - nums[i]);
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
