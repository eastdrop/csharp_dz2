Console.Write("Input number: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day <= 5) Console.WriteLine("нет");
else if (day == 6 || day == 7) Console.WriteLine("да");
else Console.WriteLine("Такого дня не существует");