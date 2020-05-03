using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            var abn = Console.ReadLine().Split(' ');
            var a = long.Parse(abn[0]);
            var b = long.Parse(abn[1]);
            var n = long.Parse(abn[2]);
            long tmp = Math.Clamp(b - 1, 0, n);
            Console.WriteLine(a * tmp / b);
        }
    }
}
