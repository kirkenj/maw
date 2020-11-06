using System;

namespace OOP4.models
{
    public static class DiceLogic
    {
        public static void RollTheDice(Dice First, Dice Second)
        {
            Random r = new Random();
            First.SetValue(r.Next(1,6));
            Second.SetValue(r.Next(1,6));
        }

        public static int ShowValues(Dice First, Dice Second)
        {
            return First.GetValue() + Second.GetValue();
        }
    }
}