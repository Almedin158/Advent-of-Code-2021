List<string> lines = new List<string>();

void Setup()
{
    string filePath = @"C:\Users\Almedin\Desktop\Github repositories\Advent-of-Code-2021\Advent of Code 2021, 03-12-2021\Puzzle input.txt";
    lines = File.ReadAllLines(filePath).ToList();
}

int PartOne()
{
    string firstBinaryNumber = "";
    string secondBinaryNumber = "";
    for(int i = 0; i < lines[0].Length; i++) {
        int one=0;
        int zero=0;
        foreach (var line in lines)
        {
            if (line[i] == '1')
            {
                one++;
            }
            else
                zero++;
        }
        if (one > zero)
        {
            firstBinaryNumber += "1";
            secondBinaryNumber += "0";
        }
        else
        {
            firstBinaryNumber += "0";
            secondBinaryNumber +="1";
        }
    }

    return Convert.ToInt32(firstBinaryNumber,2)*Convert.ToInt32(secondBinaryNumber,2);
}

int PartTwo()
{
    List<string> list=new List<string>();
    List<string> filteredList = new List<string>();

    int firstBinaryNumber;
    int secondBinaryNumber;

    int firstBinary()
    {
        list.Clear();

        foreach (var line in lines)
        {
            list.Add(line);
        }

        for (int i = 0; i < lines[0].Length; i++)
        {
            if (list.Count == 1)
            {
                break;
            }

            int one = 0;
            int zero = 0;
            foreach (var line in list)
            {
                if (line[i] == '1')
                {
                    one++;
                }
                else
                    zero++;
            }
            if (one >= zero)
            {
                foreach (var l in list)
                {
                    if (l[i] == '1')
                    {
                        filteredList.Add(l);
                    }
                }
            }
            else
            {
                foreach (var l in list)
                {
                    if (l[i] == '0')
                    {
                        filteredList.Add(l);
                    }
                }
            }
            if (filteredList.Count != list.Count)
            {
                list.Clear();
                foreach (var l in filteredList)
                {
                    list.Add(l);
                }
            }
            filteredList.Clear();
        }
        return Convert.ToInt32(list[0], 2);
    }

    firstBinaryNumber = firstBinary();

    int secondBinary()
    {
        list.Clear();

        foreach (var line in lines)
        {
            list.Add(line);
        }

        for (int i = 0; i < lines[0].Length; i++)
        {
            if (list.Count == 1)
            {
                break;
            }

            int one = 0;
            int zero = 0;
            foreach (var line in list)
            {
                if (line[i] == '1')
                {
                    one++;
                }
                else
                    zero++;
            }
            if (zero <= one)
            {
                foreach (var l in list)
                {
                    if (l[i] == '0')
                    {
                        filteredList.Add(l);
                    }
                }
            }
            else
            {
                foreach (var l in list)
                {
                    if (l[i] == '1')
                    {
                        filteredList.Add(l);
                    }
                }
            }
            if (filteredList.Count != list.Count)
            {
                list.Clear();
                foreach (var l in filteredList)
                {
                    list.Add(l);
                }
            }
            filteredList.Clear();
        }

        return Convert.ToInt32(list[0], 2);
    }

    secondBinaryNumber = secondBinary();

    return firstBinaryNumber*secondBinaryNumber;
}

Setup();
Console.WriteLine("Part one result: " + PartOne().ToString());
Console.WriteLine("Part two result: " + PartTwo().ToString());