using System.Reflection.Metadata.Ecma335;

namespace Day2;
public class Intcode
{
    public static int ValueAtIndex0AfterProgramIsRun(List<int> program)
    {
        for (int i = 0; i < program.Count; i += 4)
        {
            if (!ExecuteOpcode(program, i))
            { 
                return program[0]; 
            }
        }
        return program[0];
    }

    public static bool ExecuteOpcode(List<int> program, int index)
    {
        var opcode = program[index];
        if (opcode == 99)
        {
            return false;
        }
        else if (opcode == 1 || opcode == 2)
        {
            var firstValuePosition = program[index + 1];
            var secondValuePosition = program[index + 2];
            var targetPosition = program[index + 3];
            if (opcode == 1)
            { 
                program[targetPosition] = program[firstValuePosition] + program[secondValuePosition];
            }
            else
            { 
                program[targetPosition] = program[firstValuePosition] * program[secondValuePosition];
            }
            return true;
        }
        return false;
    }

    public static void Find19690720(List<int> program)
    {
        for (int i = 0; i < program.Count; i += 4)
        {
            var instruction = ExecuteOpcodeReturnInputValues(program, i);

            if (program[0] == 19690720)
            {
                Console.WriteLine(100 * instruction.noun + instruction.verb);
            }
        }
    }

    public static (int noun, int verb) ExecuteOpcodeReturnInputValues(List<int> program, int index)
    {
        var opcode = program[index];
        if (opcode == 99)
        {
            return (0, 0);
        }
        else if (opcode == 1 || opcode == 2)
        {
            var noun = program[index + 1];
            var verb = program[index + 2];
            var targetPosition = program[index + 3];
            if (opcode == 1)
            {
                program[targetPosition] = program[noun] + program[verb];
            }
            else
            {
                program[targetPosition] = program[noun] * program[verb];
            }
            return (noun, verb);
        }
        return (0, 0);
    }
}
