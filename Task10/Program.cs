// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Input 3 number ");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(ThreeDigitNumber);
if(stringNumber.Length !=3)
    Console.WriteLine("Input only 3 numbers");
else    
    Console.Write("The second number " + stringNumber[1]);