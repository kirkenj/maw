namespace OOP4.models
{
    public static class Logic6
    {
        public static string MounthName(int num)
        {
            string[]  mounth = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            if (num >= 1 && num <= mounth.Length)
            {
                return mounth[num];
            }
            else
            {
                return "This mounth does not exist";
            }
        }
    }
}