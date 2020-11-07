namespace OOP4.IndividualTaskB
{
    public static class B1WeekLogic
    {
        static string[] WEEK = { "Monday", "Tuesday", "Wednessday", "Thursday", "Friday", "Saturday", "Sunday" };

        public static string GetDayForNumber(int inp)
        {
            
            if (inp < 7 && inp > 0)
            {
                return WEEK[inp - 1];
            }
            else
            {
                return "Inputed number is out of range";
            }
        }
    }
}
