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
            var a = new string[3][];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Console.ReadLine().Split(' ');
            }
            var time = int.Parse(Console.ReadLine());
            var nums = new string[time];
            for(int i = 0; i < time; i++)
            {
                nums[i] = Console.ReadLine();
            }
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    for(int k = 0; k < time; k++)
                    {
                        if(nums[k] == a[i][j])
                        {
                            a[i][j] = "O";
                        }
                    }
                }
            }
            Console.WriteLine(Check(a));
            //Console.ReadKey();
        }

        static string Check(string[][] a)
        {
            string check = "No";
            if(a[0][0] == "O" && a[0][1] == "O" &&a[0][2] == "O")
            {
                check = "Yes";
            }
            else if(a[1][0] == "O" && a[1][1] == "O" && a[1][2] == "O")
            {
                check = "Yes";
            }
            else if (a[2][0] == "O" && a[2][1] == "O" && a[2][2] == "O")
            {
                check = "Yes";
            }
            else if (a[0][0] == "O" && a[1][0] == "O" && a[2][0] == "O")
            {
                check = "Yes";
            }
            else if (a[0][1] == "O" && a[1][1] == "O" && a[2][1] == "O")
            {
                check = "Yes";
            }
            else if (a[0][2] == "O" && a[1][2] == "O" && a[2][2] == "O")
            {
                check = "Yes";
            }
            else if (a[0][0] == "O" && a[1][1] == "O" && a[2][2] == "O")
            {
                check = "Yes";
            }
            else if (a[0][2] == "O" && a[1][1] == "O" && a[2][0] == "O")
            {
                check = "Yes";
            }
            return check;
        }
    }
}
