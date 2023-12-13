using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    internal class Program
    {
        public static object Arrays { get; private set; }

        static void Main(string[] args)
        {
            int[] a = { 5, 7, 2, 1, 9, 8, 6, 4 };
            Console.WriteLine(Arrays.toString(a));
            Program.shellSort(a);
            Console.WriteLine(Arrays.toString(a));
        }

        public static void shellSort(int[] d)
        {
            int tmp = 0;
            int i = 0, j = 0;
            int gap = 0;


            for (gap = d.Length / 2; gap > 0; gap /= 2)
            {
                for (i = gap; i < d.Length; i += gap)
                {
                    tmp = d[i];

                    {


                        for (j = i; j > 0 && d[j - gap] > tmp; j -= gap)
                        {
                            d[j] = d[j - gap];
                        }
                        d[j] = tmp;
                    }
                }
            }
        }
    }
}
