namespace OOP4.models
{
    public class CT1Dragon
    {
        private int heads;
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }
        public int Heads
        {
            get
            {
                return heads;
            }
            set
            {
                if (value >= 0)
                {
                    heads = value;
                }
            }
        }

        public int Eyes
        {
            get
            {
                return heads * 2;
            }
        }

        public CT1Dragon()
        {
            age = 0;
            heads = 3;
        }
    }
}
