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
            var nxy = Console.ReadLine().Split(' ');
            var n = int.Parse(nxy[0]);
            var x = int.Parse(nxy[1]);
            var y = int.Parse(nxy[2]);
            var count = new int[n - 1];
            for(int i = 1; i < n; i++)
            {
                for(int j = i + 1; j < n + 1; j++)
                {
                    count[Min3(Math.Abs(i - j), Math.Abs(i - x) + 1 + Math.Abs(y - j), Math.Abs(i - y) + 1 + Math.Abs(j - x)) - 1]++;
                }
            }
            foreach(int num in count)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }

        static public int Min3(int a,int b,int c)
        {
            int min = int.MaxValue;
            min = Math.Min(a, b);
            min = Math.Min(min, c);
            return min;
        }
    }
}
