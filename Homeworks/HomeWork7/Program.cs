// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(int rows, int columns, double minValue, double maxValue)
// {
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().NextDouble()*(maxValue-minValue)+minValue;
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element: ");
// double minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxmimal value of element: ");
// double maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//            и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// bool ValidateArray(int row, int column, int[,] myArray)
// {
//     if(row>myArray.GetLength(0) && column>myArray.GetLength(1))
//     {
//         Console.WriteLine("array does not have this element");
//         return false;
//     }
//     return true;
// }

// int[,] myArray = Create2DRandomArray(4, 4, 0, 10);
// Print2DArray(myArray);
// Console.WriteLine();
// Console.WriteLine("input index row: ");
// int  row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input index column: ");
// int column = Convert.ToInt32(Console.ReadLine());

// if (ValidateArray(row, column, myArray))
// {
//     Console.WriteLine($"if row -> {row} and column -> {column}: value of the array element -> {myArray[row, column]}");

// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// // Console.WriteLine("Input numbers of rows: ");
// // int rows = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input numbers of columns: ");
// // int columns = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input minimal value of element: ");
// // int minValue = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input maxmimal value of element: ");
// // int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(3, 4, 1, 5);
// Print2DArray(myArray);
// Console.WriteLine();
// //Console.WriteLine(myArray.GetLength(0));

// double SumOfColumns(int[,] array)
// {
//     double sum = 0;
//     //int columns = array.GetLength(0);
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < array.GetLength(1); j++)
//         {   
            
//             if (j==0) 
//                 sum += array[i, j];
                             
//         }
//         //sum = sum / columns;
//     }
//     return sum;
// }
// Console.WriteLine();

// Console.WriteLine(SumOfColumns(myArray));


