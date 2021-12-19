using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int n2 = 0;
            int suma = 0;
            for (int i = 1; i < n; i++)
            {
                if (!(i % 2 == 0))
                {
                    n2 = i + (2 * n - 1);
                    suma += n2;
                    Console.WriteLine("Значение сумм квадрата числа {0} равен {1}", i, suma);

                }

            }
            Console.ReadKey();
        }
    }
}
