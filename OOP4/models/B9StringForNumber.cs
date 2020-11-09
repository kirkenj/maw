using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.models
{
    public static class B9StringForNumber
    {
        static string[] HUNDREEDS_STR = { "One Hundreed", "Two Hundreed", "Three Hundreed", "Four Hundreed", "Five Hundreed", "Six Hundreed", "Seven Hundreed", "Eight Hundreed", "Nine Hundreed" };
        static string[] UNITS_FROM_11_TO_19 = { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] DOZENS_STR = { "\b", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] UNITS_STR = { "\b", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };



        private static int[] GetDigits(int number)
        {
            List<int> listOfNumbers = new List<int> { };
            while (number > 0)
            {
                listOfNumbers.Add(number % 10);
                number /= 10;
            }
            listOfNumbers.Reverse();
            return listOfNumbers.ToArray();
        }

        private static string GetStrForLess10(int units)
        {
            if (units > 9 || units < 0)
            {
                return "Wrong input";
            }
            return UNITS_STR[units];
        }

        private static string GetStrForLess100(int dozens, int units)
        {
            
            if ((units > 9 || units < 0) || (dozens > 9 || dozens < 0))
            {
                return "Wrong Input";
            }
            if (dozens == 1 && units > 0)
            {
                return UNITS_FROM_11_TO_19[units - 1];
            }
            return $"{DOZENS_STR[dozens]} {GetStrForLess10(units)}";
        }

        private static string GetStrForMore100(int hundreeds, int dozens, int units)
        {
            if ((units > 9 || units < 0) || (dozens > 9 || dozens < 0) || (hundreeds > 9 || hundreeds < 1))
            {
                return "Wrong Input";
            }
            return $"{HUNDREEDS_STR[hundreeds - 1]} {GetStrForLess100(dozens, units)}";
        }

        public static string GetStringForNumber(int number)
        {
            if (number == 0)
            {
                return "Zero";
            }
            int[] digits = GetDigits(number);
            int len = digits.Length;

            switch (len)
            {
                case 3:
                    {
                        return GetStrForMore100(digits[0], digits[1], digits[2]);
                    }
                case 2:
                    {
                        return GetStrForLess100(digits[0], digits[1]);
                    }
                case 1:
                    {
                        return GetStrForLess10(digits[0]);
                    }
                default:
                    {
                        return "Input limits are [0;1000)";
                    }
            }
        }
    }
}
