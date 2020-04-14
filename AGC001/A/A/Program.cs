using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = Console.ReadLine().Split(' ');
            var nums = new int[2*n];
            var result = 0;
            for(int i = 0; i < 2*n; i++)
            {
                nums[i] = int.Parse(l[i]);
            }
            Array.Sort(nums);
            for (int i = 0; i < 2*n; i++)
            {
                if(i % 2 == 0)
                {
                    result += nums[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
