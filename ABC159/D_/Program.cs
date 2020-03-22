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
            var time = int.Parse(Console.ReadLine());
            var tmp = Console.ReadLine().Split(' ');
            var nums = new int[time];
            for(int i = 0; i < time; i++)
            {
                nums[i] = int.Parse(tmp[i]);
            }
            var countArr = new int[time];
            for(int i = 0; i < time; i++)
            {
                countArr[nums[i] - 1] += 1;
            }
            for(int i = 0; i < time; i++)
            {
                countArr[nums[i] - 1]--;
                Console.WriteLine()
            }
        }
    }
}
