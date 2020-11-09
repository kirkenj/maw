using System.Runtime.InteropServices.WindowsRuntime;

namespace OOP4.IndividualTaskB
{
    public static class B3CardsLogic
    {

        public static string GetCardForNumbers(int suit, int value)
        {
            string[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" };
            string[] values = new string[] { "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            if (suit >= 1 && suit <= 4 && value >= 6 && value <= 14)
            {
                return $"Your card is {values[value - 6]} {suits[suit - 1]}";
            }
            return "Wrong input";
        }
    }
}
