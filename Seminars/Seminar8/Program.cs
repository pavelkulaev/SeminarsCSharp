//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

// int[,] RowToColumns (int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         System.Console.WriteLine("Invalid input");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0)-1; i++)
//         {
//             for (int j = i+1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array [j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxmimal value of element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// myArray = RowToColumns(myArray);
// Print2DArray(myArray);

//Задание 3. Из двумерного массива целых чисел занулить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

// int[,] DellRowsColumnsForMin(int[,] array)
// {
//     int min = array[0, 0];
//     int mr = 0;
//     int mc = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 mr = i;
//                 mc = j;
//             }
//         }
//     }
//     for (int z = 0; z < array.GetLength(0); z++)
//     {
//         array[z, mc] = 0;
//     }
//     for (int d = 0; d < array.GetLength(1); d++)
//     {
//         array[mr, d] = 0;
//     }
//     return array;
// }

// myArray = DellRowsColumnsForMin(myArray);
// Print2DArray(myArray);

//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2

// int[,] LastToFirst (int[,] array)
// {
//     int count;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         count = array[0,j];
//         array[0,j] = array[array.GetLength(0)-1,j];
//         array[array.GetLength(0)-1, j] = count;
//     }
//     return array;
// }

// myArray = LastToFirst(myArray);
// Print2DArray(myArray);

// int[,] LastToFirst (int[,] array, int firstString, int secondString)
// {
//     int count;
//     if (firstString<0 || secondString> array.GetLength(0))
//     {
//         System.Console.WriteLine("Invalid number");
//         return array;
//     }
//     else
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             count = array[firstString, j];
//             array[firstString, j] = array[secondString,j];
//             array[secondString,j] = count;
//         }
//         return array;
//     }
// }

// Console.WriteLine("Input first number of column: ");
// int firstString = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number of column: ");
// int secondString = Convert.ToInt32(Console.ReadLine());
// myArray = LastToFirst(myArray, firstString, secondString);
// Print2DArray(myArray);