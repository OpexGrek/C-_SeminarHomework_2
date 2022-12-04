// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Input day number (1-7): ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

if (DayOfWeek < 1 || DayOfWeek > 7)
    Console.WriteLine("You should input only day of week number (1-7)");
else     
    if (DayOfWeek == 6 || DayOfWeek == 7)
        Console.WriteLine("Weekend");
    else
        Console.WriteLine("Working day");