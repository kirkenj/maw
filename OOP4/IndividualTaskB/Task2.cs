using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.IndividualTaskB
{
    class Task2
    {
        const string START_MSG = "Individual task B: Task2.\nProgramm gives u a comment according to the mark";

        public static void Run()
        {
            string msg;
            OutlnConsole.Print(START_MSG);
            int m = UserInput.AnInt("Input mark:");
            
            //заменить ифы на switch - case
            if (m < 0 || m > 10)
            {
                msg = "We don't have such mark...)";
            }
            else
            {
                if (m <= 1)
                {
                    msg = "Very bad";
                }
                else if (m <= 3)
                {
                    msg = "Poor";
                }
                else if (m <= 5)
                {
                    msg = "Satisfactory";
                }
                else if (m <= 7)
                {
                    msg = "You cood be better";
                }
                else if (m == 8)
                {
                    msg = "It's still to little for ur mom";
                }
                else if (m == 9)
                {
                    msg = "Why not 10?";
                }
                else
                {
                    msg = "Good";
                }
            }
            OutlnConsole.Print(msg);
        }
    }
}
