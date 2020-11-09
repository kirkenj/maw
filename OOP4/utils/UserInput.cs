using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;

namespace OOP4
{
    static class UserInput
    {

        public static int AnInt()
        {

            while (true)
            {
                try
                {
                    return Convert.ToInt32(AString());
                }
                catch (Exception ex)
                {
                    OutlnConsole.Print(ex.Message);
                }
            }


        }

        public static double ADouble()
        {
            while (true)
            {
                try
                {
                    return Convert.ToDouble(AString());
                }
                catch (Exception ex)
                {
                    OutlnConsole.Print(ex.Message);
                }
            }
        }
        public static string AString()
        {   
            return Console.ReadLine();
        }


        public static double[] ADoubleArray()
        {
            while (true)
            {
                try
                {
                    string m = UserInput.AString();
                    string[] mas = m.Split();
                    return mas.Select(x => Convert.ToDouble(x)).ToArray();
                }
                catch (Exception ex)
                {
                    OutlnConsole.Print(ex.Message);
                }
            }
            
        }

        public static char AChar(){
            string m = "err";
            while (m.Length!=1)
            {
                m = AString();
            }
            return m[0];
        }
    }
}
