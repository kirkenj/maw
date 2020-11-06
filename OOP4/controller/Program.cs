using OOP4.models;
using System.Linq;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            CT1Dragon dragon= new CT1Dragon();

            int m = UserInput.AnInt();
            dragon.setAge(m);
            dragon.setHeads(CT1DragonLogic.countHeadsForAge(dragon));
            OutlnConsole.Print($"He has {dragon.getHeads()} heads with {dragon.getEyes()} eyes");

            /*
            double[] arr = UserInput.ADoubleArray();
            OutlnConsole.Print($"Maximal element is {arr.Max()}");
            OutlnConsole.Print(A1Logic.IsSitesOfTriange(2.5,2.5,6));
            OutlnConsole.Print(A2Logic.IsVowel('q'));
            OutlnConsole.Print(A2Logic.IsVowel('a'));
             */
            //OutlnConsole.Print(CT3Multiplicity.getMultiplePrimeForInp(UserInput.AnInt()));


        }
    }
}
