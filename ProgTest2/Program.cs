using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            Console.Write("Input1 : ");
            N = int.Parse(Console.ReadLine());


            int[] A = new int[N];
            for (i = 0; i < N; i++)
            {
                Console.Write("Input2 ke " + i + ":  ");
                A[i] = int.Parse(System.Console.ReadLine());
            }
            for (int j = 0; j < N; j++)
            {
                if (j == 0)
                {
                    Console.Write("0 ");
                }
                else
                {
                    if (A[j] > A[j - 1])
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        int l = 0;
                        for (int k = 0; k < j; k++)
                        {
                            if (A[j] < A[k])
                            {
                                l++;
                            }
                        }
                        Console.Write(l + " ");
                    }
                }
            }
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
