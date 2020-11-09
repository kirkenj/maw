namespace OOP4.models
{
    public static class A1Logic
    {
        public static bool IsSitesOfTriange(double a, double b, double c)
        {
            if ((a + b > c) && (b + c > a) && (a + c > b)){
                return true;
            }
            return false;
            
        }
    }
}