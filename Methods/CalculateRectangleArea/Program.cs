
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int rectangleArea = CalculateRectangleArea(width, length);

Console.WriteLine(rectangleArea);

static int CalculateRectangleArea(int width, int length)
{
    return width * length;
}


