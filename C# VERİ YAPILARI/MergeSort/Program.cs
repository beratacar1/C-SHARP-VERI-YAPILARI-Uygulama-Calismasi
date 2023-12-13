using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        public static object Arrays { get; private set; }

        static void Main(string[] args)
        {
            int[] d = { 3, 7, 1, 8, 2, 6, 4, 5, 9 };
            Console.WriteLine(Arrays.ToString(d));
            Program.mergeSort(d, 0, d.Length - 1);
            Console.WriteLine(Arrays.ToString(d));
            
        }

        private static void mergeSort(int[] d, int v, object value)
        {
            throw new NotImplementedException();
        }

        public static void mergeSort(int[] d, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                mergeSort(d, l, m);
                mergeSort(d, m + 1, r);
                merge(d, l, m, r);
            }
        }

        public static void merge(int[] d, int l, int m, int r)
        {
            int i = l;
            int j = m + 1;

            int[] t = new int[r - l + 1];
            int k = 0;

            while (i <= m && j <= r)
            {
                if (d[i] < d[j])
                {
                    t[k] = d[i];
                    i++;
                }
                else
                {
                    t[k] = d[j];
                    j++;
                }
                k++;
            }

            while (i <= m)
            {
                t[k] = d[i];
                i++;
                k++;

            }


            while (j <= r)
            {
                t[k] = d[j];
                j++;
                k++;
            }

            for (i = 0; i < t.Length; i++)
            {
                d[l++] = t[i];
            }
        }
    }
    }
}
