using System.Collections.Generic;

namespace OOP4.IndividualTaskB
{
    public static class B2MarkRequestLogic
    {
        static Dictionary<int, string> REQUEST_DICT = new Dictionary<int, string>
        {
            { 1, "Very-very bad"},
            { 2, "Very bad"},
            { 3, "Poor"},
            { 4, "Poor +"},
            { 5, "Satisfactory"},
            { 6, "Satisfactory +"},
            { 7, "Not bad"},
            { 8, "Good"},
            { 9, "Very good"},
            { 10, "Best mark"}
        };
        public static string GetRequestForMark(int mark)
        {
            if (mark <= 10 || mark > 0)
            {
                return REQUEST_DICT[mark];
            }
            return "We don't have such mark";
        }
    }
}
