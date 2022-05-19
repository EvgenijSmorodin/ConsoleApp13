using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(0,100);
            int summ = 0;
            int saveNumber = number;
            Console.WriteLine($"Случайное число {number}");
            while (number > 0)
            {
                if (number % 3 == 0)
                {
                    summ += number;
                   
                }
                else if (number % 5 == 0)
                {
                    summ += number;
                   
                }
                number--;
            }
            Console.WriteLine($"Сумма всех положительных чисел кратных 3 или 5 до числа {saveNumber}(включительно) равняется {summ}") ;

        }
    }
}
