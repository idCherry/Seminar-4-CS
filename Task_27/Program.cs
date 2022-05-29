// Программа принимает на вход число и выдаёт сумму цифр в числе

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumNumbers (int number)
{
    int sum = 0;
   
    while (num != 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}
int sumResult = GetSumNumbers(num);
Console.WriteLine($"Сумма цифр в числе = {sumResult}");