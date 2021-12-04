List<string> lines = new List<string>();

void Setup()
{
    string filePath = @"C:\Users\Almedin\Desktop\Github repositories\Advent-of-Code-2021\Advent of Code 2021, 01-12-2021\Puzzle input.txt";
    lines = File.ReadAllLines(filePath).ToList();
}

int PartOne()
{
    int Counter = 0;
    int Previous=int.Parse(lines[0]);

    foreach(var line in lines)
    {
        if (int.Parse(line) > Previous)
        {
            Counter++;
        }
        Previous = int.Parse(line);
    }
    return Counter;
}

int PartTwo()
{
    int Counter = 0;
    int Previous = int.Parse(lines[0]) + int.Parse(lines[1]) + int.Parse(lines[2]);

    for(int i = 0; i < lines.Count - 2; i++)
    {
        if((int.Parse(lines[i]) + int.Parse(lines[i+1]) + int.Parse(lines[i+2]) > Previous))
        {
            Counter++;
        }
        Previous = int.Parse(lines[i]) + int.Parse(lines[i + 1]) + int.Parse(lines[i + 2]);
    }
    return Counter;
}

Setup();
Console.WriteLine("Part one result: " + PartOne().ToString());
Console.WriteLine("Part two result: " + PartTwo().ToString());