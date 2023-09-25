using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DmitrievLR.Sprint1.Task2.V11.Lib
{
    public class DataService : ISprint1Task2V11
    {
        public int ConvertHoursMinutesToSeconds(int hours, int minutes)
        {
            // Часы в секунды и минуты в секунды
            int seconds = (hours * 3600) + (minutes * 60);

            return seconds;
        }
    }
}
