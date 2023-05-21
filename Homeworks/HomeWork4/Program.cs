// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Stepen(int num1, int num2)
// {
//     int step = num1; 
//     int i = 1;   
//     for (i = 1; i < num2; i++)
//     {
//         step = step*num1;
//     }
//     return step;

// }

// Console.WriteLine("input number A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input number B");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"А to the extent of В -> {Stepen(a, b)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int SummDigit (int num)
// {
//     int sum = 0;
//     int result = 0;
//     while(num > 0)
//     {
//         result = num % 10;
//         num = num / 10;
//         sum = sum + result;
//     }
//     return sum;
// }
// Console.WriteLine("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"the sum of the digits of the number {num} -> {SummDigit(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void PrintArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxmimal value of element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);


