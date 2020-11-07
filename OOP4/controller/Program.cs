using OOP4.IndividualTaskB;
using OOP4.models;
using System.Linq;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            CT1Dragon dragon = new CT1Dragon();
            OutlnConsole.Print("Input Dragon's age: ");
            int m = UserInput.AnInt();
            dragon.Age = m;
            dragon.Heads = CT1DragonLogic.CountHeadsForAge(dragon);
            OutlnConsole.Print($"He has {dragon.Heads} heads with {dragon.Eyes} eyes");


            double[] arr = UserInput.ADoubleArray();
            OutlnConsole.Print($"Maximal element is {arr.Max()}");

            OutlnConsole.Print(CT3MultiplicityLogic.GetMultiplePrimeForInp(UserInput.AnInt()));

            A5Pie pie = new A5Pie();
            OutlnConsole.Print(A5PieLogic.EatPie(pie));

            A4Dice d1 = new A4Dice();
            A4Dice d2 = new A4Dice();

            A4DiceLogic.ShowValues(d1, d2);
            OutlnConsole.Print(A4DiceLogic.ShowValues(d1, d2));

            OutlnConsole.Print(A3MoodSensorLogic.GetMood());



            OutlnConsole.Print(A1Logic.IsSitesOfTriange(2.5, 2.5, 6));
            OutlnConsole.Print(A2Logic.IsVowel('q'));
            OutlnConsole.Print(A2Logic.IsVowel('a'));

            OutlnConsole.Print(B1WeekLogic.GetDayForNumber(3));
            OutlnConsole.Print(B2MarkRequestLogic.GetRequestForMark(7));
            OutlnConsole.Print(B3CardsLogic.GetCardForNumbers(1, 8));
            OutlnConsole.Print(B4NumberInWordsLogic.GetStringOfNumber(110));


            OutlnConsole.Print(B5Logic.GetDaysInMonthNumber(12));
            OutlnConsole.Print(B6Logic.MonthName(12));

            string[] inp = ("12 * 5".Split());
            if (inp.Length == 3)
            {
                OutlnConsole.Print(B7ArithmethicLogic.DoArithmetic(System.Convert.ToDouble(inp[0]), inp[1], System.Convert.ToDouble(inp[2])));
            }
            else
            {
                OutlnConsole.Print("Input in format: *Operand_1* *Action* *Operand_2*");
            }

            OutlnConsole.Print(B8AstrologyLogic.GetZnakForBirthDay(23, 10));

            OutlnConsole.Print(B4NumberInWordsLogic.GetStringOfNumber(999));
            OutlnConsole.Print(B4NumberInWordsLogic.GetStringOfNumber(1000));
        }
    }
}
