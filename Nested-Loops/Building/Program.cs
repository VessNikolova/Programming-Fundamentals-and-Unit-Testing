
int floorCount = int.Parse(Console.ReadLine());
int estatesCount = int.Parse(Console.ReadLine());

for (int i = floorCount; i >= 1; i--)
{
    for (int j = 0; j < estatesCount; j++)
    {
        if (i == floorCount)
        {
            Console.Write($"L{i}{j} ");
        }else if(i % 2 == 1)
        {
            Console.Write($"A{i}{j} ");
        }
        else
        {
            Console.Write($"O{i}{j} ");
        }
    }

    Console.WriteLine();
}
