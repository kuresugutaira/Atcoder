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
            var str = Console.ReadLine();
            var time = int.Parse(Console.ReadLine());
            var info = new string[time][];
            int count = 0;
            for(int i = 0; i < time; i++)
            {
                info[i] = Console.ReadLine().Split(' ');
                if(info[i][0] == "1")
                {
                    count += 1;
                }
                else
                {
                    if (info[i][1] == "2" && count % 2 == 0)
                    {
                        str += info[i][2];
                    }
                    else if(info[i][1] == "2" && count % 2 == 1)
                    {
                        str = Sentou(str, info[i][2]);
                    }
                    else if(info[i][1] == "1" && count % 2 == 0)
                    {
                        str = Sentou(str, info[i][2]);
                    }
                    else
                    {
                        str += info[i][2];
                    }
                }
            }
            if(count%2 == 1)
            {
                str = Hanntenn(str);
            }
            Console.WriteLine(str);
            //Console.ReadKey();
        }

        static string Hanntenn(string str)
        {
            char[] mojis = str.ToCharArray();
            int time2 = mojis.Length / 2;
            for(int i = 0; i < time2; i++)
            {
                var tmp = mojis[i];
                mojis[i] = mojis[mojis.Length - i - 1];
                mojis[mojis.Length - i - 1] = tmp;
            }
            var st = new string(mojis);
            return st;
        }

        static string Sentou(string str,string moji)
        {
            var mojis = new List<char>(str.ToCharArray());
            var moj = moji.ToCharArray();
            mojis.Insert(0, moj[0]);
            var st = new string(mojis.ToArray());
            return st;
        }
    }
}
