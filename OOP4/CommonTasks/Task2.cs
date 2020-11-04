using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OOP4.CommonTasks
{
    class Task2
    {
        const string Start_MSG = "Task 2: find max from user inpnut\n Input array of double:\n";

        public static int Run() { 
            OutlnConsole.Print(Start_MSG);
            double[] arr = UserInput.ADoubleArray();
            OutlnConsole.Print($"Maximal element is {arr.Max()}");
            return 0;
        }
    }
}
