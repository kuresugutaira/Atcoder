using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            var rgb = new Int64[3];
            var len = int.Parse(Console.ReadLine());
            var chars = Console.ReadLine().ToCharArray();
            /* 全探索アルゴリズム(時間が足りない)
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
            }*/
            foreach(char c in chars)
            {
                if (c == 'R') rgb[0]++;
                else if (c == 'G') rgb[1]++;
                else rgb[2]++;
            }
            //考えられる組み合わせの総数
            Int64 allC = rgb[0] * rgb[1] * rgb[2];
            for (int i = 0; i < len; i++)
            {
                for(int j = i + 1; j < len; j++)
                {
                    if (2 * j - i < len)//k-j=j-iの時、k=2j-i,kが範囲外のときは考えない
                    {
                        if (chars[i] != chars[j] && chars[j] != chars[2 * j - i] && chars[i] != chars[2 * j - i])
                        {
                            allC--;
                        }
                    }
                }
            }
            Console.WriteLine(allC);
        }
    }
}
