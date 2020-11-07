using System;

namespace OOP4.models
{
    public static class MoodSensorLogic
    {
        private static int GenerateMood()
        {
            Random r = new Random();
            return r.Next(0,3);
        }

        public static string GetMood()
        {
            int mood = GenerateMood();
            string[] face = {":(", ":|", ":)", ":]"};
            return face[mood];
        }
    }
}