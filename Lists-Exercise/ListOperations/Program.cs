
List<int> items = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string input = Console.ReadLine();

while(input != "End")
{
    string[] commandParts = input.Split();

    if (commandParts.Contains("Add"))
    {
        int currentNum = int.Parse(commandParts[1]);

        items.Add(currentNum);
    }else if (commandParts.Contains("Insert"))
    {
        int item = int.Parse(commandParts[1]);
        int index = int.Parse(commandParts[2]);

        if(!IsValidIndex(index, items.Count))
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            items.Insert(index, item);
        }

        
    }else if (commandParts.Contains("Remove"))
    {
        int index = int.Parse(commandParts[1]);

        if (!IsValidIndex(index, items.Count))
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            items.RemoveAt(index);
        }
    }else if (commandParts.Contains("left"))
    {
        int count = int.Parse(commandParts[2]);

        for (int i = 0; i < count; i++)
        {
            int first = items[0];

            items.RemoveAt(0);
            items.Add(first);
        }
    }else if (commandParts.Contains("right"))
    {
        int count = int.Parse(commandParts[2]);

        for (int i = 0; i < count; i++)
        {
            int last = items[items.Count-1];

            items.RemoveAt(items.Count-1);
            items.Insert(0, last);
        }
    }

        input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", items));

static bool IsValidIndex(int index, int count)
{
    return index >= 0 && index < count;
}