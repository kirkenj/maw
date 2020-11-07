namespace OOP4.models
{
    public static class PieLogic
    {
        public static string EatPie(Pie pie)
        {
            string[] surprises = {"Raisins in the pie", "Jam in the pie", "In condensed milk pie", "Chocolate in the pie", "A coin of immortality in the pie"};
            return surprises[pie.Surprise];
        }
    }
}