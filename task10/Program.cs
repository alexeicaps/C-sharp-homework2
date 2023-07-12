// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);

void GetSecondDigit(int number1)
{
    if (number1 >= 100 && number1 < 1000 )
    {
        int second = (number1 % 100 - number1 % 10) / 10;
        Console.WriteLine(second);
    }
    if (number1 <= -100 && number1 > -1000)
    {
        int second = - (number1 % 100 - number1 % 10) / 10;
        Console.WriteLine(second);
    }
    else
    {
        Console.WriteLine("Это число не трехзначное");
    }
}

GetSecondDigit(number);