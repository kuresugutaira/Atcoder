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
            var len = int.Parse(Console.ReadLine());
            var que = new Queue<char>();
            var tmp = new char[] { 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            for (int i = 0; i < len; i++)
            {
                que.Enqueue('a');
            }
            for(int i = 0; i < 9; i++)
            {
                que.Enqueue(tmp[i]);
            }
            for(int i = 0; i < len; i++)
            {
                var result = new char[20];
                que.CopyTo(result, i);
                for(int j = 0; j < len; j++)
                {
                    Console.Write(result[i + j]);
                }
                Console.WriteLine();
                //que.Enqueue(tmp[i]);
                que.Dequeue();
            }
            Console.ReadKey();
        }
    }
}
