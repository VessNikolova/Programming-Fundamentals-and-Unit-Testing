
int num = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

while (command != "End")
{
    if(command == "Inc")
    {
        num++;
    }

    if (command == "Dec")
    {
        num--;
    }

    command = Console.ReadLine();
}

Console.WriteLine(num);
