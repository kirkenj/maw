using System;

namespace OOP4.models
{
    public static class MoodSensorLogic
    {
        private static int generateMood()
        {
            Random r = new Random();
            return r.Next(1,4);
        }

        public static string getMood()
        {
            int mood = generateMood();
            switch (mood)
            {
                case 1:
                    return ":(" ;
                case 2:
                    return ":|" ;
                case 3:
                    return ":)" ;
                case 4:
                    return ":]";
                default:
                    return "::";
            }
        }
    }
}