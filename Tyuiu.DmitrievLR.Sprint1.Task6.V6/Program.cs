using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint1.Task6.V6.Lib;

namespace Tyuiu.DmitrievLR.Sprint1.Task6.V6
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
            Console.WriteLine("* Тема: Работа со строками класс String                                  *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант: #6                                                            *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПб-23-1                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                         *");
            Console.WriteLine("* Напечатать все слова, удалив из них первую букву.                      *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            /*
             *   Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                 Console.WriteLine("**************************************************************************");
             */

            Console.WriteLine("Введите текст: ");
            string x = Console.ReadLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.DeleteFirstLetter(x));

            Console.ReadKey();

        }
    }
}
