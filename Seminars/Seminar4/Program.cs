// напишите программу, которая принимает на вход число и выдает количество цифр в числе

// int DigitCount (int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         count++;
//         num/=10;
//     }
//     return count;
// }

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Number of digits in {num} -> {DigitCount(num)}");

// Напишите программу, которая вывыодит массив из N элементов , заполненный заданными промежутком в случайном порядке 
// [1,0,1,1,0,1,0,0]

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

//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int MultipleDigit(int num)
// {
//     int count = num;
//     int result = 1;
//     while(count > 0)
//     {
//         result = result*num;
//         num = num -1;
//         count--;
//     }
//     return result;
// }

// Console.WriteLine("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"summ -> {MultipleDigit(num)}");




//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int SummDigit(int num)
// {
//     int count = num;
//     int result = 0;
//     while(count > 0)
//     {
//         result = result+num;
//         num = num -1;
//         count--;
//     }
//     return result;
// }

// Console.WriteLine("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"summ -> {SummDigit(num)}");