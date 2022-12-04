// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Clear();
Console.Write("Input number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B == A * A || A == B * B)
    Console.Write("Yes");
else
    Console.Write("No");