//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

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

// void PosNegSum (int[] array)
// {
//     int SumPos = 0;
//     int SumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0) SumPos+=array[i];
//         else SumNeg+=array[i];
//     }
//     Console.WriteLine($"Sum of positive elements -> {SumPos}, sum of negative elements -> {SumNeg}");
// }



// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxmimal value of element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// PosNegSum(myArray);



//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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
// myArray = InvertArray(myArray);
// PrintArray(myArray);

// int[] InvertArray (int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]*= -1;
//     }
//     return array;
// }

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// int [] CreateArray(int size)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите число элемента массива {i} ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// bool NumFind(int num, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }
// ;
// if (NumFind(4,CreateArray(5))) Console.WriteLine($"Число есть {4}");
// else Console.Write("Числа нет");





//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

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

// int NumFind2(int[] array)
// {
// int count = 0;
// for(int i = 0; i< array.Length; i++)
// {
// if(array[i] <= 99 && array[i] > 10) count++;
// }
// return count;
// }

// int [] myArray = CreateRandomArray(123,1,150);

// PrintArray(myArray);
// Console.WriteLine(NumFind2(myArray));