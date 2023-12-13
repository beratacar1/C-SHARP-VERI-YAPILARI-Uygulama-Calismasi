using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzyinelemeOrnek_2
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int tmp = 1;
            int n = 8;
            for (int i = 1; i <= n; i++)
            {
                tmp *= i;
            }
            Console.WriteLine(tmp);

            Console.WriteLine(Program.faktoriyel(n)); 
            Console.WriteLine(Program.faktoriyel2(n, n)); 
        }

        public static int faktoriyel2(int a, int b)
        {
            if (a == 1)
            {
                return 1;
            }
            return i * faktoriyel2(a, i + 1);
        }

        public static int faktoriyel(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a * faktoriyel(a - 1);
        }
    }
}
