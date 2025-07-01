
int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int controlNum = int.Parse(Console.ReadLine());

for (int i = 0; i < arr.Length - 1; i++) 
{
    int leftElement = arr[i];

    for (int j = i + 1; j < arr.Length; j++) 
    {
        int rigthElement = arr[j];

        int sum = leftElement + rigthElement;

        if (sum == controlNum)
        {
            Console.WriteLine($"{leftElement} {rigthElement}");
            break;
        }
    }
}
