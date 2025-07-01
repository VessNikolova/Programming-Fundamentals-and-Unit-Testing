
using System.Security.AccessControl;

List<int> list = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

string input = Console.ReadLine();

while(input != "end")
{
    string[] commandParts = input.Split(" ");
    string command = commandParts[0];

    if (command == "Delete")
    {
        int element = int.Parse(commandParts[1]);

        list.RemoveAll(number => number == element);
    }
    else if(command == "Insert")
    {
        int numToInsert = int.Parse(commandParts[1]);
        int indexToInsert = int.Parse(commandParts[2]);

        list.Insert(indexToInsert, numToInsert);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", list));
