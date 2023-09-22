using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint1.Task3.V5.Lib;

/*Написать программу, которая запрашивает у пользователя исходные данные,
 * выполняет указанные расчёты и печатает результат на экране.
 * Написать программу вычисления расстояния между населенными пунктами, изображенными на карте.
 */

namespace Tyuiu.DmitrievLR.Sprint1.Task3.V5
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
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                     *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант: #5                                                            *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПб-23-1                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу вычисления расстояния между населенными пунктами,   *");
            Console.WriteLine("* изображенными на карте.                                                *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            /*
             *   Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                 Console.WriteLine("**************************************************************************");
             */
            Console.WriteLine("Введите масштаб карты (количество км. в одном см.): ");
            double Scale = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расстояние между точками, изображающими населенные пункты (см) : ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            var result = ds.DistanceLength(Scale, distance);
            Console.WriteLine("Расстояние между населенными пунктами: " + result + " Км.");

            Console.ReadKey();
        }
    }
}
