// Программа на вход принимает число (А) и выдает сумму чисел от 1 до А

Console.Write("Введите натуральное число: ");
int num = int.Parse(Console.ReadLine());

int GetSumMunbers(int number)
{
    int sum = 0;
for (int i = 1; i <= num; i++)
    {
        sum = sum  + i;
    }
    return sum;
}

int sumResult = GetSumMunbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {sumResult}");