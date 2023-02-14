/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/
/*double N = Convert.ToInt64(Console.ReadLine());*/

/*while (N > 100)
int m = Convert.ToInt32(N / 100 % 10);
Console.WriteLine(m);*/

Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N / 100 == 0)
{
    Console.WriteLine("третьей цифры нет");
}
else if (N > 100 && N < 999)
{
    Console.WriteLine(N % 10);
}
else
{
    while (N >= 1000)
    {
        if (N < 10000)
        {
            N = N / 10;
        }
        else N = N / 100;
    }
    Console.WriteLine(N % 10);
}