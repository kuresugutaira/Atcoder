using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = long.Parse(Console.ReadLine());
            var count = 0;
            long man = 100;
            while (true)
            {
                count++;
                man = (long)(man * 1.01d);
                //Console.Write(man + " ");
                if (man >= x) break;
            }
            Console.WriteLine(count);
        }
    }
}
