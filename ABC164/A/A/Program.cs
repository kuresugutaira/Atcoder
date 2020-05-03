using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Console.ReadLine().Split(' ');
            var s = int.Parse(sw[0]);
            var w = int.Parse(sw[1]);
            if(s > w) { Console.WriteLine("safe"); }
            else { Console.WriteLine("unsafe"); }
        }
    }
}
