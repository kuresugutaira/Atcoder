using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var data = Console.ReadLine().Split(' ');
            var result = new int[n];
            foreach(string str in data){
                result[int.Parse(str)-1]++;
            }
            foreach(int num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
