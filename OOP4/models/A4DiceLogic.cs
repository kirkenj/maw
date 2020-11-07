namespace OOP4.models
{
    public static class DiceLogic
    {
        public static int ShowValues(Dice First, Dice Second)
        {
            return First.RoolTheDice() + Second.RoolTheDice();
        }
    }
}