namespace OOP4.models
{
    public static class A4DiceLogic
    {
        public static int ShowValues(A4Dice First, A4Dice Second)
        {
            return First.RoolTheDice() + Second.RoolTheDice();
        }
    }
}