// Программа выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке


int [] array = new int [8];

void PrintArray (int [] col)
{
    int length = col.Length;
    int index = 0;
    Console.Write("Массив [");
    while (index < length)
    {
        col[index] = new Random().Next(0, 2);
        Console.Write($"{col[index]}" + $"  ");
        index++;
    }
    Console.Write("]");
}

PrintArray(array);