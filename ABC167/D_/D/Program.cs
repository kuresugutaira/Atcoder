using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            var nk = Console.ReadLine().Split(' ');
            var n = long.Parse(nk[0]);
            var k = long.Parse(nk[1]);
            var mati = new long[n+1][];//1~Nまでのindexが街、要素がテレポート先
            var arr = Console.ReadLine().Split(' ');
            for (int i = 1; i < n + 1; i++)
            {
                mati[i] = new long[2];
                mati[i][0] = long.Parse(arr[i-1]);
                mati[i][1] = 0;
            }
            long count = 0;
            long tmp = 1;
            long buff = 0;
            for (int i = 1; i < n+1; i++)
            {
                if (mati[tmp][1] == 0)
                {
                    mati[tmp][1] = -i;
                }
                else
                {
                    count += mati[tmp][1];
                    count++;
                    buff = -mati[tmp][1] -1;
                    break;
                }
                tmp = mati[tmp][0];
                count++;
            }
            k -= buff;
            k %= count;
            for(int i = 0; i < k; i++)
            {
                tmp = mati[tmp][0];
            }
            Console.WriteLine(tmp);
        }
    }
}