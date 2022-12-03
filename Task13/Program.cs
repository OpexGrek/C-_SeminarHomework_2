Console.Write("Input number ");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(ThreeDigitNumber);

int lenghtNumber = stringNumber.Length;
Console.WriteLine(lenghtNumber);

if (lenghtNumber == 2) 
    Console.WriteLine("There is no 3-d number");
else 
    Console.Write("The second number is " + stringNumber[1]);