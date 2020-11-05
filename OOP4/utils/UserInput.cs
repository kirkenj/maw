using System;

namespace OOP4
{
    static class UserInput
    {
        static string m;
        static char c;

        static public int AnInt()
        {

            while (true)
            {
                try
                {
                    m = UserInput.AString();
                    return Convert.ToInt32(m);
                }
                catch (Exception ex)
                {
                    OutlnConsole.Print(ex.Message);
                }
            }


        }

        static public double ADouble()
        {
            double ret;
            while (true)
            {
                try
                {
                    m = UserInput.AString();
                    ret = Convert.ToDouble(m);
                    return ret;
                }
                catch (Exception ex)
                {
                    OutlnConsole.Print(ex.Message);
                }
            }
        }
        static public string AString()
        {
            m = Console.ReadLine();
            return m;
        }


        static public double[] ADoubleArray()
        {
            m = UserInput.AString();
            string[] mas = m.Split();
            int len = mas.Length;
            double[] ret = new double[len];
            for (int i = 0; i < mas.Length; i++)
            {
                ret[i] = Convert.ToDouble(mas[i]);
            }
            return ret;
        }

        static public char AChar(){
            m = UserInput.AString();
            if (m.Length == 1)
            {
                c = m[0];
            }
            else
            {
                c = AChar();
            }
            return c;
        }
    }
}
