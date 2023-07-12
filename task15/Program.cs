// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

int result = checkTheDayOfWeek(number);
if (result == 1)
{
    Console.WriteLine(number + " -> " + "Нет");
}
else if (result == 2)
{
    Console.WriteLine(number + " -> " + "Да");
}
else
{
   Console.WriteLine(number + " -> " + " нет такого дня!"); 
}

int checkTheDayOfWeek(int day)
{
    if (day >= 1 && day <= 5)
    {
        return 1;
    }
    else if (day == 6 || day == 7)
    {
        return 2;
    }
    else
    {
        return 3;
    }
}