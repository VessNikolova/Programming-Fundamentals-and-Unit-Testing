

List<int> items = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string input = Console.ReadLine();

while (input != "end")
{
    string[] commandParts = input.Split();

    if (commandParts.Contains("Add"))
    {
        int currentNum = int.Parse(commandParts[1]);

        items.Add(currentNum);
    }
    else if (commandParts.Contains("Remove"))
    {
        int item = int.Parse(commandParts[1]);

        items.Remove(item);
    }
    else if (commandParts.Contains("RemoveAt"))
    {
        int index = int.Parse(commandParts[1]);

        items.RemoveAt(index);
    }
    else if (commandParts.Contains("Insert"))
    {
        int item = int.Parse(commandParts[1]);
        int index = int.Parse(commandParts[2]);

        items.Insert(index, item);
    }
   

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", items));
