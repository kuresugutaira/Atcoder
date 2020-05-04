using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            for(int a=-199; a < 200; a++)
            {
                for(int b=-200; b < a; b++)
                {
                    if (x == a * a * a * a * a - b * b * b * b * b)
                    {
                        Console.WriteLine(a + " " + b);
                        goto label;
                    }
                }
            }
        label:;
        }
    }
}
