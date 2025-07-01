
string typeMovie = Console.ReadLine();
int rowCount = int.Parse(Console.ReadLine());
int seatsPerRow = int.Parse(Console.ReadLine());

int totalSeats = rowCount * seatsPerRow;

double ticketPrice = 0;

if(typeMovie == "Premiere")
{
    ticketPrice = 12;
}else if(typeMovie == "Normal")
{
    ticketPrice = 7.50;
}else if(typeMovie == "Discount")
{
    ticketPrice = 5;
}

double totalSum = ticketPrice * totalSeats;

Console.WriteLine($"{totalSum:F2}");
