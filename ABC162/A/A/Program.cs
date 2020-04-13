using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().ToCharArray();
            bool flag = false;
            foreach(char n in nums)
            {
                if(n == '7')
                {
                    flag = true;
                }
            }
            Console.WriteLine(flag ? "Yes" : "No");
        }
    }
}
