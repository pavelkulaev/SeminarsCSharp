//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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

//  Print2DArray(Create2DRandomArray(rows, columns, minValue, maxValue));

//Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int SumOfMainDiag(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i==j)
//                 sum+=array[i,j];
//         }   
//     }
//     return sum;
// }
// Console.WriteLine(SumOfMainDiag(myArray));


//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int[,] QuadrateOfElements(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i,j] = array[i,j]*array[i,j];
//             }
                
//         }
//     }
//     return array;
// }
// Console.WriteLine();
// Print2DArray(QuadrateOfElements(myArray));


//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.


// int[,] SumOfIndex(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = i+j; 
//         }
//     }
//     return array;
// }
// Console.WriteLine();
// Print2DArray(SumOfIndex(myArray));