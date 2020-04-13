using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var num = int.Parse(Console.ReadLine());
            for(int i = 1; i < num+1; i++)
            {
                for (int j = 1; j < num+1; j++)
                {
                    for (int k = 1; k < num+1; k++)
                    {
                        sum += Gcd(i, Gcd(j,k));
                    }
                }
            }
            Console.WriteLine(sum);
        }

        public static int Gcd(int a, int b)
        {
            if (a < b)
                // 引数を入替えて自分を呼び出す
                return Gcd(b, a);
            while (b != 0)
            {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

    }
}
