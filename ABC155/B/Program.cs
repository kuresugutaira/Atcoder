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
            var time = int.Parse(Console.ReadLine());
            var info = Console.ReadLine().Split(' ');
            var nums = new int[time];
            bool check = true;
            for(int i = 0; i < time; i++)
            {
                nums[i] = int.Parse(info[i]);
            }
            foreach(int num in nums)
            {
                if(num % 2 == 0)
                {
                    if (num % 3 != 0 && num % 5 != 0)
                    {
                        check = false;
                    }
                }
            }
            if (check == true) Console.WriteLine("APPROVED");
            else Console.WriteLine("DENIED");
        }
    }
}
