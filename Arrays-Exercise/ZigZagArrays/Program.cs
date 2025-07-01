
int lines = int.Parse(Console.ReadLine());

int[] arr1 = new int[lines];
int[] arr2 = new int[lines];

for (int i = 0; i < lines; i++)
{
    int[] currentArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    int num1 = currentArr[0];
    int num2 = currentArr[1];

    if(i % 2 == 0)
    {
        arr1[i] = num1;
        arr2[i] = num2;
    }
    else
    {
        arr1[i] = num2;
        arr2[i] = num1;
    }
    
}

Console.WriteLine(String.Join(" ", arr1));
Console.WriteLine(String.Join(" ", arr2));