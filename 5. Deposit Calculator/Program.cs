double depositedAmount = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double annualIntRate = double.Parse(Console.ReadLine()) / 100;

double totalAmount = depositedAmount + months * (depositedAmount * annualIntRate) / 12;
Console.WriteLine($"{totalAmount:F2}");