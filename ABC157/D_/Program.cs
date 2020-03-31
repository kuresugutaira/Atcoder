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
            var buffer = new int[ninzuu + 1];
            var uni = new UnionFind(ninzuu + 1);

            for(int i = 0; i < tomo; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var x = int.Parse(line[0]);
                var y = int.Parse(line[1]);
                uni.Union(x, y);
                buffer[x]++;
                buffer[y]++;
            }
            for(int i = 0; i < block; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var x = int.Parse(line[0]);
                var y = int.Parse(line[1]);
                if (uni.isSame(x, y))
                {
                    buffer[x]++;
                    buffer[y]++;
                }
            }
            for (int i = 1; i < ninzuu + 1; i++)
            {
                Console.Write(uni.Size(i) - buffer[i] - 1 + " ");
            }
            Console.ReadKey();
        }
    }

    class UnionFind
    {
        public int[] Parents { get; set; }

        public UnionFind(int size)
        {
            Parents = new int[size];
            for(int i = 0; i < size; i++)
            {
                this.Parents[i] = -1;
            }
        }

        public int Find(int x)
        {
            if (this.Parents[x] < 0) return x;

            this.Parents[x] = Find(this.Parents[x]);
            return this.Parents[x];
        }

        public int Size(int x)
        {
            return -this.Parents[this.Find(x)];
        }

        public bool isSame(int x,int y)
        {
            return this.Find(x) == this.Find(y);
        }

        public void Union(int x,int y)
        {
            x = this.Find(x);
            y = this.Find(y);
            if (x == y) return;
            if(Size(x) > Size(y))
            {
                var tmp = x;
                x = y;
                y = tmp;
            }
            this.Parents[y] += this.Parents[x];
            this.Parents[x] = y;
        }
    }
}
