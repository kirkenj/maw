namespace OOP4.models
{
    public static class A2Logic
    {
        public static bool IsVowel(char c)
        {
            switch (c.ToString().ToLower())
            {
                case "a":
                    return true;
                case "e":
                    return true;
                case "i":
                    return true;
                case "o":
                    return true;
                case "u":
                    return true;
                case "y":
                    return true;
                default:
                    return false;
            }
        }
    }
}