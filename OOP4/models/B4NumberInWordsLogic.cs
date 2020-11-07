using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.models
{
    public static class B4NumberInWordsLogic
    {
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

        private static string ForLess10(int units)
        { 
            string[] unitsStr = { "\b","One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            if (units > 9 || units < 0)
            {
                return "Wrong input";
            }
            return unitsStr[units];
        }

        private static string ForLess100(int dozens, int units)
        {    
            string[] unitsFrom11To19 = { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] dozensStr = { "\b","Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        
            if ( (units >9 || units <0) ||(dozens>9 || dozens<0))
            {
                return "Wrong Input";
            }
            if (dozens==1 && units > 0)
            {
                return unitsFrom11To19[units - 1];
            }        
            return $"{dozensStr[dozens]} {ForLess10(units)}";
        }

        private static string ForMore100(int hundreeds, int dozens, int units)
        {
            if ((units > 9 || units < 0) || (dozens > 9 || dozens < 0) || (hundreeds > 9 || hundreeds <1))
            {
                return "Wrong Input";
            }
            string[] hundreedsStr = { "One Hundreed", "Two Hundreed", "Three Hundreed", "Four Hundreed", "Five Hundreed", "Six Hundreed", "Seven Hundreed", "Eight Hundreed", "Nine Hundreed" };
            return $"{hundreedsStr[hundreeds-1]} {ForLess100(dozens,units)}";
        }

        public static string GetStringOfNumber(int number)
        {
            if (number == 0)
            {
                return "Zero";
            }
            int[] digits = GetDigits(number);
            int len = digits.Length;
            if (len ==3)
            {
                return ForMore100(digits[0],digits[1],digits[2]);
            }
            if (len == 2)
            {
                return ForLess100(digits[0],digits[1]);
            }
            if (len ==1)
            {
                
                return ForLess10(digits[0]);
            }
            return "Input limits are [0;1000)";
        }
    }
}
