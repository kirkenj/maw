using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.IndividualTaskB
{
    class Task1
    {
        const string START_MSG = "IndividualTaskB: Task1\nProgramm shows equal day for inputet number";
        static string[] WEEK = { "Monday", "Tuesday", "Wednessday", "Thursday", "Friday", "Saturday", "Sunday" };

        public static void Run()
        {
            OutlnConsole.Print(START_MSG);
            int inp = UserInput.AnInt("Input the number of the day in week");
            if(inp<7 && inp>0)
            {
                OutlnConsole.Print(WEEK[inp - 1]);
            }
            else
            {
                OutlnConsole.Print("Inputed number is out of range");
            }
        }
    }
}
