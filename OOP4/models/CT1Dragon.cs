namespace OOP4.models
{
    public class CT1Dragon
    {
        private int age;
        private int heads;

        public CT1Dragon()
        {
            this.age = 0;
            this.heads = 3;
        }

        public void setAge(int set)
        {
            if (set >= 0)
            {
                this.age = set;
            }
        }

        public int getAge()
        {
            return this.age;
        }
        public int getEyes()
        {
            return 2 * this.heads;
        }

        public int getHeads()
        {
            return this.heads;
        }

        public void setHeads(int heads)
        {
            this.heads = heads;
        }

    }
}
