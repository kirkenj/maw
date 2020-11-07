namespace OOP4.models
{
    public class A4Dice
    {
        public int RoolTheDice(){
            System.Random r = new System.Random();
            return r.Next(1,6);
        }
    }
}