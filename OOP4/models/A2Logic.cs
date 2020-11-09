namespace OOP4.models
{
    public static class A2Logic
    {
        public static bool IsVowel(char c)
        {
            switch (c.ToString().ToLower())
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                case "y":
                    return true;
                default:
                    return false;
            }
        }
    }
}