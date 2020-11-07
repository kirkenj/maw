namespace OOP4.models
{
    public static class CT1DragonLogic
    {
        public static int CountHeadsForAge(CT1Dragon dragon)
        {
            const int HEADS_PER_YEAR_1ST_PERIOD = 3;
            const int HEADS_PER_YEAR_2ND_PERIOD = 2;
            const int HEADS_PER_YEAR_3RD_PERIOD = 1;

            const int FIRST_PERIOD = 200;
            const int SECOND_PERIOD = 300;
            //3rd period starts after 2nd

            const int START_HEADS = 3;
            int age = dragon.Age;
            

            if (age >= 0)
            {
                if (age <= FIRST_PERIOD)
                {
                    return START_HEADS + age * HEADS_PER_YEAR_1ST_PERIOD;
                }
                else if (age <= SECOND_PERIOD)
                {
                    return START_HEADS + FIRST_PERIOD * HEADS_PER_YEAR_1ST_PERIOD + (age - FIRST_PERIOD) * HEADS_PER_YEAR_2ND_PERIOD;
                }
                else if (age > SECOND_PERIOD)
                {
                    return  START_HEADS + FIRST_PERIOD * HEADS_PER_YEAR_1ST_PERIOD + HEADS_PER_YEAR_2ND_PERIOD * SECOND_PERIOD + (age - (FIRST_PERIOD + SECOND_PERIOD)) * HEADS_PER_YEAR_3RD_PERIOD;
                }
            }
            return 0;
        }
    }
}
