using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint1.Task2.V11.Lib;

/*
 * Написать программу, 
 * которая запрашивает у пользователя исходные данные, 
 * выполняет указанные расчёты и печатает результат на экране.
 */

namespace Tyuiu.DmitrievLR.Sprint1.Task2.V11
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
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант: #11                                                           *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПб-23-1                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            /*
             *   Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                 Console.WriteLine("**************************************************************************");
             */
            Console.WriteLine("Введите количество часов: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество минут: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Секунд прошло с начала суток: " + ds.ConvertHoursMinutesToSeconds(hours,minutes));


            Console.ReadKey();
        }
    }
}
