using System;

namespace OOP4
{
    static class UserInput
    {
        static string m;

        static public int AnInt(String inputMsg = "")
        {

            while (true)
            {
                try
                {
                    m = UserInput.AString(inputMsg);
                    return Convert.ToInt32(m);
                }
                catch (Exception ex)
                {
                    OutlnConsole.Print(ex.Message);
                }
            }


        }

        static public double ADouble(string inputMsg = "")
        {
            double ret;
            while (true)
            {
                try
                {
                    m = UserInput.AString(inputMsg);
                    ret = Convert.ToDouble(m);
                    return ret;
                }
                catch (Exception ex)
                {
                    OutlnConsole.Print(ex.Message);
                }
            }
        }
        static public string AString(string inputMsg = "")
        {
            OutlnConsole.Print(inputMsg);
            m = Console.ReadLine();
            return m;
        }


        static public double[] ADoubleArray(string inputMsg = "")
        {
            m = UserInput.AString(inputMsg);
            string[] mas = m.Split();
            int len = mas.Length;
            double[] ret = new double[len];
            for (int i = 0; i < mas.Length; i++)
            {
                ret[i] = Convert.ToDouble(mas[i]);
            }
            return ret;
        }
    }
}
