using System;

namespace OOP4
{
    static class OutlnConsole
    {
        public static void Print<T>(T msg)
        {
            Console.WriteLine(msg);
        }

        public static void Print<T>(T[] mas)
        {
            OutlnConsole.Print(string.Join(", ", mas));
        }
    }
}
