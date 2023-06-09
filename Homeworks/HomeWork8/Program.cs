// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// int[,] SortToLow(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int z = 0; z < array.GetLength(1) - 1; z++)
//             {
//                 if (array[i, z] < array[i, z + 1])
//                 {
//                     int temp = array[i, z + 1];
//                     array[i, z + 1] = array[i, z];
//                     array[i, z] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// myArray = SortToLow(myArray);
// Print2DArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[] SumOfRows(int[,] array)
// {
//     int sum = 0;
//     int columns = array.GetLength(1);
//     int rows = array.GetLength(0);
//     int [] dArray = new int[rows];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {    
//                 sum += array[i, j];

//         }
//         dArray[i] =sum;
//         sum = 0;
//     }
//     return dArray;
// }

// void PrintArray (int[] dArray)
// {
//     for(int i = 0; i < dArray.Length; i++)
//     {
//         Console.Write(dArray[i] + " ");
//     }
//     Console.WriteLine();
// }

// void minValueSum (int[] dArray)
// {
//     int minSum = dArray[0];
//     int num_str = 0;
//     for(int i = 0; i < dArray.Length; i++)
//     {
//         if(dArray[i] < minSum)
//         {
//             minSum = dArray[i];
//             num_str = i;    
//         }      
//     }
//     Console.WriteLine($"{minSum} is min sum and number of row {num_str}"); 
// }

// int [] Array = SumOfRows(myArray);
// PrintArray(Array);
// minValueSum(Array);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DMatrix(int rows, int columns, int minValue, int maxValue)
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

// int[,] MultipleMatrix(int[,] firstMatrix, int[,] secondMatrix)
// {
//     if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
//     {
//         Console.WriteLine("Matrices cannot be multiplied");
//     }
//     int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
//     for (int i = 0; i < firstMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < secondMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < firstMatrix.GetLength(1); k++)
//             {
//                 resultMatrix[i,j] += firstMatrix[i, k] * secondMatrix[k, j];
//             }

//         }
//     }
//     return resultMatrix;
// }
// Console.WriteLine("Input numbers of rows first matrix: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of columns first matrix: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element first matrix: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxmimal value of element first matrix: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input numbers of rows second matrix: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of columns second matrix: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element second matrix: ");
// int minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxmimal value of element second matrix: ");
// int maxValue1 = Convert.ToInt32(Console.ReadLine());

// int[,] firstMatrix = Create2DMatrix(rows, columns, minValue, maxValue);
// Print2DArray(firstMatrix);
// Console.WriteLine();
// int[,] secondMatrix = Create2DMatrix(rows1, columns1, minValue1, maxValue1);
// Print2DArray(secondMatrix);
// int [,] FinalMatrix = MultipleMatrix(firstMatrix, secondMatrix);
// Print2DArray(FinalMatrix);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] Create3DArray(int row, int col, int dep, int minValue, int maxValue)
// {
//     int[,,] matrix = new int[row, col, dep];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             for (int k = 0; k < dep; k++)
//             {
//                 matrix[i, j, k] = new Random().Next(minValue, maxValue);
//             }
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 Console.Write("[" + i + "," + j + "," + k + "]" + matrix[i, j, k] + " ");
//             }
//         }
//         Console.WriteLine();
//     }

// }

// Console.WriteLine("Input numbers of rows: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of columns: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of dep: ");
// int dep = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxmimal value of element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,,] matrix = Create3DArray(row, column, dep, minValue, maxValue);
// PrintMatrix(matrix);



