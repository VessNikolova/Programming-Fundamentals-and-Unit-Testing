
string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double orderPrice = GetOrderPrice(product, quantity);

Console.WriteLine($"{orderPrice:F2}");

static double GetOrderPrice(string product, int quantity)
{
    double price = 0;

    if (product == "coffee")
    {
        price = 1.50 * quantity;
    }
    else if (product == "water")
    {
        price = 1.00 * quantity;
    }
    else if (product == "coke")
    {
        price = 1.40 * quantity;
    }else if(product == "snacks")
    {
        price = 2.00 * quantity;
    }

    return price;
}