using AdventOfCode;
using Day1;
using Day2;
using Day3;
using Day4;

var day1 = ReadInput.ReadPuzzleInputByLines<int>("C:\\Source\\emmas-playground\\PlayGround\\Day1\\puzzleinput.txt");
var day2 = ReadInput.ReadCommaSeparatedPuzzleInput<int>("C:\\Source\\emmas-playground\\PlayGround\\Day2\\puzzleinput.txt");
var day3 = ReadInput.ReadPuzzleInTwoLines("C:\\Source\\emmas-playground\\PlayGround\\Day3\\puzzleinput.txt");

Console.WriteLine("Advent Of Code 2019!");
//Console.WriteLine("Day 1, part 1: " + FuelRequirements.GetFuelRequirements(day1));
//Console.WriteLine("Day 1, part 2: " + FuelRequirements.GetFullFuelRequirements(day1));
//Console.WriteLine("Day 2, part 1: " + Intcode.ValueAtIndex0AfterProgramIsRun(day2.ToList()));
//Console.WriteLine("Day 3, part 1: " + WiresIntersections.GetShortestManhattanDistance(day3.ToList()));
//Console.WriteLine("Day 3, part 2: " + WiresIntersections.GetShortestWayToInstersection(day3.ToList()));
Console.WriteLine("Day 4, part 1: " + new PasswordFinder().GetNumberOfPossiblePasswords());
Console.WriteLine("Day 4, part 2: " + new PasswordFinder().GetNumberOfPossiblePasswordsWithExtraRule());
