using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PimenovaTS.Sprint4.Task3.V17.Lib;

namespace Tyuiu.PimenovaTS.Sprint4.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Пименова Т. С. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                            * ");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Пименова Т. С. | ИИПб-23-2                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8. Найдите сумму элементов  *");
            Console.WriteLine("* в четвертом столбце массива.                                            *");
            Console.WriteLine("* 6, 4, 2, 2, 1,                                                          *");
            Console.WriteLine("* 3, 6, 5, 4, 1,                                                          *");
            Console.WriteLine("* 5, 2, 3, 1, 6,                                                          *");
            Console.WriteLine("* 8, 8, 4, 5, 3,                                                          *");
            Console.WriteLine("* 7, 4, 5, 1, 6,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] job = new int[5, 5] { { 6, 4, 2, 2, 1 }, { 3, 6, 5, 4, 1 }, { 5, 2, 3, 1, 6 }, { 8, 8, 4, 5, 3 }, { 7, 4, 5, 1, 6 } };
            int kols = job.GetUpperBound(0) + 1;
            int kolst = job.Length / kols;
            Console.WriteLine("Массив: ");
            for (int i = 0; i < kols; i++)
            {
                for (int j = 0; j < kolst; j++)
                {
                    Console.Write($"{job[i, j]} \t");
                }
                Console.WriteLine();
            }
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма элементов четвёртого столбца массива = " + ds.Calculate(job));
            Console.ReadKey();
        }
    }
}
