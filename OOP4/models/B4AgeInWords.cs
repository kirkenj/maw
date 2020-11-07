using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.models
{
    public static class B4AgeInWords
    {
        static int BOTTOM_AGE = 0;
        static int UPPER_AGE = 120;
        public static string GetStringOfAge(int age)
        {
            if (age >= BOTTOM_AGE && age <= UPPER_AGE)
            {
                return $"{B9StringForNumber.GetStringForNumber(age)} y.o.";
            }
            return $"Age more than {UPPER_AGE} or less than {BOTTOM_AGE} is counted incorrect";
        }
    }
}
