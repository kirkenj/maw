using System;

namespace OOP4.models
{
    public class A5Pie
    {
        private int surprise;

        public A5Pie(){
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