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


// int checkTheDayOfWeek(int day)
// {
//     if (day >= 1 && day <= 5)
//     {
//         Console.WriteLine("It's not a weekend day" + "No");
//     }
//     else if (day == 6 || day == 7)
//     {
//         Console.WriteLine("This is a weekend day" + "Yes");
//     }
//     else
//     {
//         Console.WriteLine("Такого дня нет!");
//     }
// }


// Console.WriteLine("Задача 15 ");

// Console.Write("Введи цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void CheckingTheDayOfTheWeek (int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("(этот день выходной) -> да");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) {
//     Console.WriteLine("это вообще не день недели");
//   }
//   else Console.WriteLine("(этот день не выходной) -> нет");
// }

// CheckingTheDayOfTheWeek(dayNumber);