using System;

namespace B
{
    class Program
    {
        static void Main()
        {
            var info = Console.ReadLine().Split(' ');
            var range = Int64.Parse(info[0]);
            var blue = Int64.Parse(info[1]);
            var red = Int64.Parse(info[2]);
            if (blue + red == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Int64 time = range / (blue + red);
                var ans = time * blue;
                var rem = range % (blue + red);
                if (rem >= blue)
                {
                    ans += blue;
                }
                else
                {
                    ans += rem;
                }
                Console.WriteLine(ans);
            }
            Console.ReadKey();
        }
    }
}
