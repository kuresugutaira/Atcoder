using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var tmp = 0;
            var result = 0;
            var i = 1;
            while (tmp + i - 1 < str.Length)
            {
                if(long.Parse(str.Substring(tmp,i)) % 2019 == 0)
                {
                    tmp += i - 1;
                    i = 0;
                    result++;
                }
                i++;
            }
            Console.WriteLine(result);

        }
    }
}
