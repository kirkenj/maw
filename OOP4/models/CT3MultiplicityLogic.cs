using System.Collections.Generic;

namespace OOP4.models
{
    public static class CT3MultiplicityLogic
    {
        
        static int[] PRIME_MAS = { 2, 3, 5, 7, 11, 17, 19 };
        public static int[] GetMultiplePrimeForInp(int inp)
        {
            List<int> listOfMultiplies = new List<int> { };
            foreach (int elem in PRIME_MAS)
            {
                if (inp % elem == 0)
                {
                    listOfMultiplies.Add(elem);
                }
            }
            if(listOfMultiplies.Count>0)
            {
                return listOfMultiplies.ToArray();
            }
            return new int[] { -1 };
        }
    }
}
