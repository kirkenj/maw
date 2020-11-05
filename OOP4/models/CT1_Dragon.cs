using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOP4.models
{
    class CT1_Dragon
    {
        private int age;
        private int heads;

        public CT1_Dragon()
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


        public void countHeadsForAge()
        {
            const int HEADS_PER_YEAR_1ST_PERIOD = 3;
            const int HEADS_PER_YEAR_2ND_PERIOD = 2;
            const int HEADS_PER_YEAR_3DP_PERIOD = 1;

            const int FIRST_PERIOD = 200;
            const int SECOND_PERIOD = 300;
            //3rd period starts after 2nd

            const int START_HEADS = 3;

            int age = this.age;
            int ret = 0;

            if (age >= 0)
            {
                if (age <= FIRST_PERIOD)
                {
                    ret = START_HEADS + age * HEADS_PER_YEAR_1ST_PERIOD;
                }
                else if (age <= SECOND_PERIOD)
                {
                    ret = START_HEADS + FIRST_PERIOD * HEADS_PER_YEAR_1ST_PERIOD + (age - FIRST_PERIOD) * HEADS_PER_YEAR_2ND_PERIOD;
                }
                else if (age > SECOND_PERIOD)
                {
                    ret = START_HEADS + FIRST_PERIOD * HEADS_PER_YEAR_1ST_PERIOD + HEADS_PER_YEAR_2ND_PERIOD * SECOND_PERIOD + (age - (FIRST_PERIOD + SECOND_PERIOD)) * HEADS_PER_YEAR_3DP_PERIOD;
                }
            }
            this.heads = ret;
        }

        public int getEyes()
        {
            return 2 * this.heads;
        }

        public int getHeads()
        {
            if (this.heads == 0)
            {
                this.countHeadsForAge();
            }
            return this.heads;
        }


    }

   

}
