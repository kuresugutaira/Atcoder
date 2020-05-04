using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var nk = Console.ReadLine().Split(' ');
            var n = int.Parse(nk[0]);
            var k = int.Parse(nk[1]);
            var strs = new string[k][];
            for(int i = 0; i < k; i++)
            {
                Console.ReadLine();
                strs[i] = Console.ReadLine().Split(' ');
            }
            var sunukes = new int[n + 1];
            sunukes[0]++;
            foreach(string[] ss in strs)
            {
                foreach(string str in ss)
                {
                    sunukes[int.Parse(str)]++;
                }
            }
            var count = 0;
            foreach(int num in sunukes)
            {
                if(num == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
