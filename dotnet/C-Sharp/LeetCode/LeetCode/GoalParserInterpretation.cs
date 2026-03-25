using System.Text;

namespace LeetCode;

// https://leetcode.com/problems/goal-parser-interpretation/

public class GoalParserInterpretation
{
    public string Interpret(string command)
    {
        var sb = new StringBuilder();

        var c = 0;
        while (command.Length > 0)
        {
            if (c > 100)
            {
                return "";
            }
            c++;

            if (command.StartsWith("G"))
            {
                sb.Append("G");
                command = command[1..];
                continue;
            }

            if (command.StartsWith("()"))
            {
                sb.Append("o");
                command = command[2..];
                continue;
            }

            if (command.StartsWith("(al)"))
            {
                sb.Append("al");
                command = command[4..];
                continue;
            }
        }

        return sb.ToString();
    }
}
