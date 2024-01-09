namespace LeapYear_ClassLibrary
{
    public class LeapYear
    {
        public static bool CalculateLeapYear(int year)
        {
            if (year % 100 == 0 && year % 400 > 0)
            {
                return false;
            }
            return year % 4 == 0;
        }
    }
}
