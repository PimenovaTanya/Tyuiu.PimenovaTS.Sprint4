using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PimenovaTS.Sprint4.Task5.V1.Lib;

namespace Tyuiu.PimenovaTS.Sprint4.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнила: Пименова Т. С. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: вумерные массивы. (генератор случайных чисел)                    * ");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Пименова Т. С. | ИИПб-23-2                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -9 до 8. Заменить положительные    *");
            Console.WriteLine("* элементы на 1.                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество сторк массива: ");
            int kols = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество сторк массива: ");
            int kolst = Convert.ToInt32(Console.ReadLine());

            int[,] zombi = new int[kols, kolst];

            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < kols; i++)
            {
                for (int j = 0; j < kolst; j++)
                {
                    zombi[i, j] = rnd.Next(-9, 8);
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < kols; i++)
            {
                for (int j = 0; j < kolst; j++)
                {
                    Console.Write($"{zombi[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            zombi = ds.Calculate(zombi);

            for (int i = 0; i < kols; i++)
            {
                for (int j = 0; j < kolst; j++)
                {
                    Console.Write($"{zombi[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
