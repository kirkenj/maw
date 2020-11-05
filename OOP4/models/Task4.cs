using System;

namespace OOP4.IndividualTaskB
{
    class Task4
    {
        private static string[] Convert(int inp)
        {

            int ost = 0;
            ost = inp % 10;
            Console.WriteLine("Ента залупень работает");
            return ost.ToString();
        }


        public static void Run()
        {

            int age = UserInput.AnInt("Input age (from 1 till 120)");
            if (age >= 1 && age <= 120)
            {
                if (age % 10 > 0 && age % 10 < 5)
                {

                }
                else
                {

                }
            }
        }
    }
}
