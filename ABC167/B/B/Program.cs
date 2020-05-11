using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ');
            var a = int.Parse(arr[0]);
            var b = int.Parse(arr[1]);
            var c = int.Parse(arr[2]);
            var k = int.Parse(arr[3]);
            var result = 0;
            if(k < a)
            {
                result += k;
            }else if(k <= a + b)
            {
                result += a;
            }
            else
            {
                result += a - (k - a - b);
            }
            Console.WriteLine(result);
        }
    }
}
