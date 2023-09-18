using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Важно подключать
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.DmitrievLR.Sprint1.Task0.Lib
{
    public class DataService : ISprint1Task0V5 //Alt + Enter для упрощения создания функций
    {
        public double Calculate()
        {
            return (1 + 2) * (1 + 9 / 3);
        }
    }
}
