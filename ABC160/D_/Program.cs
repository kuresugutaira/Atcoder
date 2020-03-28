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
            var input = Console.ReadLine().Split(' ');
            var time = int.Parse(input[0]);
            int[][] graph = new int[time][];
            for(int i = 0; i < time; i++)
            {
                graph[i] = new int[time];
            }
            for(int i = 0; i < time; i++)
            {
                graph[i][i + 1] = 1;
            }
            graph[int.Parse(input[1])][int.Parse(input[2])] = 1;

        }
    }
}
