int numBookPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysForBook = int.Parse(Console.ReadLine());
int hoursForBook = numBookPages / pagesPerHour;

Console.WriteLine(hoursForBook / daysForBook);
