using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 count = 0;
            var len = int.Parse(Console.ReadLine());
            var chars = Console.ReadLine().ToCharArray();
            for(int i = 0; i < len - 2; i++)
            {
                for(int j = i + 1;j<len - 1; j++)
                {
                    if(chars[j] != chars[i])
                    {
                        for(int k = j+1;k<len; k++)
                        {
                            if(chars[i] != chars[k] && chars[j] != chars[k] && k - j != j - i)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
