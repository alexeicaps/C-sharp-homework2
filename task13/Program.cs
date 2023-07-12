
// ---------------------------------------------------------------------------------------------------------------------------------------

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int result = ThirdDigit(number);
if (result == -1)
{
    Console.WriteLine("Такой цифры нет! ");
}
else
{
    Console.WriteLine("Третья цифра числа " + number + " это " + result);
}

int ThirdDigit(int number1)
{
    if (number1 < 100 && number1 > -100)
    {
        return -1;
    }
    else if (number1 < -99)
    {
        while (number1 < -999)
        {
            number1 = number1 / 10;
        }
        int result = - number1 % 10;
        return result;
    }
    else
    {
        while (number1 > 999)
        {
            number1 = number1 / 10;
        }
        int result = number1 % 10;
        return result;
    }
}