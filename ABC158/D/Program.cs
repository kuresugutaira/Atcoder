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
                        str = str.Insert(0, info[i][2]);
                    }
                    else if(info[i][1] == "1" && count % 2 == 0)
                    {
                        str = str.Insert(0, info[i][2]);
                    }
                    else
                    {
                        str += info[i][2];
                    }
                }
            }
            if (count % 2 == 1)
            {
                var result = str.ToCharArray();
                for (int i = result.Length - 1; i > -1; i--)
                {
                    Console.Write(result[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}
