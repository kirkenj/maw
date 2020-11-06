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
            dragon.setAge(m);
            dragon.setHeads(CT1DragonLogic.countHeadsForAge(dragon));
            OutlnConsole.Print($"He has {dragon.getHeads()} heads with {dragon.getEyes()} eyes");

            
            double[] arr = UserInput.ADoubleArray();
            OutlnConsole.Print($"Maximal element is {arr.Max()}");
            OutlnConsole.Print(CT3Multiplicity.getMultiplePrimeForInp(UserInput.AnInt()));

            CT3Multiplicity.getMultiplePrimeForInp(UserInput.AnInt());

            Pie pie = new Pie();
            OutlnConsole.Print(PieLogic.eatPie(pie));

            Dice d1 = new Dice();
            Dice d2 = new Dice();

            DiceLogic.rollTheDice(d1, d2);
            OutlnConsole.Print(DiceLogic.showValues(d1, d2));

            OutlnConsole.Print(MoodSensorLogic.getMood());

            OutlnConsole.Print(Logic6.monthName(UserInput.AnInt()));

            OutlnConsole.Print(A1Logic.IsSitesOfTriange(2.5,2.5,6));
            OutlnConsole.Print(A2Logic.IsVowel('q'));
            OutlnConsole.Print(A2Logic.IsVowel('a'));
             


        }
    }
}
