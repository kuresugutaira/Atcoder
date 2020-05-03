using System;
using System.Linq;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            var n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            IEnumerable<string> result = list.Distinct();
            Console.WriteLine(result.Count());
        }
    }
}
