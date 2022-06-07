// // Задача 2: Напишите программу, которая на вход
// // принимает два числа и выдаёт, какое число большее, а
// // какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.WriteLine("Input integer number a: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Input integer number b: ");
// int b = int.Parse(Console.ReadLine());
// if (a < b)
// {
//     Console.WriteLine("min = " + a + ", max = " + b);
// }
// else if (a > b)
// {
//     Console.WriteLine("min = " + b + ", max = " + a);
// }
// else
// {
//     Console.WriteLine("a = b = " + a);
// }

// // Задача 4: Напишите программу, которая принимает на
// // вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// Console.WriteLine("Input integer number a: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Input integer number b: ");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine("Input integer number c: ");
// int c = int.Parse(Console.ReadLine());
// int max = -9999999;
// if (a >= b & a >= c)
// {
//     max = a;
// }
// else if (b > a & b >= c)
// {
//     max = b;
// }
// else
// {
//     max = c;
// }
// Console.WriteLine("max = " + max);


// // Задача 6: Напишите программу, которая на вход
// // принимает число и выдаёт, является ли число чётным
// // (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// Console.Write("Input integer number a: ");
// int a = int.Parse(Console.ReadLine());
// if (a % 2 == 0)
// {
//     Console.WriteLine("yes");
// }
// else
// {
//     Console.WriteLine("no");
// }

// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
int N = -1;
while (N <= 0) // check our user
{
    Console.Write("Input positive integer number N: ");
    N = int.Parse(Console.ReadLine());
    if (N <= 0)
    {
        Console.WriteLine("Incorrect input!");
    }
}

if (N != 1)
{
    int i = 2;
    while(i <= N)
    {
        Console.Write(i + " ");
        i += 2;
    }
}
else
{
    Console.WriteLine("There are not even numbers.");
}

