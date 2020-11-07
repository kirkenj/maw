using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.models
{
    public static class B5Logic
    {
        public static int GetDaysInMonthNumber(int monthNumber)
        {
            int[] daysInMonthes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (monthNumber > 0 && monthNumber < 13)
            {
                return daysInMonthes[monthNumber - 1];
            }
            return -1;
        }
    }
}
