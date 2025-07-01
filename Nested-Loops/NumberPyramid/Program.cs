
int end = int.Parse(Console.ReadLine());

int counter = 0;
bool isReached = false;

for (int row = 1; row <= end; row++)
{
    for (int col = 1; col <= row; col++)
    {
        counter++;

        Console.Write(counter + " ");
        if (counter == end)
        {
            isReached = true;
            break;
        }
    }

    if (isReached)
        break;

    Console.WriteLine();
}
