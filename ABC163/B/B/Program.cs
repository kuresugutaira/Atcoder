using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(' ');
            var data = Console.ReadLine().Split(' ');
            var sum = 0;
            foreach (string str in data)
            {
                sum += int.Parse(str);
            }
            sum = int.Parse(nm[0]) - sum;
            if (sum >= 0) {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
