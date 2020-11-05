namespace OOP4.models
{
    public static class A2Logic
    {
        public static bool IsVowel(char c)
        {
            switch (c)
            {
                case 'a':
                    return true;
                case 'e':
                    return true;
                case 'i':
                    return true;
                case 'o':
                    return true;
                case 'u':
                    return true;
                case 'y':
                    return true;
                case 'A':
                    return true;
                case 'E':
                    return true;
                case 'I':
                    return true;
                case 'O':
                    return true;
                case 'U':
                    return true;
                case 'Y':
                    return true;
                default:
                    return false;
            }
        }
    }
}