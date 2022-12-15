int[] ArrayGenerator(int Size, int Min, int Max)
{
    int[] array = new int[Size];
      
    for (int i = 0; i < Size; i++)
    {
        array[i] = new Random().Next(Min, Max+1);
    }
    return array;
}

void ArrayPrint(int[] array)
    {
        Console.WriteLine("Все элементы нового массива: ");
        for (int i = 0; i < array.Length-1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine($"{array[array.Length-1]}");
    }

int SumOfOdd(int[] array)  
{
    int summa = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        summa += array[i]; 
    }

    return summa;
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
    int[] array = ArrayGenerator(intSize, intMin, intMax);
    ArrayPrint(array);
    Console.WriteLine($"Сумма чисел на нечетных позициях: {SumOfOdd(array)}");
}
