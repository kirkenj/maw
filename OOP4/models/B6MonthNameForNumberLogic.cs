namespace OOP4.models
{
    public static class B6MonthNameForNumberLogic
    {
        public static string GetMonthName(int num)
        {
            string[]  mounth = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            if (num >= 1 && num <= mounth.Length)
            {
                return mounth[num-1];
            }
            else
            {
                return "This mounth does not exist";
            }
        }
    }
}