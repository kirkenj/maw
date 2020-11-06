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

        public void SetAge(int set)
        {
            if (set >= 0)
            {
                this.age = set;
            }
        }

        public int GetAge()
        {
            return this.age;
        }
        public int GetEyes()
        {
            return 2 * this.heads;
        }

        public int GetHeads()
        {
            return this.heads;
        }

        public void SetHeads(int heads)
        {
            this.heads = heads;
        }

    }
}
