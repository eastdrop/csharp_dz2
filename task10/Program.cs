Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 99 && N < 1000)
{
    Console.WriteLine(N % 100 / 10);
}
else Console.WriteLine("Это не трехзначное число");