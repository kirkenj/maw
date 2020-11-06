using OOP4.models;
using System.Linq;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            CT1Dragon dragon= new CT1Dragon();

            OutlnConsole.Print("Input Dragon's age: ");
            int m = UserInput.AnInt();
            dragon.SetAge(m);
            dragon.SetHeads(CT1DragonLogic.CountHeadsForAge(dragon));
            OutlnConsole.Print($"He has {dragon.GetHeads()} heads with {dragon.GetEyes()} eyes");

            
            double[] arr = UserInput.ADoubleArray();
            OutlnConsole.Print($"Maximal element is {arr.Max()}");
            OutlnConsole.Print(CT3Multiplicity.GetMultiplePrimeForInp(UserInput.AnInt()));

            CT3Multiplicity.GetMultiplePrimeForInp(UserInput.AnInt());

            Pie pie = new Pie();
            OutlnConsole.Print(PieLogic.EatPie(pie));

            Dice d1 = new Dice();
            Dice d2 = new Dice();

            DiceLogic.RollTheDice(d1, d2);
            OutlnConsole.Print(DiceLogic.ShowValues(d1, d2));

            OutlnConsole.Print(MoodSensorLogic.GetMood());

            OutlnConsole.Print(Logic6.MonthName(UserInput.AnInt()));

            OutlnConsole.Print(A1Logic.IsSitesOfTriange(2.5,2.5,6));
            OutlnConsole.Print(A2Logic.IsVowel('q'));
            OutlnConsole.Print(A2Logic.IsVowel('a'));
             


        }
    }
}
