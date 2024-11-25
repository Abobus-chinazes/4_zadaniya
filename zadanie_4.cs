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
            double percent = 0;
            if (sum < 100)
            {
                percent = 0.05;
            }
            else if (sum <= 200)
            {
                percent = 0.07;
            }
            else
            {
                percent = 0.1;
            }
            sum += sum * percent + 15;

            Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");

            Console.ReadKey();
        }
    }
}