using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PimenovaTS.Sprint4.Task4.V11.Lib;

namespace Tyuiu.PimenovaTS.Sprint4.Task4.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Пименова Т. С. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                           * ");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Пименова Т. С. | ИИПб-23-2                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 5 до 8. Найдите сумму нечетных   *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("* 5, 7, 7, 8, 5,                                                          *");
            Console.WriteLine("* 6, 5, 6, 8, 6,                                                          *");
            Console.WriteLine("* 7, 6, 8, 8, 5,                                                          *");
            Console.WriteLine("* 7, 6, 7, 8, 6,                                                          *");
            Console.WriteLine("* 7, 6, 7, 7, 5,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество сторк массива: ");
            int kols = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество сторк массива: ");
            int kolst = Convert.ToInt32(Console.ReadLine());

            int[,] mass = new int[kols, kolst];

            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < kols; i++)
            {
                for (int j = 0; j < kolst; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nЬассив:");
            for (int i = 0; i < kols; i++)
            {
                for (int j = 0; j < kolst; j++)
                {
                    Console.Write($"{mass[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма нечётных элементов массива массива = " + ds.Calculate(mass));
            Console.ReadKey();
        }
    }
}
