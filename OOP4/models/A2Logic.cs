namespace OOP4.models
{
    public static class A2Logic
    {
        public static bool IsVowel(char c)
        {
            switch (c.ToLower())
            {
                case "a":
                    return True;
                    break;
                case "e":
                    return True;
                    break;
                case "i":
                    return True;
                    break;
                case "o":
                    return True;
                    break;
                case "u":
                    return True;
                    break;
                case "y":
                    return True;
                    break;
                default:
                    return False;
            }
        }
    }
}