using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.models
{
	public static class B8AstrologyLogic
	{
		static string[] ZODIAKS = { "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces" };
		static int[,] PERIODS ={			  { 21,  3},        /*Aries*/       { 21,  4},	   /*Taurus*/
											  { 21,  5},		/*Gemini*/		{ 22,  6},	   /*Cancer*/
											  { 23,  7},		/*Leo*/		    { 24,  8},	   /*Virgo*/
											  { 24,  9},		/*Libra*/  	    { 24, 10},	   /*Scorpio*/
											  { 23, 11},		/*Sagittarius*/	{ 22, 12},	   /*Capricorn*/
											  { 21,  1},		/*Aquarius*/    { 21,  2}      /*Pisces*/};
		//array elements determine intervals of zodiaks. In comments u can see for wich zodiac each period is.
		//first element of the array pair determines the day since wich the following period starts
		public static string GetZodiakForBirthDay(int birthDay, int birthMonth)
		{
			if (birthDay > B5DaysForMonthNumberLogic.GetDaysInMonthNumber(birthMonth) || birthDay < 1 || birthMonth>12 || birthMonth<1)
            {
				return "Wrong Input";
            }
			int i = 0;
			
			while (PERIODS[i,1] != birthMonth)
			{
				i++;
			}
			if (birthDay < PERIODS[i,0])
			{
				if (i == 0) 
				{ 
					i = 11; 
				} 
				else 
				{
					i -= 1;
				};
			}
			return ZODIAKS[i];
		}

	}
}
