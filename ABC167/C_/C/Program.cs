using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var nmx = Console.ReadLine().Split(' ');
            var n = int.Parse(nmx[0]);
            var m = int.Parse(nmx[1]);
            var x = int.Parse(nmx[2]);
            var strss = new string[n][];
            for(int i = 0; i < n; i++)
            {
                strss[i] = Console.ReadLine().Split(' ');
            }


        }
    }
}
