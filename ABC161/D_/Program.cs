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
            var num = int.Parse(Console.ReadLine());
            var que = new Queue<Int64>();
            for (int i = 1; i < 10; i++)
            {
                que.Enqueue(i);
            }
            for(int i = 0; i < num - 1; i++)
            {
                Action(que);
            }
            Console.WriteLine(Action(que));
            Console.ReadKey();
        }
        static Int64 Action(Queue<Int64> que)
        {
            var x = que.Dequeue();
            if (x % 10 != 0) que.Enqueue(10 * x + (x % 10) - 1);
            que.Enqueue(10 * x + (x % 10));
            if (x % 10 != 9) que.Enqueue(10 * x + (x % 10) + 1);
            return x;
        }
    }
}
