
int[] arr1 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] arr2 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr1.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            Console.Write(arr1[i] + " ");
        }
    }
}
