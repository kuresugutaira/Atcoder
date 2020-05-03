using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());
            var tmp = Console.ReadLine().Split(' ');
            var a = int.Parse(tmp[0]);
            var b = int.Parse(tmp[1]);
            var flag = false;
            for (int i = 0; i < 1000 / k + 1; i++)
            {
                if(a <= i * k && i * k <= b)
                {
                    flag = true;
                }
            }
            Console.WriteLine(flag ? "OK" : "NG");
        }
    }
}
