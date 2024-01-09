namespace RomanNumerals_ClassLibrary
{
    public class RomanNumerals
    {
        public static string GetRomanNumeralString(int number)
        {
            var romanNumerals = "";

            if (number >= 10)
            {
                var vs = number / 10;
                romanNumerals = AddXsLast(romanNumerals, vs);
                number -= vs*10;
            }
            if (number == 9)
            {
                if (romanNumerals.Length == 0)
                {
                    return "IX";
                }
                romanNumerals = romanNumerals + "IX";
                number -= 9;
            }
            if (number >= 5)
            {
                var vs = number / 5;
                romanNumerals = AddVsLast(romanNumerals, vs);
                number -= vs*5;
            }
            if (number == 4) 
            {
                if (romanNumerals.Length == 0)
                {
                    return "IV";
                }
                romanNumerals = romanNumerals + "IV";
                number -= 4;
            }
            if (number < 4) 
            {
                romanNumerals = AddIsLast(romanNumerals, number);
            }

            return romanNumerals;
        }

        private static string AddIsLast(string romanNumerals, int add)
        {
            return romanNumerals + new String('I', add);
        }

        private static string AddVsLast(string romanNumerals, int add)
        {
            return romanNumerals + new String('V', add);
        }
    
        private static string AddXsLast(string romanNumerals, int add)
        {
            return new String('X', add) + romanNumerals;
        }
    }
}
