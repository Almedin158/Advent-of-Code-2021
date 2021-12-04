List<string> lines = new List<string>();

void Setup()
{
    string filePath = @"C:\Users\Almedin\Desktop\Github repositories\Advent-of-Code-2021\Advent of Code 2021, 02-12-2021\Puzzle input.txt";
    lines = File.ReadAllLines(filePath).ToList();
}

int PartOne()
{
    int depth = 0;
    int forward = 0;

    foreach(var line in lines)
    {
        if (line.Contains("forward"))
        {
            forward += int.Parse(line.Substring(line.IndexOf(" ") + 1));
        }
        else if (line.Contains("down"))
        {
            depth+= int.Parse(line.Substring(line.IndexOf(" ") + 1));
        }
        else
        {
            depth-= int.Parse(line.Substring(line.IndexOf(" ") + 1));
        }
    }

    return depth*forward;
}

int PartTwo()
{
    int depth = 0;
    int forward = 0;
    int aim = 0;

    foreach(var line in lines)
    {
        if (line.Contains("down"))
        {
            aim+= int.Parse(line.Substring(line.IndexOf(" ") + 1));
        }
        else if (line.Contains("up"))
        {
            aim -= int.Parse(line.Substring(line.IndexOf(" ") + 1));
        }
        else
        {
            forward += int.Parse(line.Substring(line.IndexOf(" ") + 1));
            depth += aim * int.Parse(line.Substring(line.IndexOf(" ") + 1));
        }
    }

    return forward*depth;
}

Setup();
Console.WriteLine("Part one result: " + PartOne().ToString());
Console.WriteLine("Part two result: " + PartTwo().ToString());