
int basketballFee = int.Parse(Console.ReadLine());

double sneakersPrice = basketballFee - (basketballFee * 0.40);
double uniformPrice = sneakersPrice - (sneakersPrice * 0.20);
double ballPrice = uniformPrice * 0.25;
double accesoiresPrice = ballPrice * 0.20;

double totalSum = basketballFee + sneakersPrice + uniformPrice + ballPrice + accesoiresPrice;

Console.WriteLine(totalSum);