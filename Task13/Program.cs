// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input number ");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(ThreeDigitNumber);

int lenghtNumber = stringNumber.Length;
//Console.WriteLine(lenghtNumber);

if (lenghtNumber == 2 || lenghtNumber == 1) 
    Console.WriteLine("There is no 3-d number");
else 
    Console.Write("The second number is " + stringNumber[1]);