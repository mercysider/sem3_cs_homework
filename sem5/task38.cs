double[] ArrayGenerator(int Size, int Min, int Max)
{
    double[] array = new double[Size];
      
    for (int i = 0; i < Size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (Max - Min) + Min, 2);
    }
    return array;
}

void ArrayPrint(double[] array)
    {
        Console.WriteLine("Все элементы нового массива: ");
        for (int i = 0; i < array.Length-1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine($"{array[array.Length-1]}");
    }

double MaxMinDiff(double[] array)  
{
    Array.Sort(array);
    return array[array.Length - 1] - array[0];
}  
    
Console.WriteLine("Введите размерность массива:");
int intSize = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальный элемент массива:");
int intMin = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальный элемент массива:");
int intMax = int.Parse(Console.ReadLine()!);


if (intMin > intMax) Console.WriteLine("Минимальное значение не может быть больше максимального!");
else
{
    double[] array = ArrayGenerator(intSize, intMin, intMax);
    ArrayPrint(array);
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива: {Math.Round(MaxMinDiff(array), 2)}");
}