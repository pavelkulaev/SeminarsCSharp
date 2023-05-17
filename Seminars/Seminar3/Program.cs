// напишите прграмму которая принимает на вход координаты точки (x и y), причем x и y не равны 0 и выдает номер четверти

// int FindQuart(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;

//     return 0;
// }

// Console.WriteLine("Input X:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Y:");
// int y = Convert.ToInt32(Console.ReadLine());  
// int result = FindQuart(x, y);

// Console.WriteLine($"point with {x} && {y} coordinates located at {result} quart");

// напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в двухмерном пространстве

// double FindDistance(double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2)),2);
// }

// Console.WriteLine("Input coordinate X to A:");
// double xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Y to A:");
// double ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate X to B:");
// double xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Y to B:");
// double yb = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"distance between point A with coordinates ({xa},{ya}) and point B with coordinates ({xb},{yb}) {FindDistance(xa, ya, xb, yb)}");


// Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void Fun(int number)
// {
//     if (number == 1) Console.WriteLine("x > 0, y > 0");
//     if (number == 2) Console.WriteLine("x < 0, y > 0");
//     if (number == 3) Console.WriteLine("x < 0, y < 0");
//     if (number == 4) Console.WriteLine("x > 0, y < 0");
// }

// Console.WriteLine("Введите номер четверти");
// int quart = Convert.ToInt32(Console.ReadLine());
// Fun(quart);


//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N
// void Fun(int number)
// {
//     int i = 1;
//     while(i <= number)
//     {
//         System.Console.WriteLine($"{i} -> {i*i}");
//         i++;
//     }
// }
// Console.WriteLine("Введите число");
// int countnumber = Convert.ToInt32(Console.ReadLine());
// Fun(countnumber);
