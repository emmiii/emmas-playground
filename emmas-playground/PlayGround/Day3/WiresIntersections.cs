namespace Day3;
public static class WiresIntersections
{
    public static int GetShortestManhattanDistance(List<string> wires)
    {
        var wire1 = wires[0].Split(',');
        var wire2 = wires[1].Split(',');
        var intersections = GetIntersections(wire1, wire2);
        return CalculateManhattanDistance(intersections).Min();
    }
    public static int GetShortestWayToInstersection(List<string> wires)
    {
        var wire1 = wires[0].Split(',');
        var wire2 = wires[1].Split(',');
        var steps = GetStepsForIntersections(wire1, wire2);
        return steps.Min();
    }

    private static List<(int, int)> GetIntersections(IEnumerable<string> wire1, IEnumerable<string> wire2)
    {
        var wire1Coordinates = MapWireLocations(wire1);
        var wire2Coordinates = MapWireLocations(wire2);

        var intersections = new List<(int, int)>();
        foreach (var coordinate in wire1Coordinates)
        {
            if (wire2Coordinates.Contains(coordinate))
            {
                intersections.Add(coordinate);
            }
        }
        return intersections;
    }

    private static List<int> GetStepsForIntersections(IEnumerable<string> wire1, IEnumerable<string> wire2)
    {
        var wire1CoordinatesAndSteps = MapWireLocationsAndCountSteps(wire1);
        var wire2CoordinatesAndSteps = MapWireLocationsAndCountSteps(wire2);

        var intersectionSteps = new List<int>();
        foreach (var coordinate in wire1CoordinatesAndSteps.Keys)
        {
            if (wire2CoordinatesAndSteps.Keys.Contains(coordinate))
            {
                intersectionSteps.Add(wire1CoordinatesAndSteps[coordinate] + wire2CoordinatesAndSteps[coordinate]);
            }
        }
        return intersectionSteps;
    }

    private static List<(int x, int y)> MapWireLocations(IEnumerable<string> wirePath)
    {
        List<(int x, int y)> coordinates= new List<(int, int)>();
        var x_coord = 0;
        var y_coord = 0;

        foreach (var move in wirePath)
        {
            for (int i = 0; i < GetNumberOfSteps(move); i++)
            { 
                //up
                if (move.StartsWith('U'))
                {
                    y_coord++;
                }
                //down
                if (move.StartsWith('D'))
                {
                    y_coord--;
                }
                //right
                if (move.StartsWith('R'))
                {
                    x_coord++;
                }
                //left
                if (move.StartsWith('L'))
                {
                    x_coord--;
                }
                coordinates.Add((x_coord, y_coord));
            }
        }
        return coordinates;
    }

    private static Dictionary<(int x, int y), int> MapWireLocationsAndCountSteps(IEnumerable<string> wirePath)
    {
        Dictionary<(int x, int y), int> coordinatesAndSteps = new Dictionary<(int x, int y), int>();
        var x_coord = 0;
        var y_coord = 0;
        var steps = 0;

        foreach (var move in wirePath)
        {
            for (int i = 0; i < GetNumberOfSteps(move); i++)
            {
                steps++;
                //up
                if (move.StartsWith('U'))
                {
                    y_coord++;
                }
                //down
                if (move.StartsWith('D'))
                {
                    y_coord--;
                }
                //right
                if (move.StartsWith('R'))
                {
                    x_coord++;
                }
                //left
                if (move.StartsWith('L'))
                {
                    x_coord--;
                }
                if (!coordinatesAndSteps.Keys.Contains((x_coord, y_coord)))
                { 
                    coordinatesAndSteps.Add((x_coord, y_coord), steps);
                }
            }
        }
        return coordinatesAndSteps;
    }

    private static int GetNumberOfSteps(string move) 
    {
        return Int32.Parse(move.Substring(1));
    }

    private static List<int> CalculateManhattanDistance(List<(int x, int y)> coordinates)
    {
        var distances = new List<int>();

        foreach (var coordinate in coordinates)
        {
            var distance = Math.Abs(coordinate.x) + Math.Abs(coordinate.y);
            distances.Add(distance);
        }

        return distances;
    }
}
