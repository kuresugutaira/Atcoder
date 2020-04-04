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
            var info = Console.ReadLine().Split(' ');
            var vote = Console.ReadLine().Split(' ');
            var nums = new int[int.Parse(info[0])];
            double sum = 0;
            var count = 0;
            for(int i = 0; i < int.Parse(info[0]); i++)
            {
                nums[i] = int.Parse(vote[i]);
            }
            foreach(int num in nums)
            {
                sum += num;
            }
            double check = sum / (4 * int.Parse(info[1]));
            //Console.WriteLine(check);
            foreach (int num in nums)
            {
                if (num >= check)
                {
                    count++;
                }
            }
            if (count >= int.Parse(info[1])) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
