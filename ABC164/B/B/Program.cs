using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ');
            var flag = true;
            var tHP = int.Parse(data[0]);
            var tAP = int.Parse(data[1]);
            var aHP = int.Parse(data[2]);
            var aAP = int.Parse(data[3]);

            while(true)
            {
                aHP -= tAP;
                if (aHP <= 0)
                {
                    break;
                }
                tHP -= aAP;
                if(tHP <= 0)
                {
                    flag = false;
                    break;
                }
            }
            Console.WriteLine(flag ? "Yes" : "No");
        }
    }
}
