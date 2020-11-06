namespace OOP4.models
{
    public class Dice
    {
        private int value;

        public Dice()
        {
            this.value = 1;
        }

        public int GetValue(){
            return this.value;
        }

        public void SetValue(int a){
            this.value = a;
        }
    }
}