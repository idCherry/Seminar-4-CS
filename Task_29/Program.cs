// Программа задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int [] array = new int [arrayLength];

void PrintArray (int [] collection)
{
    int length = collection.Length;
    int i = 0;
    Console.Write("Массив [");
    while (i < length)
    {
        collection[i] = new Random().Next(0, arrayLength);
        Console.Write($"{collection[i]}" + $"  ");
        i++;
    }
    Console.Write("]");
}

PrintArray(array);
