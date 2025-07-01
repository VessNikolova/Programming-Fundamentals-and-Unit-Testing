
int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();


while(arr.Length > 1)
{
    int[] condensedArr = new int[arr.Length - 1];

    for (int i = 0; i < arr.Length - 1; i++)
    {
        condensedArr[i] = arr[i] + arr[i + 1];
    }

    arr = condensedArr;
}

Console.WriteLine(arr[0]);

    
