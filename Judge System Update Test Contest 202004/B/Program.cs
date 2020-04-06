using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = int.Parse(Console.ReadLine());
            var reds = new List<int>();
            var blues = new List<int>();
            for(int i = 0; i < time; i++)
            {
                var line = Console.ReadLine().Split(' ');
                if(line[1] == "R")
                {
                    reds.Add(int.Parse(line[0]));
                }
                else
                {
                    blues.Add(int.Parse(line[0]));
                }
            }
            reds.Sort();
            blues.Sort();
            foreach(int num in reds)
            {
                Console.WriteLine(num);
            }
            foreach (int num in blues)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
