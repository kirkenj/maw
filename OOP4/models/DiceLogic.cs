using System;

namespace OOP4.models
{
    public static class DiceLogic
    {
        static void rollTheDice(Dice First, Dice Second)
        {
            Random r = new Random();
            First.setValue(r.Next(1,6));
            Second.setValue(r.Next(1,6));
        }

        static int showValues(Dice First, Dice Second)
        {
            return First.getValue() + Second.getValue();
        }
    }
}