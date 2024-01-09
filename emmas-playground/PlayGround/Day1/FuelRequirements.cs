namespace Day1;
public static class FuelRequirements
{
    public static int GetFuelRequirements(IEnumerable<int> modules)
    {
        var result = 0;
        foreach (var module in modules)
        {
            result += FuelRequirement(module);
        }
        return result;
    }

    public static int GetFullFuelRequirements(IEnumerable<int> modules)
    {
        var result = 0;
        foreach (var module in modules)
        {
            var fuel = module;
            while (fuel > 0)
            { 
                fuel = FuelRequirement(fuel);
                if (fuel < 0)
                {
                    fuel= 0;
                }
                result += fuel;
            }
        }
        return result;
    }

    private static int FuelRequirement(int module) => ((int)(module / 3) - 2);
}
