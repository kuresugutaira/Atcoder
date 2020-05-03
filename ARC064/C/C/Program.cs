using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var nx = Console.ReadLine().Split(' ');
            var n = int.Parse(nx[0]);
            var x = long.Parse(nx[1]);
            var tmp = Console.ReadLine().Split(' ');
            var arr = new long[n];
            var tm = 0;
            long count = 0;
            tm = int.Parse(tmp[0]);
            tmp[0] = "-1000000000";
            for(int i = 0; i < n - 1; i++)
            {
                arr[i] = long.Parse(tmp[i]) + long.Parse(tmp[i + 1]);
            }
            
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > x)
                {
                    count += arr[i] - x;
                    arr[i + 1] -= arr[i] - x;
                    arr[i] -= arr[i] - x;
                }
            }

            Console.WriteLine(count);
        }
    }
}
