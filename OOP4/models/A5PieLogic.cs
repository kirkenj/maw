namespace OOP4.models
{
    public static class A5PieLogic
    {
        public static string EatPie(A5Pie pie)
        {
            string[] surprises = {"Raisins in the pie", "Jam in the pie", "In condensed milk pie", "Chocolate in the pie", "A coin of immortality in the pie"};
            return surprises[pie.Surprise];
        }
    }
}