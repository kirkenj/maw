using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.models
{
    public static class B2AstrologyLogic
    {
		public static int GetZnakForBirthDay(int[] birthDate)
		{
			int i;
			int[,] periods = new int[12,2];
			periods = { { 21, 3 },      /*oven*/        { 21,  4},	   /*telezz*/
								 { 22,  5},		/*bliznezzi*/   { 23,  6},	   /*rak*/
								 { 24,  7},		/*lev*/		    { 24,  8},	   /*Deva*/
								 { 24,  9},		/*vesi*/   	    { 23, 10},	   /*scorpion*/
								 { 23, 11},		/*strlezz*/		{ 21, 12},	   /*kozerog*/
								 { 21,  1},		/*vodolei*/	    { 20,  2}      /*ribi*/;

			}

			while (periods[i][1] != birthDate[1])
			{
				i++;
			}
			if (birthDate[0] < periods[i][0])
			{
				if (i == 0) i = 11; else i -= 1;
			}
			return i;
		}

	}
}
