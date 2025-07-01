
List<int> wagons = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int maxWagonCapacity = int.Parse(Console.ReadLine());

string input = Console.ReadLine(); 
 
while(input != "end")
{
    string[] commandParts = input.Split();
   

    if (commandParts[0] == "Add")
    {
        int passengers = int.Parse(commandParts[1]);

        wagons.Add(passengers);
    }
    else
    {
        int passengers = int.Parse(commandParts[0]);

        for ( int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passengers <= maxWagonCapacity)
            {
                wagons[i] += passengers;
                break;
            }
           
        }
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", wagons));
