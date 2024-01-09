namespace Day4;
public class PasswordFinder
{
    private readonly int rangeStart = 172930;
    private readonly int rangeStop = 683082;

    public int GetNumberOfPossiblePasswords()
    {
        var possiblePasswords = 0;
        for (int i = rangeStart; i < rangeStop; i++)
        {
            if (!HasDouble(i))
            {
                continue;
            }
            if (!NotDescreasing(i))
            {
                continue;
            }
            possiblePasswords++;
        }
        return possiblePasswords;
    }

    public int GetNumberOfPossiblePasswordsWithExtraRule()
    {
        var possiblePasswords = 0;
        for (int i = rangeStart; i < rangeStop; i++)
        {
            if (!HasDoubleNotInLargerGroup(i))
            {
                continue;
            }
            if (!NotDescreasing(i))
            {
                continue;
            }
            possiblePasswords++;
        }
        return possiblePasswords;
    }

    private bool HasDouble(int number)
    {
        var searchString = number.ToString();
        for (int i = 0; i < searchString.Length-1; i++) 
        {
            if (searchString[i].Equals(searchString[i + 1]))
            {
                return true;
            }
        }
        return false;
    }

    private bool NotDescreasing(int number)
    {
        var searchString = number.ToString();
        for (int i = 0; i < searchString.Length-1; i++) 
        {
            var digit = int.Parse(searchString[i].ToString());
            var nextDigit = int.Parse(searchString[i+1].ToString());
            if (nextDigit < digit)
            {
                return false;
            }
        }
        return true;
    }

    private bool HasDoubleNotInLargerGroup(int number)
    {
        var searchString = number.ToString();

        if (searchString[0].Equals(searchString[1]) && !searchString[1].Equals(searchString[2]))
        {
            return true;
        }
        if (searchString[1].Equals(searchString[2]) && !searchString[2].Equals(searchString[3]) && !searchString[0].Equals(searchString[1]))
        {
            return true;
        }
        if (searchString[2].Equals(searchString[3]) && !searchString[3].Equals(searchString[4]) && !searchString[1].Equals(searchString[2]))
        {
            return true;
        }
        if (searchString[3].Equals(searchString[4]) && !searchString[4].Equals(searchString[5]) && !searchString[2].Equals(searchString[3]))
        {
            return true;
        }
        if (searchString[4].Equals(searchString[5]) && !searchString[3].Equals(searchString[4]))
        {
            return true;
        }
        return false;
    }
}
