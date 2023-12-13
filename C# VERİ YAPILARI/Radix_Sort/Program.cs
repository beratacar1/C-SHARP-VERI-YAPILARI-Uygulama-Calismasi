using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix_Sort
{
    internal class Program
    {
        public static object Arrays { get; private set; }

        static void Main(string[] args)
        {
            
            {
                int[] d = { 178, 12, 9, 199, 354, 17, 23, 453, 170, 20, 30 };
                Console.WriteLine(Arrays.ToString(d));
                Program.radixSort(d);
                Console.WriteLine(Arrays.ToString(d));
            }
            void countSort(int[] d, int e)
            {
                int n = d.Length;
                int[] t = new int[n];
                int[] c = new int[10];
                int i = 0;

                for (i = 0; i < n; i++)
                {
                    c[d[i] / e % 10]++;
                }
                for (i = 1; i < 10; i++)
                {
                    c[i] += c[i - 1];
                }

                for (i = n - 1; i >= 0; i--)
                {
                    t[--c[(d[i] / e) % 10]] = d[i];
                }

                for (i = 0; i < n; i++)
                {
                    d[i] = t[i];
                }
            }

            void radixSort(int[] d)
            {
                int max = Program.findMax(d);
                for (int e = 1; (max / e) > 0; e *= 10)
                {
                    Program.countSort(d, e);
                }
            }
        }

        private static void radixSort(int[] d)
        {
            throw new NotImplementedException();
        }

        private static int findMax(int[] d)
        {
            throw new NotImplementedException();
        }

        private static void countSort(int[] d, int e)
        {
            throw new NotImplementedException();
        }
    }
}

