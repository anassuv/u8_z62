using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 4;

            int[,] a = new int [n, n];

            int k = 0;
            for (int i = 0; i <= n / 2; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    k++;
                    a[i, j] = k;
                }
                for (int j = i + 1; j < n - i; j++)
                {
                    k++;
                    a[j, n - i - 1] = k;
                }
                for (int j = n - 2 - i; j > i; j--)
                {
                    k++;
                    a[n - i - 1, j] = k;
                }
                for (int j = n - 1 - i; j > i; j--)
                {
                    k++;
                    a[j, i] = k;
                }
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:00}", a[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
