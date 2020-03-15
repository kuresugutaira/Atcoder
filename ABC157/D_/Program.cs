using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_
{
    class Program
    {
        static void Main(string[] args)
        {
            var nmk = Console.ReadLine().Split(' ');
            var ninzuu = int.Parse(nmk[0]);
            var tomo = int.Parse(nmk[1]);
            var block = int.Parse(nmk[2]);
            var tomos = new string[tomo][];
            var blocks = new string[block][];
            for(int i = 0; i < tomo; i++)
            {
                tomos[i] = Console.ReadLine().Split(' ');
            }
            for (int i = 0; i < block; i++)
            {
                blocks[i] = Console.ReadLine().Split(' ');
            }

        }
    }
}
