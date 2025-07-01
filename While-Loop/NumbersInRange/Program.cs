
while (true)
{
    int currentNum = int.Parse(Console.ReadLine());

    if (currentNum >= 1 && currentNum <= 100)
    {
        Console.WriteLine(currentNum);
        break;
    }
}