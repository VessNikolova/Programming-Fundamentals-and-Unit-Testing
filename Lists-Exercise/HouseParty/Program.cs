
using System.Xml.Linq;

int commandCount = int.Parse(Console.ReadLine());

List<string> guests = new List<string>();


for (int i = 0; i < commandCount; i++)
{
    string[] commandParts = Console.ReadLine().Split();
    string currentGuest = commandParts[0];

    if (commandParts.Contains("not"))
    {
        if (guests.Contains(currentGuest))
        {
            guests.Remove(currentGuest);
        }
        else
        {
            Console.WriteLine($"{currentGuest} is not in the list!");
        }

    }
    else
    {
        if (guests.Contains(currentGuest))
        {
            Console.WriteLine($"{currentGuest} is already in the list!");
        }
        else
        {
            guests.Add(currentGuest);
        }
    }
}

Console.WriteLine(string.Join("\n", guests));
