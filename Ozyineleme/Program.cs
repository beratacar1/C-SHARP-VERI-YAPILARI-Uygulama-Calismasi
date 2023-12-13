using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozyineleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fiboonacci Örnek
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;

            Console.WriteLine(n1 + ", ");
            Console.WriteLine(n2 + ", "); 

            for (int i = 2; i < 9; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + ",");
                n1 = n2;
                n2 = n3;
            }

            Console.WriteLine("\n----------------------");

            Console.WriteLine(Program.fibonacci(9)); 
        }


        public static int fibonacci(int a)
        {
            if (a == 1) return 0;
            else if (a < 4) return 1;
            return fibonacci(a - 1) + fibonacci(-2);
        }
    }
}