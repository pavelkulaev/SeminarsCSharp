// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] myArray = CreateRandomArray(5,100,1000);

// PrintArray(myArray);

// int count = 0;

// for (int i = 0; i < myArray.Length; i++)
// if (myArray[i] % 2 == 0)
// count++;

// Console.WriteLine($"всего {myArray.Length} чисел, {count} из них чётные");


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
//         Console.Write(array[i] + " ");
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

// int Summ = 0;
// for (int i = 1; i < myArray.Length; i+=2)
// {
//     Summ = Summ + myArray[i];
// }
// Console.WriteLine($"всего {myArray.Length} чисел, сумма элементов на нечетных позициях {Summ} ");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// double[] CreateRandomArray(int size, double minValue, double maxValue)
// {
//     double [] newArray = new double [size];
//     for (int i = 0; i < size; i++)
//     {
//          newArray[i] = new Random().NextDouble()*(maxValue-minValue)+minValue;
//     }
//     return newArray;
// }

// void PrintArray (double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element");
// double minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxmimal value of element");
// double maxValue = Convert.ToInt32(Console.ReadLine());

// double [] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);

// void DifferenceNumbers(double[] array)
// {
//     double maxValue = array[0];
//     double minValue = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>maxValue) maxValue = array[i];
//         if(array[i]<minValue) minValue= array[i];
//     }
//     Console.WriteLine($"Разница максимального и минимального значения массива:{maxValue-minValue}");

// }
// DifferenceNumbers(myArray);