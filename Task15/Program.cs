Console.Clear();
Console.Write("Input day number (1-7): ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

if (DayOfWeek == 6 || DayOfWeek == 7)
    Console.WriteLine("Weekend");
else
    Console.WriteLine("Working day");