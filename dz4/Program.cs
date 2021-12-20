using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значение N большее 0");
            int N = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int sum = 0;

            if (N > 0)
            {
                for(int i = 1; i <=2*N-1; i=i+2)
                {
                    x +=i;
                    Console.WriteLine(x);
                    sum= x;
                }
            }
            else
            {
                Console.WriteLine("Введено неверное условие");
            }
            Console.WriteLine("квадрат числа равен {0}  " , sum);
            Console.ReadKey();

        }
    }
}
