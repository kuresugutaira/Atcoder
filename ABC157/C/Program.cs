using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(' ');
            var keta = int.Parse(nm[0]);
            var time = int.Parse(nm[1]);
            var info = new string[time][];
            var result = "-1";
            var flag = true;
            for(int i = 0; i < time; i++)
            {
                info[i] = Console.ReadLine().Split(' ');
            }
            var num = new char[keta];
            for(int i = 0; i < keta; i++)
            {
                num[i] = 'e';
            }
            for(int i = 0; i < time; i++)
            {
                if (num[int.Parse(info[i][0]) - 1] == 'e')
                {
                    var tmp = info[i][1].ToCharArray();
                    num[int.Parse(info[i][0]) - 1] = tmp[0];
                }
                else
                {
                    var tmp = info[i][1].ToCharArray();
                    if (num[int.Parse(info[i][0]) - 1] != tmp[0])
                    {
                        flag = false;
                        break;
                    }
                }
                if(num[0] == '0')
                {
                    flag = false;
                    break;
                }
            }
            if(keta != 1 && num[0] == 'e') { num[0] = '1'; }
            if (keta == 1 && num[0] == '0'|| keta == 1 && num[0] == 'e')
            {
                flag = true;
                num[0] = '0';
            }
            for (int i = 1; i < keta ; i++)
            {
                if(num[i] == 'e') { num[i] = '0'; }
            }
            if (flag == true) { result = new string(num); }
            Console.WriteLine(result);
            //Console.ReadKey();
        }
    }
}
