// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// // 14212 -> нет

// // 12821 -> да

// // 23432 -> да
// bool FindPalindrom(int num)
// {
//     int num1 = num / 10000;
//     int num2 = (num / 1000) % 10;
//     int num4 = (num / 10) % 10;
//     int num5 = num % 10;

//     if (num1 == num5 && num2 == num4)
//     {
//         return true;
//     }
//     return false;


// }
// bool ValidateNumber(int num)
// {
//     if (num < 9999 || num > 100000)
//     {
//         Console.WriteLine("it's not a five-digit number");
//         return false;
//     }
//     return true;
// }

// Console.WriteLine("Input five-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool result = FindPalindrom(number);

// if (ValidateNumber(number))
// {
//     Console.WriteLine($"the number {number} is a polindrome? Answer: {result}");
// }

// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84

// // A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2) ),2);
// }

// Console.WriteLine("Input coordinate X to A:");
// double xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Y to A:");
// double ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Z to A:");
// double za = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate X to B:");
// double xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Y to B:");
// double yb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Z to B:");
// double zb = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"distance between point A with coordinates ({xa},{ya},{za}) and point B with coordinates ({xb},{yb},{zb}) -> {FindDistance(xa, ya, za, xb, yb, zb)}");


// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// void Fun(int number)
// {
//     int i = 1;
//     while(i <= number)
//     {
//         System.Console.WriteLine($"{i} -> {i*i*i}");
//         i++;
//     }
// }
// Console.WriteLine("Введите число");
// int countnumber = Convert.ToInt32(Console.ReadLine());
// Fun(countnumber);