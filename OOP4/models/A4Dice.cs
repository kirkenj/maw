namespace OOP4.models
{
    public class Dice
    {
        public int RoolTheDice(){
            System.Random r = new System.Random();
            return r.Next(1,6);
        }
    }
}