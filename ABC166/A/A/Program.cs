using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var chrs = Console.ReadLine().ToCharArray();
            Console.WriteLine(chrs[1] == 'R' ? "ABC" : "ARC");
        }
    }
}
