// Программа принимает на вход число N и выдет произведение чисел от 1 до N

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());


int FindFacNumbers (int number)
{
    int fac = 1;
    for (int i = 1; i <= num; i++)
    {
        fac = fac * i; 
    }
    return fac;
}
int result = FindFacNumbers(num);
Console.WriteLine($"Произведение чисел от 1 до {num} = {result}");