namespace OOP4.models
{
    public class Dice
    {
        private int value;

        public Dice()
        {
            this.value = 1;
        }

        public int getValue(){
            return this.value;
        }

        public void setValue(int a){
            this.value = a;
        }
    }
}