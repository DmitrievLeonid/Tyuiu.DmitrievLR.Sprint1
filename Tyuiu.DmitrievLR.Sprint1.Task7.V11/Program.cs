using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint1.Task7.V11.Lib;

namespace Tyuiu.DmitrievLR.Sprint1.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            //Сокращаем ссылку на DataService

            Console.Title = " Спринт 1 | Выполнил Дмитриев Л. Р.  | ИИПб-23-1 ";

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант: #11                                                           *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПб-23-1                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение         *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                  *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("        (ln(sin x))^x                                                     ");
            Console.WriteLine("  z = --------------- + (y - sqrt(abs(x))                                 ");
            Console.WriteLine("         ln(1 + x^2)                                                      ");
            /*
             *      (ln(sin x))^x
             * z = --------------- + (y - sqrt(abs(x))
             *      ln(1 + x^2)
             */
            Console.WriteLine("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate(x,y));

            Console.ReadKey();

        }
    }
}
