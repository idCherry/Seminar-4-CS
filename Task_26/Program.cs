// Программа на вход принимает число и выдает кол-во цифр в числе

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int CountNumbers (int num)
{
    int div = 1;
    int count = 0;
    while (num > div)
    {
        div = div * 10;
        count++;
    }
    return count;
}
Console.WriteLine($"Количество цифр в числе = {CountNumbers(number)}");
