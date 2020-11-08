namespace OOP4.models
{
    public class CT1Dragon
    {
        public const int HEADS_PER_YEAR_1ST_PERIOD = 3;
        public const int HEADS_PER_YEAR_2ND_PERIOD = 2;
        public const int HEADS_PER_YEAR_3RD_PERIOD = 1;

        public const int FIRST_PERIOD = 200;
        public const int SECOND_PERIOD = 300;
        //3rd period starts after 2nd

        const int START_HEADS = 3;



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
