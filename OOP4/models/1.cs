namespace OOP4.CommonTasks
{

    class Task1
    {
        const int HEADS_PER_YEAR_1ST_PERIOD = 3;
        const int HEADS_PER_YEAR_2ND_PERIOD = 2;
        const int HEADS_PER_YEAR_3DP_PERIOD = 1;

        const int FIRS_PERIOD = 200;
        const int SECOND_PERIOD = 300;
        const int START_HEADS = 3;
        const string START_MSG = "Dragon's heads:\nInput dragon's age and amount of his heads will be printed.\n";

        public static int Run()
        {
            int age;
            int ret = 0;
            //3rd period starts after 2nd
            OutlnConsole.Print(START_MSG + $" When a dragon is born he has {START_HEADS} heads.");
            age = UserInput.AnInt("Input Dragon age:");
            if (age > 0)
            {
                if (age <= FIRS_PERIOD)
                {
                    ret = START_HEADS + age * HEADS_PER_YEAR_1ST_PERIOD;
                }
                else if (age <= SECOND_PERIOD)
                {
                    ret = START_HEADS + FIRS_PERIOD * HEADS_PER_YEAR_1ST_PERIOD + (age - FIRS_PERIOD) * HEADS_PER_YEAR_2ND_PERIOD;
                }
                else if (age > SECOND_PERIOD)
                {
                    ret = START_HEADS + FIRS_PERIOD * HEADS_PER_YEAR_1ST_PERIOD + HEADS_PER_YEAR_2ND_PERIOD * SECOND_PERIOD + (age - (FIRS_PERIOD + SECOND_PERIOD)) * HEADS_PER_YEAR_3DP_PERIOD;
                }

                //OutlnConsole.Print($"Amount of Dragon's heads is {ret}");
            }
            else if (age == 0)
            {
                //OutlnConsole.Print($"Oh baby dragon ^^\namount of his heads is {START_HEADS}");
            }
            else
            {
                //OutlnConsole.Print("WRONG INPUT\n");
            }
            return 0;
        }

    }
}
