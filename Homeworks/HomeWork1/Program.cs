//Task1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее а какое меньшее

// Console.WriteLine("input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"{num1} является max, {num2} является min");
// }
// else
// {
//     Console.WriteLine($"{num1} является min, {num2} является max");
// }

//Task2. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

// Console.WriteLine("input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input third number");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;
// if (num1 > max) max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;

// Console.Write("max = ");
// Console.WriteLine(max);

//Task3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("input N:");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n % 2 == 0)
// {
//     Console.WriteLine($"{n} является четным числом");
// }
// else
// {
//     Console.WriteLine($"{n} является нечетным числом");
// }

//Task4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("input N:");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n < 0) Console.WriteLine("Invalid input N");

// int count = 1;
// if (count == 1)
// {
//     count += 1;
// }
// while (count <= n)
// {
//     Console.Write(count + " ");
//     count += 2;
// }