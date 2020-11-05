using System;

namespace OOP4
{
    class OutlnConsole
    {
        public static void Print(string msg)
        {
            if (msg.Length > 0)
            {
                Console.WriteLine(msg);
            }
        }

        public static void Print<T>(T[] mas)
        {
            OutlnConsole.Print(string.Join(", ", mas));
        }
    }
}
