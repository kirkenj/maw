namespace OOP4.models
{
    public static class PieLogic
    {
        public static string EatPie(Pie pie)
        {
            switch (pie.GetSurprise())
            {
                case 1:
                    return "raisins in the pie";
                case 2:
                    return "jam in the pie";
                case 3:
                    return "in condensed milk pie";
                case 4:
                    return "chocolate in the pie";
                case 5:
                    return "a coin of immortality in the pie";
                default:
                    return "::";
            }
        }
    }
}