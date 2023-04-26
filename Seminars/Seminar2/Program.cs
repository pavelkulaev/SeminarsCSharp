// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8
// 12 -> 2
// 85 -> 8



// int MaxDigit (int randomnum)
// {
//     int dec = randomnum / 10;
//     int ed = randomnum % 10;
//     if(dec == ed)
//     Console.WriteLine("Число является палиндромом");
//     if(dec > ed) return dec;
//     else return ed;
// }

// int num = new Random().Next(10, 99 + 1);

// int result = MaxDigit(num);

// Console.WriteLine($"{num} -> {result}");

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если втрое число не кратно первому, то прогрмма выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// bool kratnost(int num1, int num2)
// {
//     if (num1 % num2 == 0) return true;
//     else return false;
// }

// Console.WriteLine("input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1}, {num2} -> {kratnost(num1, num2)} ost{num1%num2}");

// напишите программу, которая принимает число и проверяет кратно ли оно 7 и 23 одновременно.

// bool multiplicity(int num1)
// {
//     if (num1 % 7 == 0 && num1 % 23 ==0) return true;
//     else return false;
// }
// Console.WriteLine("input number");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{multiplicity(n)}");

// Напишите пргорамму, которая принимает на вход два числа и повторяет является ли одно число квадратом второго.

// bool quad(int num1, int num2)
// {
//     if (num1 / num2 == num2 || num2 / num1 == num1) return true;
//     else return false;
// }
// Console.WriteLine("input number1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input number2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{quad(num1, num2)}");
