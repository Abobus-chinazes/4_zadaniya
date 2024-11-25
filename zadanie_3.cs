using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rkis_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());

            if (sum < 100)
            {
                sum += sum * 0.05;
            }
            else if (sum <= 200)
            {
                sum += sum * 0.07;
            }
            else
            {
                sum += sum * 0.1;
            }
            Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");

            Console.ReadKey();
        }
    }
}