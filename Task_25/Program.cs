// Цикл принимает на вход два числа (A и B) и возводит число A в натуральную
// степень B

Console.Write("Введите число A: ");
double numA = double.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
double numB = double.Parse(Console.ReadLine());

double exponentiation = Math.Pow(numA, numB);
Console.WriteLine($"{numA} в степени {numB} = {exponentiation}");


