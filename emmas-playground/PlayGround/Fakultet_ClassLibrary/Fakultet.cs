namespace Fakultet_ClassLibrary;
public static class Fakultet
{
    public static int GetSumRecursively(int number)
    {
        return number > 0 ? number*GetSumRecursively(number-1) : 1;
    }

    public static int GetSumUsingLoop(int number)
    {
        var sum = 1;
        for(int i = 1; i < number+1; i++) 
        {
            sum *= i;
        }
        return sum;
    }
}
