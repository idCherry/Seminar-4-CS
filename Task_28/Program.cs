// Программа принимает на вход число N и выдет произведение чисел от 1 до N

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());


int FindMulNumbers (int number)
{
    int mul = 1;
    for (int i = 1; i <= num; i++)
    {
        mul = mul * i; 
    }
    return mul;
}
int result = FindMulNumbers(num);
Console.WriteLine($"Произведение чисел от 1 до {num} = {result}");