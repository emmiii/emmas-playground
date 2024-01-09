namespace FizzBuzz_ClassLibrary
{
    public class FizzBuzz
    {
        public static string Convert(int number)
        {
            var response = "";
            var useNumber = true;
            if (number % 3 == 0) 
            {
                response += "Fizz";
                useNumber = false;
                if (number.ToString().Contains('3'))
                { 
                    response += "Fizz";
                }
            }
            if (number % 5 == 0) 
            {
                response += "Buzz";
                useNumber = false;
                if (number.ToString().Contains('5'))
                {
                    response += "Buzz";
                }
            }
            return useNumber ? number.ToString() : response;
        }
    }
}
