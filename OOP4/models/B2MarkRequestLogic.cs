namespace OOP4.IndividualTaskB
{
    public static class B2MarkRequestLogic
    {
        public static string GetRequestForMark(int Mark)
        {
            switch (Mark)
            {
                case 1:
                    {
                        return "Very-very bad";
                    }
                case 2:
                    {
                        return "Very bad";
                    }
                case 3:
                    {
                        return "Poor";
                    }
                case 4:
                    {
                        return "Poor +";
                    }
                case 5:
                    {
                        return "Satisfactory";
                    }
                case 6:
                    {
                        return "Satisfactory +";
                    }
                case 7:
                    {
                        return "Not bad";
                    }
                case 8:
                    {
                        return "Good";
                    }
                case 9:
                    {
                        return "Very good";
                    }
                case 10:
                    {
                        return "Best mark";
                    }
                default:
                    {
                        return "We don't have such mark...)";
                    }
            }
        }
    }
}
