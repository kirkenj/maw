using System;

namespace OOP4.models
{
    public class Pie
    {
        private int surprise;

        public Pie(){
            Random r = new Random();
            this.surprise = r.Next(1,5);
        }

        public int Surprise
        {
            get
            {
                return this.surprise;
            }
        }
    }
}