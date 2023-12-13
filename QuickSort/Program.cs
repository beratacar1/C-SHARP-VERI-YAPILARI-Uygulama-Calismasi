using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        public static object Arrays { get; private set; }

        static void Main(string[] args)
        {

            {
                int[] d = { 8, 1, 4, 7, 2, 6, 9, 3, 14, 20, 10 };
                Console.WriteLine(Arrays.ToString(d));
                Program.quickSort(d, 0, d.Length - 1);
                Console.WriteLine(Arrays.ToString(d));
            }

             void quickSort(int[] d, int l, int r)
            {
                if (l < r)
                {
                    int pi = partition(d, l, r);
                    quickSort(d, l, pi - 1);
                    quickSort(d, pi + 1, r);
                }
            }

             int partition(int[] d, int l, int r)
            {
                int pi = r; // sayı olarak tutacak olsaydık d[r] biçiminde yazacaktık
                int i = l;
                int j = r - 1;

                do
                {
                    while (d[i] < d[pi] && i < r) i++;
                    while (d[j] > d[pi] && j > 0) j--;
                    if (i < j) swap(d, i, j);
                } while (i < j);
                swap(d, i, pi);


                return i;
            }

             void swap(int[] d, int i, int j)
            {
                int tmp = d[i];
                d[i] = d[j];
                d[j] = tmp;
            }
        }

        private static void quickSort(int[] d, int v, object value)
        {
            throw new NotImplementedException();
        }
    }
}
