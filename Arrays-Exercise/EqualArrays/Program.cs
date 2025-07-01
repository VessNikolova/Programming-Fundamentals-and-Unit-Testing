
int[] arr1 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] arr2 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

bool isEqual = false;

for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] == arr2[i])
    {
        isEqual = true;
    }
    else
    {
        isEqual = false;
        break;
    }
}

if (isEqual)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}
