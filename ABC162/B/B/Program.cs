using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Int64 sum = 0;
            for(int i = 1; i < num + 1; i++)
            {
                if(i % 3 != 0 && i % 5 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
