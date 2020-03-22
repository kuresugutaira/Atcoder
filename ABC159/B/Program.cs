using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            var str = Console.ReadLine();
            var n = str.Length;
            var data = str.ToCharArray();
            for(int i = 0; i < (n - 1) / 2; i++)
            {
                if (data[i] != data[n - i - 1]) check = false;
            }
            for (int i = 0; i < ((n - 1) / 2 + 1) / 2; i++)
            {
                if (data[i] != data[(n - 1) / 2 - i - 1]) check = false;
            }
            if (check == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
