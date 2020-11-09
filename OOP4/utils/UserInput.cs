using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;

namespace OOP4
{
    static class UserInput
    {

        public static int GetInt()
        {

            while (true)
            {
                try
                {
                    return Convert.ToInt32(GetString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }

        public static double GetDouble()
        {
            while (true)
            {
                try
                {
                    return Convert.ToDouble(GetString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static string GetString()
        {   
            return Console.ReadLine();
        }


        public static double[] GetDoubleArray()
        {
            while (true)
            {
                try
                {
                    return GetString()
                        .Split()
                        .Select(x => Convert.ToDouble(x))
                        .ToArray();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        public static char GetChar(){
            string m = "err";
            while (m.Length!=1)
            {
                m = GetString();
            }
            return m[0];
        }
    }
}
