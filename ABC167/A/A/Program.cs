using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            var tmp = t.Substring(0, s.Length);
            Console.WriteLine(s == tmp ? "Yes" : "No");
        }
    }
}
