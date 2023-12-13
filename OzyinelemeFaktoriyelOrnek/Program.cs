using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzyinelemeFaktoriyelOrnek
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            // Faktöriyel hesaplama örneği

            {
                int tmp = 1;
                int n = 8;
                for (int i = 1; i <= n; i++)
                {
                    tmp *= i;
                }
                Console.WriteLine(tmp);

                Console.WriteLine(Program.faktoriyel(n));
                Console.WriteLine(Program.faktoriyel(n));
            }

            int faktoriyel2(int a, int b)
            {
                if (a == 1)
                {
                    return 1;
                }
                return i * faktoriyel2(a, i + 1);
            }

            int faktoriyel(int a)
            {
                if (a == 1)
                {
                    return 1;
                }
                return a * faktoriyel(a - 1);
            }
        }

        private static bool faktoriyel(int n)
        {
            throw new NotImplementedException();
        }
    }
}
