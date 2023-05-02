//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondDigit(int randomnum)
// {
//     int SecondDigit = randomnum / 10 % 10;
//     return SecondDigit;
// }
// bool ValidateNumber (int num)
// {
//     if (num < 100 || num >= 1000)
//     {
//         Console.WriteLine("it's not a three-digit number");
//         return false;
//     }
//     return true;    
// }
// Console.WriteLine("input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = SecondDigit(num);
// if (ValidateNumber(num))
// {
//     Console.WriteLine($"the number {num} has second number {result}");
// }


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ThirdDigit(int randomnum)
// {
//     while (randomnum > 999)
//     {
//         randomnum = randomnum / 10;
//     }
//     return randomnum % 10;

// }
// bool ValidateNumber(int number)
// {
//     if (number <100)
//     {
//         Console.WriteLine("this number does not have a third digit");
//         return false;
//     }
//     return true;
// }

// Console.WriteLine("input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = ThirdDigit(num);
// if (ValidateNumber(num))
// {
//     Console.WriteLine($"the number {num} has third number {result}");
// }


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// bool WeekEnd (int day)
// {
//     if (day > 5 )
//     {
//         return true;
//     }
//     return false;
// }
// bool ValidateWeekday (int n)
// {
//     if (n < 0 || n <= 7 )
//     {
//         return true;
//     }
//     Console.WriteLine("Это не день недели");
//     return false;

// }
// Console.WriteLine("input WeekDay:");
// int weekDay = Convert.ToInt32(Console.ReadLine());

// if (ValidateWeekday (weekDay))
// {
//     if (WeekEnd(weekDay))
//     {
//         Console.WriteLine("Ура, выходной");
//     }
//     else
//     {
//         Console.WriteLine("это будний день, иди работай");
//     }
// }