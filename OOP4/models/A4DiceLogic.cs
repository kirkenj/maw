namespace OOP4.models
{
    public static class A4DiceLogic
    {
        public static int ShowValues(A4Dice first, A4Dice second)
        {
            return first.RoolTheDice() + second.RoolTheDice();
        }
    }
}